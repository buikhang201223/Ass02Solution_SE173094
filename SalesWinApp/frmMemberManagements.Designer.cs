
namespace MyStoreWinApp
{
    partial class frmMemberManagements
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            cboSearchCountry = new System.Windows.Forms.ComboBox();
            cboSearchCity = new System.Windows.Forms.ComboBox();
            lbMemberID = new System.Windows.Forms.Label();
            lbPassword = new System.Windows.Forms.Label();
            lbMemberName = new System.Windows.Forms.Label();
            lbCountry = new System.Windows.Forms.Label();
            lbCity = new System.Windows.Forms.Label();
            lbEmail = new System.Windows.Forms.Label();
            txtEmail = new System.Windows.Forms.TextBox();
            txtMemberID = new System.Windows.Forms.TextBox();
            txtMemberName = new System.Windows.Forms.TextBox();
            txtPassword = new System.Windows.Forms.TextBox();
            cboCity = new System.Windows.Forms.ComboBox();
            btnDelete = new System.Windows.Forms.Button();
            btnNew = new System.Windows.Forms.Button();
            btnLoad = new System.Windows.Forms.Button();
            btnClose = new System.Windows.Forms.Button();
            dgvMemberList = new System.Windows.Forms.DataGridView();
            txtSearch = new System.Windows.Forms.TextBox();
            btnSearch = new System.Windows.Forms.Button();
            cboCountry = new System.Windows.Forms.ComboBox();
            btnFind = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)dgvMemberList).BeginInit();
            SuspendLayout();
            // 
            // cboSearchCountry
            // 
            cboSearchCountry.FormattingEnabled = true;
            cboSearchCountry.Items.AddRange(new object[] { "United State", "Viet Nam", "America", "United Kingdom" });
            cboSearchCountry.Location = new System.Drawing.Point(124, 194);
            cboSearchCountry.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            cboSearchCountry.Name = "cboSearchCountry";
            cboSearchCountry.Size = new System.Drawing.Size(185, 23);
            cboSearchCountry.TabIndex = 19;
            cboSearchCountry.Text = "Country";
            cboSearchCountry.SelectedIndexChanged += cboSearchCountry_SelectedIndexChanged;
            // 
            // cboSearchCity
            // 
            cboSearchCity.FormattingEnabled = true;
            cboSearchCity.Items.AddRange(new object[] { "Ho Chi Minh", "Da Nang", "Ha Noi", "Phu Quoc", "Vung Tau" });
            cboSearchCity.Location = new System.Drawing.Point(362, 195);
            cboSearchCity.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            cboSearchCity.Name = "cboSearchCity";
            cboSearchCity.Size = new System.Drawing.Size(189, 23);
            cboSearchCity.TabIndex = 21;
            cboSearchCity.Text = "City";
            cboSearchCity.SelectedIndexChanged += cboSearchCity_SelectedIndexChanged;
            // 
            // lbMemberID
            // 
            lbMemberID.AutoSize = true;
            lbMemberID.Location = new System.Drawing.Point(51, 17);
            lbMemberID.Name = "lbMemberID";
            lbMemberID.Size = new System.Drawing.Size(66, 15);
            lbMemberID.TabIndex = 0;
            lbMemberID.Text = "Member ID";
            // 
            // lbPassword
            // 
            lbPassword.AutoSize = true;
            lbPassword.Location = new System.Drawing.Point(51, 88);
            lbPassword.Name = "lbPassword";
            lbPassword.Size = new System.Drawing.Size(57, 15);
            lbPassword.TabIndex = 1;
            lbPassword.Text = "Password";
            // 
            // lbMemberName
            // 
            lbMemberName.AutoSize = true;
            lbMemberName.Location = new System.Drawing.Point(51, 54);
            lbMemberName.Name = "lbMemberName";
            lbMemberName.Size = new System.Drawing.Size(87, 15);
            lbMemberName.TabIndex = 2;
            lbMemberName.Text = "Member Name";
            // 
            // lbCountry
            // 
            lbCountry.AutoSize = true;
            lbCountry.Location = new System.Drawing.Point(362, 56);
            lbCountry.Name = "lbCountry";
            lbCountry.Size = new System.Drawing.Size(50, 15);
            lbCountry.TabIndex = 3;
            lbCountry.Text = "Country";
            // 
            // lbCity
            // 
            lbCity.AutoSize = true;
            lbCity.Location = new System.Drawing.Point(362, 91);
            lbCity.Name = "lbCity";
            lbCity.Size = new System.Drawing.Size(28, 15);
            lbCity.TabIndex = 4;
            lbCity.Text = "City";
            // 
            // lbEmail
            // 
            lbEmail.AutoSize = true;
            lbEmail.Location = new System.Drawing.Point(362, 17);
            lbEmail.Name = "lbEmail";
            lbEmail.Size = new System.Drawing.Size(36, 15);
            lbEmail.TabIndex = 5;
            lbEmail.Text = "Email";
            // 
            // txtEmail
            // 
            txtEmail.Location = new System.Drawing.Point(438, 17);
            txtEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new System.Drawing.Size(219, 23);
            txtEmail.TabIndex = 7;
            // 
            // txtMemberID
            // 
            txtMemberID.Location = new System.Drawing.Point(150, 17);
            txtMemberID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            txtMemberID.Name = "txtMemberID";
            txtMemberID.Size = new System.Drawing.Size(192, 23);
            txtMemberID.TabIndex = 8;
            // 
            // txtMemberName
            // 
            txtMemberName.Location = new System.Drawing.Point(148, 54);
            txtMemberName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            txtMemberName.Name = "txtMemberName";
            txtMemberName.Size = new System.Drawing.Size(192, 23);
            txtMemberName.TabIndex = 9;
            // 
            // txtPassword
            // 
            txtPassword.Location = new System.Drawing.Point(150, 88);
            txtPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.ReadOnly = true;
            txtPassword.Size = new System.Drawing.Size(192, 23);
            txtPassword.TabIndex = 10;
            // 
            // cboCity
            // 
            cboCity.FormattingEnabled = true;
            cboCity.Items.AddRange(new object[] { "Ho Chi Minh", "Da Nang", "Ha Noi", "Phu Quoc", "Vung Tau" });
            cboCity.Location = new System.Drawing.Point(438, 88);
            cboCity.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            cboCity.Name = "cboCity";
            cboCity.Size = new System.Drawing.Size(219, 23);
            cboCity.TabIndex = 11;
            // 
            // btnDelete
            // 
            btnDelete.Location = new System.Drawing.Point(529, 130);
            btnDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new System.Drawing.Size(82, 22);
            btnDelete.TabIndex = 12;
            btnDelete.Text = "&Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnNew
            // 
            btnNew.Location = new System.Drawing.Point(310, 130);
            btnNew.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btnNew.Name = "btnNew";
            btnNew.Size = new System.Drawing.Size(82, 22);
            btnNew.TabIndex = 13;
            btnNew.Text = "&New";
            btnNew.UseVisualStyleBackColor = true;
            btnNew.Click += btnNew_Click;
            // 
            // btnLoad
            // 
            btnLoad.Location = new System.Drawing.Point(93, 130);
            btnLoad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new System.Drawing.Size(82, 22);
            btnLoad.TabIndex = 14;
            btnLoad.Text = "&Load";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // btnClose
            // 
            btnClose.Location = new System.Drawing.Point(310, 381);
            btnClose.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btnClose.Name = "btnClose";
            btnClose.Size = new System.Drawing.Size(82, 22);
            btnClose.TabIndex = 15;
            btnClose.Text = "&Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // dgvMemberList
            // 
            dgvMemberList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMemberList.Location = new System.Drawing.Point(10, 220);
            dgvMemberList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            dgvMemberList.Name = "dgvMemberList";
            dgvMemberList.ReadOnly = true;
            dgvMemberList.RowHeadersWidth = 51;
            dgvMemberList.RowTemplate.Height = 29;
            dgvMemberList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvMemberList.Size = new System.Drawing.Size(680, 126);
            dgvMemberList.TabIndex = 16;
            dgvMemberList.CellDoubleClick += DgvMemberList_CellDoubleClick;
            // 
            // txtSearch
            // 
            txtSearch.Location = new System.Drawing.Point(124, 158);
            txtSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Seach member";
            txtSearch.Size = new System.Drawing.Size(427, 23);
            txtSearch.TabIndex = 17;
            // 
            // btnSearch
            // 
            btnSearch.Location = new System.Drawing.Point(608, 156);
            btnSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new System.Drawing.Size(82, 22);
            btnSearch.TabIndex = 18;
            btnSearch.Text = "&Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // cboCountry
            // 
            cboCountry.FormattingEnabled = true;
            cboCountry.Items.AddRange(new object[] { "Viet Nam", "America", "United State", "United Kingdom" });
            cboCountry.Location = new System.Drawing.Point(438, 56);
            cboCountry.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            cboCountry.Name = "cboCountry";
            cboCountry.Size = new System.Drawing.Size(219, 23);
            cboCountry.TabIndex = 20;
            // 
            // btnFind
            // 
            btnFind.Location = new System.Drawing.Point(608, 194);
            btnFind.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btnFind.Name = "btnFind";
            btnFind.Size = new System.Drawing.Size(82, 22);
            btnFind.TabIndex = 22;
            btnFind.Text = "&Find";
            btnFind.UseVisualStyleBackColor = true;
            btnFind.Click += btnFind_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(26, 161);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(92, 15);
            label1.TabIndex = 23;
            label1.Text = "ID and/or Name";
            // 
            // frmMemberManagements
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(712, 426);
            Controls.Add(label1);
            Controls.Add(btnFind);
            Controls.Add(cboSearchCity);
            Controls.Add(cboCountry);
            Controls.Add(cboSearchCountry);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Controls.Add(dgvMemberList);
            Controls.Add(btnClose);
            Controls.Add(btnLoad);
            Controls.Add(btnNew);
            Controls.Add(btnDelete);
            Controls.Add(cboCity);
            Controls.Add(txtPassword);
            Controls.Add(txtMemberName);
            Controls.Add(txtMemberID);
            Controls.Add(txtEmail);
            Controls.Add(lbEmail);
            Controls.Add(lbCity);
            Controls.Add(lbCountry);
            Controls.Add(lbMemberName);
            Controls.Add(lbPassword);
            Controls.Add(lbMemberID);
            Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            Name = "frmMemberManagements";
            Text = "Member Management";
            Load += frmMemberManagements_Load;
            ((System.ComponentModel.ISupportInitialize)dgvMemberList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lbMemberID;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.Label lbMemberName;
        private System.Windows.Forms.Label lbCountry;
        private System.Windows.Forms.Label lbCity;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtMemberID;
        private System.Windows.Forms.TextBox txtMemberName;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.ComboBox cboCity;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridView dgvMemberList;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ComboBox cboSearchCountry;
        private System.Windows.Forms.ComboBox cboCountry;
        private System.Windows.Forms.ComboBox cboSearchCity;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Label label1;
    }
}

