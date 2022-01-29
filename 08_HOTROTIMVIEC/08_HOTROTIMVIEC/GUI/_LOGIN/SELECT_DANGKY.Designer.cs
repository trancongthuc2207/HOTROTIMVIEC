
namespace _08_HOTROTIMVIEC.GUI._LOGIN
{
    partial class SELECT_DANGKY
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
            this.btnDK_DVTD = new System.Windows.Forms.Button();
            this.btnDK_NLD = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblDangXuat = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnDK_DVTD
            // 
            this.btnDK_DVTD.BackColor = System.Drawing.Color.Transparent;
            this.btnDK_DVTD.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDK_DVTD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDK_DVTD.ForeColor = System.Drawing.Color.Indigo;
            this.btnDK_DVTD.Location = new System.Drawing.Point(76, 76);
            this.btnDK_DVTD.Name = "btnDK_DVTD";
            this.btnDK_DVTD.Size = new System.Drawing.Size(200, 129);
            this.btnDK_DVTD.TabIndex = 0;
            this.btnDK_DVTD.UseVisualStyleBackColor = false;
            // 
            // btnDK_NLD
            // 
            this.btnDK_NLD.BackColor = System.Drawing.Color.Transparent;
            this.btnDK_NLD.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDK_NLD.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDK_NLD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDK_NLD.Location = new System.Drawing.Point(366, 76);
            this.btnDK_NLD.Name = "btnDK_NLD";
            this.btnDK_NLD.Size = new System.Drawing.Size(211, 129);
            this.btnDK_NLD.TabIndex = 1;
            this.btnDK_NLD.UseVisualStyleBackColor = false;
            this.btnDK_NLD.Click += new System.EventHandler(this.btnDK_NLD_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.BlueViolet;
            this.label1.Location = new System.Drawing.Point(155, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(347, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "ĐĂNG KÝ VỚI TƯ CÁCH:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.ForeColor = System.Drawing.Color.Crimson;
            this.label2.Location = new System.Drawing.Point(48, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(245, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "ĐƠN VỊ TUYỂN DỤNG";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.ForeColor = System.Drawing.Color.Crimson;
            this.label3.Location = new System.Drawing.Point(368, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(209, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "NGƯỜI LAO ĐỘNG";
            // 
            // lblDangXuat
            // 
            this.lblDangXuat.AutoSize = true;
            this.lblDangXuat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblDangXuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDangXuat.ForeColor = System.Drawing.Color.Blue;
            this.lblDangXuat.Location = new System.Drawing.Point(12, 9);
            this.lblDangXuat.Name = "lblDangXuat";
            this.lblDangXuat.Size = new System.Drawing.Size(47, 16);
            this.lblDangXuat.TabIndex = 4;
            this.lblDangXuat.Text = "Trở về";
            this.lblDangXuat.Click += new System.EventHandler(this.lblDangXuat_Click);
            this.lblDangXuat.MouseLeave += new System.EventHandler(this.lblDangXuat_MouseLeave);
            this.lblDangXuat.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lblDangXuat_MouseMove);
            // 
            // SELECT_DANGKY
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 225);
            this.Controls.Add(this.lblDangXuat);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDK_NLD);
            this.Controls.Add(this.btnDK_DVTD);
            this.Name = "SELECT_DANGKY";
            this.Text = "SELECT_DANGKY";
            this.Load += new System.EventHandler(this.SELECT_DANGKY_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDK_DVTD;
        private System.Windows.Forms.Button btnDK_NLD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblDangXuat;
    }
}