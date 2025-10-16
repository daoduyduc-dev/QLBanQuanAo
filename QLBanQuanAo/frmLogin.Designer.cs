namespace QLBanQuanAo
{
    partial class frmLogin
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
            this.components = new System.ComponentModel.Container();
            this.txtTenDN = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.lblMk = new System.Windows.Forms.Label();
            this.lblTenDn = new System.Windows.Forms.Label();
            this.btnDN = new System.Windows.Forms.Button();
            this.grbDn = new System.Windows.Forms.GroupBox();
            this.txtMK = new System.Windows.Forms.TextBox();
            this.lblGoDK = new System.Windows.Forms.Label();
            this.llblDangKy = new System.Windows.Forms.LinkLabel();
            this.grbDn.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtTenDN
            // 
            this.txtTenDN.Location = new System.Drawing.Point(132, 64);
            this.txtTenDN.Multiline = true;
            this.txtTenDN.Name = "txtTenDN";
            this.txtTenDN.Size = new System.Drawing.Size(206, 36);
            this.txtTenDN.TabIndex = 1;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // lblMk
            // 
            this.lblMk.AutoSize = true;
            this.lblMk.Location = new System.Drawing.Point(129, 116);
            this.lblMk.Name = "lblMk";
            this.lblMk.Size = new System.Drawing.Size(61, 16);
            this.lblMk.TabIndex = 4;
            this.lblMk.Text = "Mật khẩu";
            // 
            // lblTenDn
            // 
            this.lblTenDn.AutoSize = true;
            this.lblTenDn.Location = new System.Drawing.Point(129, 45);
            this.lblTenDn.Name = "lblTenDn";
            this.lblTenDn.Size = new System.Drawing.Size(102, 16);
            this.lblTenDn.TabIndex = 5;
            this.lblTenDn.Text = "Tên Đăng Nhập";
            // 
            // btnDN
            // 
            this.btnDN.Location = new System.Drawing.Point(196, 223);
            this.btnDN.Name = "btnDN";
            this.btnDN.Size = new System.Drawing.Size(93, 30);
            this.btnDN.TabIndex = 6;
            this.btnDN.Text = "Đăng Nhập";
            this.btnDN.UseVisualStyleBackColor = true;
            // 
            // grbDn
            // 
            this.grbDn.Controls.Add(this.lblMk);
            this.grbDn.Controls.Add(this.txtMK);
            this.grbDn.Controls.Add(this.lblGoDK);
            this.grbDn.Controls.Add(this.llblDangKy);
            this.grbDn.Controls.Add(this.lblTenDn);
            this.grbDn.Controls.Add(this.txtTenDN);
            this.grbDn.Controls.Add(this.btnDN);
            this.grbDn.Location = new System.Drawing.Point(158, 96);
            this.grbDn.Name = "grbDn";
            this.grbDn.Size = new System.Drawing.Size(487, 259);
            this.grbDn.TabIndex = 8;
            this.grbDn.TabStop = false;
            this.grbDn.Text = "Đăng Nhập";
            this.grbDn.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtMK
            // 
            this.txtMK.Location = new System.Drawing.Point(132, 135);
            this.txtMK.Multiline = true;
            this.txtMK.Name = "txtMK";
            this.txtMK.Size = new System.Drawing.Size(206, 36);
            this.txtMK.TabIndex = 10;
            // 
            // lblGoDK
            // 
            this.lblGoDK.AutoSize = true;
            this.lblGoDK.Location = new System.Drawing.Point(160, 187);
            this.lblGoDK.Name = "lblGoDK";
            this.lblGoDK.Size = new System.Drawing.Size(120, 16);
            this.lblGoDK.TabIndex = 9;
            this.lblGoDK.Text = "Chưa có tài khoản?";
            this.lblGoDK.Click += new System.EventHandler(this.lblGoDK_Click);
            // 
            // llblDangKy
            // 
            this.llblDangKy.AutoSize = true;
            this.llblDangKy.Location = new System.Drawing.Point(281, 187);
            this.llblDangKy.Name = "llblDangKy";
            this.llblDangKy.Size = new System.Drawing.Size(57, 16);
            this.llblDangKy.TabIndex = 7;
            this.llblDangKy.TabStop = true;
            this.llblDangKy.Text = "Đăng Ký";
            this.llblDangKy.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grbDn);
            this.Name = "frmLogin";
            this.Text = "frmLogin";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.grbDn.ResumeLayout(false);
            this.grbDn.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtTenDN;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label lblMk;
        private System.Windows.Forms.Label lblTenDn;
        private System.Windows.Forms.Button btnDN;
        private System.Windows.Forms.GroupBox grbDn;
        private System.Windows.Forms.Label lblGoDK;
        private System.Windows.Forms.LinkLabel llblDangKy;
        private System.Windows.Forms.TextBox txtMK;
    }
}