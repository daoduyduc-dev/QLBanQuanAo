using System;
using System.Data.SqlClient;

namespace QLBanQuanAo.DAL
{
    public class AccountDAL
    {
        private string connectionString = @"Data Source=LAPTOP-J1Q2HGTO\SQLEXPRESS;Initial Catalog=QLBanQuanAo;Integrated Security=True";

        public bool Register(string username, string password, string fullname)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                // Kiểm tra trùng tên đăng nhập
                string checkQuery = "SELECT COUNT(*) FROM Account WHERE TenDangNhap = @TenDangNhap";
                SqlCommand checkCmd = new SqlCommand(checkQuery, conn);
                checkCmd.Parameters.AddWithValue("@TenDangNhap", username);

                int count = (int)checkCmd.ExecuteScalar();
                if (count > 0)
                    return false; // trùng username

                // Thêm tài khoản mới
                string insertQuery = "INSERT INTO Account (TenDangNhap, MatKhau, HoTen) VALUES (@TenDangNhap, @MatKhau, @HoTen)";
                SqlCommand cmd = new SqlCommand(insertQuery, conn);
                cmd.Parameters.AddWithValue("@TenDangNhap", username);
                cmd.Parameters.AddWithValue("@MatKhau", password);
                cmd.Parameters.AddWithValue("@HoTen", fullname);

                int rows = cmd.ExecuteNonQuery();
                return rows > 0;
            }
        }
    }
}
