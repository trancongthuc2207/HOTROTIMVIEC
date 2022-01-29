using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _08_HOTROTIMVIEC.BUS;

namespace _08_HOTROTIMVIEC.GUI._NGUOILAODONG
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
            initDangXuat();
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
            {
                UC_TrangChu_NLD.Instance.BringToFront();
            }
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

        private void btnQuanLyDon_Click(object sender, EventArgs e)
        {
            if (!panel_main.Controls.Contains(UC_QuanLyDon_CaNhan.Instance))
            {
                panel_main.Controls.Add(UC_QuanLyDon_CaNhan.Instance);
                UC_QuanLyDon_CaNhan.Instance.Dock = DockStyle.Fill;
                UC_QuanLyDon_CaNhan.Instance.BringToFront();
            }
            else
                UC_QuanLyDon_CaNhan.Instance.BringToFront();
        }
        /////////////ĐĂNG XUẤT
        private void lblDangXuat_MouseMove(object sender, MouseEventArgs e)
        {
            lblDangXuat.Font = new Font("Microsoft Sans Serif", 12, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))));
            lblDangXuat.ForeColor = Color.Red;
        }

        private void initDangXuat()
        {
            lblDangXuat.Font = new Font("Microsoft Sans Serif", 10);
            lblDangXuat.ForeColor = Color.DarkBlue;
        }

        private void lblDangXuat_MouseLeave(object sender, EventArgs e)
        {
            initDangXuat();
        }

        private void lblDangXuat_Click(object sender, EventArgs e)
        {
            DialogResult dlr = MessageBox.Show("Bạn có chắc chắn muốn đăng xuất không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlr == DialogResult.Yes)
            {
                this.Hide();
                LOGIN lg = new LOGIN();
                lg.ShowDialog();
                this.Close();
            }
        }
    }
}
