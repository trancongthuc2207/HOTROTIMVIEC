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

namespace _08_HOTROTIMVIEC.GUI._ADMINISTRATION
{
    public partial class MENU_ADMINISTRATION : Form
    {
        BUS_ADMINISTRATION bUS_ADMINISTRATION;
        private ADMINISTRATION admin_Cur = LOGIN.admin_Cur_TK();
        public MENU_ADMINISTRATION()
        {
            InitializeComponent();
        }
        private void MENU_ADMINISTRATION_Load(object sender, EventArgs e)
        {
            bUS_ADMINISTRATION = new BUS_ADMINISTRATION();
        }
    }
}
