using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _08_HOTROTIMVIEC;
using _08_HOTROTIMVIEC.DAO;

namespace _08_HOTROTIMVIEC.BUS
{
    class BUS_VIECLAM
    {
        DAO_VIECLAM dAO_VIECLAM;
        public BUS_VIECLAM()
        {
            dAO_VIECLAM = new DAO_VIECLAM();
        }
        /////////////////////////////////////THỨC
        public dynamic getListFromTenViec(string tenViec)
        {
            return dAO_VIECLAM.getListFromTenViec(tenViec);
        }

        public dynamic getListFromMucLuong(string mucluong)
        {
            return dAO_VIECLAM.getListFromMucLuong(mucluong);
        }
        public dynamic getViecLam()
        {
            return dAO_VIECLAM.getViecLam();
        }
        public VIECLAM GetVIECLAMByMaViec(int maViec)
        {
            return dAO_VIECLAM.GetVIECLAMByMaViec(maViec);
        }
        public VIECLAM GetVIECLAMByTenViec(string tenViec)
        {
            return dAO_VIECLAM.GetVIECLAMByTenViec(tenViec);
        }
        /////////////////////////////////////
    }
}
