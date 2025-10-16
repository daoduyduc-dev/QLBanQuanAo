using System;
using System.Windows.Forms;
using QLBanQuanAo.BUS;

namespace QLBanQuanAo
{
    public partial class FormRegister : Form
    {
        private AccountBUS accountBUS = new AccountBUS();

        public FormRegister()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string fullname = txtFullname.Text.Trim();
            string password = txtPassword.Text.Trim();
            string confirm = txtConfirm.Text.Trim();

            string message = accountBUS.RegisterAccount(username, password, confirm, fullname);

            lblMessage.Text = message;
            if (message == "Đăng ký thành công!")
            {
                lblMessage.ForeColor = System.Drawing.Color.Green;
                txtUsername.Clear();
                txtFullname.Clear();
                txtPassword.Clear();
                txtConfirm.Clear();
            }
            else
            {
                lblMessage.ForeColor = System.Drawing.Color.Red;
            }
        }

        private void FormRegister_Load(object sender, EventArgs e)
        {

        }
    }
}
