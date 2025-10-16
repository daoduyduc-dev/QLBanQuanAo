namespace QLBanQuanAo.UI
{
    partial class frmChiTietSanPham
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.PictureBox picSanPham;
        private System.Windows.Forms.Label lblTenSP;
        private System.Windows.Forms.Label lblGia;
        private System.Windows.Forms.Label lblMoTa;
        private System.Windows.Forms.Label lblSoLuong;
        private System.Windows.Forms.Button btnMuaHang;
        private System.Windows.Forms.NumericUpDown nudSoLuong;
        private System.Windows.Forms.Label lblChonSoLuong;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTenSP = new System.Windows.Forms.Label();
            this.lblGia = new System.Windows.Forms.Label();
            this.lblMoTa = new System.Windows.Forms.Label();
            this.lblSoLuong = new System.Windows.Forms.Label();
            this.btnMuaHang = new System.Windows.Forms.Button();
            this.nudSoLuong = new System.Windows.Forms.NumericUpDown();
            this.lblChonSoLuong = new System.Windows.Forms.Label();
            this.picSanPham = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSanPham)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTenSP
            // 
            this.lblTenSP.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTenSP.Location = new System.Drawing.Point(320, 30);
            this.lblTenSP.Name = "lblTenSP";
            this.lblTenSP.Size = new System.Drawing.Size(400, 40);
            this.lblTenSP.TabIndex = 1;
            // 
            // lblGia
            // 
            this.lblGia.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblGia.ForeColor = System.Drawing.Color.Red;
            this.lblGia.Location = new System.Drawing.Point(320, 80);
            this.lblGia.Name = "lblGia";
            this.lblGia.Size = new System.Drawing.Size(300, 30);
            this.lblGia.TabIndex = 2;
            // 
            // lblMoTa
            // 
            this.lblMoTa.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblMoTa.Location = new System.Drawing.Point(320, 120);
            this.lblMoTa.Name = "lblMoTa";
            this.lblMoTa.Size = new System.Drawing.Size(400, 100);
            this.lblMoTa.TabIndex = 3;
            // 
            // lblSoLuong
            // 
            this.lblSoLuong.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Italic);
            this.lblSoLuong.Location = new System.Drawing.Point(320, 230);
            this.lblSoLuong.Name = "lblSoLuong";
            this.lblSoLuong.Size = new System.Drawing.Size(200, 25);
            this.lblSoLuong.TabIndex = 4;
            // 
            // btnMuaHang
            // 
            this.btnMuaHang.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnMuaHang.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnMuaHang.ForeColor = System.Drawing.Color.White;
            this.btnMuaHang.Location = new System.Drawing.Point(320, 300);
            this.btnMuaHang.Name = "btnMuaHang";
            this.btnMuaHang.Size = new System.Drawing.Size(120, 40);
            this.btnMuaHang.TabIndex = 7;
            this.btnMuaHang.Text = "Mua hàng";
            this.btnMuaHang.UseVisualStyleBackColor = false;
            this.btnMuaHang.Click += new System.EventHandler(this.btnMuaHang_Click);
            // 
            // nudSoLuong
            // 
            this.nudSoLuong.Location = new System.Drawing.Point(477, 263);
            this.nudSoLuong.Name = "nudSoLuong";
            this.nudSoLuong.Size = new System.Drawing.Size(60, 22);
            this.nudSoLuong.TabIndex = 6;
            this.nudSoLuong.ValueChanged += new System.EventHandler(this.nudSoLuong_ValueChanged);
            // 
            // lblChonSoLuong
            // 
            this.lblChonSoLuong.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblChonSoLuong.Location = new System.Drawing.Point(320, 260);
            this.lblChonSoLuong.Name = "lblChonSoLuong";
            this.lblChonSoLuong.Size = new System.Drawing.Size(151, 25);
            this.lblChonSoLuong.TabIndex = 5;
            this.lblChonSoLuong.Text = "Chọn số lượng:";
            // 
            // picSanPham
            // 
            this.picSanPham.Location = new System.Drawing.Point(40, 30);
            this.picSanPham.Name = "picSanPham";
            this.picSanPham.Size = new System.Drawing.Size(250, 250);
            this.picSanPham.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picSanPham.TabIndex = 0;
            this.picSanPham.TabStop = false;
            // 
            // frmChiTietSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 370);
            this.Controls.Add(this.picSanPham);
            this.Controls.Add(this.lblTenSP);
            this.Controls.Add(this.lblGia);
            this.Controls.Add(this.lblMoTa);
            this.Controls.Add(this.lblSoLuong);
            this.Controls.Add(this.lblChonSoLuong);
            this.Controls.Add(this.nudSoLuong);
            this.Controls.Add(this.btnMuaHang);
            this.Name = "frmChiTietSanPham";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chi tiết sản phẩm";
            this.Load += new System.EventHandler(this.frmChiTietSanPham_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSanPham)).EndInit();
            this.ResumeLayout(false);

        }
    }
}
