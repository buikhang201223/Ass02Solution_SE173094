using BusinessObject.Models;
using DataAccess.Repository;
using Microsoft.Extensions.Configuration;
using SalesWinApp;
using System;
using System.IO;
using System.Windows.Forms;

namespace MyStoreWinApp
{
    public partial class frmLogin : Form
    {
        private MemberRepository memberRepository = new MemberRepository();
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            this.Hide();
            IConfiguration config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", true, true)
                .Build();

            var adminAccount = new Member
            {
                Email = config["DefaultAccount:Email"],
                Password = config["DefaultAccount:password"]
            };

            string Email = adminAccount.Email;
            string Password = adminAccount.Password;
            bool isMem = false;

            if (Email.Equals(txtUserName.Text) && Password.Equals(txtPassword.Text))
            {
                frmMain frm = new frmMain()
                {
                    isAdmin = true
                };
                isMem = true;
                MessageBox.Show("Login Successfully!", "Login Successfully!");
                frm.FormClosed += (s, args) => this.Show();
                frm.ShowDialog();

            }


            var members = memberRepository.GetMembers();

            foreach (var i in members)
            {
                if (i.Email.Equals(txtUserName.Text) && i.Password.Equals(txtPassword.Text))
                {
                    frmMain frm = new frmMain()
                    {
                        isAdmin = false
                    };
                    isMem = true;
                    MessageBox.Show("Login Successfully!", "Login Successfully!");
                    frm.FormClosed += (s, args) => this.Show();
                    frm.ShowDialog();
                    break;

                }
                
            }
            if (!isMem)
            {
                MessageBox.Show("Wrong user name or password, please try again", "Login Failed!");
                this.Show();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e) => this.Close();

    }
}
