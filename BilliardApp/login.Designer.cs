namespace BilliardApp
{
    partial class login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TB_TaiKhoan = new Guna.UI2.WinForms.Guna2TextBox();
            this.TB_MatKhau = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.link_QuenMatKhau = new System.Windows.Forms.LinkLabel();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.btn_DangKy = new Bunifu.Framework.UI.BunifuThinButton2();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_DangNhap = new Bunifu.Framework.UI.BunifuThinButton2();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.label1.Location = new System.Drawing.Point(1148, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "CHÀO BẠN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(999, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tài khoản";
            // 
            // TB_TaiKhoan
            // 
            this.TB_TaiKhoan.BorderRadius = 10;
            this.TB_TaiKhoan.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TB_TaiKhoan.DefaultText = "";
            this.TB_TaiKhoan.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TB_TaiKhoan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TB_TaiKhoan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TB_TaiKhoan.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TB_TaiKhoan.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TB_TaiKhoan.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TB_TaiKhoan.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TB_TaiKhoan.Location = new System.Drawing.Point(1108, 166);
            this.TB_TaiKhoan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TB_TaiKhoan.Name = "TB_TaiKhoan";
            this.TB_TaiKhoan.PasswordChar = '\0';
            this.TB_TaiKhoan.PlaceholderText = "";
            this.TB_TaiKhoan.SelectedText = "";
            this.TB_TaiKhoan.Size = new System.Drawing.Size(268, 42);
            this.TB_TaiKhoan.TabIndex = 1;
            // 
            // TB_MatKhau
            // 
            this.TB_MatKhau.BorderRadius = 10;
            this.TB_MatKhau.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TB_MatKhau.DefaultText = "";
            this.TB_MatKhau.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TB_MatKhau.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TB_MatKhau.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TB_MatKhau.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TB_MatKhau.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TB_MatKhau.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TB_MatKhau.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TB_MatKhau.Location = new System.Drawing.Point(1108, 256);
            this.TB_MatKhau.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TB_MatKhau.Name = "TB_MatKhau";
            this.TB_MatKhau.PasswordChar = '*';
            this.TB_MatKhau.PlaceholderText = "";
            this.TB_MatKhau.SelectedText = "";
            this.TB_MatKhau.Size = new System.Drawing.Size(268, 42);
            this.TB_MatKhau.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(999, 266);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Mật khẩu";
            // 
            // link_QuenMatKhau
            // 
            this.link_QuenMatKhau.AutoSize = true;
            this.link_QuenMatKhau.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.link_QuenMatKhau.LinkColor = System.Drawing.Color.Black;
            this.link_QuenMatKhau.Location = new System.Drawing.Point(1204, 346);
            this.link_QuenMatKhau.Name = "link_QuenMatKhau";
            this.link_QuenMatKhau.Size = new System.Drawing.Size(172, 23);
            this.link_QuenMatKhau.TabIndex = 3;
            this.link_QuenMatKhau.TabStop = true;
            this.link_QuenMatKhau.Text = "Quên mật khẩu ?";
            this.link_QuenMatKhau.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_QuenMatKhau_LinkClicked);
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Thoat.Image = global::BilliardApp.Properties.Resources.close_window_30px;
            this.btn_Thoat.Location = new System.Drawing.Point(1349, 12);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_Thoat.Size = new System.Drawing.Size(47, 37);
            this.btn_Thoat.TabIndex = 5;
            this.btn_Thoat.UseVisualStyleBackColor = true;
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
            // 
            // btn_DangKy
            // 
            this.btn_DangKy.ActiveBorderThickness = 1;
            this.btn_DangKy.ActiveCornerRadius = 20;
            this.btn_DangKy.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btn_DangKy.ActiveForecolor = System.Drawing.Color.White;
            this.btn_DangKy.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btn_DangKy.BackColor = System.Drawing.Color.White;
            this.btn_DangKy.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_DangKy.BackgroundImage")));
            this.btn_DangKy.ButtonText = "Đăng ký";
            this.btn_DangKy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_DangKy.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DangKy.ForeColor = System.Drawing.Color.SeaGreen;
            this.btn_DangKy.IdleBorderThickness = 1;
            this.btn_DangKy.IdleCornerRadius = 20;
            this.btn_DangKy.IdleFillColor = System.Drawing.Color.MediumTurquoise;
            this.btn_DangKy.IdleForecolor = System.Drawing.Color.White;
            this.btn_DangKy.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btn_DangKy.Location = new System.Drawing.Point(1054, 494);
            this.btn_DangKy.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btn_DangKy.Name = "btn_DangKy";
            this.btn_DangKy.Size = new System.Drawing.Size(313, 50);
            this.btn_DangKy.TabIndex = 5;
            this.btn_DangKy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_DangKy.Click += new System.EventHandler(this.btn_DangKy_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(973, 744);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btn_DangNhap
            // 
            this.btn_DangNhap.ActiveBorderThickness = 1;
            this.btn_DangNhap.ActiveCornerRadius = 20;
            this.btn_DangNhap.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btn_DangNhap.ActiveForecolor = System.Drawing.Color.White;
            this.btn_DangNhap.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btn_DangNhap.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_DangNhap.BackColor = System.Drawing.Color.White;
            this.btn_DangNhap.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_DangNhap.BackgroundImage")));
            this.btn_DangNhap.ButtonText = "Đăng nhập";
            this.btn_DangNhap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_DangNhap.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DangNhap.ForeColor = System.Drawing.Color.SeaGreen;
            this.btn_DangNhap.IdleBorderThickness = 1;
            this.btn_DangNhap.IdleCornerRadius = 20;
            this.btn_DangNhap.IdleFillColor = System.Drawing.Color.MediumTurquoise;
            this.btn_DangNhap.IdleForecolor = System.Drawing.Color.White;
            this.btn_DangNhap.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btn_DangNhap.Location = new System.Drawing.Point(1054, 407);
            this.btn_DangNhap.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btn_DangNhap.Name = "btn_DangNhap";
            this.btn_DangNhap.Size = new System.Drawing.Size(313, 50);
            this.btn_DangNhap.TabIndex = 4;
            this.btn_DangNhap.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_DangNhap.Click += new System.EventHandler(this.btn_DangNhap_Click);
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1432, 744);
            this.Controls.Add(this.btn_Thoat);
            this.Controls.Add(this.link_QuenMatKhau);
            this.Controls.Add(this.btn_DangKy);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_DangNhap);
            this.Controls.Add(this.TB_MatKhau);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TB_TaiKhoan);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "login";
            this.Text = "login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox TB_TaiKhoan;
        private Guna.UI2.WinForms.Guna2TextBox TB_MatKhau;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_DangNhap;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_DangKy;
        private System.Windows.Forms.LinkLabel link_QuenMatKhau;
        private System.Windows.Forms.Button btn_Thoat;
    }
}