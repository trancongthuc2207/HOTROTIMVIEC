using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _08_HOTROTIMVIEC;

namespace _08_HOTROTIMVIEC.DAO
{
    class DAO_DON_TUYENDUNG
    {
        HTTVDataContext conn;
        public DAO_DON_TUYENDUNG()
        {
            conn = new HTTVDataContext();
        }

        public int? SV_addDON_TUYENDUNG(int maNLD, int Id, DateTime ngayDK)
        {
            int? check = 0;
            conn.SV_addDON_TUYENDUNG(maNLD, Id, ngayDK.Date, ref check);
            return check;
        }
        /////////////////THỨC
        public DON_TUYENDUNG getDon_TuyenDung_ByMaNLD_Id(int maNLD, int id)
        {
            DON_TUYENDUNG don = (from s in conn.DON_TUYENDUNGs where s.MaNLD == maNLD && s.Id == id select s).First();
            return don;
        }
        public void DeleteDon_TuyenDung_ByMaNLD_Id(int maNLD, int id)
        {
            conn.SV_Delete_Don_TuyenDung(maNLD,id);
        }
        ///////////////////
    }
}
