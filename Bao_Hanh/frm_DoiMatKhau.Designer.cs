﻿namespace Bao_Hanh
{
    partial class frm_DoiMatKhau
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
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.btn_DoiMK = new System.Windows.Forms.Button();
            this.btn_LamMoi = new System.Windows.Forms.Button();
            this.txt_TenDangNhap = new DevExpress.XtraEditors.TextEdit();
            this.txt_MatKhauCu = new DevExpress.XtraEditors.TextEdit();
            this.txt_MatKhauMoi = new DevExpress.XtraEditors.TextEdit();
            this.txt_XacNhanMK = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_TenDangNhap.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_MatKhauCu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_MatKhauMoi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_XacNhanMK.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(21, 203);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(218, 24);
            this.labelControl4.TabIndex = 3;
            this.labelControl4.Text = "Xác nhận mật khẩu mới:";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(21, 160);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(128, 24);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "Mật khẩu mới:";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(21, 116);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(115, 24);
            this.labelControl2.TabIndex = 5;
            this.labelControl2.Text = "Mật khẩu cũ:";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(21, 71);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(141, 24);
            this.labelControl1.TabIndex = 6;
            this.labelControl1.Text = "Tên đăng nhập:";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.ForeColor = System.Drawing.Color.Green;
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Appearance.Options.UseForeColor = true;
            this.labelControl5.Location = new System.Drawing.Point(251, 15);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(159, 33);
            this.labelControl5.TabIndex = 13;
            this.labelControl5.Text = "Đổi mật khẩu";
            this.labelControl5.UseMnemonic = false;
            // 
            // btn_DoiMK
            // 
            this.btn_DoiMK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(185)))), ((int)(((byte)(255)))));
            this.btn_DoiMK.FlatAppearance.BorderSize = 0;
            this.btn_DoiMK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_DoiMK.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.btn_DoiMK.ForeColor = System.Drawing.Color.White;
            this.btn_DoiMK.Location = new System.Drawing.Point(251, 258);
            this.btn_DoiMK.Margin = new System.Windows.Forms.Padding(4);
            this.btn_DoiMK.Name = "btn_DoiMK";
            this.btn_DoiMK.Size = new System.Drawing.Size(183, 39);
            this.btn_DoiMK.TabIndex = 14;
            this.btn_DoiMK.Text = "Đổi mật khẩu";
            this.btn_DoiMK.UseVisualStyleBackColor = false;
            this.btn_DoiMK.Click += new System.EventHandler(this.btn_DoiMK_Click);
            // 
            // btn_LamMoi
            // 
            this.btn_LamMoi.BackColor = System.Drawing.Color.DimGray;
            this.btn_LamMoi.FlatAppearance.BorderSize = 0;
            this.btn_LamMoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_LamMoi.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.btn_LamMoi.ForeColor = System.Drawing.Color.White;
            this.btn_LamMoi.Location = new System.Drawing.Point(251, 305);
            this.btn_LamMoi.Margin = new System.Windows.Forms.Padding(4);
            this.btn_LamMoi.Name = "btn_LamMoi";
            this.btn_LamMoi.Size = new System.Drawing.Size(183, 39);
            this.btn_LamMoi.TabIndex = 15;
            this.btn_LamMoi.Tag = "";
            this.btn_LamMoi.Text = "Clear";
            this.btn_LamMoi.UseVisualStyleBackColor = false;
            this.btn_LamMoi.Click += new System.EventHandler(this.btn_LamMoi_Click);
            // 
            // txt_TenDangNhap
            // 
            this.txt_TenDangNhap.EditValue = "";
            this.txt_TenDangNhap.Enabled = false;
            this.txt_TenDangNhap.Location = new System.Drawing.Point(289, 60);
            this.txt_TenDangNhap.Margin = new System.Windows.Forms.Padding(4);
            this.txt_TenDangNhap.Name = "txt_TenDangNhap";
            this.txt_TenDangNhap.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 15F);
            this.txt_TenDangNhap.Properties.Appearance.Options.UseFont = true;
            this.txt_TenDangNhap.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.txt_TenDangNhap.Size = new System.Drawing.Size(351, 36);
            this.txt_TenDangNhap.TabIndex = 17;
            // 
            // txt_MatKhauCu
            // 
            this.txt_MatKhauCu.EditValue = "";
            this.txt_MatKhauCu.Location = new System.Drawing.Point(289, 103);
            this.txt_MatKhauCu.Margin = new System.Windows.Forms.Padding(4);
            this.txt_MatKhauCu.Name = "txt_MatKhauCu";
            this.txt_MatKhauCu.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 15F);
            this.txt_MatKhauCu.Properties.Appearance.Options.UseFont = true;
            this.txt_MatKhauCu.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.txt_MatKhauCu.Size = new System.Drawing.Size(351, 36);
            this.txt_MatKhauCu.TabIndex = 18;
            // 
            // txt_MatKhauMoi
            // 
            this.txt_MatKhauMoi.EditValue = "";
            this.txt_MatKhauMoi.Location = new System.Drawing.Point(289, 149);
            this.txt_MatKhauMoi.Margin = new System.Windows.Forms.Padding(4);
            this.txt_MatKhauMoi.Name = "txt_MatKhauMoi";
            this.txt_MatKhauMoi.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 15F);
            this.txt_MatKhauMoi.Properties.Appearance.Options.UseFont = true;
            this.txt_MatKhauMoi.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.txt_MatKhauMoi.Size = new System.Drawing.Size(351, 36);
            this.txt_MatKhauMoi.TabIndex = 19;
            // 
            // txt_XacNhanMK
            // 
            this.txt_XacNhanMK.EditValue = "";
            this.txt_XacNhanMK.Location = new System.Drawing.Point(289, 194);
            this.txt_XacNhanMK.Margin = new System.Windows.Forms.Padding(4);
            this.txt_XacNhanMK.Name = "txt_XacNhanMK";
            this.txt_XacNhanMK.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 15F);
            this.txt_XacNhanMK.Properties.Appearance.Options.UseFont = true;
            this.txt_XacNhanMK.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.txt_XacNhanMK.Size = new System.Drawing.Size(351, 36);
            this.txt_XacNhanMK.TabIndex = 20;
            // 
            // frm_DoiMatKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 369);
            this.Controls.Add(this.txt_XacNhanMK);
            this.Controls.Add(this.txt_MatKhauMoi);
            this.Controls.Add(this.txt_MatKhauCu);
            this.Controls.Add(this.txt_TenDangNhap);
            this.Controls.Add(this.btn_LamMoi);
            this.Controls.Add(this.btn_DoiMK);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_DoiMatKhau";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Đổi mật khẩu";
            this.Load += new System.EventHandler(this.frm_DoiMatKhau_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txt_TenDangNhap.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_MatKhauCu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_MatKhauMoi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_XacNhanMK.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private System.Windows.Forms.Button btn_DoiMK;
        private System.Windows.Forms.Button btn_LamMoi;
        private DevExpress.XtraEditors.TextEdit txt_TenDangNhap;
        private DevExpress.XtraEditors.TextEdit txt_MatKhauCu;
        private DevExpress.XtraEditors.TextEdit txt_MatKhauMoi;
        private DevExpress.XtraEditors.TextEdit txt_XacNhanMK;
    }
}