using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _08_HOTROTIMVIEC;

namespace _08_HOTROTIMVIEC.DAO
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
        ////////////////////////////THỨC
        public DONVITUYENDUNG GetDVTDByMaDV(string maDV)
        {
            DONVITUYENDUNG dv = (from s in conn.DONVITUYENDUNGs where s.MaDV.Equals(maDV) select s).First();
            return dv;
        }

        ////////////////////////////
    }
}
