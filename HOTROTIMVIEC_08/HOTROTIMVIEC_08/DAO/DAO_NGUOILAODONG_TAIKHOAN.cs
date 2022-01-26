using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HOTROTIMVIEC_08.DAO
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
    }
}
