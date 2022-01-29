using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _08_HOTROTIMVIEC;
using _08_HOTROTIMVIEC.DAO;

namespace _08_HOTROTIMVIEC.BUS
{
    class BUS_DONVITUYENDUNG_VIECLAM
    {
        DAO_DONVITUYENDUNG_VIECLAM dAO_DONVITUYENDUNG_VIECLAM;
        public BUS_DONVITUYENDUNG_VIECLAM()
        {
            dAO_DONVITUYENDUNG_VIECLAM = new DAO_DONVITUYENDUNG_VIECLAM();
        }
        //////////////////////////THỨC
        public DONVITUYENDUNG_VIECLAM GetDVTD_VL_By_DV_VL(DONVITUYENDUNG dv, VIECLAM vl)
        {
            return dAO_DONVITUYENDUNG_VIECLAM.GetDVTD_VL_By_DV_VL(dv, vl);
        }
        //////////////////////////

    }
}
