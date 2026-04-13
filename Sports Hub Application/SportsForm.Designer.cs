namespace MixedGymProject
{
    partial class SportsForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.headerPanel = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlTabs = new System.Windows.Forms.Panel();
            this.btnDbSubs = new System.Windows.Forms.Button();
            this.btnDbPool = new System.Windows.Forms.Button();
            this.btnDbMalaab = new System.Windows.Forms.Button();
            this.btnDbMixed = new System.Windows.Forms.Button();
            this.pnlInputs = new System.Windows.Forms.Panel();
            this.lblId = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.chkActive = new System.Windows.Forms.CheckBox();
            this.txtMilitaryPrice = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDegree1Price = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCivilianPrice = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMemberPrice = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grid = new System.Windows.Forms.DataGridView();
            this.headerPanel.SuspendLayout();
            this.pnlTabs.SuspendLayout();
            this.pnlInputs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.SuspendLayout();
            // 
            // headerPanel
            // 
            this.headerPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.headerPanel.Controls.Add(this.btnBack);
            this.headerPanel.Controls.Add(this.lblTitle);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.Location = new System.Drawing.Point(0, 0);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(900, 60);
            this.headerPanel.TabIndex = 0;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(12, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(80, 35);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "رجوع →";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(712, 15);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(157, 32);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "إدارة الرياضات";
            // 
            // pnlTabs
            // 
            this.pnlTabs.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlTabs.Controls.Add(this.btnDbSubs);
            this.pnlTabs.Controls.Add(this.btnDbPool);
            this.pnlTabs.Controls.Add(this.btnDbMalaab);
            this.pnlTabs.Controls.Add(this.btnDbMixed);
            this.pnlTabs.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTabs.Location = new System.Drawing.Point(0, 60);
            this.pnlTabs.Name = "pnlTabs";
            this.pnlTabs.Padding = new System.Windows.Forms.Padding(5);
            this.pnlTabs.Size = new System.Drawing.Size(900, 50);
            this.pnlTabs.TabIndex = 2;
            // 
            // btnDbSubs
            // 
            this.btnDbSubs.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnDbSubs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDbSubs.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnDbSubs.Location = new System.Drawing.Point(195, 5);
            this.btnDbSubs.Name = "btnDbSubs";
            this.btnDbSubs.Size = new System.Drawing.Size(175, 40);
            this.btnDbSubs.TabIndex = 3;
            this.btnDbSubs.Text = "الاشتراكات";
            this.btnDbSubs.Click += new System.EventHandler(this.btnDbSubs_Click);
            // 
            // btnDbPool
            // 
            this.btnDbPool.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnDbPool.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDbPool.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnDbPool.Location = new System.Drawing.Point(370, 5);
            this.btnDbPool.Name = "btnDbPool";
            this.btnDbPool.Size = new System.Drawing.Size(175, 40);
            this.btnDbPool.TabIndex = 2;
            this.btnDbPool.Text = "بريفت بول";
            this.btnDbPool.Click += new System.EventHandler(this.btnDbPool_Click);
            // 
            // btnDbMalaab
            // 
            this.btnDbMalaab.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnDbMalaab.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDbMalaab.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnDbMalaab.Location = new System.Drawing.Point(545, 5);
            this.btnDbMalaab.Name = "btnDbMalaab";
            this.btnDbMalaab.Size = new System.Drawing.Size(175, 40);
            this.btnDbMalaab.TabIndex = 1;
            this.btnDbMalaab.Text = "الملاعب";
            this.btnDbMalaab.Click += new System.EventHandler(this.btnDbMalaab_Click);
            // 
            // btnDbMixed
            // 
            this.btnDbMixed.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnDbMixed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDbMixed.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnDbMixed.Location = new System.Drawing.Point(720, 5);
            this.btnDbMixed.Name = "btnDbMixed";
            this.btnDbMixed.Size = new System.Drawing.Size(175, 40);
            this.btnDbMixed.TabIndex = 0;
            this.btnDbMixed.Text = "الجيم الميكس";
            this.btnDbMixed.Click += new System.EventHandler(this.btnDbMixed_Click);
            // 
            // pnlInputs
            // 
            this.pnlInputs.BackColor = System.Drawing.Color.White;
            this.pnlInputs.Controls.Add(this.lblId);
            this.pnlInputs.Controls.Add(this.btnClear);
            this.pnlInputs.Controls.Add(this.btnSave);
            this.pnlInputs.Controls.Add(this.chkActive);
            this.pnlInputs.Controls.Add(this.txtMilitaryPrice);
            this.pnlInputs.Controls.Add(this.label5);
            this.pnlInputs.Controls.Add(this.txtDegree1Price);
            this.pnlInputs.Controls.Add(this.label4);
            this.pnlInputs.Controls.Add(this.txtCivilianPrice);
            this.pnlInputs.Controls.Add(this.label3);
            this.pnlInputs.Controls.Add(this.txtMemberPrice);
            this.pnlInputs.Controls.Add(this.label2);
            this.pnlInputs.Controls.Add(this.txtName);
            this.pnlInputs.Controls.Add(this.label1);
            this.pnlInputs.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlInputs.Location = new System.Drawing.Point(0, 110);
            this.pnlInputs.Name = "pnlInputs";
            this.pnlInputs.Padding = new System.Windows.Forms.Padding(20);
            this.pnlInputs.Size = new System.Drawing.Size(300, 490);
            this.pnlInputs.TabIndex = 1;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(250, 9);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(17, 19);
            this.lblId.TabIndex = 14;
            this.lblId.Text = "0";
            this.lblId.Visible = false;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Gray;
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(24, 430);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(240, 40);
            this.btnClear.TabIndex = 12;
            this.btnClear.Text = "جديد / مسح";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(24, 380);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(240, 40);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "حفظ / تعديل";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // chkActive
            // 
            this.chkActive.AutoSize = true;
            this.chkActive.Checked = true;
            this.chkActive.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkActive.Location = new System.Drawing.Point(24, 340);
            this.chkActive.Name = "chkActive";
            this.chkActive.Size = new System.Drawing.Size(57, 23);
            this.chkActive.TabIndex = 10;
            this.chkActive.Text = "نشط";
            this.chkActive.UseVisualStyleBackColor = true;
            // 
            // txtMilitaryPrice
            // 
            this.txtMilitaryPrice.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtMilitaryPrice.Location = new System.Drawing.Point(24, 305);
            this.txtMilitaryPrice.Name = "txtMilitaryPrice";
            this.txtMilitaryPrice.Size = new System.Drawing.Size(240, 27);
            this.txtMilitaryPrice.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Gray;
            this.label5.Location = new System.Drawing.Point(20, 283);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 19);
            this.label5.TabIndex = 8;
            this.label5.Text = "سعر العسكري";
            // 
            // txtDegree1Price
            // 
            this.txtDegree1Price.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtDegree1Price.Location = new System.Drawing.Point(24, 240);
            this.txtDegree1Price.Name = "txtDegree1Price";
            this.txtDegree1Price.Size = new System.Drawing.Size(240, 27);
            this.txtDegree1Price.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Gray;
            this.label4.Location = new System.Drawing.Point(20, 218);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "سعر الدرجة الأولى";
            // 
            // txtCivilianPrice
            // 
            this.txtCivilianPrice.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtCivilianPrice.Location = new System.Drawing.Point(24, 175);
            this.txtCivilianPrice.Name = "txtCivilianPrice";
            this.txtCivilianPrice.Size = new System.Drawing.Size(240, 27);
            this.txtCivilianPrice.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(20, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "سعر المدني";
            // 
            // txtMemberPrice
            // 
            this.txtMemberPrice.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtMemberPrice.Location = new System.Drawing.Point(24, 110);
            this.txtMemberPrice.Name = "txtMemberPrice";
            this.txtMemberPrice.Size = new System.Drawing.Size(240, 27);
            this.txtMemberPrice.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(20, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "سعر العضو";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtName.Location = new System.Drawing.Point(24, 45);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(240, 27);
            this.txtName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(20, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "اسم الرياضة";
            // 
            // grid
            // 
            this.grid.AllowUserToAddRows = false;
            this.grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grid.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.grid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid.Location = new System.Drawing.Point(300, 110);
            this.grid.MultiSelect = false;
            this.grid.Name = "grid";
            this.grid.ReadOnly = true;
            this.grid.RowHeadersVisible = false;
            this.grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid.Size = new System.Drawing.Size(600, 490);
            this.grid.TabIndex = 3;
            this.grid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_CellClick);
            // 
            // SportsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(900, 600);
            this.Controls.Add(this.grid);
            this.Controls.Add(this.pnlInputs);
            this.Controls.Add(this.pnlTabs);
            this.Controls.Add(this.headerPanel);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "SportsForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sports Management";
            this.headerPanel.ResumeLayout(false);
            this.headerPanel.PerformLayout();
            this.pnlTabs.ResumeLayout(false);
            this.pnlInputs.ResumeLayout(false);
            this.pnlInputs.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlInputs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtMilitaryPrice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDegree1Price;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCivilianPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMemberPrice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chkActive;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.DataGridView grid;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Panel pnlTabs;
        private System.Windows.Forms.Button btnDbMixed;
        private System.Windows.Forms.Button btnDbMalaab;
        private System.Windows.Forms.Button btnDbPool;
        private System.Windows.Forms.Button btnDbSubs;
    }
}