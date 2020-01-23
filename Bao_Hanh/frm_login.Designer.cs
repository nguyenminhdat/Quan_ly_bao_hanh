namespace Bao_Hanh
{
    partial class frm_login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_login));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.btn_Login = new System.Windows.Forms.Button();
            this.txtTaiKhoan = new DevExpress.XtraEditors.TextEdit();
            this.txtMatKhau = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTaiKhoan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMatKhau.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(16, 72);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(95, 23);
            this.labelControl1.TabIndex = 3;
            this.labelControl1.Text = "Tài khoản :";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(16, 108);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(91, 23);
            this.labelControl2.TabIndex = 4;
            this.labelControl2.Text = "Mật khẩu :";
            // 
            // simpleButton1
            // 
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(16, 12);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.simpleButton1.Size = new System.Drawing.Size(54, 51);
            this.simpleButton1.TabIndex = 5;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.ForeColor = System.Drawing.Color.Green;
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Appearance.Options.UseForeColor = true;
            this.labelControl3.Location = new System.Drawing.Point(91, 21);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(293, 25);
            this.labelControl3.TabIndex = 6;
            this.labelControl3.Text = "Đăng nhập hệ thống Bảo Hành";
            this.labelControl3.UseMnemonic = false;
            // 
            // btn_Login
            // 
            this.btn_Login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(185)))), ((int)(((byte)(255)))));
            this.btn_Login.FlatAppearance.BorderSize = 0;
            this.btn_Login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Login.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.btn_Login.ForeColor = System.Drawing.Color.White;
            this.btn_Login.Location = new System.Drawing.Point(161, 156);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(107, 32);
            this.btn_Login.TabIndex = 7;
            this.btn_Login.Text = "Đăng nhập";
            this.btn_Login.UseVisualStyleBackColor = false;
            // 
            // txtTaiKhoan
            // 
            this.txtTaiKhoan.EditValue = "";
            this.txtTaiKhoan.Location = new System.Drawing.Point(147, 65);
            this.txtTaiKhoan.Name = "txtTaiKhoan";
            this.txtTaiKhoan.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 15F);
            this.txtTaiKhoan.Properties.Appearance.Options.UseFont = true;
            this.txtTaiKhoan.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.txtTaiKhoan.Size = new System.Drawing.Size(258, 30);
            this.txtTaiKhoan.TabIndex = 16;
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.EditValue = "";
            this.txtMatKhau.Location = new System.Drawing.Point(147, 104);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 15F);
            this.txtMatKhau.Properties.Appearance.Options.UseFont = true;
            this.txtMatKhau.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.txtMatKhau.Size = new System.Drawing.Size(258, 30);
            this.txtMatKhau.TabIndex = 17;
            // 
            // frm_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 200);
            this.Controls.Add(this.txtMatKhau);
            this.Controls.Add(this.txtTaiKhoan);
            this.Controls.Add(this.btn_Login);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_login";
            this.Text = "Đăng nhập";
            ((System.ComponentModel.ISupportInitialize)(this.txtTaiKhoan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMatKhau.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private System.Windows.Forms.Button btn_Login;
        private DevExpress.XtraEditors.TextEdit txtTaiKhoan;
        private DevExpress.XtraEditors.TextEdit txtMatKhau;
    }
}