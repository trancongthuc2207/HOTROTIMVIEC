using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HOTROTIMVIEC_08.BUS;

namespace HOTROTIMVIEC_08.GUI._NGUOILAODONG
{
    public partial class UC_ThongTinNLD : UserControl
    {
        BUS_NGUOILAODONG_TAIKHOAN bUS_NGUOILAODONG_TAIKHOAN;
        BUS_NGUOILAODONG bUS_NGUOILAODONG;
        private NGUOILAODONG_TAIKHOAN nld_Cur_TK = MENU_NGUOILAODONG.nld_Cur_TK;
        private NGUOILAODONG nld;
        public UC_ThongTinNLD()
        {
            InitializeComponent();
        }
        private static UC_ThongTinNLD _instance;
        public static UC_ThongTinNLD Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UC_ThongTinNLD();
                return _instance;
            }
        }

        private void UC_ThongTinNLD_Load(object sender, EventArgs e)
        {
            bUS_NGUOILAODONG_TAIKHOAN = new BUS_NGUOILAODONG_TAIKHOAN();
            bUS_NGUOILAODONG = new BUS_NGUOILAODONG();
            nld = bUS_NGUOILAODONG.getNLDFromTK(nld_Cur_TK);
            //LOAD
            loadTT();
        }
        private void loadTT()
        {
            txtTen.Text = nld.Ten; 
        }

    }
}
