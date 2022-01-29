using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _08_HOTROTIMVIEC;
using _08_HOTROTIMVIEC.DAO;

namespace _08_HOTROTIMVIEC.BUS
{
    class BUS_DON_TUYENDUNG
    {
        DAO_DON_TUYENDUNG dAO_DON_TUYENDUNG;
        public BUS_DON_TUYENDUNG()
        {
            dAO_DON_TUYENDUNG = new DAO_DON_TUYENDUNG();
        }
        public int? SV_addDON_TUYENDUNG(int maNLD, int Id, DateTime ngayDK)
        {
            return dAO_DON_TUYENDUNG.SV_addDON_TUYENDUNG(maNLD, Id, ngayDK);
        }
        ////////////////THỨC
        public DON_TUYENDUNG getDon_TuyenDung_ByMaNLD_Id(int maNLD, int id)
        {
            return dAO_DON_TUYENDUNG.getDon_TuyenDung_ByMaNLD_Id(maNLD, id);
        }
        public void DeleteDon_TuyenDung_ByMaNLD_Id(int maNLD, int id)
        {
            dAO_DON_TUYENDUNG.DeleteDon_TuyenDung_ByMaNLD_Id(maNLD, id);
        }
        ////////////////////
    }
}
