using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _08_HOTROTIMVIEC;

namespace _08_HOTROTIMVIEC.DAO
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
        //////////////////////THỨC
        public void Update_ThongTin_NLD(int maNLD,string ten, string gt, DateTime ngaysinh,string ddiem,string bangcap)
        {
            conn.SV_UpdateThongTin_NLD(maNLD,ten,gt,ngaysinh,ddiem,bangcap);
        }
        public int getMaNNLD_HT()
        {
            try
            {
                return conn.NGUOILAODONGs.Select(s => s.MaNLD).Max();
            }
            catch
            {
                int ma = 0;
                return ma;
            }
        }
        //////////////////////
    }
}
