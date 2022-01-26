
namespace HOTROTIMVIEC_08.GUI._NGUOILAODONG
{
    partial class MENU_NGUOILAODONG
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
            this.panel_main = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDoiMatKhau = new System.Windows.Forms.Button();
            this.btnThongTin = new System.Windows.Forms.Button();
            this.btnTrangChu = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_main
            // 
            this.panel_main.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel_main.Location = new System.Drawing.Point(190, 111);
            this.panel_main.Name = "panel_main";
            this.panel_main.Size = new System.Drawing.Size(1030, 531);
            this.panel_main.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox1.Controls.Add(this.btnDoiMatKhau);
            this.groupBox1.Controls.Add(this.btnThongTin);
            this.groupBox1.Controls.Add(this.btnTrangChu);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(2, 105);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(182, 537);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "CHỨC NĂNG";
            // 
            // btnDoiMatKhau
            // 
            this.btnDoiMatKhau.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDoiMatKhau.Location = new System.Drawing.Point(0, 242);
            this.btnDoiMatKhau.Name = "btnDoiMatKhau";
            this.btnDoiMatKhau.Size = new System.Drawing.Size(182, 55);
            this.btnDoiMatKhau.TabIndex = 2;
            this.btnDoiMatKhau.Text = "Tài Khoản";
            this.btnDoiMatKhau.UseVisualStyleBackColor = true;
            this.btnDoiMatKhau.Click += new System.EventHandler(this.btnDoiMatKhau_Click);
            // 
            // btnThongTin
            // 
            this.btnThongTin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThongTin.Location = new System.Drawing.Point(0, 154);
            this.btnThongTin.Name = "btnThongTin";
            this.btnThongTin.Size = new System.Drawing.Size(182, 55);
            this.btnThongTin.TabIndex = 1;
            this.btnThongTin.Text = "Thông Tin";
            this.btnThongTin.UseVisualStyleBackColor = true;
            this.btnThongTin.Click += new System.EventHandler(this.btnThongTin_Click);
            // 
            // btnTrangChu
            // 
            this.btnTrangChu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTrangChu.Location = new System.Drawing.Point(0, 63);
            this.btnTrangChu.Name = "btnTrangChu";
            this.btnTrangChu.Size = new System.Drawing.Size(182, 55);
            this.btnTrangChu.TabIndex = 0;
            this.btnTrangChu.Text = "Trang Chủ";
            this.btnTrangChu.UseVisualStyleBackColor = true;
            this.btnTrangChu.Click += new System.EventHandler(this.btnTrangChu_Click);
            // 
            // MENU_NGUOILAODONG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1232, 654);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel_main);
            this.Name = "MENU_NGUOILAODONG";
            this.Text = "MENU_NGUOILAODONG";
            this.Load += new System.EventHandler(this.MENU_NGUOILAODONG_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_main;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnTrangChu;
        private System.Windows.Forms.Button btnThongTin;
        private System.Windows.Forms.Button btnDoiMatKhau;
    }
}