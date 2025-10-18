namespace QLBanQuanAo.UI
{
    partial class frmSanPham
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelSanPham;
        private System.Windows.Forms.Button btnTatCa;
        private System.Windows.Forms.Button btnDoNam;
        private System.Windows.Forms.Button btnDoNu;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.flowLayoutPanelSanPham = new System.Windows.Forms.FlowLayoutPanel();
            this.btnTatCa = new System.Windows.Forms.Button();
            this.btnDoNam = new System.Windows.Forms.Button();
            this.btnDoNu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // flowLayoutPanelSanPham
            // 
            this.flowLayoutPanelSanPham.AutoScroll = true;
            this.flowLayoutPanelSanPham.Location = new System.Drawing.Point(12, 53);
            this.flowLayoutPanelSanPham.Name = "flowLayoutPanelSanPham";
            this.flowLayoutPanelSanPham.Size = new System.Drawing.Size(860, 500);
            this.flowLayoutPanelSanPham.TabIndex = 0;
            // 
            // btnTatCa
            // 
            this.btnTatCa.Location = new System.Drawing.Point(12, 12);
            this.btnTatCa.Name = "btnTatCa";
            this.btnTatCa.Size = new System.Drawing.Size(75, 35);
            this.btnTatCa.TabIndex = 1;
            this.btnTatCa.Text = "Tất cả";
            this.btnTatCa.UseVisualStyleBackColor = true;
            this.btnTatCa.Click += new System.EventHandler(this.btnTatCa_Click);
            // 
            // btnDoNam
            // 
            this.btnDoNam.Location = new System.Drawing.Point(100, 12);
            this.btnDoNam.Name = "btnDoNam";
            this.btnDoNam.Size = new System.Drawing.Size(100, 35);
            this.btnDoNam.TabIndex = 2;
            this.btnDoNam.Text = "Đồ Nam";
            this.btnDoNam.UseVisualStyleBackColor = true;
            this.btnDoNam.Click += new System.EventHandler(this.btnDoNam_Click);
            // 
            // btnDoNu
            // 
            this.btnDoNu.Location = new System.Drawing.Point(210, 12);
            this.btnDoNu.Name = "btnDoNu";
            this.btnDoNu.Size = new System.Drawing.Size(100, 35);
            this.btnDoNu.TabIndex = 3;
            this.btnDoNu.Text = "Đồ Nữ";
            this.btnDoNu.UseVisualStyleBackColor = true;
            this.btnDoNu.Click += new System.EventHandler(this.btnDoNu_Click);
            // 
            // frmSanPham
            // 
            this.ClientSize = new System.Drawing.Size(884, 581);
            this.Controls.Add(this.btnDoNu);
            this.Controls.Add(this.btnDoNam);
            this.Controls.Add(this.btnTatCa);
            this.Controls.Add(this.flowLayoutPanelSanPham);
            this.Name = "frmSanPham";
            this.Text = "Danh sách sản phẩm";
            this.Load += new System.EventHandler(this.frmSanPham_Load);
            this.ResumeLayout(false);

        }
    }
}
