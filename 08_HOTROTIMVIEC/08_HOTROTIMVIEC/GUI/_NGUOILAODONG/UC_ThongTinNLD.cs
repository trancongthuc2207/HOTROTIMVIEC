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
    public partial class UC_ThongTinNLD : UserControl
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
        /////khoitao
        private string txtImage = "";
        private string txtImage_stamp = "";
        ///////////////STAMP THONG TIN NLD
        private string TenNLD_stamp;
        private string GioiTinh_stamp;
        private DateTime NgaySinh_stamp;
        private string DiaChi_stamp;
        private string BangCap_stamp;
        public UC_ThongTinNLD()
        {
            InitializeComponent();
        }
        private static UC_ThongTinNLD _instance;
        public static UC_ThongTinNLD Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UC_ThongTinNLD();
                return _instance;
            }
        }

        private void UC_ThongTinNLD_Load(object sender, EventArgs e)
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
            try
            {
                txtImage = bUS_SERVICES.get_NGUOILD_images(nld.MaNLD).Link;
                txtImage_stamp = bUS_SERVICES.get_NGUOILD_images(nld.MaNLD).Link;
            }
            catch { }
            //SAVE
            SaveDuLieu_StampNLD();
            //
            loadTTCT_NLD();
        }
        private void loadTTCT_NLD()
        {
            //Thong tin
            lblMaNLD.Text = nld.MaNLD.ToString();
            txtTen.Text = nld.Ten;
            txtCMND.Text = nld.CMND;
            cbbGioiTinh.Text = nld.GioiTinh;
            dtP_NgaySinh.Value = nld.NgaySinh.Date;
            txtDiaChi.Text = nld.DiaChi;
            txtSDT.Text = nld.SDT;
            txtBangCap.Text = nld.BangCap;
            //Avatar
            if (bUS_SERVICES.CheckNLD_Image(nld.MaNLD) == 1)
            {
                NGUOILD_Image dv_img = bUS_SERVICES.get_NGUOILD_images(nld.MaNLD);
                if (!String.IsNullOrEmpty(dv_img.Link))
                {
                    ptcB_Avatar.Image = Image.FromFile("NGUOILD/" + dv_img.Link);
                    ptcB_Avatar.SizeMode = PictureBoxSizeMode.StretchImage;
                    ptcB_Avatar.Show();
                }
                else
                    ptcB_Avatar.Hide();
            }
            else if (bUS_SERVICES.CheckNLD_Image(nld.MaNLD) == 0)
            {
                ptcB_Avatar.Hide();
            }
        }

        private void btnChonAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = "D:\\trancongthuc\\HOTROTIMVIEC\\08_HOTROTIMVIEC\\08_HOTROTIMVIEC\\bin\\Debug\\NGUOILD";//Định đường dẫn khi mở cửa sổ tìm ảnh
            openFileDialog.FileName = "";// Tên ảnh
            openFileDialog.Filter = "Images(*.jpg)|*.jpg|PNG (*.png)|*.png|All files (*.*)|*.*";
            openFileDialog.ShowDialog();// Hiện cửa sổ 
            if (openFileDialog.FileName != "")
            {
                txtImage = System.IO.Path.GetFileName(openFileDialog.FileName);// Hiển thị tên ảnh lên Textbox
                ptcB_Avatar.Image = Image.FromFile(openFileDialog.FileName);//Hiện ảnh lên Picbox.
                ptcB_Avatar.Show();
            }
        }

        private void btnLuuAnh_Click(object sender, EventArgs e)
        {
            try
            {
                if (!txtImage.Equals(txtImage_stamp))
                {
                    DialogResult dlr = MessageBox.Show("Bạn có chắc chắn muốn thay đổi AVATAR không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dlr == DialogResult.Yes)
                    {
                        if (bUS_SERVICES.Check_NLD_image_TrungTen(txtImage) == 0)
                        {
                            bUS_SERVICES.UpdateImage_Link_NLD(nld.MaNLD, txtImage);
                            MessageBox.Show("Thay đổi avatar thành công!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtImage_stamp = txtImage;
                        }
                        else
                            MessageBox.Show("Thay đổi avatar thất bại, vì hình ảnh đã trùng!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                    MessageBox.Show("Chưa có ảnh mới để lưu thay đổi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Hiện tại tài khoản của bạn chưa có avatar!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void SaveDuLieu_StampNLD()
        {
            bUS_NGUOILAODONG = new BUS_NGUOILAODONG();
            nld = bUS_NGUOILAODONG.getNLDFromTK(nld_Cur_TK);
            TenNLD_stamp = nld.Ten;
            GioiTinh_stamp = nld.GioiTinh;
            NgaySinh_stamp = nld.NgaySinh;
            DiaChi_stamp = nld.DiaChi;
            BangCap_stamp = nld.BangCap;
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (!txtTen.Text.Equals(TenNLD_stamp) || !cbbGioiTinh.Text.Equals(GioiTinh_stamp) || dtP_NgaySinh.Value.Date != NgaySinh_stamp.Date || !txtDiaChi.Text.Equals(DiaChi_stamp) || !txtBangCap.Text.Equals(BangCap_stamp))
            {
                DialogResult dlr = MessageBox.Show("Bạn có chắc chắn muốn thay đổi thông tin không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dlr == DialogResult.Yes)
                {
                    bUS_NGUOILAODONG.Update_ThongTin_NLD(nld.MaNLD, txtTen.Text, cbbGioiTinh.Text, dtP_NgaySinh.Value.Date, txtDiaChi.Text, txtBangCap.Text);
                    MessageBox.Show("Thay đổi thông tin được cập nhật thành công!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    SaveDuLieu_StampNLD();
                }
            }
            else
                MessageBox.Show("Chưa có sự thay đổi để cập nhật!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnPhucHoi_Click(object sender, EventArgs e)
        {
            if (!txtTen.Text.Equals(TenNLD_stamp) || !cbbGioiTinh.Text.Equals(GioiTinh_stamp) || dtP_NgaySinh.Value.Date != NgaySinh_stamp.Date || !txtDiaChi.Text.Equals(DiaChi_stamp) || !txtBangCap.Text.Equals(BangCap_stamp))
            {
                DialogResult dlr = MessageBox.Show("Bạn có chắc chắn muốn phục hồi thông tin không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dlr == DialogResult.Yes)
                {
                    txtTen.Text = TenNLD_stamp;
                    cbbGioiTinh.Text = GioiTinh_stamp;
                    dtP_NgaySinh.Value = NgaySinh_stamp;
                    txtDiaChi.Text = DiaChi_stamp;
                    txtBangCap.Text = BangCap_stamp;
                    MessageBox.Show("Phục hồi thông tin thành công!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
                MessageBox.Show("Chưa có sự thay đổi để phục hồi!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void initGioiHan()
        {
            txtTen.MaxLength = 50;
            txtDiaChi.MaxLength = 50;
            txtBangCap.MaxLength = 50;
        }

        private void dtP_NgaySinh_ValueChanged(object sender, EventArgs e)
        {
            if (DateTime.Now.Year - dtP_NgaySinh.Value.Year <= 16)
            {
                MessageBox.Show("Yêu cầu phải lớn hơn 16 tuổi!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dtP_NgaySinh.Value = nld.NgaySinh;
            }
        }
    }
}
