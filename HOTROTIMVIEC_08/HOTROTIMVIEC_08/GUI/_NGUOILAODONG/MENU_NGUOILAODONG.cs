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
    public partial class MENU_NGUOILAODONG : Form
    {
        public static NGUOILAODONG_TAIKHOAN nld_Cur_TK = LOGIN.nld_Cur_TK();
        BUS_NGUOILAODONG bUS_NGUOILAODONG;
        // private NGUOILAODONG nld = bUS_NGUOILAODONG.getNLDFromTK(nld_Cur_TK);
        public MENU_NGUOILAODONG()
        {
            InitializeComponent();
        }

        private void MENU_NGUOILAODONG_Load(object sender, EventArgs e)
        {
            //BUS NEW
            bUS_NGUOILAODONG = new BUS_NGUOILAODONG();

            //KHOI TAO TRANG CHU
            this.btnTrangChu_Click(sender, e);
        }

        private void btnTrangChu_Click(object sender, EventArgs e)
        {
            if (!panel_main.Controls.Contains(UC_TrangChu_NLD.Instance))
            {
                panel_main.Controls.Add(UC_TrangChu_NLD.Instance);
                UC_TrangChu_NLD.Instance.Dock = DockStyle.Fill;
                UC_TrangChu_NLD.Instance.BringToFront();
            }
            else
                UC_TrangChu_NLD.Instance.BringToFront();
        }

        private void btnThongTin_Click(object sender, EventArgs e)
        {
            if (!panel_main.Controls.Contains(UC_ThongTinNLD.Instance))
            {
                panel_main.Controls.Add(UC_ThongTinNLD.Instance);
                UC_ThongTinNLD.Instance.Dock = DockStyle.Fill;
                UC_ThongTinNLD.Instance.BringToFront();
            }
            else
                UC_ThongTinNLD.Instance.BringToFront();
        }

        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {
            if (!panel_main.Controls.Contains(UC_DoiMatKhau.Instance))
            {
                panel_main.Controls.Add(UC_DoiMatKhau.Instance);
                UC_DoiMatKhau.Instance.Dock = DockStyle.Fill;
                UC_DoiMatKhau.Instance.BringToFront();
            }
            else
                UC_DoiMatKhau.Instance.BringToFront();
        }
    }
}
