using QLBanQuanAo.DAL.Models;
using System.Linq;

namespace QLBanQuanAo.DAL
{
    public class SanPhamDAL
    {
        private ModelQLBanQuanAoDB db = new ModelQLBanQuanAoDB();

        public SanPham GetSanPhamById(int maSP)
        {
            return db.SanPham.FirstOrDefault(sp => sp.MaSP == maSP);
        }
    }
}
