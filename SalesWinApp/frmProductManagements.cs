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
    public partial class frmProductManagements : Form
    {
        public bool isAdmin { get; set; }
        IProductRepository productRepository = new ProductRepository();
        BindingSource source;


        public frmProductManagements()
        {
            InitializeComponent();
        }

        private void frmProductManagements_Load(object sender, EventArgs e)
        {
            if (isAdmin == false)
            {
                btnDelete.Enabled = false;
                btnNew.Enabled = false;
                btnFind.Enabled = false;
                btnLoad.Enabled = false;
                btnSearch.Enabled = false;
                txtProductName.Enabled = false;
                txtCategoryID.Enabled = false;
                txtFind.Enabled = false;
                txtProductID.Enabled = false;
                txtSearch.Enabled = false;
                txtUnitPrice.Enabled = false;
                txtUnitPrice.Enabled = false;
                txtUnitsInStock.Enabled = false;
                txtWeight.Enabled = false;
                dgvProductList.CellDoubleClick += null;
            }
            else
            {
                btnDelete.Enabled = false;
            }
        }
        private void dgvProductList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmProductDetails frm = new frmProductDetails
            {
                Text = "Update product",
                InsertOrUpdate = true,
                ProductInfor = GetProductObject(),
                ProductRepository = productRepository
            };
            if (frm.ShowDialog() == DialogResult.OK)
            {
                LoadProductList();
                source.Position = source.Count - 1;
            }
        }

        private void ClearText()
        {
            txtWeight.Text = string.Empty;
            txtUnitsInStock.Text = string.Empty;
            txtUnitPrice.Text = string.Empty;
            txtProductName.Text = string.Empty;
            txtProductID.Text = string.Empty;
            txtCategoryID.Text = string.Empty;
        }
        //-----------------------------------------------
        private Product GetProductObject()
        {
            Product member = null;
            try
            {
                member = new Product
                {
                    ProductId = int.Parse(txtProductID.Text),
                    ProductName = txtProductName.Text.ToString(),
                    CategoryId = int.Parse(txtCategoryID.Text),
                    UnitPrice = decimal.Parse(txtUnitPrice.Text),
                    UnitsInStock = int.Parse(txtUnitsInStock.Text),
                    Weight = txtWeight.Text.ToString()
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Get product");
            }
            return member;
        }

        public void LoadProductList()
        {
            var products = productRepository.GetProducts();

            try
            {
                source = new BindingSource();
                source.DataSource = products.OrderByDescending(product => product.ProductName);
                txtProductID.DataBindings.Clear();
                txtProductName.DataBindings.Clear();
                txtCategoryID.DataBindings.Clear();
                txtUnitPrice.DataBindings.Clear();
                txtUnitsInStock.DataBindings.Clear();
                txtWeight.DataBindings.Clear();

                txtProductID.DataBindings.Add("Text", source, "ProductId");
                txtProductName.DataBindings.Add("Text", source, "ProductName");
                txtCategoryID.DataBindings.Add("Text", source, "CategoryId");
                txtUnitPrice.DataBindings.Add("Text", source, "UnitPrice");
                txtUnitsInStock.DataBindings.Add("Text", source, "UnitsInStock");
                txtWeight.DataBindings.Add("Text", source, "Weight");


                dgvProductList.DataSource = null;
                dgvProductList.DataSource = source;
                if (isAdmin == false)
                {
                    if (products.Count() == 0)
                    {
                        ClearText();
                        btnDelete.Enabled = false;
                    }
                    else
                    {
                        btnDelete.Enabled = false;
                    }
                }
                else
                {
                    if (products.Count() == 0)
                    {
                        ClearText();
                        btnDelete.Enabled = false;
                    }
                    else
                    {
                        btnDelete.Enabled = true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load product list");
            }
        }
        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadProductList();
        }


        private void btnNew_Click(object sender, EventArgs e)
        {
            frmProductDetails frm = new frmProductDetails
            {
                Text = "Add product",
                InsertOrUpdate = false,
                ProductRepository = productRepository
            };
            if (frm.ShowDialog() == DialogResult.OK)
            {
                LoadProductList();
                source.Position = source.Count - 1;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            try
            {
                var member = GetProductObject();
                productRepository.DeleteProduct(member.ProductId);
                LoadProductList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Delete a product");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoadOneProduct()
        {
            Product member = new Product();
            var members = productRepository.GetProducts();
            try
            {
                foreach (var i in members)
                {
                    if (i.ProductName.Equals(txtSearch.Text))
                    {
                        source = new BindingSource();


                        source.DataSource = productRepository.GetProductByID(i.ProductId);

                        txtProductID.DataBindings.Clear();
                        txtProductName.DataBindings.Clear();
                        txtCategoryID.DataBindings.Clear();
                        txtUnitPrice.DataBindings.Clear();
                        txtUnitsInStock.DataBindings.Clear();
                        txtWeight.DataBindings.Clear();

                        txtProductID.DataBindings.Add("Text", source, "ProductId");
                        txtProductName.DataBindings.Add("Text", source, "ProductName");
                        txtCategoryID.DataBindings.Add("Text", source, "CategoryId");
                        txtUnitPrice.DataBindings.Add("Text", source, "UnitPrice");
                        txtUnitsInStock.DataBindings.Add("Text", source, "UnitsInStock");
                        txtWeight.DataBindings.Add("Text", source, "Weight");


                        dgvProductList.DataSource = null;
                        dgvProductList.DataSource = source;
                        break;
                    }
                    else if (i.ProductId.ToString().Equals(txtSearch.Text))
                    {
                        source = new BindingSource();


                        source.DataSource = productRepository.GetProductByID(i.ProductId);
                        txtProductID.DataBindings.Clear();
                        txtProductName.DataBindings.Clear();
                        txtCategoryID.DataBindings.Clear();
                        txtUnitPrice.DataBindings.Clear();
                        txtUnitsInStock.DataBindings.Clear();
                        txtWeight.DataBindings.Clear();

                        txtProductID.DataBindings.Add("Text", source, "ProductId");
                        txtProductName.DataBindings.Add("Text", source, "ProductName");
                        txtCategoryID.DataBindings.Add("Text", source, "CategoryId");
                        txtUnitPrice.DataBindings.Add("Text", source, "UnitPrice");
                        txtUnitsInStock.DataBindings.Add("Text", source, "UnitsInStock");
                        txtWeight.DataBindings.Add("Text", source, "Weight");


                        dgvProductList.DataSource = null;
                        dgvProductList.DataSource = source;
                        break;
                    }


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load product list");
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadOneProduct();
        }

        private void FilterProduct()
        {

            Product product = new Product();
            List<Product> filterList = productRepository.GetProductByUnitPriceAndUnitInStock(int.Parse(txtFind.Text), int.Parse(txtToNum.Text));
            // var products = productRepository.Getproducts();
            try
            {
                // if (i.Country.Equals(this.cboSearchCountry.GetItemText(this.cboSearchCountry.SelectedItem)) && i.City.Equals(this.cboSearchCity.GetItemText(this.cboSearchCity.SelectedItem)))

                /* foreach (var i in products)
                 {
                  if (i.Country.Equals(cboSearchCountry.Text) && i.City.Equals(cboSearchCity.Text))
                     {
                         filterList.Add(i);
                     }
                     else
                     {
                         if (filterList.Count == 0)
                         {
                             MessageBox.Show("No product matched", "No result");
                             break;
                         }
                     }
                 }*/
                if (filterList.Count == 0)
                {
                    MessageBox.Show("No product matched", "No result");
                }
                else if (filterList.Count != 0)
                {
                    source = new BindingSource();
                    source.DataSource = filterList.OrderByDescending(product => product.UnitPrice);
                    txtProductID.DataBindings.Clear();
                    txtProductName.DataBindings.Clear();
                    txtCategoryID.DataBindings.Clear();
                    txtUnitPrice.DataBindings.Clear();
                    txtUnitsInStock.DataBindings.Clear();
                    txtWeight.DataBindings.Clear();

                    txtProductID.DataBindings.Add("Text", source, "ProductId");
                    txtProductName.DataBindings.Add("Text", source, "ProductName");
                    txtCategoryID.DataBindings.Add("Text", source, "CategoryId");
                    txtUnitPrice.DataBindings.Add("Text", source, "UnitPrice");
                    txtUnitsInStock.DataBindings.Add("Text", source, "UnitsInStock");
                    txtWeight.DataBindings.Add("Text", source, "Weight");


                    dgvProductList.DataSource = null;
                    dgvProductList.DataSource = source;
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load product list");
            }
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            FilterProduct();
        }

    }
}
