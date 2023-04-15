namespace QLPhongTro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.pnlTop = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.ptbMinimize = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ptbState = new System.Windows.Forms.PictureBox();
            this.ptbExit = new System.Windows.Forms.PictureBox();
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.pnlRight = new System.Windows.Forms.Panel();
            this.pblBottom = new System.Windows.Forms.Panel();
            this.grbContent = new System.Windows.Forms.GroupBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.danhMụcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đổiMậtKhẩuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.khóaMànHìnhToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.danhMụcToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.loaiPhongToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.phongToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dichVuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tácVụToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thuêPhòngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trảPhòngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.phòngĐangThuêToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.phòngTrốngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tiềnĐiệnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tiềnNướcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doanhThuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.phiênBảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bảnQuyềnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.liênHệToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbState)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbExit)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.PaleVioletRed;
            this.pnlTop.Controls.Add(this.label1);
            this.pnlTop.Controls.Add(this.ptbMinimize);
            this.pnlTop.Controls.Add(this.pictureBox1);
            this.pnlTop.Controls.Add(this.ptbState);
            this.pnlTop.Controls.Add(this.ptbExit);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Margin = new System.Windows.Forms.Padding(4);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(1188, 37);
            this.pnlTop.TabIndex = 0;
            this.pnlTop.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlTop_Paint);
            this.pnlTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlTop_MouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(63, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(285, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "ỨNG DỤNG QUẢN LÝ NHÀ TRỌ ";
            // 
            // ptbMinimize
            // 
            this.ptbMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ptbMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptbMinimize.Image = global::QLPhongTro.Properties.Resources.minimazar;
            this.ptbMinimize.Location = new System.Drawing.Point(1079, 9);
            this.ptbMinimize.Margin = new System.Windows.Forms.Padding(4);
            this.ptbMinimize.Name = "ptbMinimize";
            this.ptbMinimize.Size = new System.Drawing.Size(27, 25);
            this.ptbMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbMinimize.TabIndex = 0;
            this.ptbMinimize.TabStop = false;
            this.ptbMinimize.Click += new System.EventHandler(this.ptbMinimize_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox1.Image = global::QLPhongTro.Properties.Resources.ctut;
            this.pictureBox1.Location = new System.Drawing.Point(11, 2);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(36, 33);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.ptbState_Click);
            // 
            // ptbState
            // 
            this.ptbState.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ptbState.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptbState.Image = global::QLPhongTro.Properties.Resources.maxi;
            this.ptbState.Location = new System.Drawing.Point(1113, 9);
            this.ptbState.Margin = new System.Windows.Forms.Padding(4);
            this.ptbState.Name = "ptbState";
            this.ptbState.Size = new System.Drawing.Size(27, 25);
            this.ptbState.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbState.TabIndex = 0;
            this.ptbState.TabStop = false;
            this.ptbState.Click += new System.EventHandler(this.ptbState_Click);
            // 
            // ptbExit
            // 
            this.ptbExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ptbExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptbExit.Image = global::QLPhongTro.Properties.Resources.close;
            this.ptbExit.Location = new System.Drawing.Point(1145, 9);
            this.ptbExit.Margin = new System.Windows.Forms.Padding(4);
            this.ptbExit.Name = "ptbExit";
            this.ptbExit.Size = new System.Drawing.Size(27, 25);
            this.ptbExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbExit.TabIndex = 0;
            this.ptbExit.TabStop = false;
            this.ptbExit.Click += new System.EventHandler(this.ptbExit_Click);
            // 
            // pnlLeft
            // 
            this.pnlLeft.BackColor = System.Drawing.Color.Snow;
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft.Location = new System.Drawing.Point(0, 37);
            this.pnlLeft.Margin = new System.Windows.Forms.Padding(4);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(13, 558);
            this.pnlLeft.TabIndex = 0;
            this.pnlLeft.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlLeft_Paint);
            // 
            // pnlRight
            // 
            this.pnlRight.BackColor = System.Drawing.Color.Snow;
            this.pnlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlRight.Location = new System.Drawing.Point(1175, 37);
            this.pnlRight.Margin = new System.Windows.Forms.Padding(4);
            this.pnlRight.Name = "pnlRight";
            this.pnlRight.Size = new System.Drawing.Size(13, 558);
            this.pnlRight.TabIndex = 0;
            this.pnlRight.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlRight_Paint);
            // 
            // pblBottom
            // 
            this.pblBottom.BackColor = System.Drawing.Color.Snow;
            this.pblBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pblBottom.Location = new System.Drawing.Point(0, 595);
            this.pblBottom.Margin = new System.Windows.Forms.Padding(4);
            this.pblBottom.Name = "pblBottom";
            this.pblBottom.Size = new System.Drawing.Size(1188, 12);
            this.pblBottom.TabIndex = 0;
            this.pblBottom.Paint += new System.Windows.Forms.PaintEventHandler(this.pblBottom_Paint);
            // 
            // grbContent
            // 
            this.grbContent.BackColor = System.Drawing.Color.Snow;
            this.grbContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grbContent.Location = new System.Drawing.Point(13, 65);
            this.grbContent.Margin = new System.Windows.Forms.Padding(4);
            this.grbContent.Name = "grbContent";
            this.grbContent.Padding = new System.Windows.Forms.Padding(4);
            this.grbContent.Size = new System.Drawing.Size(1162, 530);
            this.grbContent.TabIndex = 1;
            this.grbContent.TabStop = false;
            this.grbContent.Enter += new System.EventHandler(this.grbContent_Enter);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Pink;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.danhMụcToolStripMenuItem,
            this.danhMụcToolStripMenuItem1,
            this.tácVụToolStripMenuItem,
            this.hToolStripMenuItem,
            this.thToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(13, 37);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1162, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // danhMụcToolStripMenuItem
            // 
            this.danhMụcToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.đổiMậtKhẩuToolStripMenuItem,
            this.khóaMànHìnhToolStripMenuItem,
            this.thoátToolStripMenuItem,
            this.thoátToolStripMenuItem1});
            this.danhMụcToolStripMenuItem.Name = "danhMụcToolStripMenuItem";
            this.danhMụcToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
            this.danhMụcToolStripMenuItem.Text = "Hệ thống";
            // 
            // đổiMậtKhẩuToolStripMenuItem
            // 
            this.đổiMậtKhẩuToolStripMenuItem.Name = "đổiMậtKhẩuToolStripMenuItem";
            this.đổiMậtKhẩuToolStripMenuItem.Size = new System.Drawing.Size(183, 26);
            this.đổiMậtKhẩuToolStripMenuItem.Text = "Đổi mật khẩu";
            // 
            // khóaMànHìnhToolStripMenuItem
            // 
            this.khóaMànHìnhToolStripMenuItem.Name = "khóaMànHìnhToolStripMenuItem";
            this.khóaMànHìnhToolStripMenuItem.Size = new System.Drawing.Size(183, 26);
            this.khóaMànHìnhToolStripMenuItem.Text = "Khóa màn hình";
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(183, 26);
            this.thoátToolStripMenuItem.Text = "Cấu hình";
            // 
            // thoátToolStripMenuItem1
            // 
            this.thoátToolStripMenuItem1.Name = "thoátToolStripMenuItem1";
            this.thoátToolStripMenuItem1.Size = new System.Drawing.Size(183, 26);
            this.thoátToolStripMenuItem1.Text = "Thoát";
            // 
            // danhMụcToolStripMenuItem1
            // 
            this.danhMụcToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loaiPhongToolStripMenuItem,
            this.phongToolStripMenuItem,
            this.dichVuToolStripMenuItem});
            this.danhMụcToolStripMenuItem1.Name = "danhMụcToolStripMenuItem1";
            this.danhMụcToolStripMenuItem1.Size = new System.Drawing.Size(88, 24);
            this.danhMụcToolStripMenuItem1.Text = "Danh mục";
            // 
            // loaiPhongToolStripMenuItem
            // 
            this.loaiPhongToolStripMenuItem.Name = "loaiPhongToolStripMenuItem";
            this.loaiPhongToolStripMenuItem.Size = new System.Drawing.Size(159, 26);
            this.loaiPhongToolStripMenuItem.Text = "Loại phòng";
            this.loaiPhongToolStripMenuItem.Click += new System.EventHandler(this.loaiPhongToolStripMenuItem_Click);
            // 
            // phongToolStripMenuItem
            // 
            this.phongToolStripMenuItem.Name = "phongToolStripMenuItem";
            this.phongToolStripMenuItem.Size = new System.Drawing.Size(159, 26);
            this.phongToolStripMenuItem.Text = "Phòng";
            this.phongToolStripMenuItem.Click += new System.EventHandler(this.phongToolStripMenuItem_Click);
            // 
            // dichVuToolStripMenuItem
            // 
            this.dichVuToolStripMenuItem.Name = "dichVuToolStripMenuItem";
            this.dichVuToolStripMenuItem.Size = new System.Drawing.Size(159, 26);
            this.dichVuToolStripMenuItem.Text = "Dịch vụ";
            this.dichVuToolStripMenuItem.Click += new System.EventHandler(this.dichVuToolStripMenuItem_Click);
            // 
            // tácVụToolStripMenuItem
            // 
            this.tácVụToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thuêPhòngToolStripMenuItem,
            this.trảPhòngToolStripMenuItem});
            this.tácVụToolStripMenuItem.Name = "tácVụToolStripMenuItem";
            this.tácVụToolStripMenuItem.Size = new System.Drawing.Size(61, 24);
            this.tácVụToolStripMenuItem.Text = "Tác vụ";
            // 
            // thuêPhòngToolStripMenuItem
            // 
            this.thuêPhòngToolStripMenuItem.Name = "thuêPhòngToolStripMenuItem";
            this.thuêPhòngToolStripMenuItem.Size = new System.Drawing.Size(163, 26);
            this.thuêPhòngToolStripMenuItem.Text = "Thuê phòng";
            this.thuêPhòngToolStripMenuItem.Click += new System.EventHandler(this.thuêPhòngToolStripMenuItem_Click);
            // 
            // trảPhòngToolStripMenuItem
            // 
            this.trảPhòngToolStripMenuItem.Name = "trảPhòngToolStripMenuItem";
            this.trảPhòngToolStripMenuItem.Size = new System.Drawing.Size(163, 26);
            this.trảPhòngToolStripMenuItem.Text = "Trả phòng";
            // 
            // hToolStripMenuItem
            // 
            this.hToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.phòngĐangThuêToolStripMenuItem,
            this.phòngTrốngToolStripMenuItem,
            this.tiềnĐiệnToolStripMenuItem,
            this.tiềnNướcToolStripMenuItem,
            this.doanhThuToolStripMenuItem});
            this.hToolStripMenuItem.Name = "hToolStripMenuItem";
            this.hToolStripMenuItem.Size = new System.Drawing.Size(82, 24);
            this.hToolStripMenuItem.Text = "Thống kê";
            // 
            // phòngĐangThuêToolStripMenuItem
            // 
            this.phòngĐangThuêToolStripMenuItem.Name = "phòngĐangThuêToolStripMenuItem";
            this.phòngĐangThuêToolStripMenuItem.Size = new System.Drawing.Size(197, 26);
            this.phòngĐangThuêToolStripMenuItem.Text = "Phòng đang thuê";
            // 
            // phòngTrốngToolStripMenuItem
            // 
            this.phòngTrốngToolStripMenuItem.Name = "phòngTrốngToolStripMenuItem";
            this.phòngTrốngToolStripMenuItem.Size = new System.Drawing.Size(197, 26);
            this.phòngTrốngToolStripMenuItem.Text = "Phòng trống";
            // 
            // tiềnĐiệnToolStripMenuItem
            // 
            this.tiềnĐiệnToolStripMenuItem.Name = "tiềnĐiệnToolStripMenuItem";
            this.tiềnĐiệnToolStripMenuItem.Size = new System.Drawing.Size(197, 26);
            this.tiềnĐiệnToolStripMenuItem.Text = "Tiền điện";
            // 
            // tiềnNướcToolStripMenuItem
            // 
            this.tiềnNướcToolStripMenuItem.Name = "tiềnNướcToolStripMenuItem";
            this.tiềnNướcToolStripMenuItem.Size = new System.Drawing.Size(197, 26);
            this.tiềnNướcToolStripMenuItem.Text = "Tiền nước";
            // 
            // doanhThuToolStripMenuItem
            // 
            this.doanhThuToolStripMenuItem.Name = "doanhThuToolStripMenuItem";
            this.doanhThuToolStripMenuItem.Size = new System.Drawing.Size(197, 26);
            this.doanhThuToolStripMenuItem.Text = "Doanh thu";
            // 
            // thToolStripMenuItem
            // 
            this.thToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.phiênBảnToolStripMenuItem,
            this.bảnQuyềnToolStripMenuItem,
            this.liênHệToolStripMenuItem});
            this.thToolStripMenuItem.Name = "thToolStripMenuItem";
            this.thToolStripMenuItem.Size = new System.Drawing.Size(84, 24);
            this.thToolStripMenuItem.Text = "Thông tin";
            // 
            // phiênBảnToolStripMenuItem
            // 
            this.phiênBảnToolStripMenuItem.Name = "phiênBảnToolStripMenuItem";
            this.phiênBảnToolStripMenuItem.Size = new System.Drawing.Size(153, 26);
            this.phiênBảnToolStripMenuItem.Text = "Phiên bản";
            // 
            // bảnQuyềnToolStripMenuItem
            // 
            this.bảnQuyềnToolStripMenuItem.Name = "bảnQuyềnToolStripMenuItem";
            this.bảnQuyềnToolStripMenuItem.Size = new System.Drawing.Size(153, 26);
            this.bảnQuyềnToolStripMenuItem.Text = "Bản quyền";
            // 
            // liênHệToolStripMenuItem
            // 
            this.liênHệToolStripMenuItem.Name = "liênHệToolStripMenuItem";
            this.liênHệToolStripMenuItem.Size = new System.Drawing.Size(153, 26);
            this.liênHệToolStripMenuItem.Text = "Liên hệ";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(1188, 607);
            this.Controls.Add(this.grbContent);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pnlRight);
            this.Controls.Add(this.pnlLeft);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.pblBottom);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phần mềm quản lý phòng trọ";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbState)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbExit)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.Panel pnlRight;
        private System.Windows.Forms.Panel pblBottom;
        private System.Windows.Forms.GroupBox grbContent;
        private System.Windows.Forms.PictureBox ptbMinimize;
        private System.Windows.Forms.PictureBox ptbState;
        private System.Windows.Forms.PictureBox ptbExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem danhMụcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đổiMậtKhẩuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem khóaMànHìnhToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem danhMụcToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem loaiPhongToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem phongToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dichVuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tácVụToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thuêPhòngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trảPhòngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem phòngĐangThuêToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem phòngTrốngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tiềnĐiệnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tiềnNướcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem doanhThuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem phiênBảnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bảnQuyềnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem liênHệToolStripMenuItem;
    }
}

