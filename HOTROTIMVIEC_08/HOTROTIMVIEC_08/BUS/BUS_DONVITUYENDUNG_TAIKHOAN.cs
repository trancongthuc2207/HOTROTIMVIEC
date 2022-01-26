using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HOTROTIMVIEC_08.DAO;

namespace HOTROTIMVIEC_08.BUS
{
    class BUS_DONVITUYENDUNG_TAIKHOAN
    {
        DAO_DONVITUYENDUNG_TAIKHOAN dAO_DONVITUYENDUNG_TAIKHOAN;
        public BUS_DONVITUYENDUNG_TAIKHOAN()
        {
            dAO_DONVITUYENDUNG_TAIKHOAN = new DAO_DONVITUYENDUNG_TAIKHOAN();
        }
        public DONVITUYENDUNG_TAIKHOAN getTaiKhoanByTK_MK(string tk, string mk)
        {
            DONVITUYENDUNG_TAIKHOAN tk_dvtd = dAO_DONVITUYENDUNG_TAIKHOAN.getTaiKhoanByTK_MK(tk, mk);
            return tk_dvtd;
        }
    }
}
