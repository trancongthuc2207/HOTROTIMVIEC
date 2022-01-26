using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HOTROTIMVIEC_08.DAO
{
    class DAO_DONVITUYENDUNG
    {
        HTTVDataContext conn;
        public DAO_DONVITUYENDUNG()
        {
            conn = new HTTVDataContext();
        }
        public DONVITUYENDUNG getDVTDFromTK(DONVITUYENDUNG_TAIKHOAN acc)
        {
            DONVITUYENDUNG dvtd = conn.DONVITUYENDUNGs.FirstOrDefault(s => s.MaDV == acc.MaDV_TaiKhoan);
            return dvtd;
        }
    }
}
