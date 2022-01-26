using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HOTROTIMVIEC_08.DAO
{
    class DAO_NGUOILAODONG
    {
        HTTVDataContext conn;
        public DAO_NGUOILAODONG()
        {
            conn = new HTTVDataContext();
        }
        public NGUOILAODONG getNLDFromTK(NGUOILAODONG_TAIKHOAN acc)
        {
            NGUOILAODONG nld = conn.NGUOILAODONGs.FirstOrDefault(s => s.MaNLD == acc.MaNLD);
            return nld;
        }
    }
}
