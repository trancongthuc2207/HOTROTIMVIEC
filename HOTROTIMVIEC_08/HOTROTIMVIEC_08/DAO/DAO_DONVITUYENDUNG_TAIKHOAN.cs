using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HOTROTIMVIEC_08.DAO
{
    class DAO_DONVITUYENDUNG_TAIKHOAN
    {
        HTTVDataContext conn;
        public DAO_DONVITUYENDUNG_TAIKHOAN()
        {
            conn = new HTTVDataContext();
        }
        public DONVITUYENDUNG_TAIKHOAN getTaiKhoanByTK_MK(string tk, string mk)
        {
            DONVITUYENDUNG_TAIKHOAN tk_nld = conn.DONVITUYENDUNG_TAIKHOANs.FirstOrDefault(a => a.MaDV_TaiKhoan == tk && a.Matkhau == mk);
            return tk_nld;
        }
    }
}
