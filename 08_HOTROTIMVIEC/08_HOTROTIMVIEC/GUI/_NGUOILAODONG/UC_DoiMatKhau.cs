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
            char[] rs = nld_Cur_TK.Taikhoan.ToCharArray();
            string taikhoan = "";
            for (int i = 0; i < rs.Length; i++)
            {
                if (i >= (rs.Length / 2))
                    taikhoan += "*";
                else
                    taikhoan += rs[i];
            }
            txtTaikhoan.Text = taikhoan;
        }

        public bool KiemTra()
        {
            bUS_NGUOILAODONG_TAIKHOAN = new BUS_NGUOILAODONG_TAIKHOAN();
            NGUOILAODONG_TAIKHOAN tk = bUS_NGUOILAODONG_TAIKHOAN.getTaiKhoanByMaNLD(nld.MaNLD);
            if (txtMKC.Text == "")
            {
                lblShowInfor.Show();
                lblShowInfor.ForeColor = Color.Red;
                lblShowInfor.Text = "Vui lòng nhập mật khẩu hiện tại !!";
                txtMKC.Focus();
                return false;
            }
            else if (txtMKM1.Text == "")
            {
                lblShowInfor.Show();
                lblShowInfor.ForeColor = Color.Red;
                lblShowInfor.Text = "Vui lòng nhập mật khẩu mới !!";
                txtMKM1.Focus();
                return false;
            }
            else if (txtMKM2.Text == "")
            {
                lblShowInfor.Show();
                lblShowInfor.ForeColor = Color.Red;
                lblShowInfor.Text = "Vui lòng xác nhận mật khẩu !!";
                txtMKM2.Focus();
                return false;
            }
            else if (txtMKM1.Text != txtMKM2.Text)
            {
                lblShowInfor.Show();
                lblShowInfor.ForeColor = Color.Red;
                lblShowInfor.Text = "Mật khẩu mới và mật khẩu xác nhận không trùng khớp";
                txtMKM2.Focus();
                txtMKM2.SelectAll();
                return false;
            }
            else if (txtMKC.Text != tk.Matkhau)
            {
                lblShowInfor.Show();
                lblShowInfor.ForeColor = Color.Red;
                lblShowInfor.Text = "Mật khẩu cũ sai !!";
                txtMKC.Focus();
                return false;
            }
            else if (txtMKM1.Text == tk.Matkhau)
            {
                lblShowInfor.Show();
                lblShowInfor.ForeColor = Color.Red;
                lblShowInfor.Text = "Mật khẩu mới phải khác mật khẩu cũ !!";
                txtMKC.Focus();
                return false;
            }
            return true;
        }
        private void ckbMK_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbMK.Checked)
            {
                txtMKC.UseSystemPasswordChar = false;
                txtMKM1.UseSystemPasswordChar = false;
                txtMKM2.UseSystemPasswordChar = false;
            }
            else
            {
                txtMKC.UseSystemPasswordChar = true;
                txtMKM1.UseSystemPasswordChar = true;
                txtMKM2.UseSystemPasswordChar = true;
            }
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (KiemTra())
            {
                DialogResult dlr = MessageBox.Show("Bạn có chắc chắn muốn thay đổi mật khẩu mới không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dlr == DialogResult.Yes)
                {
                    bUS_NGUOILAODONG_TAIKHOAN.UpdateMatKhauMoi_NLD(nld.MaNLD, txtMKM2.Text);
                    MessageBox.Show("Đổi mật khẩu thành công");
                    initTextbox();
                    lblShowInfor.Hide();
                }
            }
        }
        private void initTextbox()
        {
            txtMKC.Text = "";
            txtMKM1.Text = "";
            txtMKM2.Text = "";
        }
    }
}
