namespace LibraryManagementSoftware
{
    partial class fLibrarian
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.taiKhoanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinTaiKhoanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đôiMâtKhâuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.danhMucToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quanLySachToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quanLyBanĐocToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quanLyMươnTraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.taiKhoanToolStripMenuItem,
            this.danhMucToolStripMenuItem,
            this.thoatToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1070, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // taiKhoanToolStripMenuItem
            // 
            this.taiKhoanToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thôngTinTaiKhoanToolStripMenuItem,
            this.đôiMâtKhâuToolStripMenuItem});
            this.taiKhoanToolStripMenuItem.Name = "taiKhoanToolStripMenuItem";
            this.taiKhoanToolStripMenuItem.Size = new System.Drawing.Size(85, 24);
            this.taiKhoanToolStripMenuItem.Text = "Tài khoản";
            // 
            // thôngTinTaiKhoanToolStripMenuItem
            // 
            this.thôngTinTaiKhoanToolStripMenuItem.Name = "thôngTinTaiKhoanToolStripMenuItem";
            this.thôngTinTaiKhoanToolStripMenuItem.Size = new System.Drawing.Size(220, 26);
            this.thôngTinTaiKhoanToolStripMenuItem.Text = "Thông tin tài khoản";
            this.thôngTinTaiKhoanToolStripMenuItem.Click += new System.EventHandler(this.thôngTinTaiKhoanToolStripMenuItem_Click);
            // 
            // đôiMâtKhâuToolStripMenuItem
            // 
            this.đôiMâtKhâuToolStripMenuItem.Name = "đôiMâtKhâuToolStripMenuItem";
            this.đôiMâtKhâuToolStripMenuItem.Size = new System.Drawing.Size(220, 26);
            this.đôiMâtKhâuToolStripMenuItem.Text = "Đổi mật khẩu";
            this.đôiMâtKhâuToolStripMenuItem.Click += new System.EventHandler(this.đôiMâtKhâuToolStripMenuItem_Click);
            // 
            // danhMucToolStripMenuItem
            // 
            this.danhMucToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quanLySachToolStripMenuItem,
            this.quanLyBanĐocToolStripMenuItem,
            this.quanLyMươnTraToolStripMenuItem});
            this.danhMucToolStripMenuItem.Name = "danhMucToolStripMenuItem";
            this.danhMucToolStripMenuItem.Size = new System.Drawing.Size(90, 24);
            this.danhMucToolStripMenuItem.Text = "Danh mục";
            // 
            // quanLySachToolStripMenuItem
            // 
            this.quanLySachToolStripMenuItem.Name = "quanLySachToolStripMenuItem";
            this.quanLySachToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.quanLySachToolStripMenuItem.Text = "Quản lý sách";
            this.quanLySachToolStripMenuItem.Click += new System.EventHandler(this.quanLySachToolStripMenuItem_Click);
            // 
            // quanLyBanĐocToolStripMenuItem
            // 
            this.quanLyBanĐocToolStripMenuItem.Name = "quanLyBanĐocToolStripMenuItem";
            this.quanLyBanĐocToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.quanLyBanĐocToolStripMenuItem.Text = "Quản lý bạn đọc";
            this.quanLyBanĐocToolStripMenuItem.Click += new System.EventHandler(this.quanLyBanĐocToolStripMenuItem_Click);
            // 
            // quanLyMươnTraToolStripMenuItem
            // 
            this.quanLyMươnTraToolStripMenuItem.Name = "quanLyMươnTraToolStripMenuItem";
            this.quanLyMươnTraToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.quanLyMươnTraToolStripMenuItem.Text = "Quản lý mượn trả";
            this.quanLyMươnTraToolStripMenuItem.Click += new System.EventHandler(this.quanLyMươnTraToolStripMenuItem_Click);
            // 
            // thoatToolStripMenuItem
            // 
            this.thoatToolStripMenuItem.Name = "thoatToolStripMenuItem";
            this.thoatToolStripMenuItem.Size = new System.Drawing.Size(91, 24);
            this.thoatToolStripMenuItem.Text = "Đăng xuất";
            this.thoatToolStripMenuItem.Click += new System.EventHandler(this.thoatToolStripMenuItem_Click);
            // 
            // fLibrarian
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1070, 617);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "fLibrarian";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Quản lý thư viện";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem taiKhoanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinTaiKhoanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đôiMâtKhâuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem danhMucToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quanLySachToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quanLyBanĐocToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quanLyMươnTraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoatToolStripMenuItem;
    }
}