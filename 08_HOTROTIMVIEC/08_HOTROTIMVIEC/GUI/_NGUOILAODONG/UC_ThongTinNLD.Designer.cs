
namespace _08_HOTROTIMVIEC.GUI._NGUOILAODONG
{
    partial class UC_ThongTinNLD
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ptcB_Avatar = new System.Windows.Forms.PictureBox();
            this.grb_TTCT_NLD = new System.Windows.Forms.GroupBox();
            this.dtP_NgaySinh = new System.Windows.Forms.DateTimePicker();
            this.cbbGioiTinh = new System.Windows.Forms.ComboBox();
            this.lblMaNLD = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBangCap = new System.Windows.Forms.TextBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtCMND = new System.Windows.Forms.TextBox();
            this.btnLuuAnh = new System.Windows.Forms.Button();
            this.btnChonAnh = new System.Windows.Forms.Button();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.btnPhucHoi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ptcB_Avatar)).BeginInit();
            this.grb_TTCT_NLD.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Họ và tên:";
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(125, 82);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(284, 26);
            this.txtTen.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(135, 318);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "AVATAR";
            // 
            // ptcB_Avatar
            // 
            this.ptcB_Avatar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ptcB_Avatar.Location = new System.Drawing.Point(29, 30);
            this.ptcB_Avatar.Name = "ptcB_Avatar";
            this.ptcB_Avatar.Size = new System.Drawing.Size(307, 276);
            this.ptcB_Avatar.TabIndex = 2;
            this.ptcB_Avatar.TabStop = false;
            // 
            // grb_TTCT_NLD
            // 
            this.grb_TTCT_NLD.Controls.Add(this.btnPhucHoi);
            this.grb_TTCT_NLD.Controls.Add(this.btnCapNhat);
            this.grb_TTCT_NLD.Controls.Add(this.dtP_NgaySinh);
            this.grb_TTCT_NLD.Controls.Add(this.cbbGioiTinh);
            this.grb_TTCT_NLD.Controls.Add(this.lblMaNLD);
            this.grb_TTCT_NLD.Controls.Add(this.label3);
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
            this.grb_TTCT_NLD.Location = new System.Drawing.Point(377, 30);
            this.grb_TTCT_NLD.Name = "grb_TTCT_NLD";
            this.grb_TTCT_NLD.Size = new System.Drawing.Size(606, 424);
            this.grb_TTCT_NLD.TabIndex = 3;
            this.grb_TTCT_NLD.TabStop = false;
            this.grb_TTCT_NLD.Text = "THÔNG TIN CHI TIẾT CÁ NHÂN";
            // 
            // dtP_NgaySinh
            // 
            this.dtP_NgaySinh.Location = new System.Drawing.Point(125, 229);
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
            this.cbbGioiTinh.Location = new System.Drawing.Point(125, 179);
            this.cbbGioiTinh.Name = "cbbGioiTinh";
            this.cbbGioiTinh.Size = new System.Drawing.Size(284, 28);
            this.cbbGioiTinh.TabIndex = 2;
            // 
            // lblMaNLD
            // 
            this.lblMaNLD.AutoSize = true;
            this.lblMaNLD.Location = new System.Drawing.Point(141, 42);
            this.lblMaNLD.Name = "lblMaNLD";
            this.lblMaNLD.Size = new System.Drawing.Size(21, 20);
            this.lblMaNLD.TabIndex = 0;
            this.lblMaNLD.Text = "...";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mã Cá Nhân:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(32, 371);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 20);
            this.label9.TabIndex = 0;
            this.label9.Text = "Bằng Cấp:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(32, 325);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "SDT";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(32, 277);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Địa Chỉ:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 233);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Ngày Sinh:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Giới Tính:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "CMND:";
            // 
            // txtBangCap
            // 
            this.txtBangCap.Location = new System.Drawing.Point(125, 367);
            this.txtBangCap.Name = "txtBangCap";
            this.txtBangCap.Size = new System.Drawing.Size(284, 26);
            this.txtBangCap.TabIndex = 1;
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(125, 321);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.ReadOnly = true;
            this.txtSDT.Size = new System.Drawing.Size(284, 26);
            this.txtSDT.TabIndex = 1;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(125, 271);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(284, 26);
            this.txtDiaChi.TabIndex = 1;
            // 
            // txtCMND
            // 
            this.txtCMND.Location = new System.Drawing.Point(125, 134);
            this.txtCMND.Name = "txtCMND";
            this.txtCMND.ReadOnly = true;
            this.txtCMND.Size = new System.Drawing.Size(284, 26);
            this.txtCMND.TabIndex = 1;
            // 
            // btnLuuAnh
            // 
            this.btnLuuAnh.Location = new System.Drawing.Point(188, 350);
            this.btnLuuAnh.Name = "btnLuuAnh";
            this.btnLuuAnh.Size = new System.Drawing.Size(75, 24);
            this.btnLuuAnh.TabIndex = 4;
            this.btnLuuAnh.Text = "Lưu ảnh";
            this.btnLuuAnh.UseVisualStyleBackColor = true;
            this.btnLuuAnh.Click += new System.EventHandler(this.btnLuuAnh_Click);
            // 
            // btnChonAnh
            // 
            this.btnChonAnh.Location = new System.Drawing.Point(95, 350);
            this.btnChonAnh.Name = "btnChonAnh";
            this.btnChonAnh.Size = new System.Drawing.Size(75, 24);
            this.btnChonAnh.TabIndex = 4;
            this.btnChonAnh.Text = "Chọn ảnh";
            this.btnChonAnh.UseVisualStyleBackColor = true;
            this.btnChonAnh.Click += new System.EventHandler(this.btnChonAnh_Click);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Location = new System.Drawing.Point(463, 37);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(115, 31);
            this.btnCapNhat.TabIndex = 4;
            this.btnCapNhat.Text = "Cập Nhật";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // btnPhucHoi
            // 
            this.btnPhucHoi.Location = new System.Drawing.Point(463, 97);
            this.btnPhucHoi.Name = "btnPhucHoi";
            this.btnPhucHoi.Size = new System.Drawing.Size(115, 31);
            this.btnPhucHoi.TabIndex = 4;
            this.btnPhucHoi.Text = "Phục Hồi";
            this.btnPhucHoi.UseVisualStyleBackColor = true;
            this.btnPhucHoi.Click += new System.EventHandler(this.btnPhucHoi_Click);
            // 
            // UC_ThongTinNLD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnChonAnh);
            this.Controls.Add(this.btnLuuAnh);
            this.Controls.Add(this.grb_TTCT_NLD);
            this.Controls.Add(this.ptcB_Avatar);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Name = "UC_ThongTinNLD";
            this.Size = new System.Drawing.Size(1030, 531);
            this.Load += new System.EventHandler(this.UC_ThongTinNLD_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ptcB_Avatar)).EndInit();
            this.grb_TTCT_NLD.ResumeLayout(false);
            this.grb_TTCT_NLD.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox ptcB_Avatar;
        private System.Windows.Forms.GroupBox grb_TTCT_NLD;
        private System.Windows.Forms.Label lblMaNLD;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbbGioiTinh;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBangCap;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtCMND;
        private System.Windows.Forms.Button btnLuuAnh;
        private System.Windows.Forms.Button btnChonAnh;
        private System.Windows.Forms.DateTimePicker dtP_NgaySinh;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Button btnPhucHoi;
    }
}
