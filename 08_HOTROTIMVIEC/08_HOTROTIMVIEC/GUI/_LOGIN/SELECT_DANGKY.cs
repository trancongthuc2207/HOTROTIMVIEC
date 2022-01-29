using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _08_HOTROTIMVIEC.GUI._LOGIN
{
    public partial class SELECT_DANGKY : Form
    {
        public SELECT_DANGKY()
        {
            InitializeComponent();
        }
        private void SELECT_DANGKY_Load(object sender, EventArgs e)
        {
            //Dangxuat
            initDangXuat();
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
            DialogResult dlr = MessageBox.Show("Bạn có muốn thoát khỏi đăng kí không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlr == DialogResult.Yes)
            {
                this.Hide();
                LOGIN lg = new LOGIN();
                lg.ShowDialog();
                this.Close();
            }
        }

        private void btnDK_NLD_Click(object sender, EventArgs e)
        {
            this.Hide();
            DANGKY_NGUOILAODONG dk_nld = new DANGKY_NGUOILAODONG();
            dk_nld.ShowDialog();
            this.Close();
        }
    }
}
