using QLBanQuanAo.DAL;

namespace QLBanQuanAo.BUS
{
    public class AccountBUS
    {
        private AccountDAL accountDAL = new AccountDAL();

        // Phương thức XÁC THỰC NGƯỜI DÙNG (Cho chức năng Đăng nhập)
        public bool AuthenticateUser(string username, string password)
        {
            // Kiểm tra tính hợp lệ cơ bản của dữ liệu
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                return false;
            }

            // Gọi DAL để kiểm tra trong Database
            return accountDAL.CheckLogin(username, password);
        }

        // Phương thức ĐĂNG KÝ (Đã có sẵn từ code bạn cung cấp)
        public string RegisterAccount(string username, string password, string confirmPassword, string fullname)
        {
            if (string.IsNullOrWhiteSpace(username) ||
                string.IsNullOrWhiteSpace(password) ||
                string.IsNullOrWhiteSpace(confirmPassword) ||
                string.IsNullOrWhiteSpace(fullname))
            {
                return "Vui lòng nhập đầy đủ thông tin!";
            }

            if (password != confirmPassword)
            {
                return "Mật khẩu xác nhận không khớp!";
            }

            bool result = accountDAL.Register(username, password, fullname);
            if (!result)
                return "Tên đăng nhập đã tồn tại!";

            return "Đăng ký thành công!";
        }
    }
}