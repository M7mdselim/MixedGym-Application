using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace MixedGymProject
{
    public partial class SportsForm : Form
    {
        private DataTable dt;
        private bool hasActiveColumn = true;
        private string currentDatabase = "MixedGymDB";

        public SportsForm()
        {
            InitializeComponent();
            SetupGridStyles();

            if (string.IsNullOrEmpty(DatabaseConfig.connectionString))
            {
                MessageBox.Show("خطأ: إعدادات الاتصال بقاعدة البيانات مفقودة.", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Load Default DB
            SelectDatabase("MixedGymDB", btnDbMixed);
        }

        private void SetupGridStyles()
        {
            grid.EnableHeadersVisualStyles = false;
            grid.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 122, 204);
            grid.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            grid.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            grid.ColumnHeadersHeight = 40;
            grid.DefaultCellStyle.SelectionBackColor = Color.FromArgb(200, 230, 255);
            grid.DefaultCellStyle.SelectionForeColor = Color.Black;
            grid.RowTemplate.Height = 35;
        }

        private void SelectDatabase(string dbName, Button activeBtn)
        {
            currentDatabase = dbName;
            ResetTabButtons();
            activeBtn.BackColor = Color.FromArgb(0, 122, 204);
            activeBtn.ForeColor = Color.White;

            ClearForm();
            LoadData();
        }

        private void ResetTabButtons()
        {
            Color inactiveColor = Color.FromArgb(224, 224, 224);
            Color inactiveText = Color.FromArgb(64, 64, 64);
            SetBtnStyle(btnDbMixed, inactiveColor, inactiveText);
            SetBtnStyle(btnDbMalaab, inactiveColor, inactiveText);
            SetBtnStyle(btnDbPool, inactiveColor, inactiveText);
            SetBtnStyle(btnDbSubs, inactiveColor, inactiveText);
        }

        private void SetBtnStyle(Button b, Color bg, Color fg)
        {
            b.BackColor = bg;
            b.ForeColor = fg;
        }

        private string GetCurrentConnectionString()
        {
            var builder = new SqlConnectionStringBuilder(DatabaseConfig.connectionString);
            builder.InitialCatalog = currentDatabase;
            return builder.ToString();
        }

        private void LoadData()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(GetCurrentConnectionString()))
                {
                    con.Open();
                    SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Sports", con);
                    dt = new DataTable();
                    da.Fill(dt);
                    grid.DataSource = dt;

                    hasActiveColumn = dt.Columns.Contains("Active");
                    chkActive.Enabled = hasActiveColumn;
                    chkActive.Visible = hasActiveColumn;

                    if (grid.Columns["SportID"] != null) grid.Columns["SportID"].Visible = false;

                    // Arabic Headers
                    if (grid.Columns["SportName"] != null) grid.Columns["SportName"].HeaderText = "اسم الرياضة";
                    if (grid.Columns["MemberPrice"] != null) grid.Columns["MemberPrice"].HeaderText = "سعر العضو";
                    if (grid.Columns["CivilianPrice"] != null) grid.Columns["CivilianPrice"].HeaderText = "سعر المدني";
                    if (grid.Columns["Degree1Price"] != null) grid.Columns["Degree1Price"].HeaderText = "درجة أولى";
                    if (grid.Columns["MilitaryPrice"] != null) grid.Columns["MilitaryPrice"].HeaderText = "سعر العسكري";
                    if (grid.Columns["Active"] != null) grid.Columns["Active"].HeaderText = "نشط";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"خطأ في تحميل البيانات: {ex.Message}");
            }
        }

        // CORRECTED: Grid click now drives the selection, allowing duplicates to be edited individually
        private void grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var row = grid.Rows[e.RowIndex];

            // Map cells to inputs using the specific row clicked
            lblId.Text = row.Cells["SportID"].Value.ToString();
            txtName.Text = row.Cells["SportName"].Value.ToString();
            txtMemberPrice.Text = row.Cells["MemberPrice"].Value.ToString();
            txtCivilianPrice.Text = row.Cells["CivilianPrice"].Value.ToString();
            txtDegree1Price.Text = row.Cells["Degree1Price"].Value.ToString();
            txtMilitaryPrice.Text = row.Cells["MilitaryPrice"].Value.ToString();

            if (hasActiveColumn && row.Cells["Active"].Value != DBNull.Value)
                chkActive.Checked = Convert.ToBoolean(row.Cells["Active"].Value);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text)) { MessageBox.Show("الاسم مطلوب", "تنبيه"); return; }

            try
            {
                using (SqlConnection con = new SqlConnection(GetCurrentConnectionString()))
                {
                    con.Open();
                    SqlCommand cmd;
                    int id = int.Parse(lblId.Text);

                    string activeCol = hasActiveColumn ? ", Active" : "";
                    string activeParam = hasActiveColumn ? ", @act" : "";
                    string activeUpdate = hasActiveColumn ? ", Active=@act" : "";

                    if (id == 0) // INSERT NEW
                    {
                        string query = $@"INSERT INTO Sports (SportName, MemberPrice, CivilianPrice, Degree1Price, MilitaryPrice {activeCol}) 
                                         VALUES (@nm, @mp, @cp, @d1, @mil {activeParam})";
                        cmd = new SqlCommand(query, con);
                    }
                    else // UPDATE EXISTING BY UNIQUE ID
                    {
                        string query = $@"UPDATE Sports SET SportName=@nm, MemberPrice=@mp, CivilianPrice=@cp, 
                                         Degree1Price=@d1, MilitaryPrice=@mil {activeUpdate} WHERE SportID=@id";
                        cmd = new SqlCommand(query, con);
                        cmd.Parameters.AddWithValue("@id", id);
                    }

                    cmd.Parameters.AddWithValue("@nm", txtName.Text);
                    cmd.Parameters.AddWithValue("@mp", decimal.TryParse(txtMemberPrice.Text, out decimal d1) ? d1 : 0);
                    cmd.Parameters.AddWithValue("@cp", decimal.TryParse(txtCivilianPrice.Text, out decimal d2) ? d2 : 0);
                    cmd.Parameters.AddWithValue("@d1", decimal.TryParse(txtDegree1Price.Text, out decimal d3) ? d3 : 0);
                    cmd.Parameters.AddWithValue("@mil", decimal.TryParse(txtMilitaryPrice.Text, out decimal d4) ? d4 : 0);

                    if (hasActiveColumn)
                        cmd.Parameters.AddWithValue("@act", chkActive.Checked);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("تم الحفظ بنجاح!", "نجاح");

                    LoadData();
                    ClearForm();
                }
            }
            catch (Exception ex) { MessageBox.Show("خطأ في الحفظ: " + ex.Message); }
        }

        private void ClearForm()
        {
            lblId.Text = "0";
            txtName.Clear();
            txtMemberPrice.Clear();
            txtCivilianPrice.Clear();
            txtDegree1Price.Clear();
            txtMilitaryPrice.Clear();
            if (hasActiveColumn) chkActive.Checked = true;
            grid.ClearSelection();
        }

        // Database Switching Events
        private void btnDbMixed_Click(object sender, EventArgs e) => SelectDatabase("MixedGymDB", btnDbMixed);
        private void btnDbMalaab_Click(object sender, EventArgs e) => SelectDatabase("MalaabDB", btnDbMalaab);
        private void btnDbPool_Click(object sender, EventArgs e) => SelectDatabase("PrivatePoolDB", btnDbPool);
        private void btnDbSubs_Click(object sender, EventArgs e) => SelectDatabase("SubscriptionsDB", btnDbSubs);
        private void btnClear_Click(object sender, EventArgs e) => ClearForm();
        private void btnBack_Click(object sender, EventArgs e) => this.Close();
    }
}