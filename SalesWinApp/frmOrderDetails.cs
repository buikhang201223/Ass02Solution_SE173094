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
    public partial class frmOrderDetails : Form
    {
        public bool isAdmin { get; set; }
        public IOrderRepository OrderRepository { get; set; }
        public bool InsertOrUpdate { get; set; }
        public Order OrderInfor { get; set; }
        IOrderDetailRepository orderDRepository = new OrderDetailRepository();
        IMemberRepository memberRepository = new MemberRepository();
        //Create a data source
        BindingSource source;
        public frmOrderDetails()
        {
            InitializeComponent();
        }

        private void frmOrderDetails_Load(object sender, EventArgs e)
        {

            txtOrderID.Enabled = !InsertOrUpdate;
            txtMemberID.Enabled = !InsertOrUpdate;
            txtOrderDate.Enabled = !InsertOrUpdate;
            if (InsertOrUpdate == true)//update mode
            {
                //Show member to perform updating
                txtOrderID.Text = OrderInfor.OrderId.ToString();
                txtOrderDate.Text = DateTime.Now.ToString();
                txtMemberID.Text = OrderInfor.MemberId.ToString();
                txtRequiredDate.Text = OrderInfor.RequiredDate.ToString();
                txtShippedDate.Text = OrderInfor.ShippedDate.ToString();
                txtFreight.Text = OrderInfor.Freight.ToString();
            }
            if (isAdmin == false)
            {
                btnDelete.Enabled = false;
                btnNew.Enabled = false;
                txtFreight.Enabled = false;
                txtMemberID.Enabled = false;
                txtOrderDate.Enabled = false;
                txtOrderID.Enabled = false;
                txtRequiredDate.Enabled = false;
                txtShippedDate.Enabled = false;
                dgvMemberList.CellDoubleClick += null;
            }
            else
            {
                btnDelete.Enabled = false;
                //Register this event to open the frmMemberDetail form that performs updating
                dgvMemberList.CellDoubleClick += dgvMemberList_CellDoubleClick;
            }
        }

        private void dgvMemberList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmOrderDDetails frm = new frmOrderDDetails
            {
                isAdmin = this.isAdmin,
                Text = "Update order detail",
                InsertOrUpdate = true,
                OrderDInfor = GetOrderObject(),
                OrderDetailRepository = orderDRepository
            };
            if (frm.ShowDialog() == DialogResult.OK)
            {
                LoadMemberList();
                //Set focus member updated
                source.Position = source.Count - 1;
            }
        }

        private void ClearText()
        {
            txtFreight.Text = string.Empty;
            txtMemberID.Text = string.Empty;
            txtOrderDate.Text = string.Empty;
            txtOrderID.Text = string.Empty;
            txtRequiredDate.Text = string.Empty;
            txtShippedDate.Text = string.Empty;
        }
        //-----------------------------------------------
        private OrderDetail GetOrderObject()
        {
            OrderDetail member = null;
            try
            {
                member = new OrderDetail
                {
                    OrderId = int.Parse(txtOrderID.Text),
                    ProductId = int.Parse(txtProductID.Text),
                    Discount = double.Parse(txtDiscount.Text.ToString()),
                    Quantity = int.Parse(txtQuantity.Text.ToString()),
                    UnitPrice = decimal.Parse(txtUnitPrice.Text.ToString()),
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Get order");
            }
            return member;
        }

        public void LoadMemberList()
        {
            var members = orderDRepository.GetOrderDetails();

            try
            {
                //The BindingSource component is designed to simplify
                //the process of binding controls to an underlying data source
                source = new BindingSource();
                source.DataSource = members.OrderByDescending(member => member.OrderId);
                txtOrderID.DataBindings.Clear();

                txtOrderID.DataBindings.Add("Text", source, "OrderId");

                dgvMemberList.DataSource = null;
                dgvMemberList.DataSource = source;
               
                if (isAdmin == false)
                {
                    if (members.Count() == 0)
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
                    if (members.Count() == 0)
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
                MessageBox.Show(ex.Message, "Load order detail list");
            }
        }
        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadMemberList();

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            frmOrderDDetails frm = new frmOrderDDetails
            {
                isAdmin = this.isAdmin,
                Text = "Add Order Detail",
                InsertOrUpdate = false,
                OrderId= OrderInfor.OrderId,
                OrderDetailRepository = orderDRepository
            };
            if (frm.ShowDialog() == DialogResult.OK)
            {
                LoadMemberList();
                //Set focus member inserted
                source.Position = source.Count - 1;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                var member = GetOrderObject();
                orderDRepository.DeleteOrderDetail(member.OrderId, member.ProductId);
                LoadMemberList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Delete an order detail");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                var Order = new Order
                {
                    OrderId = int.Parse(txtOrderID.Text),
                    OrderDate = DateTime.Parse(txtOrderDate.Text),
                    ShippedDate = DateTime.Parse(txtShippedDate.Text),
                    RequiredDate = DateTime.Parse(txtRequiredDate.Text),
                    Freight = decimal.Parse(txtFreight.Text),
                    MemberId = int.Parse(txtMemberID.Text),

                };
                if (InsertOrUpdate == false)
                {
                    OrderRepository.InsertOrder(Order);
                }
                else
                {
                    OrderRepository.UpdateOrder(Order);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, InsertOrUpdate == false ? "Add a new order" : "Update a order detail");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e) => Close();


        public void LoadMemberLList()
        {
            var members = memberRepository.GetMembers();

            try
            {
                //The BindingSource component is designed to simplify
                //the process of binding controls to an underlying data source
                source = new BindingSource();
                source.DataSource = members.OrderByDescending(member => member.CompanyName);
                txtMemberID.DataBindings.Clear();


                txtMemberID.DataBindings.Add("Text", source, "MemberId");


                dataGridView1.DataSource = null;
                dataGridView1.DataSource = source;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load member list");
            }
        }
        //------------------------------------------------------
        private void button1_Click(object sender, EventArgs e)
        {
            LoadMemberLList();
        }
    }
}
