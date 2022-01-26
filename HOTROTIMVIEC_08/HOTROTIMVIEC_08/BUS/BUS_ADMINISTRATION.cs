using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HOTROTIMVIEC_08.DAO;

namespace HOTROTIMVIEC_08.BUS
{
    class BUS_ADMINISTRATION
    {
        DAO_ADMINISTRATION dAO_ADMINISTRATION;
        public BUS_ADMINISTRATION()
        {
            dAO_ADMINISTRATION = new DAO_ADMINISTRATION();
        }
        public ADMINISTRATION getAdminFromTK_MK(string tk, string mk)
        {
            return dAO_ADMINISTRATION.getAdminFromTK_MK(tk,mk);
        }
    }
}
