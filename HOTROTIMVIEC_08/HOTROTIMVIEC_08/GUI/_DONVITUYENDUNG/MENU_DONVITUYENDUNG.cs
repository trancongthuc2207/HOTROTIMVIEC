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

namespace HOTROTIMVIEC_08.GUI._DONVITUYENDUNG
{
    public partial class MENU_DONVITUYENDUNG : Form
    {
        BUS_DONVITUYENDUNG bUS_DONVITUYENDUNG;
        private DONVITUYENDUNG_TAIKHOAN dvtd_Cur_TK = LOGIN.dvtd_Cur_TK();
        private DONVITUYENDUNG dvtd_Cur;
        public MENU_DONVITUYENDUNG()
        {
            InitializeComponent();
        }

        private void MENU_DONVITUYENDUNG_Load(object sender, EventArgs e)
        {
            bUS_DONVITUYENDUNG = new BUS_DONVITUYENDUNG();
            dvtd_Cur = bUS_DONVITUYENDUNG.getDVTDFromTK(dvtd_Cur_TK);
            MessageBox.Show(dvtd_Cur.TenDV);
        }
    }
}
