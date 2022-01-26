using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HOTROTIMVIEC_08.DAO;

namespace HOTROTIMVIEC_08.BUS
{
    class BUS_DONVITUYENDUNG
    {
        DAO_DONVITUYENDUNG dAO_DONVITUYENDUNG;
        public BUS_DONVITUYENDUNG()
        {
            dAO_DONVITUYENDUNG = new DAO_DONVITUYENDUNG();
        }
        public DONVITUYENDUNG getDVTDFromTK(DONVITUYENDUNG_TAIKHOAN acc)
        {
            return dAO_DONVITUYENDUNG.getDVTDFromTK(acc);
        }
    }
}
