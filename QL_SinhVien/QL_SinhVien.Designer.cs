namespace QL_SinhVien
{
    partial class frmMain
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
            this.mnuQuanLySV = new System.Windows.Forms.MenuStrip();
            this.mnuDuLieu = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuLop = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSinhVien = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMonHoc = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuThongTinDangNhap = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCapNhat = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuChonHKNK = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuKetQuaHT = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTienIch = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDangNhap = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuThoatDangNhap = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuGioiThieu = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuThoat = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDoiMK = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuQuanLySV.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuQuanLySV
            // 
            this.mnuQuanLySV.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuQuanLySV.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnuQuanLySV.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuDuLieu,
            this.mnuCapNhat,
            this.mnuTienIch});
            this.mnuQuanLySV.Location = new System.Drawing.Point(0, 0);
            this.mnuQuanLySV.Name = "mnuQuanLySV";
            this.mnuQuanLySV.Size = new System.Drawing.Size(586, 30);
            this.mnuQuanLySV.TabIndex = 1;
            this.mnuQuanLySV.Text = "menuStrip1";
            // 
            // mnuDuLieu
            // 
            this.mnuDuLieu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuLop,
            this.mnuSinhVien,
            this.mnuMonHoc,
            this.toolStripMenuItem2,
            this.mnuThongTinDangNhap});
            this.mnuDuLieu.Name = "mnuDuLieu";
            this.mnuDuLieu.Size = new System.Drawing.Size(83, 26);
            this.mnuDuLieu.Text = "Dữ liệu";
            // 
            // mnuLop
            // 
            this.mnuLop.Name = "mnuLop";
            this.mnuLop.Size = new System.Drawing.Size(263, 26);
            this.mnuLop.Text = "Lớp";
            this.mnuLop.Click += new System.EventHandler(this.mnuLop_Click);
            // 
            // mnuSinhVien
            // 
            this.mnuSinhVien.Name = "mnuSinhVien";
            this.mnuSinhVien.Size = new System.Drawing.Size(263, 26);
            this.mnuSinhVien.Text = "Sinh Viên";
            this.mnuSinhVien.Click += new System.EventHandler(this.mnuSinhVien_Click);
            // 
            // mnuMonHoc
            // 
            this.mnuMonHoc.Name = "mnuMonHoc";
            this.mnuMonHoc.Size = new System.Drawing.Size(263, 26);
            this.mnuMonHoc.Text = "Môn học";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(260, 6);
            // 
            // mnuThongTinDangNhap
            // 
            this.mnuThongTinDangNhap.Name = "mnuThongTinDangNhap";
            this.mnuThongTinDangNhap.Size = new System.Drawing.Size(263, 26);
            this.mnuThongTinDangNhap.Text = "Thông tin đăng nhập";
            this.mnuThongTinDangNhap.Click += new System.EventHandler(this.mnuThongTinDangNhap_Click);
            // 
            // mnuCapNhat
            // 
            this.mnuCapNhat.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuChonHKNK,
            this.mnuKetQuaHT});
            this.mnuCapNhat.Name = "mnuCapNhat";
            this.mnuCapNhat.Size = new System.Drawing.Size(99, 26);
            this.mnuCapNhat.Text = "Cập nhật";
            // 
            // mnuChonHKNK
            // 
            this.mnuChonHKNK.Name = "mnuChonHKNK";
            this.mnuChonHKNK.Size = new System.Drawing.Size(223, 26);
            this.mnuChonHKNK.Text = "Chọn học kỳ";
            // 
            // mnuKetQuaHT
            // 
            this.mnuKetQuaHT.Name = "mnuKetQuaHT";
            this.mnuKetQuaHT.Size = new System.Drawing.Size(223, 26);
            this.mnuKetQuaHT.Text = "Kết quả học tập";
            // 
            // mnuTienIch
            // 
            this.mnuTienIch.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuDangNhap,
            this.mnuThoatDangNhap,
            this.toolStripMenuItem1,
            this.mnuGioiThieu,
            this.mnuDoiMK,
            this.mnuThoat});
            this.mnuTienIch.Name = "mnuTienIch";
            this.mnuTienIch.Size = new System.Drawing.Size(90, 26);
            this.mnuTienIch.Text = "Tiện ích";
            // 
            // mnuDangNhap
            // 
            this.mnuDangNhap.Name = "mnuDangNhap";
            this.mnuDangNhap.Size = new System.Drawing.Size(233, 26);
            this.mnuDangNhap.Text = "Đăng nhập ";
            this.mnuDangNhap.Click += new System.EventHandler(this.mnuDangNhap_Click);
            // 
            // mnuThoatDangNhap
            // 
            this.mnuThoatDangNhap.Name = "mnuThoatDangNhap";
            this.mnuThoatDangNhap.Size = new System.Drawing.Size(233, 26);
            this.mnuThoatDangNhap.Text = "Thoát đăng nhập";
            this.mnuThoatDangNhap.Click += new System.EventHandler(this.mnuThoatDangNhap_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(230, 6);
            // 
            // mnuGioiThieu
            // 
            this.mnuGioiThieu.Name = "mnuGioiThieu";
            this.mnuGioiThieu.Size = new System.Drawing.Size(233, 26);
            this.mnuGioiThieu.Text = "Giới thiệu";
            this.mnuGioiThieu.Click += new System.EventHandler(this.mnuGioiThieu_Click);
            // 
            // mnuThoat
            // 
            this.mnuThoat.Name = "mnuThoat";
            this.mnuThoat.Size = new System.Drawing.Size(233, 26);
            this.mnuThoat.Text = "Thoát";
            this.mnuThoat.Click += new System.EventHandler(this.mnuThoat_Click);
            // 
            // mnuDoiMK
            // 
            this.mnuDoiMK.Name = "mnuDoiMK";
            this.mnuDoiMK.Size = new System.Drawing.Size(233, 26);
            this.mnuDoiMK.Text = "Đổi mật khẩu";
            this.mnuDoiMK.Click += new System.EventHandler(this.mnuDoiMK_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QL_SinhVien.Properties.Resources.helloworlddddd;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(586, 373);
            this.Controls.Add(this.mnuQuanLySV);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mnuQuanLySV;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý sinh viên";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.mnuQuanLySV.ResumeLayout(false);
            this.mnuQuanLySV.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuQuanLySV;
        private System.Windows.Forms.ToolStripMenuItem mnuLop;
        private System.Windows.Forms.ToolStripMenuItem mnuSinhVien;
        private System.Windows.Forms.ToolStripMenuItem mnuMonHoc;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem mnuThongTinDangNhap;
        private System.Windows.Forms.ToolStripMenuItem mnuChonHKNK;
        private System.Windows.Forms.ToolStripMenuItem mnuKetQuaHT;
        private System.Windows.Forms.ToolStripMenuItem mnuTienIch;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mnuGioiThieu;
        private System.Windows.Forms.ToolStripMenuItem mnuThoat;
        public System.Windows.Forms.ToolStripMenuItem mnuCapNhat;
        public System.Windows.Forms.ToolStripMenuItem mnuDangNhap;
        public System.Windows.Forms.ToolStripMenuItem mnuThoatDangNhap;
        public System.Windows.Forms.ToolStripMenuItem mnuDuLieu;
        private System.Windows.Forms.ToolStripMenuItem mnuDoiMK;
    }
}

