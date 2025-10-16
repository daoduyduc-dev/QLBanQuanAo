using QLBanQuanAo.DAL;
using QLBanQuanAo.DAL.Models;

namespace QLBanQuanAo.BUS
{
    public class SanPhamBUS
    {
        private SanPhamDAL spDAL = new SanPhamDAL();

        public SanPham LaySanPhamTheoMa(int maSP)
        {
            return spDAL.GetSanPhamById(maSP);
        }
    }
}
