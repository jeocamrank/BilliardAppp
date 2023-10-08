namespace BilliardApp
{
    partial class resetPassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(resetPassword));
            this.TB_Code = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TB_Email = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BT_QuayLai = new Bunifu.Framework.UI.BunifuThinButton2();
            this.BT_XacMinh = new Bunifu.Framework.UI.BunifuThinButton2();
            this.BT_GuiMa = new Bunifu.Framework.UI.BunifuThinButton2();
            this.SuspendLayout();
            // 
            // TB_Code
            // 
            this.TB_Code.BorderRadius = 10;
            this.TB_Code.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TB_Code.DefaultText = "";
            this.TB_Code.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TB_Code.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TB_Code.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TB_Code.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TB_Code.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TB_Code.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TB_Code.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TB_Code.Location = new System.Drawing.Point(294, 266);
            this.TB_Code.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TB_Code.Name = "TB_Code";
            this.TB_Code.PasswordChar = '\0';
            this.TB_Code.PlaceholderText = "";
            this.TB_Code.SelectedText = "";
            this.TB_Code.Size = new System.Drawing.Size(341, 42);
            this.TB_Code.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(155, 276);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 18);
            this.label3.TabIndex = 27;
            this.label3.Text = "Nhập Code";
            // 
            // TB_Email
            // 
            this.TB_Email.BorderRadius = 10;
            this.TB_Email.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TB_Email.DefaultText = "";
            this.TB_Email.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TB_Email.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TB_Email.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TB_Email.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TB_Email.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TB_Email.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TB_Email.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TB_Email.Location = new System.Drawing.Point(294, 116);
            this.TB_Email.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TB_Email.Name = "TB_Email";
            this.TB_Email.PasswordChar = '\0';
            this.TB_Email.PlaceholderText = "";
            this.TB_Email.SelectedText = "";
            this.TB_Email.Size = new System.Drawing.Size(341, 42);
            this.TB_Email.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(92, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 18);
            this.label2.TabIndex = 24;
            this.label2.Text = "Nhập Email đăng ký";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(280, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 23);
            this.label1.TabIndex = 22;
            this.label1.Text = "Xác thực mật khẩu Email";
            // 
            // BT_QuayLai
            // 
            this.BT_QuayLai.ActiveBorderThickness = 1;
            this.BT_QuayLai.ActiveCornerRadius = 20;
            this.BT_QuayLai.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.BT_QuayLai.ActiveForecolor = System.Drawing.Color.White;
            this.BT_QuayLai.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.BT_QuayLai.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BT_QuayLai.BackColor = System.Drawing.SystemColors.Control;
            this.BT_QuayLai.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BT_QuayLai.BackgroundImage")));
            this.BT_QuayLai.ButtonText = "Quay lại";
            this.BT_QuayLai.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BT_QuayLai.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_QuayLai.ForeColor = System.Drawing.Color.SeaGreen;
            this.BT_QuayLai.IdleBorderThickness = 1;
            this.BT_QuayLai.IdleCornerRadius = 20;
            this.BT_QuayLai.IdleFillColor = System.Drawing.Color.MediumTurquoise;
            this.BT_QuayLai.IdleForecolor = System.Drawing.Color.White;
            this.BT_QuayLai.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.BT_QuayLai.Location = new System.Drawing.Point(95, 442);
            this.BT_QuayLai.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.BT_QuayLai.Name = "BT_QuayLai";
            this.BT_QuayLai.Size = new System.Drawing.Size(105, 58);
            this.BT_QuayLai.TabIndex = 5;
            this.BT_QuayLai.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BT_QuayLai.Click += new System.EventHandler(this.BT_QuayLai_Click);
            // 
            // BT_XacMinh
            // 
            this.BT_XacMinh.ActiveBorderThickness = 1;
            this.BT_XacMinh.ActiveCornerRadius = 20;
            this.BT_XacMinh.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.BT_XacMinh.ActiveForecolor = System.Drawing.Color.White;
            this.BT_XacMinh.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.BT_XacMinh.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BT_XacMinh.BackColor = System.Drawing.SystemColors.Control;
            this.BT_XacMinh.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BT_XacMinh.BackgroundImage")));
            this.BT_XacMinh.ButtonText = "Xác minh";
            this.BT_XacMinh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BT_XacMinh.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_XacMinh.ForeColor = System.Drawing.Color.SeaGreen;
            this.BT_XacMinh.IdleBorderThickness = 1;
            this.BT_XacMinh.IdleCornerRadius = 20;
            this.BT_XacMinh.IdleFillColor = System.Drawing.Color.MediumTurquoise;
            this.BT_XacMinh.IdleForecolor = System.Drawing.Color.White;
            this.BT_XacMinh.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.BT_XacMinh.Location = new System.Drawing.Point(371, 337);
            this.BT_XacMinh.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.BT_XacMinh.Name = "BT_XacMinh";
            this.BT_XacMinh.Size = new System.Drawing.Size(157, 49);
            this.BT_XacMinh.TabIndex = 4;
            this.BT_XacMinh.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BT_XacMinh.Click += new System.EventHandler(this.BT_XacMinh_Click);
            // 
            // BT_GuiMa
            // 
            this.BT_GuiMa.ActiveBorderThickness = 1;
            this.BT_GuiMa.ActiveCornerRadius = 20;
            this.BT_GuiMa.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.BT_GuiMa.ActiveForecolor = System.Drawing.Color.White;
            this.BT_GuiMa.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.BT_GuiMa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BT_GuiMa.BackColor = System.Drawing.SystemColors.Control;
            this.BT_GuiMa.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BT_GuiMa.BackgroundImage")));
            this.BT_GuiMa.ButtonText = "Gửi mã";
            this.BT_GuiMa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BT_GuiMa.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_GuiMa.ForeColor = System.Drawing.Color.SeaGreen;
            this.BT_GuiMa.IdleBorderThickness = 1;
            this.BT_GuiMa.IdleCornerRadius = 20;
            this.BT_GuiMa.IdleFillColor = System.Drawing.Color.MediumTurquoise;
            this.BT_GuiMa.IdleForecolor = System.Drawing.Color.White;
            this.BT_GuiMa.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.BT_GuiMa.Location = new System.Drawing.Point(371, 177);
            this.BT_GuiMa.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.BT_GuiMa.Name = "BT_GuiMa";
            this.BT_GuiMa.Size = new System.Drawing.Size(157, 49);
            this.BT_GuiMa.TabIndex = 2;
            this.BT_GuiMa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BT_GuiMa.Click += new System.EventHandler(this.BT_GuiMa_Click);
            // 
            // resetPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 534);
            this.Controls.Add(this.BT_QuayLai);
            this.Controls.Add(this.BT_XacMinh);
            this.Controls.Add(this.TB_Code);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BT_GuiMa);
            this.Controls.Add(this.TB_Email);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "resetPassword";
            this.Text = "resetPassword";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuThinButton2 BT_QuayLai;
        private Bunifu.Framework.UI.BunifuThinButton2 BT_XacMinh;
        private Guna.UI2.WinForms.Guna2TextBox TB_Code;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuThinButton2 BT_GuiMa;
        private Guna.UI2.WinForms.Guna2TextBox TB_Email;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}