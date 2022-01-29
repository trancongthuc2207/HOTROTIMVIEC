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
using _08_HOTROTIMVIEC.BUS;

namespace _08_HOTROTIMVIEC.GUI._NGUOILAODONG
{
    public partial class UC_TrangChu_NLD : UserControl
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
        //check click
        private bool check_Click_GridViecLam = false;
        private bool check_Click_GridDonVi = false;
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
            bUS_NGUOILAODONG_TAIKHOAN = new BUS_NGUOILAODONG_TAIKHOAN();
            bUS_NGUOILAODONG = new BUS_NGUOILAODONG();
            bUS_VIECLAM = new BUS_VIECLAM();
            bUS_SERVICES = new BUS_SERVICES();
            bUS_DONVITUYENDUNG = new BUS_DONVITUYENDUNG();
            bUS_DONVITUYENDUNG_VIECLAM = new BUS_DONVITUYENDUNG_VIECLAM();
            bUS_DON_TUYENDUNG = new BUS_DON_TUYENDUNG();
            nld = bUS_NGUOILAODONG.getNLDFromTK(nld_Cur_TK);
            //LOAD
            this.txtTimKiem_TextChanged(sender, e);
            grb_TTDonVi.Hide();
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            if (cbbTimkiem.SelectedIndex == 0)
            {
                lblNhacNhoChonTC.Hide();
                gridV_ViecLam.DataSource = bUS_VIECLAM.getListFromTenViec(txtTimKiem.Text);
                check_Click_GridViecLam = false;
            }
            else if (cbbTimkiem.SelectedIndex == 1)
            {
                lblNhacNhoChonTC.Hide();
                gridV_ViecLam.DataSource = bUS_VIECLAM.getListFromMucLuong(txtTimKiem.Text);
                check_Click_GridViecLam = false;
            }
            else if (cbbTimkiem.SelectedIndex == -1)
            {
                loadGridV_ViecLam();
                lblNhacNhoChonTC.Show();
            }
        }

        private void cbbTimkiem_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbTimkiem.SelectedIndex == 0)
            {
                lblNhacNhoChonTC.Hide();
                gridV_ViecLam.DataSource = bUS_VIECLAM.getListFromTenViec(txtTimKiem.Text);
                check_Click_GridViecLam = false;
            }
            else if (cbbTimkiem.SelectedIndex == 1)
            {
                lblNhacNhoChonTC.Hide();
                gridV_ViecLam.DataSource = bUS_VIECLAM.getListFromMucLuong(txtTimKiem.Text);
                check_Click_GridViecLam = false;
            }
        }

        private void gridV_ViecLam_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                check_Click_GridViecLam = true;
                int index = gridV_ViecLam.CurrentCell.RowIndex; //lấy ra chỉ số của row đang đc chọn
                string cell = gridV_ViecLam.Rows[index].Cells[0].Value.ToString().Trim(); // Lấy mã hợp đồng
                gridV_DonVi.DataSource = bUS_SERVICES.getListDVTD_By_MaViec(int.Parse(cell));
                LoadGrid_DonVi();
                grb_TTDonVi.Hide();
            }
            catch
            {
                check_Click_GridViecLam = false;
                MessageBox.Show("Chỉ được chọn hàng hợp lệ trong bảng này!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void gridV_DonVi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                check_Click_GridDonVi = true;
                loadGBox_TTDV();
            }
            catch
            {
                check_Click_GridDonVi = false;
                MessageBox.Show("Chỉ được chọn hàng hợp lệ trong bảng này!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        ////////Tìm kiếm địa điểm 
        private void txtDiaDiem_TextChanged(object sender, EventArgs e)
        {
            gridV_DonVi.DataSource = bUS_SERVICES.getList_DiaDiem_MaViec(maViecClick(), txtDiaDiem.Text);
            check_Click_GridDonVi = false;
        }
        /////////NHẬN MÃ VIỆC VÀ MÃ ĐƠN VỊ
        private int maViecClick()
        {
            int index = gridV_ViecLam.CurrentCell.RowIndex; //lấy ra chỉ số của row đang đc chọn
            string cell = gridV_ViecLam.Rows[index].Cells[0].Value.ToString().Trim();
            return int.Parse(cell);
        }
        private string maDVClick()
        {
            int index = gridV_DonVi.CurrentCell.RowIndex; //lấy ra chỉ số của row đang đc chọn
            string cell = gridV_DonVi.Rows[index].Cells[0].Value.ToString().Trim();
            return cell;
        }
        ///////////////////////////////////
        ////LOAD
        private void loadGBox_TTDV()
        {
            try
            {
                bUS_DONVITUYENDUNG = new BUS_DONVITUYENDUNG();
                bUS_DONVITUYENDUNG_VIECLAM = new BUS_DONVITUYENDUNG_VIECLAM();
                bUS_DON_TUYENDUNG = new BUS_DON_TUYENDUNG();
                VIECLAM vl = bUS_VIECLAM.GetVIECLAMByMaViec(maViecClick());
                DONVITUYENDUNG dv = bUS_DONVITUYENDUNG.GetDVTDByMaDV(maDVClick());
                DONVITUYENDUNG_VIECLAM dv_vl = bUS_DONVITUYENDUNG_VIECLAM.GetDVTD_VL_By_DV_VL(dv, vl);

                ///Thong tin
                lblMaDV.Text = dv.MaDV;
                lblTenDV.Text = dv.TenDV;
                lblViecLam.Text = vl.TenViec;
                lblQuyMo.Text = dv_vl.QuyMo.ToString();
                lblMucLuong.Text = vl.MucLuong.ToString();
                try
                {
                    lblNBD.Text = dv_vl.TGBatDau.Value.ToShortDateString();
                    lblNKT.Text = dv_vl.TGKetThuc.Value.ToShortDateString();
                }
                catch
                {
                    lblNBD.Text = "";
                    lblNKT.Text = "";
                }
                ///Hinh anh
                if (bUS_SERVICES.CheckDV_Image(maDVClick()) == 1)
                {
                    DONVI_Image dv_img = bUS_SERVICES.get_DV_images(maDVClick());
                    if (!String.IsNullOrEmpty(dv_img.Link))
                    {
                        ptcBox_DonVi.Image = Image.FromFile("DONVI/" + dv_img.Link);
                        ptcBox_DonVi.SizeMode = PictureBoxSizeMode.StretchImage;
                        ptcBox_DonVi.Show();
                    }
                    else
                        ptcBox_DonVi.Hide();
                }
                else if (bUS_SERVICES.CheckDV_Image(maDVClick()) == 0)
                {
                    ptcBox_DonVi.Hide();
                }
                //Show
                grb_TTDonVi.Show();
            }
            catch
            {
                grb_TTDonVi.Hide();
                ptcBox_DonVi.Hide();
            }
        }

        private void loadGridV_ViecLam()
        {
            bUS_VIECLAM = new BUS_VIECLAM();
            check_Click_GridViecLam = false;
            gridV_ViecLam.DataSource = bUS_VIECLAM.getViecLam();
            LoadGrid_ViecLam();
        }

        private void tbnNopDon_Click(object sender, EventArgs e)
        {
            if (check_Click_GridViecLam == true && check_Click_GridDonVi == true)
            {
                VIECLAM vl = bUS_VIECLAM.GetVIECLAMByMaViec(maViecClick());
                DONVITUYENDUNG dv = bUS_DONVITUYENDUNG.GetDVTDByMaDV(maDVClick());
                DONVITUYENDUNG_VIECLAM dv_vl = bUS_DONVITUYENDUNG_VIECLAM.GetDVTD_VL_By_DV_VL(dv, vl);
                if (checkTime())
                {
                    if (bUS_DON_TUYENDUNG.SV_addDON_TUYENDUNG(nld.MaNLD, dv_vl.Id, DateTime.Now.Date) == 1)
                    {
                        DialogResult dlr = MessageBox.Show("Bạn có chắc chắn muốn nộp đơn việc (" + vl.TenViec.ToUpper() + ") vào đơn vị (" + dv.TenDV.ToUpper() + ") này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (dlr == DialogResult.Yes)
                        {
                            bUS_DON_TUYENDUNG.SV_addDON_TUYENDUNG(nld.MaNLD, dv_vl.Id, DateTime.Now.Date);
                            MessageBox.Show("Bạn nộp đơn tuyển dụng thành công!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                        MessageBox.Show("Nộp thất bại! Bạn đã nộp đơn đối với công việc và đơn vị này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                    MessageBox.Show("Nộp thất bại! Đơn vị công ty này đã hết hạn tuyển!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
                MessageBox.Show("Mời bạn chọn lại công việc và đơn vị tuyển dụng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }
        private void LoadGrid_ViecLam()
        {
            gridV_ViecLam.Columns[0].Width = (int)(gridV_ViecLam.Width * 0.2);
            gridV_ViecLam.Columns[1].Width = (int)(gridV_ViecLam.Width * 0.2);
            gridV_ViecLam.Columns[2].Width = (int)(gridV_ViecLam.Width * 0.34);
            gridV_ViecLam.Columns[3].Width = (int)(gridV_ViecLam.Width * 0.2);
        }
        private void LoadGrid_DonVi()
        {
            gridV_DonVi.Columns[0].Width = (int)(gridV_DonVi.Width * 0.1);
            gridV_DonVi.Columns[1].Width = (int)(gridV_DonVi.Width * 0.15);
            gridV_DonVi.Columns[2].Width = (int)(gridV_DonVi.Width * 0.1);
            gridV_DonVi.Columns[3].Width = (int)(gridV_DonVi.Width * 0.2);
            gridV_DonVi.Columns[4].Width = (int)(gridV_DonVi.Width * 0.2);
            gridV_DonVi.Columns[5].Width = (int)(gridV_DonVi.Width * 0.2);
        }
        private bool checkTime()
        {
            bool check = false;
            VIECLAM vl = bUS_VIECLAM.GetVIECLAMByMaViec(maViecClick());
            DONVITUYENDUNG dv = bUS_DONVITUYENDUNG.GetDVTDByMaDV(maDVClick());
            DONVITUYENDUNG_VIECLAM dv_vl = bUS_DONVITUYENDUNG_VIECLAM.GetDVTD_VL_By_DV_VL(dv, vl);
            try
            {
                string nbd = "";
                nbd = dv_vl.TGBatDau.Value.Date.ToString();
                string nkt = "";
                nkt = dv_vl.TGKetThuc.Value.Date.ToString();
                if (DateTime.Now.Date >= DateTime.Parse(nbd).Date && DateTime.Now.Date <= DateTime.Parse(nkt).Date)
                {
                    check = true;
                }
                else
                    check = false;
            }
            catch
            {
                check = true;
            }
            return check;
        }
    }
}
