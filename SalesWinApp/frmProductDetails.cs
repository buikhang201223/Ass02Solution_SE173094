using BusinessObject.Models;
using DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesWinApp
{
    public partial class frmProductDetails : Form
    {
       
        public IProductRepository ProductRepository { get; set; }
        public bool InsertOrUpdate { get; set; }
        public Product ProductInfor { get; set; }


        public frmProductDetails()
        {
            InitializeComponent();
        }
        private void frmProductDetails_Load(object sender, EventArgs e)
        {
        
            txtProductID.Enabled = !InsertOrUpdate;
            if (InsertOrUpdate == true)
            {

                txtProductID.Text = ProductInfor.ProductId.ToString();
                txtProductName.Text = ProductInfor.ProductName;
                txtCategoryID.Text = ProductInfor.CategoryId.ToString();
                txtWeight.Text = ProductInfor.Weight;
                txtUnitPrice.Text = ProductInfor.UnitPrice.ToString("0");
                txtUnitsInStock.Text = ProductInfor.UnitsInStock.ToString();

            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        { 
            try
            {
                var product = new Product
                {
                    ProductId = int.Parse(txtProductID.Text),
                    ProductName = txtProductName.Text,
                    Weight = txtWeight.Text,
                    UnitPrice = int.Parse(txtUnitPrice.Text),
                    UnitsInStock = int.Parse(txtUnitsInStock.Text),
                    CategoryId = int.Parse(txtCategoryID.Text),

                };
                if (InsertOrUpdate == false)
                {
                    ProductRepository.InsertProduct(product);
                }
                else
                {
                    ProductRepository.UpdateProduct(product);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, InsertOrUpdate == false ? "Add a new Product" : "Update a Product");
            } 
        }

        private void btnCancel_Click(object sender, EventArgs e) => Close();
       
    }
}
