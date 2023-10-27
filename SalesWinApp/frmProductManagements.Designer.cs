
namespace SalesWinApp
{
    partial class frmProductManagements
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
            txtUnitsInStock = new System.Windows.Forms.TextBox();
            txtUnitPrice = new System.Windows.Forms.TextBox();
            txtCategoryID = new System.Windows.Forms.TextBox();
            txtProductName = new System.Windows.Forms.TextBox();
            txtProductID = new System.Windows.Forms.TextBox();
            txtWeight = new System.Windows.Forms.TextBox();
            lbWeight = new System.Windows.Forms.Label();
            lbUnitsInStock = new System.Windows.Forms.Label();
            lbUnitPrice = new System.Windows.Forms.Label();
            lbProductName = new System.Windows.Forms.Label();
            lbCategoryID = new System.Windows.Forms.Label();
            lbProductID = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            btnFind = new System.Windows.Forms.Button();
            btnSearch = new System.Windows.Forms.Button();
            txtSearch = new System.Windows.Forms.TextBox();
            dgvProductList = new System.Windows.Forms.DataGridView();
            btnClose = new System.Windows.Forms.Button();
            btnLoad = new System.Windows.Forms.Button();
            btnNew = new System.Windows.Forms.Button();
            btnDelete = new System.Windows.Forms.Button();
            label2 = new System.Windows.Forms.Label();
            txtFind = new System.Windows.Forms.TextBox();
            txtToNum = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvProductList).BeginInit();
            SuspendLayout();
            // 
            // txtUnitsInStock
            // 
            txtUnitsInStock.Location = new System.Drawing.Point(499, 115);
            txtUnitsInStock.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            txtUnitsInStock.Name = "txtUnitsInStock";
            txtUnitsInStock.Size = new System.Drawing.Size(219, 23);
            txtUnitsInStock.TabIndex = 63;
            // 
            // txtUnitPrice
            // 
            txtUnitPrice.Location = new System.Drawing.Point(499, 81);
            txtUnitPrice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            txtUnitPrice.Name = "txtUnitPrice";
            txtUnitPrice.Size = new System.Drawing.Size(219, 23);
            txtUnitPrice.TabIndex = 62;
            // 
            // txtCategoryID
            // 
            txtCategoryID.Location = new System.Drawing.Point(198, 115);
            txtCategoryID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            txtCategoryID.Name = "txtCategoryID";
            txtCategoryID.ReadOnly = true;
            txtCategoryID.Size = new System.Drawing.Size(192, 23);
            txtCategoryID.TabIndex = 57;
            // 
            // txtProductName
            // 
            txtProductName.Location = new System.Drawing.Point(198, 81);
            txtProductName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new System.Drawing.Size(192, 23);
            txtProductName.TabIndex = 56;
            // 
            // txtProductID
            // 
            txtProductID.Location = new System.Drawing.Point(198, 41);
            txtProductID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            txtProductID.Name = "txtProductID";
            txtProductID.Size = new System.Drawing.Size(192, 23);
            txtProductID.TabIndex = 55;
            // 
            // txtWeight
            // 
            txtWeight.Location = new System.Drawing.Point(499, 41);
            txtWeight.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            txtWeight.Name = "txtWeight";
            txtWeight.Size = new System.Drawing.Size(219, 23);
            txtWeight.TabIndex = 54;
            // 
            // lbWeight
            // 
            lbWeight.AutoSize = true;
            lbWeight.Location = new System.Drawing.Point(412, 44);
            lbWeight.Name = "lbWeight";
            lbWeight.Size = new System.Drawing.Size(45, 15);
            lbWeight.TabIndex = 53;
            lbWeight.Text = "Weight";
            // 
            // lbUnitsInStock
            // 
            lbUnitsInStock.AutoSize = true;
            lbUnitsInStock.Location = new System.Drawing.Point(412, 118);
            lbUnitsInStock.Name = "lbUnitsInStock";
            lbUnitsInStock.Size = new System.Drawing.Size(79, 15);
            lbUnitsInStock.TabIndex = 52;
            lbUnitsInStock.Text = "Units In Stock";
            // 
            // lbUnitPrice
            // 
            lbUnitPrice.AutoSize = true;
            lbUnitPrice.Location = new System.Drawing.Point(412, 83);
            lbUnitPrice.Name = "lbUnitPrice";
            lbUnitPrice.Size = new System.Drawing.Size(58, 15);
            lbUnitPrice.TabIndex = 51;
            lbUnitPrice.Text = "Unit Price";
            // 
            // lbProductName
            // 
            lbProductName.AutoSize = true;
            lbProductName.Location = new System.Drawing.Point(101, 81);
            lbProductName.Name = "lbProductName";
            lbProductName.Size = new System.Drawing.Size(84, 15);
            lbProductName.TabIndex = 50;
            lbProductName.Text = "Product Name";
            // 
            // lbCategoryID
            // 
            lbCategoryID.AutoSize = true;
            lbCategoryID.Location = new System.Drawing.Point(101, 115);
            lbCategoryID.Name = "lbCategoryID";
            lbCategoryID.Size = new System.Drawing.Size(69, 15);
            lbCategoryID.TabIndex = 49;
            lbCategoryID.Text = "Category ID";
            // 
            // lbProductID
            // 
            lbProductID.AutoSize = true;
            lbProductID.Location = new System.Drawing.Point(101, 44);
            lbProductID.Name = "lbProductID";
            lbProductID.Size = new System.Drawing.Size(63, 15);
            lbProductID.TabIndex = 48;
            lbProductID.Text = "Product ID";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(84, 195);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(92, 15);
            label1.TabIndex = 74;
            label1.Text = "ID and/or Name";
            // 
            // btnFind
            // 
            btnFind.Location = new System.Drawing.Point(587, 221);
            btnFind.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btnFind.Name = "btnFind";
            btnFind.Size = new System.Drawing.Size(82, 22);
            btnFind.TabIndex = 73;
            btnFind.Text = "&Search";
            btnFind.UseVisualStyleBackColor = true;
            btnFind.Click += btnFind_Click;
            // 
            // btnSearch
            // 
            btnSearch.Location = new System.Drawing.Point(389, 193);
            btnSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new System.Drawing.Size(82, 22);
            btnSearch.TabIndex = 70;
            btnSearch.Text = "&Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new System.Drawing.Point(198, 192);
            txtSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Seach member";
            txtSearch.Size = new System.Drawing.Size(185, 23);
            txtSearch.TabIndex = 69;
            // 
            // dgvProductList
            // 
            dgvProductList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductList.Location = new System.Drawing.Point(12, 254);
            dgvProductList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            dgvProductList.Name = "dgvProductList";
            dgvProductList.ReadOnly = true;
            dgvProductList.RowHeadersWidth = 51;
            dgvProductList.RowTemplate.Height = 29;
            dgvProductList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvProductList.Size = new System.Drawing.Size(776, 126);
            dgvProductList.TabIndex = 68;
            dgvProductList.CellDoubleClick += dgvProductList_CellDoubleClick;
            // 
            // btnClose
            // 
            btnClose.Location = new System.Drawing.Point(368, 393);
            btnClose.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btnClose.Name = "btnClose";
            btnClose.Size = new System.Drawing.Size(82, 22);
            btnClose.TabIndex = 67;
            btnClose.Text = "&Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnLoad
            // 
            btnLoad.Location = new System.Drawing.Point(151, 164);
            btnLoad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new System.Drawing.Size(82, 22);
            btnLoad.TabIndex = 66;
            btnLoad.Text = "&Load";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // btnNew
            // 
            btnNew.Location = new System.Drawing.Point(368, 164);
            btnNew.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btnNew.Name = "btnNew";
            btnNew.Size = new System.Drawing.Size(82, 22);
            btnNew.TabIndex = 65;
            btnNew.Text = "&New";
            btnNew.UseVisualStyleBackColor = true;
            btnNew.Click += btnNew_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new System.Drawing.Point(587, 164);
            btnDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new System.Drawing.Size(82, 22);
            btnDelete.TabIndex = 64;
            btnDelete.Text = "&Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(118, 225);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(58, 15);
            label2.TabIndex = 76;
            label2.Text = "Unit Price";
            // 
            // txtFind
            // 
            txtFind.Location = new System.Drawing.Point(198, 220);
            txtFind.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            txtFind.Name = "txtFind";
            txtFind.PlaceholderText = "From";
            txtFind.Size = new System.Drawing.Size(185, 23);
            txtFind.TabIndex = 75;
            // 
            // txtToNum
            // 
            txtToNum.Location = new System.Drawing.Point(389, 220);
            txtToNum.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            txtToNum.Name = "txtToNum";
            txtToNum.PlaceholderText = "To";
            txtToNum.Size = new System.Drawing.Size(185, 23);
            txtToNum.TabIndex = 77;
            // 
            // frmProductManagements
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(txtToNum);
            Controls.Add(label2);
            Controls.Add(txtFind);
            Controls.Add(label1);
            Controls.Add(btnFind);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Controls.Add(dgvProductList);
            Controls.Add(btnClose);
            Controls.Add(btnLoad);
            Controls.Add(btnNew);
            Controls.Add(btnDelete);
            Controls.Add(txtUnitsInStock);
            Controls.Add(txtUnitPrice);
            Controls.Add(txtCategoryID);
            Controls.Add(txtProductName);
            Controls.Add(txtProductID);
            Controls.Add(txtWeight);
            Controls.Add(lbWeight);
            Controls.Add(lbUnitsInStock);
            Controls.Add(lbUnitPrice);
            Controls.Add(lbProductName);
            Controls.Add(lbCategoryID);
            Controls.Add(lbProductID);
            Name = "frmProductManagements";
            Text = "frmProductManagements";
            Load += frmProductManagements_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProductList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txtUnitsInStock;
        private System.Windows.Forms.TextBox txtUnitPrice;
        private System.Windows.Forms.TextBox txtCategoryID;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.TextBox txtProductID;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.Label lbWeight;
        private System.Windows.Forms.Label lbUnitsInStock;
        private System.Windows.Forms.Label lbUnitPrice;
        private System.Windows.Forms.Label lbProductName;
        private System.Windows.Forms.Label lbCategoryID;
        private System.Windows.Forms.Label lbProductID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridView dgvProductList;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFind;
        private System.Windows.Forms.TextBox txtToNum;
    }
}