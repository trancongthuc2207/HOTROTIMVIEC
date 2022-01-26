using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HOTROTIMVIEC_08.DAO;

namespace HOTROTIMVIEC_08.BUS
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
    }
}
