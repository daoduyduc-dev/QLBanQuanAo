namespace QLBanQuanAo
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.chưcNăngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngNhâpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngKyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hêThôngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quanLyKhacToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngKêDoanhThuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngKêSanPhâmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chưcNăngToolStripMenuItem,
            this.hêThôngToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // chưcNăngToolStripMenuItem
            // 
            this.chưcNăngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.đăngNhâpToolStripMenuItem,
            this.đăngKyToolStripMenuItem,
            this.thoatToolStripMenuItem});
            this.chưcNăngToolStripMenuItem.Name = "chưcNăngToolStripMenuItem";
            this.chưcNăngToolStripMenuItem.Size = new System.Drawing.Size(93, 24);
            this.chưcNăngToolStripMenuItem.Text = "Chức năng";
            // 
            // đăngNhâpToolStripMenuItem
            // 
            this.đăngNhâpToolStripMenuItem.Name = "đăngNhâpToolStripMenuItem";
            this.đăngNhâpToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.đăngNhâpToolStripMenuItem.Text = "Đăng nhập";
            this.đăngNhâpToolStripMenuItem.Click += new System.EventHandler(this.đăngNhâpToolStripMenuItem_Click);
            // 
            // đăngKyToolStripMenuItem
            // 
            this.đăngKyToolStripMenuItem.Name = "đăngKyToolStripMenuItem";
            this.đăngKyToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.đăngKyToolStripMenuItem.Text = "Đăng ký";
            this.đăngKyToolStripMenuItem.Click += new System.EventHandler(this.đăngKyToolStripMenuItem_Click);
            // 
            // thoatToolStripMenuItem
            // 
            this.thoatToolStripMenuItem.Name = "thoatToolStripMenuItem";
            this.thoatToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.thoatToolStripMenuItem.Text = "Thoát";
            this.thoatToolStripMenuItem.Click += new System.EventHandler(this.thoatToolStripMenuItem_Click);
            // 
            // hêThôngToolStripMenuItem
            // 
            this.hêThôngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quanLyKhacToolStripMenuItem,
            this.thôngKêDoanhThuToolStripMenuItem,
            this.thôngKêSanPhâmToolStripMenuItem});
            this.hêThôngToolStripMenuItem.Name = "hêThôngToolStripMenuItem";
            this.hêThôngToolStripMenuItem.Size = new System.Drawing.Size(85, 24);
            this.hêThôngToolStripMenuItem.Text = "Hệ thống";
            // 
            // quanLyKhacToolStripMenuItem
            // 
            this.quanLyKhacToolStripMenuItem.Name = "quanLyKhacToolStripMenuItem";
            this.quanLyKhacToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.quanLyKhacToolStripMenuItem.Text = "Quản lý khách hàng";
            this.quanLyKhacToolStripMenuItem.Click += new System.EventHandler(this.quanLyKhacToolStripMenuItem_Click);
            // 
            // thôngKêDoanhThuToolStripMenuItem
            // 
            this.thôngKêDoanhThuToolStripMenuItem.Name = "thôngKêDoanhThuToolStripMenuItem";
            this.thôngKêDoanhThuToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.thôngKêDoanhThuToolStripMenuItem.Text = "Thống kê doanh thu";
            this.thôngKêDoanhThuToolStripMenuItem.Click += new System.EventHandler(this.thôngKêDoanhThuToolStripMenuItem_Click);
            // 
            // thôngKêSanPhâmToolStripMenuItem
            // 
            this.thôngKêSanPhâmToolStripMenuItem.Name = "thôngKêSanPhâmToolStripMenuItem";
            this.thôngKêSanPhâmToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.thôngKêSanPhâmToolStripMenuItem.Text = "Thống kê sản phẩm";
            this.thôngKêSanPhâmToolStripMenuItem.Click += new System.EventHandler(this.thôngKêSanPhâmToolStripMenuItem_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem chưcNăngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngNhâpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngKyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hêThôngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quanLyKhacToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngKêDoanhThuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngKêSanPhâmToolStripMenuItem;
    }
}

