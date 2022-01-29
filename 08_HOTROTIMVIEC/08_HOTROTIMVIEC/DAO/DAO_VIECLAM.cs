using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _08_HOTROTIMVIEC;

namespace _08_HOTROTIMVIEC.DAO
{
    class DAO_VIECLAM
    {
        HTTVDataContext conn;
        public DAO_VIECLAM()
        {
            conn = new HTTVDataContext();
        }

        ////////////////////////////THỨC
        public dynamic getListFromTenViec(string tenViec)
        {
            var ds = conn.SV_Timkiem_TenViec(tenViec).Select(s => new {
                s.MaViec,
                s.TenViec,
                s.MoTa,
                s.MucLuong
            }).ToList();
            return ds;
        }
        public dynamic getListFromMucLuong(string mucluong)
        {
            try
            {
                var ds = conn.SV_Timkiem_MucLuong(decimal.Parse(mucluong)).Select(s => new {
                    s.MaViec,
                    s.TenViec,
                    s.MoTa,
                    s.MucLuong
                }).ToList();
                return ds;
            }
            catch
            {
                return getViecLam();
            }
            
        }
        public dynamic getViecLam()
        {
            var ds = conn.VIECLAMs.Select(s => new {
                s.MaViec,
                s.TenViec,
                s.MoTa,
                s.MucLuong
            }).ToList();
            return ds;
        }

        public VIECLAM GetVIECLAMByMaViec(int maViec)
        {
            VIECLAM vl = (from s in conn.VIECLAMs where s.MaViec == maViec select s).First();
            return vl;
        }
        public VIECLAM GetVIECLAMByTenViec(string tenViec)
        {
            VIECLAM vl = (from s in conn.VIECLAMs where s.TenViec.Equals(tenViec) select s).First();
            return vl;
        }



        ////////////////////////////
    }
}
