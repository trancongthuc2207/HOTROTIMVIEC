using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HOTROTIMVIEC_08.DAO
{
    class DAO_SERVICES
    {
        HTTVDataContext conn;
        public DAO_SERVICES()
        {
            conn = new HTTVDataContext();
        }
        public int? checkDN(string tk, string mk)
        {
            int? check = 0;
            conn.SV_CheckDN(tk, mk, ref check);
            return check;
        }
        
    }
}
