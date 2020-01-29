using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace Bao_Hanh
{
    public partial class frm_QuanLyNhanVien : DevExpress.XtraEditors.XtraForm
    {
        public frm_QuanLyNhanVien()
        {
            InitializeComponent();
            dtp_NgaySinh.DateTime = DateTime.Now.AddYears(-16);
        }
        void LoadData()
        {
            try
            {
                DataTable dt = new DataTable();
                string sql = "SELECT MaDV, TenDV, GiaDichVu, ThoiGianBH, TinhTrang FROM dbo.tbl_DichVu";
                dt = Util.GetData(sql);
                gc_Data.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không load được dữ liệu", "Thông báo");
            }
        }

        bool KiemTraKhiLuu(string madv, string tendv, string giadv, string thoigianbaohanh)
        {
            if (string.IsNullOrEmpty(madv))
            {
                MessageBox.Show("Chưa điền mã dịch vụ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return false;
            }
            if (string.IsNullOrEmpty(tendv))
            {
                MessageBox.Show("Chưa điền tên dịch vụ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return false;
            }
            if (string.IsNullOrEmpty(giadv.ToString()))
            {
                MessageBox.Show("Chưa điền mã dịch vụ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return false;
            }
           
            return true;
        }
        bool KiemTraTonTai(string madv)
        {
            string sql = "select * from tbl_DichVu where MaDV = '" + madv + "'";
            DataTable dt = new DataTable();
            dt = Util.GetData(sql);
            return dt.Rows.Count > 0 ? true : false;
        }

        private void gv_Data_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            try
            {
                int row = e.RowHandle;
                if (row >= 0)
                {
                    txt_TenDangNhap.Text = Convert.ToString(gv_Data.GetRowCellValue(row, cTenDangNhap));
                    txt_MatKhau.Text = Convert.ToString(gv_Data.GetRowCellValue(row, cMatKhau));
                    txt_HoTen.Text = Convert.ToString(gv_Data.GetRowCellValue(row, cHoTenNV));
                    txt_SoDienThoai.Text = Convert.ToString(gv_Data.GetRowCellValue(row, cSDT));
                    txt_DiaChi.Text = Convert.ToString(gv_Data.GetRowCellValue(row, cDiaChi));
                    dtp_NgaySinh.DateTime = Convert.ToDateTime(gv_Data.GetRowCellValue(row, cNgaySinh));
                    cbb_GioiTinh.Text = Convert.ToString(gv_Data.GetRowCellValue(row, cGioiTinh));
                }
            }
            catch (Exception  ex)
            {
            }
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            txt_TenDangNhap.Text = txt_SoDienThoai.Text = txt_MatKhau.Text = txt_HoTen.Text = txt_DiaChi.Text = "";
            cbb_GioiTinh.SelectedIndex = 0;
            dtp_NgaySinh.DateTime = DateTime.Now.AddYears(-16);
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            try
            {
                string madv = txtMaDichVu.Text.Trim();
                string tendv = txtTenDV.Text.Trim();
                double giadv = Convert.ToDouble(txtGiaDV.Text);
                int thoigianbh = Convert.ToInt32(cboThoiGianBaoHanh.Text);
                bool tinhtrang = chkTinhTrang.Checked;
                if (!KiemTraKhiLuu(madv, tendv, giadv.ToString(), thoigianbh.ToString()))
                {
                    //Nếu tồn tại thì thông báo cập nhật thông tin
                    if (KiemTraTonTai(madv))
                    {
                        if (MessageBox.Show("Thông tin này đã tồn tại, bạn có muốn cập nhật", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            string sql_capnhat = string.Format("update tbl_DichVu set TenDV = N'{1}', GiaDichVu = {2}, ThoiGianBH = '{3}', TinhTrang = {4} where MaDV = '{0}'",
                                madv, tendv, giadv, thoigianbh, tinhtrang
                                );
                            int capnhat = Util.RunSql(sql_capnhat);
                            if (capnhat > 0)
                            {
                                LoadData();
                                MessageBox.Show("Cập nhật dữ liệu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Cập nhật dữ liệu thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                    }
                    //Thêm mới thông tin
                    else
                    {
                        string sql_themmoi = string.Format("insert into tbl_DichVu(MaDV, TenDV, GiaDichVu, ThoiGianBH, TinhTrang) values ('{0}',N'{1}',{2},'{3}',{4})",
                                madv, tendv, giadv, thoigianbh, tinhtrang
                                );
                        int themmoi = Util.RunSql(sql_themmoi);
                        if (themmoi > 0)
                        {
                            LoadData();
                            MessageBox.Show("Thêm mới thông tin thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Thêm mới thông tin thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Xảy ra lỗi Lưu dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            try
            {
                string madv = txtMaDichVu.Text;
                if (string.IsNullOrEmpty(madv))
                {
                    MessageBox.Show("Chưa chọn thông tin xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    return;
                }
                string sql = "delete tbl_DichVu where MaDV = '" + madv + "'";
                int isxoa = Util.RunSql(sql);
                if (isxoa > 0)
                {
                    LoadData();
                    MessageBox.Show("Xóa dữ liệu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Xóa dữ liệu thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xảy ra lỗi Xóa dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_TimKiem_Click(object sender, EventArgs e)
        {
            try
            {
                string madv = txtMaDichVu.Text.Trim();
                string tendv = txtTenDV.Text.Trim();

                string sql = "select * from tbl_DichVu where 1=1 ";
                if (madv != "")
                {
                    sql += "AND MaDV = '" + madv + "'";
                }
                if (tendv != "")
                {
                    sql += "AND TenDV like N'%" + tendv + "%'";
                }
                DataTable dt = new DataTable();
                dt = Util.GetData(sql);
                if (dt.Rows.Count > 0)
                {
                    gc_Data.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("Không tìm thấy dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Xảy ra lỗi Tìm kiếm dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}