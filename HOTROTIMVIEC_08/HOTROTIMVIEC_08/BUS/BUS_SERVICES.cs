using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HOTROTIMVIEC_08.DAO;

namespace HOTROTIMVIEC_08.BUS
{
    class BUS_SERVICES
    {
        DAO_SERVICES dAO_SERVICES;
        public BUS_SERVICES()
        {
            dAO_SERVICES = new DAO_SERVICES();
        }
        public int? checkDN(string tk, string mk)
        {
            int? check = dAO_SERVICES.checkDN(tk, mk);
            return check;
        }

        
    }
}
