using System;
using System.Data;
using System.Data.SqlClient;

namespace QLBanQuanAo.DAL
{
    public class HoaDonDAL
    {
        private string connectionString = @"Data Source=.;Initial Catalog=QLBanQuanAo;Integrated Security=True";

        public DataTable LayDanhSachHoaDon()
        {
            string query = "SELECT MaHD, MaKH, Ma, NgayLap, TongTien, TrangThai FROM HoaDon";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        public DataTable TimKiemHoaDon(string maHD, DateTime? ngayLap)
        {
            string query = "SELECT MaHD, MaKH, Ma, NgayLap, TongTien, TrangThai FROM HoaDon WHERE 1=1";

            if (!string.IsNullOrEmpty(maHD))
                query += " AND MaHD = @MaHD";

            if (ngayLap.HasValue)
                query += " AND CAST(NgayLap AS DATE) = @NgayLap";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                if (!string.IsNullOrEmpty(maHD))
                    cmd.Parameters.AddWithValue("@MaHD", maHD);
                if (ngayLap.HasValue)
                    cmd.Parameters.AddWithValue("@NgayLap", ngayLap.Value.Date);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }
    }
}
