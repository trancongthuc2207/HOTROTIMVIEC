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
    public partial class UC_DoiMatKhau : UserControl
    {
        BUS_NGUOILAODONG_TAIKHOAN bUS_NGUOILAODONG_TAIKHOAN;
        BUS_NGUOILAODONG bUS_NGUOILAODONG;
        private NGUOILAODONG_TAIKHOAN nld_Cur_TK = MENU_NGUOILAODONG.nld_Cur_TK;
        private NGUOILAODONG nld;
        
        public UC_DoiMatKhau()
        {
            InitializeComponent();
        }

        private static UC_DoiMatKhau _instance;
        public static UC_DoiMatKhau Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UC_DoiMatKhau();
                return _instance;
            }
        }

        private void UC_DoiMatKhau_Load(object sender, EventArgs e)
        {
            bUS_NGUOILAODONG_TAIKHOAN = new BUS_NGUOILAODONG_TAIKHOAN();
            bUS_NGUOILAODONG = new BUS_NGUOILAODONG();
            nld = bUS_NGUOILAODONG.getNLDFromTK(nld_Cur_TK);
            //LOAD TAI KHOAN
            loadTaiKhoan();
        }
        private void loadTaiKhoan()
        {
            txtTaikhoan.Text = nld_Cur_TK.Taikhoan;
        }
    }
}
