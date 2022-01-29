using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _08_HOTROTIMVIEC;
using _08_HOTROTIMVIEC.DAO;

namespace _08_HOTROTIMVIEC.BUS
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
        ///////////////////THỨC
        public void Update_ThongTin_NLD(int maNLD, string ten, string gt, DateTime ngaysinh, string ddiem, string bangcap)
        {
            dAO_NGUOILAODONG.Update_ThongTin_NLD(maNLD, ten, gt, ngaysinh, ddiem, bangcap);
        }
        public int getMaNNLD_HT()
        {
            return dAO_NGUOILAODONG.getMaNNLD_HT();
        }
        ////////////////////
    }
}
