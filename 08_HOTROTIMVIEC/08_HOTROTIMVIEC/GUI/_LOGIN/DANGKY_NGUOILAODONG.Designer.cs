
namespace _08_HOTROTIMVIEC.GUI._LOGIN
{
    partial class DANGKY_NGUOILAODONG
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnChonAnh = new System.Windows.Forms.Button();
            this.btnLuuAnh = new System.Windows.Forms.Button();
            this.grb_TTCT_NLD = new System.Windows.Forms.GroupBox();
            this.dtP_NgaySinh = new System.Windows.Forms.DateTimePicker();
            this.cbbGioiTinh = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBangCap = new System.Windows.Forms.TextBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtCMND = new System.Windows.Forms.TextBox();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnDangKy = new System.Windows.Forms.Button();
            this.ptcB_Avatar = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.grb_Taikhoan = new System.Windows.Forms.GroupBox();
            this.txtNhapLai = new System.Windows.Forms.TextBox();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.txtTaiKhoan = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.grb_TTCT_NLD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptcB_Avatar)).BeginInit();
            this.grb_Taikhoan.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnChonAnh
            // 
            this.btnChonAnh.Location = new System.Drawing.Point(96, 354);
            this.btnChonAnh.Name = "btnChonAnh";
            this.btnChonAnh.Size = new System.Drawing.Size(75, 24);
            this.btnChonAnh.TabIndex = 8;
            this.btnChonAnh.Text = "Chọn ảnh";
            this.btnChonAnh.UseVisualStyleBackColor = true;
            this.btnChonAnh.Click += new System.EventHandler(this.btnChonAnh_Click);
            // 
            // btnLuuAnh
            // 
            this.btnLuuAnh.Location = new System.Drawing.Point(189, 354);
            this.btnLuuAnh.Name = "btnLuuAnh";
            this.btnLuuAnh.Size = new System.Drawing.Size(75, 24);
            this.btnLuuAnh.TabIndex = 9;
            this.btnLuuAnh.Text = "Lưu ảnh";
            this.btnLuuAnh.UseVisualStyleBackColor = true;
            this.btnLuuAnh.Click += new System.EventHandler(this.btnLuuAnh_Click);
            // 
            // grb_TTCT_NLD
            // 
            this.grb_TTCT_NLD.Controls.Add(this.dtP_NgaySinh);
            this.grb_TTCT_NLD.Controls.Add(this.cbbGioiTinh);
            this.grb_TTCT_NLD.Controls.Add(this.label9);
            this.grb_TTCT_NLD.Controls.Add(this.label8);
            this.grb_TTCT_NLD.Controls.Add(this.label7);
            this.grb_TTCT_NLD.Controls.Add(this.label6);
            this.grb_TTCT_NLD.Controls.Add(this.label5);
            this.grb_TTCT_NLD.Controls.Add(this.label4);
            this.grb_TTCT_NLD.Controls.Add(this.label1);
            this.grb_TTCT_NLD.Controls.Add(this.txtBangCap);
            this.grb_TTCT_NLD.Controls.Add(this.txtSDT);
            this.grb_TTCT_NLD.Controls.Add(this.txtDiaChi);
            this.grb_TTCT_NLD.Controls.Add(this.txtCMND);
            this.grb_TTCT_NLD.Controls.Add(this.txtTen);
            this.grb_TTCT_NLD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.grb_TTCT_NLD.Location = new System.Drawing.Point(378, 34);
            this.grb_TTCT_NLD.Name = "grb_TTCT_NLD";
            this.grb_TTCT_NLD.Size = new System.Drawing.Size(434, 383);
            this.grb_TTCT_NLD.TabIndex = 7;
            this.grb_TTCT_NLD.TabStop = false;
            this.grb_TTCT_NLD.Text = "NHẬP THÔNG TIN CHI TIẾT CÁ NHÂN";
            // 
            // dtP_NgaySinh
            // 
            this.dtP_NgaySinh.Location = new System.Drawing.Point(125, 189);
            this.dtP_NgaySinh.Name = "dtP_NgaySinh";
            this.dtP_NgaySinh.Size = new System.Drawing.Size(284, 26);
            this.dtP_NgaySinh.TabIndex = 3;
            this.dtP_NgaySinh.ValueChanged += new System.EventHandler(this.dtP_NgaySinh_ValueChanged);
            // 
            // cbbGioiTinh
            // 
            this.cbbGioiTinh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbGioiTinh.FormattingEnabled = true;
            this.cbbGioiTinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cbbGioiTinh.Location = new System.Drawing.Point(125, 139);
            this.cbbGioiTinh.Name = "cbbGioiTinh";
            this.cbbGioiTinh.Size = new System.Drawing.Size(284, 28);
            this.cbbGioiTinh.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(32, 331);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 20);
            this.label9.TabIndex = 0;
            this.label9.Text = "Bằng Cấp:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(32, 285);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "SDT";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(32, 237);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Địa Chỉ:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 193);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Ngày Sinh:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Giới Tính:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "CMND:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Họ và tên:";
            // 
            // txtBangCap
            // 
            this.txtBangCap.Location = new System.Drawing.Point(125, 327);
            this.txtBangCap.Name = "txtBangCap";
            this.txtBangCap.Size = new System.Drawing.Size(284, 26);
            this.txtBangCap.TabIndex = 1;
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(125, 281);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(284, 26);
            this.txtSDT.TabIndex = 1;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(125, 231);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(284, 26);
            this.txtDiaChi.TabIndex = 1;
            // 
            // txtCMND
            // 
            this.txtCMND.Location = new System.Drawing.Point(125, 94);
            this.txtCMND.Name = "txtCMND";
            this.txtCMND.Size = new System.Drawing.Size(284, 26);
            this.txtCMND.TabIndex = 1;
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(125, 42);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(284, 26);
            this.txtTen.TabIndex = 1;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(1050, 473);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(115, 31);
            this.btnRefresh.TabIndex = 4;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            // 
            // btnDangKy
            // 
            this.btnDangKy.Location = new System.Drawing.Point(869, 473);
            this.btnDangKy.Name = "btnDangKy";
            this.btnDangKy.Size = new System.Drawing.Size(115, 31);
            this.btnDangKy.TabIndex = 4;
            this.btnDangKy.Text = "Đăng Ký";
            this.btnDangKy.UseVisualStyleBackColor = true;
            this.btnDangKy.Click += new System.EventHandler(this.btnDangKy_Click);
            // 
            // ptcB_Avatar
            // 
            this.ptcB_Avatar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ptcB_Avatar.Location = new System.Drawing.Point(30, 34);
            this.ptcB_Avatar.Name = "ptcB_Avatar";
            this.ptcB_Avatar.Size = new System.Drawing.Size(307, 276);
            this.ptcB_Avatar.TabIndex = 6;
            this.ptcB_Avatar.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(136, 322);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "AVATAR";
            // 
            // grb_Taikhoan
            // 
            this.grb_Taikhoan.Controls.Add(this.txtNhapLai);
            this.grb_Taikhoan.Controls.Add(this.txtMatKhau);
            this.grb_Taikhoan.Controls.Add(this.txtTaiKhoan);
            this.grb_Taikhoan.Controls.Add(this.label3);
            this.grb_Taikhoan.Controls.Add(this.label11);
            this.grb_Taikhoan.Controls.Add(this.label10);
            this.grb_Taikhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grb_Taikhoan.Location = new System.Drawing.Point(834, 35);
            this.grb_Taikhoan.Name = "grb_Taikhoan";
            this.grb_Taikhoan.Size = new System.Drawing.Size(376, 255);
            this.grb_Taikhoan.TabIndex = 10;
            this.grb_Taikhoan.TabStop = false;
            this.grb_Taikhoan.Text = "Đăng Ký Tài Khoản";
            // 
            // txtNhapLai
            // 
            this.txtNhapLai.Location = new System.Drawing.Point(161, 135);
            this.txtNhapLai.Name = "txtNhapLai";
            this.txtNhapLai.Size = new System.Drawing.Size(170, 26);
            this.txtNhapLai.TabIndex = 1;
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Location = new System.Drawing.Point(161, 87);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Size = new System.Drawing.Size(170, 26);
            this.txtMatKhau.TabIndex = 1;
            // 
            // txtTaiKhoan
            // 
            this.txtTaiKhoan.Location = new System.Drawing.Point(161, 40);
            this.txtTaiKhoan.Name = "txtTaiKhoan";
            this.txtTaiKhoan.Size = new System.Drawing.Size(170, 26);
            this.txtTaiKhoan.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Nhập lại mật khẩu";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(76, 93);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(79, 20);
            this.label11.TabIndex = 0;
            this.label11.Text = "Mật khẩu:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(73, 46);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(82, 20);
            this.label10.TabIndex = 0;
            this.label10.Text = "Tài khoản:";
            // 
            // DANGKY_NGUOILAODONG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1233, 530);
            this.Controls.Add(this.grb_Taikhoan);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnChonAnh);
            this.Controls.Add(this.btnDangKy);
            this.Controls.Add(this.btnLuuAnh);
            this.Controls.Add(this.grb_TTCT_NLD);
            this.Controls.Add(this.ptcB_Avatar);
            this.Controls.Add(this.label2);
            this.Name = "DANGKY_NGUOILAODONG";
            this.Text = "DANGKY_NGUOILAODONG";
            this.Load += new System.EventHandler(this.DANGKY_NGUOILAODONG_Load);
            this.grb_TTCT_NLD.ResumeLayout(false);
            this.grb_TTCT_NLD.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptcB_Avatar)).EndInit();
            this.grb_Taikhoan.ResumeLayout(false);
            this.grb_Taikhoan.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnChonAnh;
        private System.Windows.Forms.Button btnLuuAnh;
        private System.Windows.Forms.GroupBox grb_TTCT_NLD;
        private System.Windows.Forms.DateTimePicker dtP_NgaySinh;
        private System.Windows.Forms.ComboBox cbbGioiTinh;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBangCap;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtCMND;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnDangKy;
        private System.Windows.Forms.PictureBox ptcB_Avatar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox grb_Taikhoan;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTaiKhoan;
        private System.Windows.Forms.TextBox txtNhapLai;
        private System.Windows.Forms.TextBox txtMatKhau;
    }
}