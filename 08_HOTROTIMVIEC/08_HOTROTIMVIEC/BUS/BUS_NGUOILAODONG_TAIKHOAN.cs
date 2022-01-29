using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _08_HOTROTIMVIEC;
using _08_HOTROTIMVIEC.DAO;

namespace _08_HOTROTIMVIEC.BUS
{
    class BUS_NGUOILAODONG_TAIKHOAN
    {
        DAO_NGUOILAODONG_TAIKHOAN dAO_NGUOILAODONG_TAIKHOAN;
        public BUS_NGUOILAODONG_TAIKHOAN()
        {
            dAO_NGUOILAODONG_TAIKHOAN = new DAO_NGUOILAODONG_TAIKHOAN();
        }
        public NGUOILAODONG_TAIKHOAN getTaiKhoanByTK_MK(string tk, string mk)
        {
            NGUOILAODONG_TAIKHOAN tk_nld = dAO_NGUOILAODONG_TAIKHOAN.getTaiKhoanByTK_MK(tk,mk);
            return tk_nld;
        }
        ///////////////////THỨC
        public void UpdateMatKhauMoi_NLD(int maNLD, string mkm)
        {
            dAO_NGUOILAODONG_TAIKHOAN.UpdateMatKhauMoi_NLD(maNLD, mkm);
        }
        public NGUOILAODONG_TAIKHOAN getTaiKhoanByMaNLD(int maNLD)
        {
            return dAO_NGUOILAODONG_TAIKHOAN.getTaiKhoanByMaNLD(maNLD);
        }
        ///////////////////
    }
}
