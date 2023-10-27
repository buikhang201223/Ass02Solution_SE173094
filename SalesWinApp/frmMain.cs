using MyStoreWinApp;
using System.Windows.Forms;

namespace SalesWinApp
{
    public partial class frmMain : Form
    {
        public bool isAdmin { get; set; }

        public frmMain()
        {
            InitializeComponent();
        }

        private void memberToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            frmMemberManagements frm = new frmMemberManagements() { isAdmin = this.isAdmin };
            frm.ShowDialog();
        }

        private void productToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            frmProductManagements frm = new frmProductManagements() { isAdmin = this.isAdmin };
            frm.ShowDialog();
        }

        private void orderToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            frmOrderManagements frm = new frmOrderManagements() { isAdmin = this.isAdmin };
            frm.ShowDialog();
        }

        private void frmMain_Load(object sender, System.EventArgs e)
        {

        }
    }
}
