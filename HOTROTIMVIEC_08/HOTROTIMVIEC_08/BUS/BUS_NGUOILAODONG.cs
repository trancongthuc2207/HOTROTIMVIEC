using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HOTROTIMVIEC_08.DAO;

namespace HOTROTIMVIEC_08.BUS
{
    class BUS_NGUOILAODONG
    {
        DAO_NGUOILAODONG dAO_NGUOILAODONG;
        public BUS_NGUOILAODONG()
        {
            dAO_NGUOILAODONG = new DAO_NGUOILAODONG();
        }
        public NGUOILAODONG getNLDFromTK(NGUOILAODONG_TAIKHOAN acc)
        {
            return dAO_NGUOILAODONG.getNLDFromTK(acc);
        }
    }
}
