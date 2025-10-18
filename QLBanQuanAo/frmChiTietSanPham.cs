using QLBanQuanAo.BUS;
using QLBanQuanAo.DAL.Models;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace QLBanQuanAo.UI
{
    public partial class frmChiTietSanPham : Form
    {
        private int _maSP;
        private SanPhamBUS spBUS = new SanPhamBUS();

        public frmChiTietSanPham(int maSP)
        {
            InitializeComponent();
            _maSP = maSP;
        }

        private void frmChiTietSanPham_Load(object sender, EventArgs e)
        {
            HienThiThongTinSanPham();
        }

        private void HienThiThongTinSanPham()
        {
            SanPham sp = spBUS.LaySanPhamTheoMa(_maSP);
            if (sp != null)
            {
                lblTenSP.Text = sp.TenSanPham;
                lblGia.Text = sp.GiaBan.ToString("N0") + " VNĐ";
                lblMoTa.Text = sp.MoTa;
                lblSoLuong.Text = "Còn lại: " + sp.SoLuongTon.ToString();

                nudSoLuong.Maximum = sp.SoLuongTon;
                nudSoLuong.Value = sp.SoLuongTon > 0 ? 1 : 0;

                string imagePath = Path.Combine(Application.StartupPath, "Images", sp.HinhAnh);
                if (File.Exists(imagePath))
                    picSanPham.Image = Image.FromFile(imagePath);
                else
                    picSanPham.Image = Properties.Resources.nothing;
            }
        }


        private void btnMuaHang_Click(object sender, EventArgs e)
        {
            int soLuongMua = (int)nudSoLuong.Value;

            if (soLuongMua <= 0)
            {
                MessageBox.Show("Vui lòng chọn số lượng hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MessageBox.Show($"Mua {soLuongMua} sản phẩm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void nudSoLuong_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
