using System;
using System.Data;
using QLBanQuanAo.DAL;

namespace QLBanQuanAo.BUS
{
    public class HoaDonBUS
    {
        private HoaDonDAL hoaDonDAL = new HoaDonDAL();

        public DataTable LayDanhSachHoaDon()
        {
            return hoaDonDAL.LayDanhSachHoaDon();
        }

        public DataTable TimKiemHoaDon(string maHD, DateTime? ngayLap)
        {
            return hoaDonDAL.TimKiemHoaDon(maHD, ngayLap);
        }
    }
}
