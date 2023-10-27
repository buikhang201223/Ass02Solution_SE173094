
namespace SalesWinApp
{
    partial class frmOrderManagements
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtFreight = new System.Windows.Forms.TextBox();
            txtShippedDate = new System.Windows.Forms.TextBox();
            dgvMemberList = new System.Windows.Forms.DataGridView();
            btnLoad = new System.Windows.Forms.Button();
            btnNew = new System.Windows.Forms.Button();
            btnDelete = new System.Windows.Forms.Button();
            txtOrderDate = new System.Windows.Forms.TextBox();
            txtMemberID = new System.Windows.Forms.TextBox();
            txtOrderID = new System.Windows.Forms.TextBox();
            txtRequiredDate = new System.Windows.Forms.TextBox();
            lbRequiredDate = new System.Windows.Forms.Label();
            lbFreight = new System.Windows.Forms.Label();
            lbCountry = new System.Windows.Forms.Label();
            lbMemberID = new System.Windows.Forms.Label();
            lbOrderDate = new System.Windows.Forms.Label();
            lbOrderID = new System.Windows.Forms.Label();
            txtToNum = new System.Windows.Forms.TextBox();
            lbReport = new System.Windows.Forms.Label();
            txtFromNum = new System.Windows.Forms.TextBox();
            btnSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)dgvMemberList).BeginInit();
            SuspendLayout();
            // 
            // txtFreight
            // 
            txtFreight.Location = new System.Drawing.Point(490, 161);
            txtFreight.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            txtFreight.Name = "txtFreight";
            txtFreight.Size = new System.Drawing.Size(219, 23);
            txtFreight.TabIndex = 63;
            // 
            // txtShippedDate
            // 
            txtShippedDate.Location = new System.Drawing.Point(490, 127);
            txtShippedDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            txtShippedDate.Name = "txtShippedDate";
            txtShippedDate.Size = new System.Drawing.Size(219, 23);
            txtShippedDate.TabIndex = 62;
            // 
            // dgvMemberList
            // 
            dgvMemberList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMemberList.Location = new System.Drawing.Point(12, 278);
            dgvMemberList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            dgvMemberList.Name = "dgvMemberList";
            dgvMemberList.ReadOnly = true;
            dgvMemberList.RowHeadersWidth = 51;
            dgvMemberList.RowTemplate.Height = 29;
            dgvMemberList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvMemberList.Size = new System.Drawing.Size(776, 126);
            dgvMemberList.TabIndex = 61;
            dgvMemberList.CellDoubleClick += dgvOrderList_CellDoubleClick;
            // 
            // btnLoad
            // 
            btnLoad.Location = new System.Drawing.Point(189, 203);
            btnLoad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new System.Drawing.Size(82, 22);
            btnLoad.TabIndex = 60;
            btnLoad.Text = "&Load";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // btnNew
            // 
            btnNew.Location = new System.Drawing.Point(402, 203);
            btnNew.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btnNew.Name = "btnNew";
            btnNew.Size = new System.Drawing.Size(82, 22);
            btnNew.TabIndex = 59;
            btnNew.Text = "&New";
            btnNew.UseVisualStyleBackColor = true;
            btnNew.Click += btnNew_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new System.Drawing.Point(601, 203);
            btnDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new System.Drawing.Size(82, 22);
            btnDelete.TabIndex = 58;
            btnDelete.Text = "&Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // txtOrderDate
            // 
            txtOrderDate.Location = new System.Drawing.Point(189, 161);
            txtOrderDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            txtOrderDate.Name = "txtOrderDate";
            txtOrderDate.ReadOnly = true;
            txtOrderDate.Size = new System.Drawing.Size(192, 23);
            txtOrderDate.TabIndex = 57;
            // 
            // txtMemberID
            // 
            txtMemberID.Location = new System.Drawing.Point(189, 127);
            txtMemberID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            txtMemberID.Name = "txtMemberID";
            txtMemberID.Size = new System.Drawing.Size(192, 23);
            txtMemberID.TabIndex = 56;
            // 
            // txtOrderID
            // 
            txtOrderID.Location = new System.Drawing.Point(189, 87);
            txtOrderID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            txtOrderID.Name = "txtOrderID";
            txtOrderID.Size = new System.Drawing.Size(192, 23);
            txtOrderID.TabIndex = 55;
            // 
            // txtRequiredDate
            // 
            txtRequiredDate.Location = new System.Drawing.Point(490, 87);
            txtRequiredDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            txtRequiredDate.Name = "txtRequiredDate";
            txtRequiredDate.Size = new System.Drawing.Size(219, 23);
            txtRequiredDate.TabIndex = 54;
            // 
            // lbRequiredDate
            // 
            lbRequiredDate.AutoSize = true;
            lbRequiredDate.Location = new System.Drawing.Point(403, 90);
            lbRequiredDate.Name = "lbRequiredDate";
            lbRequiredDate.Size = new System.Drawing.Size(81, 15);
            lbRequiredDate.TabIndex = 53;
            lbRequiredDate.Text = "Required Date";
            // 
            // lbFreight
            // 
            lbFreight.AutoSize = true;
            lbFreight.Location = new System.Drawing.Point(403, 164);
            lbFreight.Name = "lbFreight";
            lbFreight.Size = new System.Drawing.Size(44, 15);
            lbFreight.TabIndex = 52;
            lbFreight.Text = "Freight";
            // 
            // lbCountry
            // 
            lbCountry.AutoSize = true;
            lbCountry.Location = new System.Drawing.Point(403, 129);
            lbCountry.Name = "lbCountry";
            lbCountry.Size = new System.Drawing.Size(77, 15);
            lbCountry.TabIndex = 51;
            lbCountry.Text = "Shipped Date";
            // 
            // lbMemberID
            // 
            lbMemberID.AutoSize = true;
            lbMemberID.Location = new System.Drawing.Point(92, 127);
            lbMemberID.Name = "lbMemberID";
            lbMemberID.Size = new System.Drawing.Size(66, 15);
            lbMemberID.TabIndex = 50;
            lbMemberID.Text = "Member ID";
            // 
            // lbOrderDate
            // 
            lbOrderDate.AutoSize = true;
            lbOrderDate.Location = new System.Drawing.Point(92, 161);
            lbOrderDate.Name = "lbOrderDate";
            lbOrderDate.Size = new System.Drawing.Size(64, 15);
            lbOrderDate.TabIndex = 49;
            lbOrderDate.Text = "Order Date";
            // 
            // lbOrderID
            // 
            lbOrderID.AutoSize = true;
            lbOrderID.Location = new System.Drawing.Point(92, 90);
            lbOrderID.Name = "lbOrderID";
            lbOrderID.Size = new System.Drawing.Size(51, 15);
            lbOrderID.TabIndex = 48;
            lbOrderID.Text = "Order ID";
            // 
            // txtToNum
            // 
            txtToNum.Location = new System.Drawing.Point(402, 241);
            txtToNum.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            txtToNum.Name = "txtToNum";
            txtToNum.PlaceholderText = "Seach member";
            txtToNum.Size = new System.Drawing.Size(185, 23);
            txtToNum.TabIndex = 81;
            txtToNum.Text = "To Date";
            // 
            // lbReport
            // 
            lbReport.AutoSize = true;
            lbReport.Location = new System.Drawing.Point(92, 244);
            lbReport.Name = "lbReport";
            lbReport.Size = new System.Drawing.Size(71, 15);
            lbReport.TabIndex = 80;
            lbReport.Text = "Sales Report";
            // 
            // txtFromNum
            // 
            txtFromNum.Location = new System.Drawing.Point(189, 241);
            txtFromNum.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            txtFromNum.Name = "txtFromNum";
            txtFromNum.PlaceholderText = "Seach member";
            txtFromNum.Size = new System.Drawing.Size(185, 23);
            txtFromNum.TabIndex = 79;
            txtFromNum.Text = "From Date";
            // 
            // btnSearch
            // 
            btnSearch.Location = new System.Drawing.Point(601, 242);
            btnSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new System.Drawing.Size(82, 22);
            btnSearch.TabIndex = 78;
            btnSearch.Text = "&Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // frmOrderManagements
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 409);
            Controls.Add(txtToNum);
            Controls.Add(lbReport);
            Controls.Add(txtFromNum);
            Controls.Add(btnSearch);
            Controls.Add(txtFreight);
            Controls.Add(txtShippedDate);
            Controls.Add(dgvMemberList);
            Controls.Add(btnLoad);
            Controls.Add(btnNew);
            Controls.Add(btnDelete);
            Controls.Add(txtOrderDate);
            Controls.Add(txtMemberID);
            Controls.Add(txtOrderID);
            Controls.Add(txtRequiredDate);
            Controls.Add(lbRequiredDate);
            Controls.Add(lbFreight);
            Controls.Add(lbCountry);
            Controls.Add(lbMemberID);
            Controls.Add(lbOrderDate);
            Controls.Add(lbOrderID);
            Name = "frmOrderManagements";
            Text = "frmOrderManagements";
            Load += frmOrderManagements_Load;
            ((System.ComponentModel.ISupportInitialize)dgvMemberList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txtFreight;
        private System.Windows.Forms.TextBox txtShippedDate;
        private System.Windows.Forms.DataGridView dgvMemberList;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtOrderDate;
        private System.Windows.Forms.TextBox txtMemberID;
        private System.Windows.Forms.TextBox txtOrderID;
        private System.Windows.Forms.TextBox txtRequiredDate;
        private System.Windows.Forms.Label lbRequiredDate;
        private System.Windows.Forms.Label lbFreight;
        private System.Windows.Forms.Label lbCountry;
        private System.Windows.Forms.Label lbMemberID;
        private System.Windows.Forms.Label lbOrderDate;
        private System.Windows.Forms.Label lbOrderID;
        private System.Windows.Forms.TextBox txtToNum;
        private System.Windows.Forms.Label lbReport;
        private System.Windows.Forms.TextBox txtFromNum;
        private System.Windows.Forms.Button btnSearch;
    }
}