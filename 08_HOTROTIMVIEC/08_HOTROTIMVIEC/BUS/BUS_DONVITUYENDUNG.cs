using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _08_HOTROTIMVIEC;
using _08_HOTROTIMVIEC.DAO;

namespace _08_HOTROTIMVIEC.BUS
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
        ///////////////////////////THỨC
        public DONVITUYENDUNG GetDVTDByMaDV(string maDV)
        {
            return dAO_DONVITUYENDUNG.GetDVTDByMaDV(maDV);
        }
        ///////////////////////////
    }
}
