using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _08_HOTROTIMVIEC;

namespace _08_HOTROTIMVIEC.DAO
{
    class DAO_NGUOILAODONG_TAIKHOAN
    {
        HTTVDataContext conn;
        public DAO_NGUOILAODONG_TAIKHOAN()
        {
            conn = new HTTVDataContext();
        }
        public NGUOILAODONG_TAIKHOAN getTaiKhoanByTK_MK(string tk, string mk)
        {
            NGUOILAODONG_TAIKHOAN tk_nld = conn.NGUOILAODONG_TAIKHOANs.FirstOrDefault(a => a.Taikhoan == tk && a.Matkhau == mk);
            return tk_nld;
        }
        ///////////////THỨC
        public void UpdateMatKhauMoi_NLD(int maNLD, string mkm)
        {
            conn.SV_UpdateMatKhauMoi_NLD(maNLD, mkm);
        }
        public NGUOILAODONG_TAIKHOAN getTaiKhoanByMaNLD(int maNLD)
        {
            NGUOILAODONG_TAIKHOAN tk_nld = conn.NGUOILAODONG_TAIKHOANs.FirstOrDefault(a => a.MaNLD == maNLD);
            return tk_nld;
        }
        ///////////////////
    }
}
