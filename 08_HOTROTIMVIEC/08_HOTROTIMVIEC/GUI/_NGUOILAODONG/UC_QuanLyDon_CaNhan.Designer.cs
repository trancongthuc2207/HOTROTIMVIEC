
namespace _08_HOTROTIMVIEC.GUI._NGUOILAODONG
{
    partial class UC_QuanLyDon_CaNhan
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
            this.cbbKind = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.cbbTrangThai = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gridV_DonTD = new System.Windows.Forms.DataGridView();
            this.btnXoaDon = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridV_DonTD)).BeginInit();
            this.SuspendLayout();
            // 
            // cbbKind
            // 
            this.cbbKind.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbKind.FormattingEnabled = true;
            this.cbbKind.Items.AddRange(new object[] {
            "Mặc định",
            "Ngày xa nhất",
            "Ngày gần nhất"});
            this.cbbKind.Location = new System.Drawing.Point(613, 22);
            this.cbbKind.Name = "cbbKind";
            this.cbbKind.Size = new System.Drawing.Size(121, 23);
            this.cbbKind.TabIndex = 7;
            this.cbbKind.SelectedIndexChanged += new System.EventHandler(this.cbbKind_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(553, 30);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tiêu chí:";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(29, 30);
            this.label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(105, 15);
            this.label.TabIndex = 6;
            this.label.Text = "Tìm kiếm tên việc:";
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(138, 25);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(4);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(396, 21);
            this.txtTimKiem.TabIndex = 4;
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
            // 
            // cbbTrangThai
            // 
            this.cbbTrangThai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbTrangThai.FormattingEnabled = true;
            this.cbbTrangThai.Items.AddRange(new object[] {
            "Bị từ chối",
            "Đang chờ xử lý",
            "Được chấp nhận"});
            this.cbbTrangThai.Location = new System.Drawing.Point(834, 22);
            this.cbbTrangThai.Name = "cbbTrangThai";
            this.cbbTrangThai.Size = new System.Drawing.Size(121, 23);
            this.cbbTrangThai.TabIndex = 7;
            this.cbbTrangThai.SelectedIndexChanged += new System.EventHandler(this.cbbTrangThai_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(741, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Trạng thái đơn";
            // 
            // gridV_DonTD
            // 
            this.gridV_DonTD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridV_DonTD.Location = new System.Drawing.Point(32, 76);
            this.gridV_DonTD.MultiSelect = false;
            this.gridV_DonTD.Name = "gridV_DonTD";
            this.gridV_DonTD.ReadOnly = true;
            this.gridV_DonTD.Size = new System.Drawing.Size(923, 336);
            this.gridV_DonTD.TabIndex = 8;
            this.gridV_DonTD.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridV_DonTD_CellClick);
            // 
            // btnXoaDon
            // 
            this.btnXoaDon.Location = new System.Drawing.Point(613, 450);
            this.btnXoaDon.Name = "btnXoaDon";
            this.btnXoaDon.Size = new System.Drawing.Size(101, 37);
            this.btnXoaDon.TabIndex = 9;
            this.btnXoaDon.Text = "Xoá Đơn";
            this.btnXoaDon.UseVisualStyleBackColor = true;
            this.btnXoaDon.Click += new System.EventHandler(this.btnXoaDon_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(744, 450);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(101, 37);
            this.btnRefresh.TabIndex = 10;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // UC_QuanLyDon_CaNhan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnXoaDon);
            this.Controls.Add(this.gridV_DonTD);
            this.Controls.Add(this.cbbTrangThai);
            this.Controls.Add(this.cbbKind);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label);
            this.Controls.Add(this.txtTimKiem);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Name = "UC_QuanLyDon_CaNhan";
            this.Size = new System.Drawing.Size(1030, 531);
            this.Load += new System.EventHandler(this.UC_QuanLyDon_CaNhan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridV_DonTD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbbKind;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.ComboBox cbbTrangThai;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView gridV_DonTD;
        private System.Windows.Forms.Button btnXoaDon;
        private System.Windows.Forms.Button btnRefresh;
    }
}
