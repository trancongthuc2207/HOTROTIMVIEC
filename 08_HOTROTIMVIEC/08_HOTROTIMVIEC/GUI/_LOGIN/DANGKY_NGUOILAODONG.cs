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

namespace _08_HOTROTIMVIEC.GUI._LOGIN
{
    public partial class DANGKY_NGUOILAODONG : Form
    {
        BUS_NGUOILAODONG bUS_NGUOILAODONG;
        public DANGKY_NGUOILAODONG()
        {
            InitializeComponent();
        }

        private void DANGKY_NGUOILAODONG_Load(object sender, EventArgs e)
        {

        }
        /////////////////////////INIT
        private void initGioiHan()
        {
            txtTen.MaxLength = 50;
            txtDiaChi.MaxLength = 50;
            txtBangCap.MaxLength = 50;
        }

        private void dtP_NgaySinh_ValueChanged(object sender, EventArgs e)
        {
            DateTime hople = DateTime.Now.AddYears(-17);
            if (DateTime.Now.Year - dtP_NgaySinh.Value.Year <= 16)
            {
                MessageBox.Show("Yêu cầu phải lớn hơn 16 tuổi!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dtP_NgaySinh.Value = hople;
            }
                
        }

        private void btnChonAnh_Click(object sender, EventArgs e)
        {

        }

        private void btnLuuAnh_Click(object sender, EventArgs e)
        {

        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            if(checkFullOP())
            {

            }    
        }

        private bool checkFullOP()
        {
            bool check = false;
            if (!string.IsNullOrEmpty(txtTen.Text) && !string.IsNullOrEmpty(txtCMND.Text) && !string.IsNullOrEmpty(cbbGioiTinh.Text) && !string.IsNullOrEmpty(txtDiaChi.Text) && (DateTime.Now.Year - dtP_NgaySinh.Value.Year <= 16) && !string.IsNullOrEmpty(txtSDT.Text) && !string.IsNullOrEmpty(txtTaiKhoan.Text) && !string.IsNullOrEmpty(txtMatKhau.Text) && !string.IsNullOrEmpty(txtNhapLai.Text))
                check = true;
            else
                check = false;
            return check;
        }
    }
}
