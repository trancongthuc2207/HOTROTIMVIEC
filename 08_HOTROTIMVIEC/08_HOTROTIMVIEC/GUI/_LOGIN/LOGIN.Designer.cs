
namespace _08_HOTROTIMVIEC
{
    partial class LOGIN
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTK = new System.Windows.Forms.TextBox();
            this.txtMK = new System.Windows.Forms.TextBox();
            this.btnDN = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cbbKindAccount = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnDK = new System.Windows.Forms.Button();
            this.check_XemMK = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(72, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tài khoản:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(72, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mật khẩu:";
            // 
            // txtTK
            // 
            this.txtTK.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTK.Location = new System.Drawing.Point(194, 109);
            this.txtTK.Name = "txtTK";
            this.txtTK.Size = new System.Drawing.Size(174, 21);
            this.txtTK.TabIndex = 1;
            // 
            // txtMK
            // 
            this.txtMK.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMK.Location = new System.Drawing.Point(194, 149);
            this.txtMK.Name = "txtMK";
            this.txtMK.Size = new System.Drawing.Size(174, 21);
            this.txtMK.TabIndex = 2;
            this.txtMK.UseSystemPasswordChar = true;
            // 
            // btnDN
            // 
            this.btnDN.Location = new System.Drawing.Point(146, 193);
            this.btnDN.Name = "btnDN";
            this.btnDN.Size = new System.Drawing.Size(91, 23);
            this.btnDN.TabIndex = 4;
            this.btnDN.Text = "ĐĂNG NHẬP";
            this.btnDN.UseVisualStyleBackColor = true;
            this.btnDN.Click += new System.EventHandler(this.btnDN_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(30, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(465, 42);
            this.label3.TabIndex = 5;
            this.label3.Text = "HỆ THỐNG ĐĂNG NHẬP";
            // 
            // cbbKindAccount
            // 
            this.cbbKindAccount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbKindAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbKindAccount.FormattingEnabled = true;
            this.cbbKindAccount.Items.AddRange(new object[] {
            "ĐƠN VỊ TUYỂN DỤNG",
            "NGƯỜI LAO ĐỘNG",
            "ADMINISTRATION"});
            this.cbbKindAccount.Location = new System.Drawing.Point(194, 69);
            this.cbbKindAccount.Name = "cbbKindAccount";
            this.cbbKindAccount.Size = new System.Drawing.Size(174, 23);
            this.cbbKindAccount.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(169, 18);
            this.label4.TabIndex = 7;
            this.label4.Text = "Đăng nhập với quyền:";
            // 
            // btnDK
            // 
            this.btnDK.Location = new System.Drawing.Point(255, 193);
            this.btnDK.Name = "btnDK";
            this.btnDK.Size = new System.Drawing.Size(91, 24);
            this.btnDK.TabIndex = 5;
            this.btnDK.Text = "ĐĂNG KÝ";
            this.btnDK.UseVisualStyleBackColor = true;
            this.btnDK.Click += new System.EventHandler(this.btnDK_Click);
            // 
            // check_XemMK
            // 
            this.check_XemMK.AutoSize = true;
            this.check_XemMK.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.check_XemMK.Location = new System.Drawing.Point(404, 147);
            this.check_XemMK.Name = "check_XemMK";
            this.check_XemMK.Size = new System.Drawing.Size(91, 22);
            this.check_XemMK.TabIndex = 3;
            this.check_XemMK.Text = "Xem MK";
            this.check_XemMK.UseVisualStyleBackColor = true;
            this.check_XemMK.CheckedChanged += new System.EventHandler(this.check_XemMK_CheckedChanged);
            // 
            // LOGIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 243);
            this.Controls.Add(this.check_XemMK);
            this.Controls.Add(this.btnDK);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbbKindAccount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnDN);
            this.Controls.Add(this.txtMK);
            this.Controls.Add(this.txtTK);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "LOGIN";
            this.Text = "HỆ THỐNG ĐĂNG NHẬP";
            this.Load += new System.EventHandler(this.LOGIN_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTK;
        private System.Windows.Forms.TextBox txtMK;
        private System.Windows.Forms.Button btnDN;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbbKindAccount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnDK;
        private System.Windows.Forms.CheckBox check_XemMK;
    }
}

