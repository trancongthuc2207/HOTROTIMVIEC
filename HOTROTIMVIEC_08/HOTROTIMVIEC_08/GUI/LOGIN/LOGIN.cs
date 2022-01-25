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
using HOTROTIMVIEC_08.GUI;
using HOTROTIMVIEC_08.GUI.ADMINISTRATION;
using HOTROTIMVIEC_08.GUI.DONVITUYENDUNG;
using HOTROTIMVIEC_08.GUI.NGUOILAODONG;

namespace HOTROTIMVIEC_08
{
    public partial class LOGIN : Form
    {
        BUS_SERVICES bUS_SERVICES;
        public LOGIN()
        {
            InitializeComponent();
        }
        private void LOGIN_Load(object sender, EventArgs e)
        {
            txtMK.MaxLength = 25;
            txtTK.MaxLength = 25;
            bUS_SERVICES = new BUS_SERVICES();
        }

        private void btnDK_Click(object sender, EventArgs e)
        {
            this.Hide();
            SELECT_DANGKY sl = new SELECT_DANGKY();
            sl.ShowDialog();
            this.Close();
        }

        private void check_XemMK_CheckedChanged(object sender, EventArgs e)
        {
            if (check_XemMK.Checked)
            {
                txtMK.UseSystemPasswordChar = false;
            }
            else
                if (!check_XemMK.Checked)
            {
                txtMK.UseSystemPasswordChar = true;
            }
        }
        ////////////////////////////NÚT ĐĂNG NHẬP
        private void btnDN_Click(object sender, EventArgs e)
        {
            int? check = bUS_SERVICES.checkDN(txtTK.Text, txtMK.Text);
            if (cbbKindAccount.SelectedIndex == 0)
            {
                if (check == 1)
                {
                    this.Hide();
                    MessageBox.Show("Chào mừng bạn đăng nhập với tư cách là: ĐƠN VỊ TUYỂN DỤNG!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MENU_DONVITUYENDUNG dvtd = new MENU_DONVITUYENDUNG();
                    dvtd.ShowDialog();
                    this.Close();
                }
                else
                    MessageBox.Show("Sai tài khoản hoặc mật khẩu!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (cbbKindAccount.SelectedIndex == 1)
            {
                if (check == 2)
                {
                    this.Hide();
                    MessageBox.Show("Chào mừng bạn đăng nhập với tư cách là: NGƯỜI LAO ĐỘNG!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MENU_NGUOILAODONG nld = new MENU_NGUOILAODONG();
                    nld.ShowDialog();
                    this.Close();
                }
                else
                    MessageBox.Show("Sai tài khoản hoặc mật khẩu!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (cbbKindAccount.SelectedIndex == 2)
            {
                if (check == 3)
                {
                    this.Hide();
                    MessageBox.Show("Chào mừng bạn đăng nhập với tư cách là: ADMINISTRATION!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MENU_ADMINISTRATION admin = new MENU_ADMINISTRATION();
                    admin.ShowDialog();
                    this.Close();
                }
                else
                    MessageBox.Show("Sai tài khoản hoặc mật khẩu!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (cbbKindAccount.SelectedIndex == -1)
                MessageBox.Show("Mời bạn chọn quyền!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }
        
    }
}
