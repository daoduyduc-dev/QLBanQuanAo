using System;
using System.Windows.Forms;
using QLBanQuanAo.BUS; // Sử dụng tầng BUS

namespace QLBanQuanAo
{
    public partial class frmLogin : Form
    {
        // Khởi tạo đối tượng BUS
        private AccountBUS accountBUS = new AccountBUS();

        public frmLogin()
        {
            InitializeComponent();
            // Đảm bảo nút Đăng nhập đã được liên kết trong Designer
            this.btnDN.Click += new System.EventHandler(this.btnDN_Click);
        }

        // Phương thức xử lý sự kiện khi nhấn nút "Đăng Nhập" (btnDN)
        private void btnDN_Click(object sender, EventArgs e)
        {
            string username = txtTenDN.Text.Trim();
            string password = txtMK.Text;

            // 1. Kiểm tra UI/Input (quy tắc rỗng)
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ Tên đăng nhập và Mật khẩu.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenDN.Focus();
                return;
            }

            try
            {
                // 2. GỌI TẦNG BUS ĐỂ XÁC THỰC
                // Tầng BUS sẽ gọi tầng DAL để kiểm tra khớp với tài khoản trong Database
                bool isAuthenticated = accountBUS.AuthenticateUser(username, password);

                // 3. Xử lý kết quả trả về
                if (isAuthenticated)
                {
                    // THÀNH CÔNG: Mật khẩu khớp với tài khoản ĐÃ ĐĂNG KÝ trong DB
                    MessageBox.Show("Đăng nhập thành công! Chào mừng " + username, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Mở Form Main và ẩn Form Login
                    frmMain mainForm = new frmMain();
                    mainForm.Show();
                    this.Hide();
                }
                else
                {
                    // THẤT BẠI: Mật khẩu KHÔNG KHỚP hoặc tài khoản không tồn tại
                    MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng.", "Lỗi Đăng Nhập", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtMK.Clear();
                    txtTenDN.Focus();
                }
            }
            catch (Exception ex)
            {
                // Xử lý lỗi kết nối Database từ DAL
                MessageBox.Show("Đã xảy ra lỗi hệ thống: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Phương thức xử lý sự kiện khi nhấn vào LinkLabel "Đăng Ký" (llblDangKy)
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Mở form đăng ký (FormRegister)
            FormRegister registerForm = new FormRegister();
            registerForm.ShowDialog();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            // Thiết lập ô mật khẩu ẩn ký tự
            txtMK.UseSystemPasswordChar = true;

            // Thiết lập nút Đăng Nhập là nút mặc định khi nhấn Enter
            this.AcceptButton = btnDN;
        }

        private void lblGoDK_Click(object sender, EventArgs e)
        {
            // Xử lý khi click vào label "Chưa có tài khoản?" bằng cách gọi LinkLabel
            linkLabel1_LinkClicked(sender, null);
        }

        // Phương thức trống, có thể xóa trong file gốc
        private void groupBox1_Enter(object sender, EventArgs e) { }
    }
}