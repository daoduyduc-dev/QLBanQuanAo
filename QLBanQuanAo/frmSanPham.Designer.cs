namespace QLBanQuanAo.UI
{
    partial class frmSanPham
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        // Khai báo các Controls cần thiết
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelSanPham;
        private System.Windows.Forms.Panel panelTopControls;
        private System.Windows.Forms.Button btnTatCa;
        private System.Windows.Forms.Button btnDoNam;
        private System.Windows.Forms.Button btnDoNu;

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
            this.flowLayoutPanelSanPham = new System.Windows.Forms.FlowLayoutPanel();
            this.panelTopControls = new System.Windows.Forms.Panel();
            this.btnDoNu = new System.Windows.Forms.Button();
            this.btnDoNam = new System.Windows.Forms.Button();
            this.btnTatCa = new System.Windows.Forms.Button();
            this.panelTopControls.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanelSanPham
            // 
            this.flowLayoutPanelSanPham.AutoScroll = true;
            this.flowLayoutPanelSanPham.BackColor = System.Drawing.SystemColors.ControlLight;
            this.flowLayoutPanelSanPham.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelSanPham.Location = new System.Drawing.Point(0, 70);
            this.flowLayoutPanelSanPham.Name = "flowLayoutPanelSanPham";
            this.flowLayoutPanelSanPham.Padding = new System.Windows.Forms.Padding(10);
            this.flowLayoutPanelSanPham.Size = new System.Drawing.Size(1173, 602);
            this.flowLayoutPanelSanPham.TabIndex = 0;
            // 
            // panelTopControls
            // 
            this.panelTopControls.Controls.Add(this.btnDoNu);
            this.panelTopControls.Controls.Add(this.btnDoNam);
            this.panelTopControls.Controls.Add(this.btnTatCa);
            this.panelTopControls.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTopControls.Location = new System.Drawing.Point(0, 0);
            this.panelTopControls.Name = "panelTopControls";
            this.panelTopControls.Size = new System.Drawing.Size(1173, 70);
            this.panelTopControls.TabIndex = 1;
            // 
            // btnDoNu
            // 
            this.btnDoNu.BackColor = System.Drawing.Color.LightCoral;
            this.btnDoNu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDoNu.FlatAppearance.BorderSize = 0;
            this.btnDoNu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDoNu.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoNu.ForeColor = System.Drawing.Color.White;
            this.btnDoNu.Location = new System.Drawing.Point(395, 12);
            this.btnDoNu.Name = "btnDoNu";
            this.btnDoNu.Size = new System.Drawing.Size(120, 45);
            this.btnDoNu.TabIndex = 2;
            this.btnDoNu.Text = "Đồ Nữ";
            this.btnDoNu.UseVisualStyleBackColor = false;
            // 
            // btnDoNam
            // 
            this.btnDoNam.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnDoNam.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDoNam.FlatAppearance.BorderSize = 0;
            this.btnDoNam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDoNam.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoNam.ForeColor = System.Drawing.Color.White;
            this.btnDoNam.Location = new System.Drawing.Point(269, 12);
            this.btnDoNam.Name = "btnDoNam";
            this.btnDoNam.Size = new System.Drawing.Size(120, 45);
            this.btnDoNam.TabIndex = 1;
            this.btnDoNam.Text = "Đồ Nam";
            this.btnDoNam.UseVisualStyleBackColor = false;
            // 
            // btnTatCa
            // 
            this.btnTatCa.BackColor = System.Drawing.Color.Gray;
            this.btnTatCa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTatCa.FlatAppearance.BorderSize = 0;
            this.btnTatCa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTatCa.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTatCa.ForeColor = System.Drawing.Color.White;
            this.btnTatCa.Location = new System.Drawing.Point(143, 12);
            this.btnTatCa.Name = "btnTatCa";
            this.btnTatCa.Size = new System.Drawing.Size(120, 45);
            this.btnTatCa.TabIndex = 0;
            this.btnTatCa.Text = "Tất Cả";
            this.btnTatCa.UseVisualStyleBackColor = false;
            // 
            // frmSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1173, 672);
            this.Controls.Add(this.flowLayoutPanelSanPham);
            this.Controls.Add(this.panelTopControls);
            this.Name = "frmSanPham";
            this.Text = "Quản Lý Sản Phẩm";
            this.Load += new System.EventHandler(this.frmSanPham_Load_2);
            this.panelTopControls.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        // Chú ý: Tất cả các khai báo PictureBox cũ và dòng khai báo thừa panelTopControls đã được loại bỏ.
    }
}
