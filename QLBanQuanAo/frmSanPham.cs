using QLBanQuanAo.BUS;
using QLBanQuanAo.DAL.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace QLBanQuanAo.UI
{
    public partial class frmSanPham : Form
    {
        private SanPhamBUS spBUS = new SanPhamBUS();
        private List<SanPham> danhSachSP;

        public frmSanPham()
        {
            InitializeComponent();
        }

        private void frmSanPham_Load(object sender, EventArgs e)
        {
            danhSachSP = spBUS.LayTatCaSanPham(); // ✅ Đúng tên hàm trong SanPhamBUS
            HienThiSanPham(danhSachSP);
        }


        private void HienThiSanPham(List<SanPham> listSP)
        {
            flowLayoutPanelSanPham.Controls.Clear();

            foreach (var sp in listSP)
            {
                Panel pnl = new Panel()
                {
                    Width = 180,
                    Height = 250,
                    Margin = new Padding(10),
                    BorderStyle = BorderStyle.FixedSingle
                };

                // Ảnh sản phẩm
                PictureBox pic = new PictureBox()
                {
                    Width = 160,
                    Height = 160,
                    SizeMode = PictureBoxSizeMode.Zoom,
                    Cursor = Cursors.Hand,
                    Tag = sp.MaSP
                };

                string imagePath = Path.Combine(Application.StartupPath, "Images", $"{sp.MaSP}.jpg");
                if (File.Exists(imagePath))
                    pic.Image = Image.FromFile(imagePath);
                else
                    pic.Image = Properties.Resources.nothing;

                pic.Click += Pic_Click;

                // Tên sản phẩm
                Label lblTen = new Label()
                {
                    Text = sp.TenSanPham,
                    AutoSize = false,
                    Width = 160,
                    Height = 30,
                    TextAlign = ContentAlignment.MiddleCenter,
                    Font = new Font("Segoe UI", 10, FontStyle.Bold)
                };

                // Giá
                Label lblGia = new Label()
                {
                    Text = sp.GiaBan.ToString("N0") + " VNĐ",
                    AutoSize = false,
                    Width = 160,
                    Height = 25,
                    TextAlign = ContentAlignment.MiddleCenter,
                    ForeColor = Color.DarkRed
                };

                pnl.Controls.Add(pic);
                pnl.Controls.Add(lblTen);
                pnl.Controls.Add(lblGia);

                lblTen.Top = pic.Bottom + 5;
                lblGia.Top = lblTen.Bottom;

                flowLayoutPanelSanPham.Controls.Add(pnl);
            }
        }

        private void Pic_Click(object sender, EventArgs e)
        {
            PictureBox pic = sender as PictureBox;
            int maSP = Convert.ToInt32(pic.Tag);

            frmChiTietSanPham frm = new frmChiTietSanPham(maSP);
            frm.ShowDialog();
        }

        private void btnTatCa_Click(object sender, EventArgs e)
        {
            HienThiSanPham(danhSachSP);
        }

        private void btnDoNam_Click(object sender, EventArgs e)
        {
            var spNam = danhSachSP.Where(x => x.GioiTinh == "Nam").ToList();
            HienThiSanPham(spNam);
        }

        private void btnDoNu_Click(object sender, EventArgs e)
        {
            var spNu = danhSachSP.Where(x => x.GioiTinh == "Nu").ToList();
            HienThiSanPham(spNu);
        }
    }
}
