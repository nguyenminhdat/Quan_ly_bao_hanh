namespace Bao_Hanh
{
    partial class frm_QuanLyNhanVien
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
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.dtp_NgaySinh = new DevExpress.XtraEditors.DateEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txt_SoDienThoai = new DevExpress.XtraEditors.TextEdit();
            this.txt_DiaChi = new DevExpress.XtraEditors.TextEdit();
            this.txt_HoTen = new DevExpress.XtraEditors.TextEdit();
            this.txt_MatKhau = new DevExpress.XtraEditors.TextEdit();
            this.txt_TenDangNhap = new DevExpress.XtraEditors.TextEdit();
            this.btn_TimKiem = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Luu = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Xoa = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Clear = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.gc_Data = new DevExpress.XtraGrid.GridControl();
            this.gv_Data = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.cTenDangNhap = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cMatKhau = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cHoTenNV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cGioiTinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rep_GioiTinh = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.cNgaySinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rep_NgaySinh = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.cSDT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cDiaChi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cMaChucDanh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cbb_GioiTinh = new DevExpress.XtraEditors.ComboBoxEdit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtp_NgaySinh.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtp_NgaySinh.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_SoDienThoai.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_DiaChi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_HoTen.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_MatKhau.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_TenDangNhap.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gc_Data)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Data)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rep_GioiTinh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rep_NgaySinh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rep_NgaySinh.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbb_GioiTinh.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.cbb_GioiTinh);
            this.panelControl1.Controls.Add(this.dtp_NgaySinh);
            this.panelControl1.Controls.Add(this.labelControl7);
            this.panelControl1.Controls.Add(this.labelControl6);
            this.panelControl1.Controls.Add(this.labelControl3);
            this.panelControl1.Controls.Add(this.labelControl5);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.txt_SoDienThoai);
            this.panelControl1.Controls.Add(this.txt_DiaChi);
            this.panelControl1.Controls.Add(this.txt_HoTen);
            this.panelControl1.Controls.Add(this.txt_MatKhau);
            this.panelControl1.Controls.Add(this.txt_TenDangNhap);
            this.panelControl1.Controls.Add(this.btn_TimKiem);
            this.panelControl1.Controls.Add(this.btn_Luu);
            this.panelControl1.Controls.Add(this.btn_Xoa);
            this.panelControl1.Controls.Add(this.btn_Clear);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1203, 261);
            this.panelControl1.TabIndex = 0;
            // 
            // dtp_NgaySinh
            // 
            this.dtp_NgaySinh.EditValue = null;
            this.dtp_NgaySinh.Location = new System.Drawing.Point(613, 24);
            this.dtp_NgaySinh.Name = "dtp_NgaySinh";
            this.dtp_NgaySinh.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_NgaySinh.Properties.Appearance.Options.UseFont = true;
            this.dtp_NgaySinh.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtp_NgaySinh.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtp_NgaySinh.Size = new System.Drawing.Size(151, 28);
            this.dtp_NgaySinh.TabIndex = 46;
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(475, 120);
            this.labelControl7.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(51, 21);
            this.labelControl7.TabIndex = 44;
            this.labelControl7.Text = "Địa chỉ";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(475, 81);
            this.labelControl6.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(97, 21);
            this.labelControl6.TabIndex = 44;
            this.labelControl6.Text = "Số điện thoại";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(25, 118);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(49, 21);
            this.labelControl3.TabIndex = 44;
            this.labelControl3.Text = "Họ tên";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(475, 33);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(72, 21);
            this.labelControl5.TabIndex = 44;
            this.labelControl5.Text = "Ngày sinh";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(25, 76);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(68, 21);
            this.labelControl2.TabIndex = 44;
            this.labelControl2.Text = "Mật khẩu";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(25, 33);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(111, 21);
            this.labelControl1.TabIndex = 44;
            this.labelControl1.Text = "Tên đăng nhập";
            // 
            // txt_SoDienThoai
            // 
            this.txt_SoDienThoai.EditValue = "";
            this.txt_SoDienThoai.Location = new System.Drawing.Point(613, 73);
            this.txt_SoDienThoai.Margin = new System.Windows.Forms.Padding(4);
            this.txt_SoDienThoai.Name = "txt_SoDienThoai";
            this.txt_SoDienThoai.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SoDienThoai.Properties.Appearance.Options.UseFont = true;
            this.txt_SoDienThoai.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.txt_SoDienThoai.Properties.Mask.EditMask = "\\d+";
            this.txt_SoDienThoai.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txt_SoDienThoai.Size = new System.Drawing.Size(284, 28);
            this.txt_SoDienThoai.TabIndex = 43;
            // 
            // txt_DiaChi
            // 
            this.txt_DiaChi.EditValue = "";
            this.txt_DiaChi.Location = new System.Drawing.Point(613, 117);
            this.txt_DiaChi.Margin = new System.Windows.Forms.Padding(4);
            this.txt_DiaChi.Name = "txt_DiaChi";
            this.txt_DiaChi.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_DiaChi.Properties.Appearance.Options.UseFont = true;
            this.txt_DiaChi.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.txt_DiaChi.Size = new System.Drawing.Size(284, 28);
            this.txt_DiaChi.TabIndex = 43;
            // 
            // txt_HoTen
            // 
            this.txt_HoTen.EditValue = "";
            this.txt_HoTen.Location = new System.Drawing.Point(176, 113);
            this.txt_HoTen.Margin = new System.Windows.Forms.Padding(4);
            this.txt_HoTen.Name = "txt_HoTen";
            this.txt_HoTen.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_HoTen.Properties.Appearance.Options.UseFont = true;
            this.txt_HoTen.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.txt_HoTen.Size = new System.Drawing.Size(249, 28);
            this.txt_HoTen.TabIndex = 43;
            // 
            // txt_MatKhau
            // 
            this.txt_MatKhau.EditValue = "";
            this.txt_MatKhau.Location = new System.Drawing.Point(176, 69);
            this.txt_MatKhau.Margin = new System.Windows.Forms.Padding(4);
            this.txt_MatKhau.Name = "txt_MatKhau";
            this.txt_MatKhau.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MatKhau.Properties.Appearance.Options.UseFont = true;
            this.txt_MatKhau.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.txt_MatKhau.Size = new System.Drawing.Size(249, 28);
            this.txt_MatKhau.TabIndex = 43;
            // 
            // txt_TenDangNhap
            // 
            this.txt_TenDangNhap.EditValue = "";
            this.txt_TenDangNhap.Location = new System.Drawing.Point(176, 25);
            this.txt_TenDangNhap.Margin = new System.Windows.Forms.Padding(4);
            this.txt_TenDangNhap.Name = "txt_TenDangNhap";
            this.txt_TenDangNhap.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TenDangNhap.Properties.Appearance.Options.UseFont = true;
            this.txt_TenDangNhap.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.txt_TenDangNhap.Size = new System.Drawing.Size(249, 28);
            this.txt_TenDangNhap.TabIndex = 43;
            // 
            // btn_TimKiem
            // 
            this.btn_TimKiem.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(185)))), ((int)(((byte)(255)))));
            this.btn_TimKiem.Appearance.BackColor2 = System.Drawing.Color.White;
            this.btn_TimKiem.Appearance.BorderColor = System.Drawing.Color.Blue;
            this.btn_TimKiem.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.btn_TimKiem.Appearance.Options.UseBackColor = true;
            this.btn_TimKiem.Appearance.Options.UseBorderColor = true;
            this.btn_TimKiem.Appearance.Options.UseFont = true;
            this.btn_TimKiem.Location = new System.Drawing.Point(827, 178);
            this.btn_TimKiem.Name = "btn_TimKiem";
            this.btn_TimKiem.Size = new System.Drawing.Size(183, 51);
            this.btn_TimKiem.TabIndex = 9;
            this.btn_TimKiem.Text = "Tìm kiếm";
            this.btn_TimKiem.Click += new System.EventHandler(this.btn_TimKiem_Click);
            // 
            // btn_Luu
            // 
            this.btn_Luu.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(185)))), ((int)(((byte)(255)))));
            this.btn_Luu.Appearance.BackColor2 = System.Drawing.Color.White;
            this.btn_Luu.Appearance.BorderColor = System.Drawing.Color.Blue;
            this.btn_Luu.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.btn_Luu.Appearance.Options.UseBackColor = true;
            this.btn_Luu.Appearance.Options.UseBorderColor = true;
            this.btn_Luu.Appearance.Options.UseFont = true;
            this.btn_Luu.Location = new System.Drawing.Point(396, 178);
            this.btn_Luu.Name = "btn_Luu";
            this.btn_Luu.Size = new System.Drawing.Size(183, 51);
            this.btn_Luu.TabIndex = 10;
            this.btn_Luu.Text = "Lưu";
            this.btn_Luu.Click += new System.EventHandler(this.btn_Luu_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(185)))), ((int)(((byte)(255)))));
            this.btn_Xoa.Appearance.BackColor2 = System.Drawing.Color.White;
            this.btn_Xoa.Appearance.BorderColor = System.Drawing.Color.Blue;
            this.btn_Xoa.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.btn_Xoa.Appearance.Options.UseBackColor = true;
            this.btn_Xoa.Appearance.Options.UseBorderColor = true;
            this.btn_Xoa.Appearance.Options.UseFont = true;
            this.btn_Xoa.Location = new System.Drawing.Point(613, 178);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(183, 51);
            this.btn_Xoa.TabIndex = 7;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_Clear
            // 
            this.btn_Clear.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(185)))), ((int)(((byte)(255)))));
            this.btn_Clear.Appearance.BackColor2 = System.Drawing.Color.White;
            this.btn_Clear.Appearance.BorderColor = System.Drawing.Color.Blue;
            this.btn_Clear.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.btn_Clear.Appearance.Options.UseBackColor = true;
            this.btn_Clear.Appearance.Options.UseBorderColor = true;
            this.btn_Clear.Appearance.Options.UseFont = true;
            this.btn_Clear.Location = new System.Drawing.Point(176, 178);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(183, 51);
            this.btn_Clear.TabIndex = 8;
            this.btn_Clear.Text = "Clear";
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.gc_Data);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(0, 261);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(1203, 437);
            this.panelControl2.TabIndex = 1;
            // 
            // gc_Data
            // 
            this.gc_Data.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc_Data.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.gc_Data.Location = new System.Drawing.Point(2, 2);
            this.gc_Data.MainView = this.gv_Data;
            this.gc_Data.Margin = new System.Windows.Forms.Padding(4);
            this.gc_Data.Name = "gc_Data";
            this.gc_Data.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.rep_GioiTinh,
            this.rep_NgaySinh});
            this.gc_Data.Size = new System.Drawing.Size(1199, 433);
            this.gc_Data.TabIndex = 1;
            this.gc_Data.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_Data});
            // 
            // gv_Data
            // 
            this.gv_Data.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.cTenDangNhap,
            this.cMatKhau,
            this.cHoTenNV,
            this.cGioiTinh,
            this.cNgaySinh,
            this.cSDT,
            this.cDiaChi,
            this.cMaChucDanh});
            this.gv_Data.DetailHeight = 431;
            this.gv_Data.GridControl = this.gc_Data;
            this.gv_Data.Name = "gv_Data";
            this.gv_Data.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gv_Data_RowClick);
            // 
            // cTenDangNhap
            // 
            this.cTenDangNhap.Caption = "Tên đăng nhập";
            this.cTenDangNhap.FieldName = "TenDangNhap";
            this.cTenDangNhap.MinWidth = 25;
            this.cTenDangNhap.Name = "cTenDangNhap";
            this.cTenDangNhap.OptionsColumn.AllowEdit = false;
            this.cTenDangNhap.Visible = true;
            this.cTenDangNhap.VisibleIndex = 0;
            this.cTenDangNhap.Width = 94;
            // 
            // cMatKhau
            // 
            this.cMatKhau.Caption = "Mật khẩu";
            this.cMatKhau.FieldName = "MatKhau";
            this.cMatKhau.MinWidth = 25;
            this.cMatKhau.Name = "cMatKhau";
            this.cMatKhau.OptionsColumn.AllowEdit = false;
            this.cMatKhau.Visible = true;
            this.cMatKhau.VisibleIndex = 1;
            this.cMatKhau.Width = 94;
            // 
            // cHoTenNV
            // 
            this.cHoTenNV.Caption = "Họ tên";
            this.cHoTenNV.FieldName = "HoTenNV";
            this.cHoTenNV.MinWidth = 25;
            this.cHoTenNV.Name = "cHoTenNV";
            this.cHoTenNV.OptionsColumn.AllowEdit = false;
            this.cHoTenNV.Visible = true;
            this.cHoTenNV.VisibleIndex = 2;
            this.cHoTenNV.Width = 94;
            // 
            // cGioiTinh
            // 
            this.cGioiTinh.Caption = "Giới tính";
            this.cGioiTinh.FieldName = "GioiTinh";
            this.cGioiTinh.MinWidth = 25;
            this.cGioiTinh.Name = "cGioiTinh";
            this.cGioiTinh.OptionsColumn.AllowEdit = false;
            this.cGioiTinh.Visible = true;
            this.cGioiTinh.VisibleIndex = 3;
            this.cGioiTinh.Width = 94;
            // 
            // rep_GioiTinh
            // 
            this.rep_GioiTinh.AutoHeight = false;
            this.rep_GioiTinh.Name = "rep_GioiTinh";
            // 
            // cNgaySinh
            // 
            this.cNgaySinh.Caption = "Ngày sinh";
            this.cNgaySinh.ColumnEdit = this.rep_NgaySinh;
            this.cNgaySinh.FieldName = "NgaySinh";
            this.cNgaySinh.MinWidth = 25;
            this.cNgaySinh.Name = "cNgaySinh";
            this.cNgaySinh.OptionsColumn.AllowEdit = false;
            this.cNgaySinh.Visible = true;
            this.cNgaySinh.VisibleIndex = 4;
            this.cNgaySinh.Width = 94;
            // 
            // rep_NgaySinh
            // 
            this.rep_NgaySinh.AutoHeight = false;
            this.rep_NgaySinh.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.rep_NgaySinh.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.rep_NgaySinh.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.rep_NgaySinh.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.rep_NgaySinh.EditFormat.FormatString = "dd/MM/yyyy";
            this.rep_NgaySinh.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.rep_NgaySinh.Name = "rep_NgaySinh";
            // 
            // cSDT
            // 
            this.cSDT.Caption = "Số điện thoại";
            this.cSDT.FieldName = "SDT";
            this.cSDT.MinWidth = 25;
            this.cSDT.Name = "cSDT";
            this.cSDT.OptionsColumn.AllowEdit = false;
            this.cSDT.Visible = true;
            this.cSDT.VisibleIndex = 5;
            this.cSDT.Width = 94;
            // 
            // cDiaChi
            // 
            this.cDiaChi.Caption = "Địa chỉ";
            this.cDiaChi.FieldName = "DiaChi";
            this.cDiaChi.MinWidth = 25;
            this.cDiaChi.Name = "cDiaChi";
            this.cDiaChi.OptionsColumn.AllowEdit = false;
            this.cDiaChi.Visible = true;
            this.cDiaChi.VisibleIndex = 6;
            this.cDiaChi.Width = 94;
            // 
            // cMaChucDanh
            // 
            this.cMaChucDanh.Caption = "Chức danh";
            this.cMaChucDanh.FieldName = "MaChucDanh";
            this.cMaChucDanh.MinWidth = 25;
            this.cMaChucDanh.Name = "cMaChucDanh";
            this.cMaChucDanh.OptionsColumn.AllowEdit = false;
            this.cMaChucDanh.Visible = true;
            this.cMaChucDanh.VisibleIndex = 7;
            this.cMaChucDanh.Width = 94;
            // 
            // cbb_GioiTinh
            // 
            this.cbb_GioiTinh.Location = new System.Drawing.Point(788, 24);
            this.cbb_GioiTinh.Name = "cbb_GioiTinh";
            this.cbb_GioiTinh.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F);
            this.cbb_GioiTinh.Properties.Appearance.Options.UseFont = true;
            this.cbb_GioiTinh.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbb_GioiTinh.Properties.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cbb_GioiTinh.Size = new System.Drawing.Size(109, 28);
            this.cbb_GioiTinh.TabIndex = 47;
            // 
            // frm_QuanLyNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1203, 698);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Name = "frm_QuanLyNhanVien";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Quản lý nhân viên";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtp_NgaySinh.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtp_NgaySinh.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_SoDienThoai.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_DiaChi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_HoTen.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_MatKhau.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_TenDangNhap.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gc_Data)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Data)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rep_GioiTinh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rep_NgaySinh.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rep_NgaySinh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbb_GioiTinh.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.SimpleButton btn_TimKiem;
        private DevExpress.XtraEditors.SimpleButton btn_Luu;
        private DevExpress.XtraEditors.SimpleButton btn_Xoa;
        private DevExpress.XtraEditors.SimpleButton btn_Clear;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txt_HoTen;
        private DevExpress.XtraEditors.TextEdit txt_MatKhau;
        private DevExpress.XtraEditors.TextEdit txt_TenDangNhap;
        private DevExpress.XtraEditors.DateEdit dtp_NgaySinh;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit txt_SoDienThoai;
        private DevExpress.XtraEditors.TextEdit txt_DiaChi;
        private DevExpress.XtraGrid.GridControl gc_Data;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_Data;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit rep_GioiTinh;
        private DevExpress.XtraGrid.Columns.GridColumn cTenDangNhap;
        private DevExpress.XtraGrid.Columns.GridColumn cMatKhau;
        private DevExpress.XtraGrid.Columns.GridColumn cHoTenNV;
        private DevExpress.XtraGrid.Columns.GridColumn cGioiTinh;
        private DevExpress.XtraGrid.Columns.GridColumn cNgaySinh;
        private DevExpress.XtraGrid.Columns.GridColumn cSDT;
        private DevExpress.XtraGrid.Columns.GridColumn cDiaChi;
        private DevExpress.XtraGrid.Columns.GridColumn cMaChucDanh;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit rep_NgaySinh;
        private DevExpress.XtraEditors.ComboBoxEdit cbb_GioiTinh;
    }
}