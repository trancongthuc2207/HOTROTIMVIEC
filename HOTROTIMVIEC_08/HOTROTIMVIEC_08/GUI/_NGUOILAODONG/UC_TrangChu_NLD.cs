using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HOTROTIMVIEC_08.GUI._NGUOILAODONG
{
    public partial class UC_TrangChu_NLD : UserControl
    {
        public UC_TrangChu_NLD()
        {
            InitializeComponent();
        }
        private static UC_TrangChu_NLD _instance;
        public static UC_TrangChu_NLD Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UC_TrangChu_NLD();
                return _instance;
            }
        }

        private void UC_TrangChu_NLD_Load(object sender, EventArgs e)
        {

        }
    }
}
