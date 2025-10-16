using System;
using System.Data;
using System.Windows.Forms;
using QLBanQuanAo.BUS;

namespace QLBanQuanAo.UI
{
    public partial class frmHoaDon : Form
    {
        private HoaDonBUS hoaDonBUS = new HoaDonBUS();

        public frmHoaDon()
        {
            InitializeComponent();
        }

        private void frmHoaDon_Load(object sender, EventArgs e)
        {
            dgvHoaDon.DataSource = hoaDonBUS.LayDanhSachHoaDon();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string maHD = txtMaHD.Text.Trim();
            DateTime? ngayLap = dtpNgayLap.Checked ? dtpNgayLap.Value : (DateTime?)null;

            DataTable dt = hoaDonBUS.TimKiemHoaDon(maHD, ngayLap);
            dgvHoaDon.DataSource = dt;
        }

        private void btnTaiLai_Click(object sender, EventArgs e)
        {
            txtMaHD.Clear();
            dtpNgayLap.Checked = false;
            dgvHoaDon.DataSource = hoaDonBUS.LayDanhSachHoaDon();
        }

        private void lblNgayLap_Click(object sender, EventArgs e)
        {

        }
    }
}
