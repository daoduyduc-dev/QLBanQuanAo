using System.Data.SqlClient;

namespace QLBanQuanAo.DAL
{
    public class AccountDAL
    {
        // CHÚ Ý: Đảm bảo chuỗi kết nối này chính xác
        private string connectionString = @"Data Source=LAPTOP-QIN4VHKE\SQLEXPRESS;Initial Catalog=QLBanQuanAo;Integrated Security=True";

        // Phương thức kiểm tra ĐĂNG NHẬP
        public bool CheckLogin(string username, string password)
        {
            string query = "SELECT COUNT(1) FROM Account WHERE TenDangNhap = @user AND MatKhau = @pass";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@user", username);
                    cmd.Parameters.AddWithValue("@pass", password); // CẢNH BÁO: Mật khẩu nên được mã hóa (hashing)

                    conn.Open();
                    int count = (int)cmd.ExecuteScalar();
                    return count > 0;
                }
            }
        }

        // Phương thức ĐĂNG KÝ (Đã có sẵn từ code bạn cung cấp)
        public bool Register(string username, string password, string fullname)
        {
            // ... (Nội dung Đăng ký của bạn)
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string checkQuery = "SELECT COUNT(*) FROM Account WHERE TenDangNhap = @TenDangNhap";
                SqlCommand checkCmd = new SqlCommand(checkQuery, conn);
                checkCmd.Parameters.AddWithValue("@TenDangNhap", username);

                int count = (int)checkCmd.ExecuteScalar();
                if (count > 0)
                    return false;

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