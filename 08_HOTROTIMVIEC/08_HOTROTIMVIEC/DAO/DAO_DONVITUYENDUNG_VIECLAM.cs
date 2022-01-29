using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _08_HOTROTIMVIEC;

namespace _08_HOTROTIMVIEC.DAO
{
    class DAO_DONVITUYENDUNG_VIECLAM
    {
        HTTVDataContext conn;
        public DAO_DONVITUYENDUNG_VIECLAM()
        {
            conn = new HTTVDataContext();
        }

        ////////////////////////////THỨC
        public DONVITUYENDUNG_VIECLAM GetDVTD_VL_By_DV_VL(DONVITUYENDUNG dv, VIECLAM vl)
        {
            DONVITUYENDUNG_VIECLAM dv_vl = (from s in conn.DONVITUYENDUNG_VIECLAMs where s.MaDV.Equals(dv.MaDV) && s.MaViec == vl.MaViec select s).First();
            return dv_vl;
        }



        ////////////////////////////
    }
}
