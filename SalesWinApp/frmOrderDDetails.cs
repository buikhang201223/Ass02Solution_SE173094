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
    public partial class frmOrderDDetails : Form
    {
        public IOrderDetailRepository OrderDetailRepository { get; set; }
        public bool InsertOrUpdate { get; set; }
        public OrderDetail OrderDInfor { get; set; }
        public bool isAdmin { get; set; }
        public int OrderId { get; set; }
        IProductRepository productRepository = new ProductRepository();
        BindingSource source;
        public frmOrderDDetails()
        {
            InitializeComponent();
        }

        private void frmOrderDDetails_Load(object sender, EventArgs e)
        {

            txtProductID.Enabled = !InsertOrUpdate;
            txtOrderID.Enabled = false;
            txtOrderID.Text = OrderId.ToString();

            if (InsertOrUpdate == true)//update mode
            {
                //Show member to perform updating
                txtProductID.Text = OrderDInfor.ProductId.ToString();
                txtQuantity.Text = OrderDInfor.Quantity.ToString();
                txtDiscount.Text = OrderDInfor.Discount.ToString();
                txtUnitPrice.Text = OrderDInfor.UnitPrice.ToString();

            }
        }

        public void LoadMemberList()
        {
            var members = productRepository.GetProducts();

            try
            {
                //The BindingSource component is designed to simplify
                //the process of binding controls to an underlying data source
                source = new BindingSource();
                source.DataSource = members.OrderByDescending(member => member.ProductName);
                txtProductID.DataBindings.Clear();
                txtUnitPrice.DataBindings.Clear();


                txtProductID.DataBindings.Add("Text", source, "ProductId");
                txtUnitPrice.DataBindings.Add("Text", source, "UnitPrice");

                dgvMemberList.DataSource = null;
                dgvMemberList.DataSource = source;
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load product list");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                var OrderDetail = new OrderDetail
                {
                    OrderId = int.Parse(txtOrderID.Text),
                    ProductId = int.Parse(txtProductID.Text),
                    Discount = double.Parse(txtDiscount.Text.ToString()),
                    Quantity = int.Parse(txtQuantity.Text.ToString()),
                    UnitPrice = decimal.Parse(txtUnitPrice.Text.ToString()),

                };
                if (InsertOrUpdate == false)
                {
                    OrderDetailRepository.InsertOrderDetail(OrderDetail);
                }
                else
                {
                    OrderDetailRepository.UpdateOrderDetail(OrderDetail);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, InsertOrUpdate == false ? "Add a new Order detail" : "Update an order detail");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e) => Close();

        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadMemberList();
        }
    }
}
