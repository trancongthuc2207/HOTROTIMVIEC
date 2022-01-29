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
    public partial class UC_QuanLyDon_CaNhan : UserControl
    {
        BUS_NGUOILAODONG_TAIKHOAN bUS_NGUOILAODONG_TAIKHOAN;
        BUS_NGUOILAODONG bUS_NGUOILAODONG;
        BUS_VIECLAM bUS_VIECLAM;
        BUS_SERVICES bUS_SERVICES;
        BUS_DONVITUYENDUNG bUS_DONVITUYENDUNG;
        BUS_DONVITUYENDUNG_VIECLAM bUS_DONVITUYENDUNG_VIECLAM;
        BUS_DON_TUYENDUNG bUS_DON_TUYENDUNG;
        private NGUOILAODONG_TAIKHOAN nld_Cur_TK = MENU_NGUOILAODONG.nld_Cur_TK;
        private NGUOILAODONG nld;
        //////////////Khoi tao
        private int kind = 0;
        private int trangthai = 1;
        ////////////
        private string cellMaDV_stamp = "";
        private int maViec_stamp = 0;
        //////////////CHECK CLICK
        private bool checkDon_Click = false;
        public UC_QuanLyDon_CaNhan()
        {
            InitializeComponent();
        }
        private static UC_QuanLyDon_CaNhan _instance;
        public static UC_QuanLyDon_CaNhan Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UC_QuanLyDon_CaNhan();
                return _instance;
            }
        }

        private void UC_QuanLyDon_CaNhan_Load(object sender, EventArgs e)
        {
            bUS_NGUOILAODONG_TAIKHOAN = new BUS_NGUOILAODONG_TAIKHOAN();
            bUS_NGUOILAODONG = new BUS_NGUOILAODONG();
            bUS_VIECLAM = new BUS_VIECLAM();
            bUS_SERVICES = new BUS_SERVICES();
            bUS_DONVITUYENDUNG = new BUS_DONVITUYENDUNG();
            bUS_DONVITUYENDUNG_VIECLAM = new BUS_DONVITUYENDUNG_VIECLAM();
            bUS_DON_TUYENDUNG = new BUS_DON_TUYENDUNG();
            nld = bUS_NGUOILAODONG.getNLDFromTK(nld_Cur_TK);
            ////////////////////init
            cbbKind.SelectedIndex = 0;
            cbbTrangThai.SelectedIndex = 1;
            ///LOAD
            loadDonTD();
        }

        ////////////////CHỌN KIND AND TRANGTHAI
        private void cbbKind_SelectedIndexChanged(object sender, EventArgs e)
        {
            kind = cbbKind.SelectedIndex;
            gridV_DonTD.DataSource = bUS_SERVICES.LocDon_TD_TheoNgay_ByMaNLDandTenViec(nld.MaNLD, txtTimKiem.Text, kind, trangthai);
        }

        private void cbbTrangThai_SelectedIndexChanged(object sender, EventArgs e)
        {
            trangthai = cbbTrangThai.SelectedIndex;
            gridV_DonTD.DataSource = bUS_SERVICES.LocDon_TD_TheoNgay_ByMaNLDandTenViec(nld.MaNLD, txtTimKiem.Text, kind, trangthai);
        }
        ////////////////////////////////////////
        //LOAD DATAGRID
        private void loadDonTD()
        {
            bUS_SERVICES = new BUS_SERVICES();
            LoadGrid_DonTD();
            gridV_DonTD.DataSource = bUS_SERVICES.LocDon_TD_TheoNgay_ByMaNLDandTenViec(nld.MaNLD, txtTimKiem.Text, kind, trangthai);
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            gridV_DonTD.DataSource = bUS_SERVICES.LocDon_TD_TheoNgay_ByMaNLDandTenViec(nld.MaNLD, txtTimKiem.Text, kind, trangthai);
        }

        private void gridV_DonTD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                checkDon_Click = true;
                int index = gridV_DonTD.CurrentCell.RowIndex; //lấy ra chỉ số của row đang đc chọn
                cellMaDV_stamp = gridV_DonTD.Rows[index].Cells[0].Value.ToString().Trim();
                string tenV = gridV_DonTD.Rows[index].Cells[2].Value.ToString().Trim();
                VIECLAM vl_stamp = bUS_VIECLAM.GetVIECLAMByTenViec(tenV);
                maViec_stamp = vl_stamp.MaViec;
            }
            catch
            {
                checkDon_Click = false;
                MessageBox.Show("Chỉ được chọn hàng hợp lệ trong bảng này!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnXoaDon_Click(object sender, EventArgs e)
        {
            if (checkDon_Click)
            {
                DONVITUYENDUNG dv_stamp = bUS_DONVITUYENDUNG.GetDVTDByMaDV(cellMaDV_stamp);
                VIECLAM vl_stamp = bUS_VIECLAM.GetVIECLAMByMaViec(maViec_stamp);
                DONVITUYENDUNG_VIECLAM dv_vl_stamp = bUS_DONVITUYENDUNG_VIECLAM.GetDVTD_VL_By_DV_VL(dv_stamp, vl_stamp);
                DON_TUYENDUNG dtd = bUS_DON_TUYENDUNG.getDon_TuyenDung_ByMaNLD_Id(nld.MaNLD, dv_vl_stamp.Id);
                if (dtd != null && dtd.TrangThai == 1)
                {
                    DialogResult dlr = MessageBox.Show("Bạn có chắc chắn xoá đơn việc (" + vl_stamp.TenViec.ToUpper() + ") vào đơn vị tuyển dụng (" + dv_stamp.TenDV.ToUpper() + ") không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dlr == DialogResult.Yes)
                    {
                        bUS_DON_TUYENDUNG.DeleteDon_TuyenDung_ByMaNLD_Id(nld.MaNLD, dv_vl_stamp.Id);
                        loadDonTD();
                        checkDon_Click = false;
                        MessageBox.Show("Xoá đơn việc thành công!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else if (dtd != null && dtd.TrangThai == 0)
                {
                    MessageBox.Show("Đơn xin tuyển dụng này của bạn đã bị từ chối bởi " + dv_stamp.TenDV + ". Bạn không thể xoá đơn này!! ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (dtd != null && dtd.TrangThai == 2)
                {
                    MessageBox.Show("Đơn xin tuyển dụng này của bạn đã được " + dv_stamp.TenDV + " chấp nhận. Bạn không thể xoá đơn này!! ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
                MessageBox.Show("Mời bạn click chọn đơn của mình cần xoá!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            loadDonTD();
            checkDon_Click = false;
        }
        private void LoadGrid_DonTD()
        {
            gridV_DonTD.Columns[0].Width = (int)(gridV_DonTD.Width * 0.1);
            gridV_DonTD.Columns[1].Width = (int)(gridV_DonTD.Width * 0.15);
            gridV_DonTD.Columns[2].Width = (int)(gridV_DonTD.Width * 0.2);
            gridV_DonTD.Columns[3].Width = (int)(gridV_DonTD.Width * 0.2);
            gridV_DonTD.Columns[4].Width = (int)(gridV_DonTD.Width * 0.2);
        }
    }
}
