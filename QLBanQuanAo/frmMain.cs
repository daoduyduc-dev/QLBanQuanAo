using QLBanQuanAo.UI;
using System;
using System.Windows.Forms;

namespace QLBanQuanAo
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        // =========================
        //  MỤC CHỨC NĂNG
        // =========================

        private void đăngNhâpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLogin f = new frmLogin();
            f.ShowDialog();
        }

        private void đăngKyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormRegister f = new FormRegister();
            f.ShowDialog();
        }

        private void thoatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Hỏi người dùng trước khi thoát
            DialogResult r = MessageBox.Show("Bạn có chắc muốn thoát chương trình không?",
                                             "Xác nhận thoát",
                                             MessageBoxButtons.YesNo,
                                             MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        // =========================
        //  MỤC HỆ THỐNG
        // =========================

        private void quanLyKhacToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmKhachHang f = new frmKhachHang();
            f.ShowDialog();
        }

        private void thôngKêDoanhThuToolStripMenuItem_Click(object sender, EventArgs e)
        {

            frmHoaDon f = new frmHoaDon();
            f.ShowDialog();
        }

        private void thôngKêSanPhâmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSanPham f = new frmSanPham();
            f.ShowDialog();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }
    }
}
