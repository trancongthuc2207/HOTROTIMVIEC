
namespace _08_HOTROTIMVIEC.GUI._NGUOILAODONG
{
    partial class UC_TrangChu_NLD
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
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.gridV_ViecLam = new System.Windows.Forms.DataGridView();
            this.cbbTimkiem = new System.Windows.Forms.ComboBox();
            this.lblNhacNhoChonTC = new System.Windows.Forms.Label();
            this.gridV_DonVi = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDiaDiem = new System.Windows.Forms.TextBox();
            this.ptcBox_DonVi = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.grb_TTDonVi = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblNKT = new System.Windows.Forms.Label();
            this.lblNBD = new System.Windows.Forms.Label();
            this.lblMucLuong = new System.Windows.Forms.Label();
            this.lblQuyMo = new System.Windows.Forms.Label();
            this.lblViecLam = new System.Windows.Forms.Label();
            this.lblTenDV = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblMaDV = new System.Windows.Forms.Label();
            this.lbl = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbnNopDon = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridV_ViecLam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridV_DonVi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptcBox_DonVi)).BeginInit();
            this.grb_TTDonVi.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(115, 27);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(4);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(396, 21);
            this.txtTimKiem.TabIndex = 0;
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(29, 30);
            this.label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(58, 15);
            this.label.TabIndex = 1;
            this.label.Text = "Tìm kiếm";
            // 
            // gridV_ViecLam
            // 
            this.gridV_ViecLam.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridV_ViecLam.Location = new System.Drawing.Point(32, 72);
            this.gridV_ViecLam.MultiSelect = false;
            this.gridV_ViecLam.Name = "gridV_ViecLam";
            this.gridV_ViecLam.ReadOnly = true;
            this.gridV_ViecLam.Size = new System.Drawing.Size(676, 179);
            this.gridV_ViecLam.TabIndex = 2;
            this.gridV_ViecLam.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridV_ViecLam_CellClick);
            // 
            // cbbTimkiem
            // 
            this.cbbTimkiem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbTimkiem.FormattingEnabled = true;
            this.cbbTimkiem.Items.AddRange(new object[] {
            "Theo tên việc",
            "Theo mức lương"});
            this.cbbTimkiem.Location = new System.Drawing.Point(587, 26);
            this.cbbTimkiem.Name = "cbbTimkiem";
            this.cbbTimkiem.Size = new System.Drawing.Size(121, 23);
            this.cbbTimkiem.TabIndex = 3;
            this.cbbTimkiem.SelectedIndexChanged += new System.EventHandler(this.cbbTimkiem_SelectedIndexChanged);
            // 
            // lblNhacNhoChonTC
            // 
            this.lblNhacNhoChonTC.AutoSize = true;
            this.lblNhacNhoChonTC.ForeColor = System.Drawing.Color.Red;
            this.lblNhacNhoChonTC.Location = new System.Drawing.Point(115, 54);
            this.lblNhacNhoChonTC.Name = "lblNhacNhoChonTC";
            this.lblNhacNhoChonTC.Size = new System.Drawing.Size(133, 15);
            this.lblNhacNhoChonTC.TabIndex = 4;
            this.lblNhacNhoChonTC.Text = "Mời bạn chọn tiêu chí !!";
            // 
            // gridV_DonVi
            // 
            this.gridV_DonVi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridV_DonVi.Location = new System.Drawing.Point(32, 313);
            this.gridV_DonVi.MultiSelect = false;
            this.gridV_DonVi.Name = "gridV_DonVi";
            this.gridV_DonVi.ReadOnly = true;
            this.gridV_DonVi.Size = new System.Drawing.Size(676, 150);
            this.gridV_DonVi.TabIndex = 5;
            this.gridV_DonVi.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridV_DonVi_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 280);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tìm kiếm theo địa điểm tuyển dụng:";
            // 
            // txtDiaDiem
            // 
            this.txtDiaDiem.Location = new System.Drawing.Point(239, 275);
            this.txtDiaDiem.Name = "txtDiaDiem";
            this.txtDiaDiem.Size = new System.Drawing.Size(272, 21);
            this.txtDiaDiem.TabIndex = 6;
            this.txtDiaDiem.TextChanged += new System.EventHandler(this.txtDiaDiem_TextChanged);
            // 
            // ptcBox_DonVi
            // 
            this.ptcBox_DonVi.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ptcBox_DonVi.Location = new System.Drawing.Point(47, 270);
            this.ptcBox_DonVi.Name = "ptcBox_DonVi";
            this.ptcBox_DonVi.Size = new System.Drawing.Size(178, 150);
            this.ptcBox_DonVi.TabIndex = 7;
            this.ptcBox_DonVi.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 241);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "HÌNH ẢNH CÔNG TY:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(525, 30);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tiêu chí:";
            // 
            // grb_TTDonVi
            // 
            this.grb_TTDonVi.Controls.Add(this.label10);
            this.grb_TTDonVi.Controls.Add(this.label9);
            this.grb_TTDonVi.Controls.Add(this.label7);
            this.grb_TTDonVi.Controls.Add(this.ptcBox_DonVi);
            this.grb_TTDonVi.Controls.Add(this.label2);
            this.grb_TTDonVi.Controls.Add(this.label6);
            this.grb_TTDonVi.Controls.Add(this.label5);
            this.grb_TTDonVi.Controls.Add(this.lblNKT);
            this.grb_TTDonVi.Controls.Add(this.lblNBD);
            this.grb_TTDonVi.Controls.Add(this.lblMucLuong);
            this.grb_TTDonVi.Controls.Add(this.lblQuyMo);
            this.grb_TTDonVi.Controls.Add(this.lblViecLam);
            this.grb_TTDonVi.Controls.Add(this.lblTenDV);
            this.grb_TTDonVi.Controls.Add(this.label4);
            this.grb_TTDonVi.Controls.Add(this.lblMaDV);
            this.grb_TTDonVi.Controls.Add(this.lbl);
            this.grb_TTDonVi.Location = new System.Drawing.Point(765, 72);
            this.grb_TTDonVi.Name = "grb_TTDonVi";
            this.grb_TTDonVi.Size = new System.Drawing.Size(250, 437);
            this.grb_TTDonVi.TabIndex = 9;
            this.grb_TTDonVi.TabStop = false;
            this.grb_TTDonVi.Text = "Thông tin chi tiết đơn vị tuyển";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 192);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(115, 15);
            this.label10.TabIndex = 0;
            this.label10.Text = "Ngày kết thúc tuyển:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 164);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(114, 15);
            this.label9.TabIndex = 0;
            this.label9.Text = "Ngày bắt đầu tuyển:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 138);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 15);
            this.label7.TabIndex = 0;
            this.label7.Text = "Mức lương:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 15);
            this.label6.TabIndex = 0;
            this.label6.Text = "Số lượng còn:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "Tuyển công việc:";
            // 
            // lblNKT
            // 
            this.lblNKT.AutoSize = true;
            this.lblNKT.Location = new System.Drawing.Point(130, 192);
            this.lblNKT.Name = "lblNKT";
            this.lblNKT.Size = new System.Drawing.Size(16, 15);
            this.lblNKT.TabIndex = 0;
            this.lblNKT.Text = "...";
            // 
            // lblNBD
            // 
            this.lblNBD.AutoSize = true;
            this.lblNBD.Location = new System.Drawing.Point(130, 164);
            this.lblNBD.Name = "lblNBD";
            this.lblNBD.Size = new System.Drawing.Size(16, 15);
            this.lblNBD.TabIndex = 0;
            this.lblNBD.Text = "...";
            // 
            // lblMucLuong
            // 
            this.lblMucLuong.AutoSize = true;
            this.lblMucLuong.Location = new System.Drawing.Point(79, 138);
            this.lblMucLuong.Name = "lblMucLuong";
            this.lblMucLuong.Size = new System.Drawing.Size(16, 15);
            this.lblMucLuong.TabIndex = 0;
            this.lblMucLuong.Text = "...";
            // 
            // lblQuyMo
            // 
            this.lblQuyMo.AutoSize = true;
            this.lblQuyMo.Location = new System.Drawing.Point(94, 110);
            this.lblQuyMo.Name = "lblQuyMo";
            this.lblQuyMo.Size = new System.Drawing.Size(16, 15);
            this.lblQuyMo.TabIndex = 0;
            this.lblQuyMo.Text = "...";
            // 
            // lblViecLam
            // 
            this.lblViecLam.AutoSize = true;
            this.lblViecLam.Location = new System.Drawing.Point(109, 84);
            this.lblViecLam.Name = "lblViecLam";
            this.lblViecLam.Size = new System.Drawing.Size(16, 15);
            this.lblViecLam.TabIndex = 0;
            this.lblViecLam.Text = "...";
            // 
            // lblTenDV
            // 
            this.lblTenDV.AutoSize = true;
            this.lblTenDV.Location = new System.Drawing.Point(84, 59);
            this.lblTenDV.Name = "lblTenDV";
            this.lblTenDV.Size = new System.Drawing.Size(16, 15);
            this.lblTenDV.TabIndex = 0;
            this.lblTenDV.Text = "...";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Tên Công Ty:";
            // 
            // lblMaDV
            // 
            this.lblMaDV.AutoSize = true;
            this.lblMaDV.Location = new System.Drawing.Point(79, 33);
            this.lblMaDV.Name = "lblMaDV";
            this.lblMaDV.Size = new System.Drawing.Size(16, 15);
            this.lblMaDV.TabIndex = 0;
            this.lblMaDV.Text = "...";
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(6, 33);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(67, 15);
            this.lbl.TabIndex = 0;
            this.lbl.Text = "Mã Đơn Vị:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label8.Location = new System.Drawing.Point(782, 30);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(219, 24);
            this.label8.TabIndex = 10;
            this.label8.Text = "ĐƠN VỊ TUYỂN DỤNG";
            // 
            // tbnNopDon
            // 
            this.tbnNopDon.Location = new System.Drawing.Point(436, 486);
            this.tbnNopDon.Name = "tbnNopDon";
            this.tbnNopDon.Size = new System.Drawing.Size(142, 32);
            this.tbnNopDon.TabIndex = 11;
            this.tbnNopDon.Text = "Nộp đơn ứng tuyển";
            this.tbnNopDon.UseVisualStyleBackColor = true;
            this.tbnNopDon.Click += new System.EventHandler(this.tbnNopDon_Click);
            // 
            // UC_TrangChu_NLD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tbnNopDon);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.grb_TTDonVi);
            this.Controls.Add(this.txtDiaDiem);
            this.Controls.Add(this.gridV_DonVi);
            this.Controls.Add(this.lblNhacNhoChonTC);
            this.Controls.Add(this.cbbTimkiem);
            this.Controls.Add(this.gridV_ViecLam);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label);
            this.Controls.Add(this.txtTimKiem);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UC_TrangChu_NLD";
            this.Size = new System.Drawing.Size(1030, 531);
            this.Load += new System.EventHandler(this.UC_TrangChu_NLD_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridV_ViecLam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridV_DonVi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptcBox_DonVi)).EndInit();
            this.grb_TTDonVi.ResumeLayout(false);
            this.grb_TTDonVi.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.DataGridView gridV_ViecLam;
        private System.Windows.Forms.ComboBox cbbTimkiem;
        private System.Windows.Forms.Label lblNhacNhoChonTC;
        private System.Windows.Forms.DataGridView gridV_DonVi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDiaDiem;
        private System.Windows.Forms.PictureBox ptcBox_DonVi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox grb_TTDonVi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblMucLuong;
        private System.Windows.Forms.Label lblQuyMo;
        private System.Windows.Forms.Label lblViecLam;
        private System.Windows.Forms.Label lblTenDV;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblMaDV;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblNKT;
        private System.Windows.Forms.Label lblNBD;
        private System.Windows.Forms.Button tbnNopDon;
    }
}
