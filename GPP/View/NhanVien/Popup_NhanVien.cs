using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DongTX.Core;
using System.Data.SqlClient;

namespace GPP
{
    public partial class Popup_NhanVien : Form
    {
        private bool _isUpdate;

        public Popup_NhanVien(string maNV, bool isUpdate = false)
        {
            InitializeComponent();

            DataTable dtcv = SqlHelper.Instance.ExecuteDataTable("Select * FROM CHUCVU");
            cb_ChucVu.DataSource = dtcv;
            cb_ChucVu.DisplayMember = "MOTA";
            cb_ChucVu.ValueMember = "MACHUCVU";

            _isUpdate = isUpdate;
            if (isUpdate == false)
            {
                txt_manv.Text = maNV;
            }
            else
            {
                //lay data tu csdl do len cac text
                DataTable dtnv = SqlHelper.Instance.ExecuteDataTable("Select * from NHANVIEN WHERE MANHANVIEN='" + maNV + "'");
                txt_manv.Text = maNV;
                txt_Hoten.Text = dtnv.Rows[0][1].ToString();
                txt_DiaChi.Text = dtnv.Rows[0][2].ToString();
                _checkNam.Checked = dtnv.Rows[0][3].ToString() == "True" ? true : false;
                txt_SDT.Text = dtnv.Rows[0][4].ToString();
                txt_Email.Text = dtnv.Rows[0][5].ToString();
                txt_DanToc.Text = dtnv.Rows[0][6].ToString();
                txt_TonGiao.Text = dtnv.Rows[0][7].ToString();
                txt_CMTND.Text = dtnv.Rows[0][8].ToString();
                date_NgayCap.Value = DateTime.Parse(dtnv.Rows[0][9].ToString());
                txt_NoiCap.Text = dtnv.Rows[0][10].ToString();
                date_ngayBatDauLam.Value = DateTime.Parse(dtnv.Rows[0][11].ToString());
                txt_MucLuong.Text = dtnv.Rows[0][12].ToString();
                txt_GhiChu.Text = dtnv.Rows[0][13].ToString();
                cb_ChucVu.SelectedValue = dtnv.Rows[0][14].ToString();
                txt_TaiKhoan.Text = dtnv.Rows[0][15].ToString();
                txt_MatKhau.Text = dtnv.Rows[0][16].ToString();
            }
            
        }
       
        private void CleanAllTextOnScreen()
        {
            foreach (Control item in _groupBox.Controls)
            {
                if (item is TextBox && item.Enabled == true)
                {
                    item.Text = "";
                }
            }    
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void Popup_NhanVien_Load(object sender, EventArgs e)
        {

        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (CheckData())
            {
                if (_isUpdate)
                {
                    UpdateData();
                }
                else
                {
                    InsertData();
                }
            }
            else
            {
                MessageBox.Show("Xem lai du lieu nhap vao, cac muc dau * la yeu cau bat buoc");
            }
        }

        private bool CheckData()
        {
            if (string.IsNullOrEmpty(txt_TaiKhoan.Text))
            {
                _labelCheckTenDangNhap.Visible = true;
                txt_TaiKhoan.Focus();
                return false;
            }
            //kiem tra mot so thu khac tuong tu
            return true;
        }

        private void UpdateData()
        {
            //viet cau lenh sua
            int recordEffect = SqlHelper.Instance.Update("NHANVIEN", new SqlParameter[]
                {   
                    new SqlParameter("HOTEN", txt_Hoten.Text),
                    new SqlParameter("DIACHI", txt_DiaChi.Text),
                    new SqlParameter("GIOITINH", _checkNam.Checked),
                    new SqlParameter("SDT", txt_SDT.Text),
                    new SqlParameter("EMAIL", txt_Email.Text),
                    new SqlParameter("DANTOC", txt_DanToc.Text),
                    new SqlParameter("TONGIAO", txt_TonGiao.Text),
                    new SqlParameter("CMTND", txt_CMTND.Text),
                    new SqlParameter("NGAYCAP", date_NgayCap.Text),
                    new SqlParameter("NGAYBATDAUVAOLAM", date_ngayBatDauLam.Text),
                    new SqlParameter("MUCLUONG", txt_MucLuong.Text),
                    new SqlParameter("GHICHU", txt_GhiChu.Text),
                    new SqlParameter("MACHUCVU",cb_ChucVu.SelectedValue),
                    new SqlParameter("TAIKHOAN", txt_TaiKhoan.Text),
                    new SqlParameter("MATKHAU", txt_MatKhau.Text)
                },
                new SqlParameter[]{
                    new SqlParameter("MANHANVIEN", txt_manv.Text),
                });
            if (recordEffect <= 0)
            {
                MessageBox.Show("Không thể sửa dữ liệu này", 
                    "Lỗi", 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Warning);
            }
        }

        private void InsertData()
        {
            //them moi du lieu  
            int recordEffect = (int)SqlHelper.Instance.Insert("NHANVIEN", new SqlParameter[]
                {
                    new SqlParameter("MANHANVIEN",txt_manv.Text),
                    new SqlParameter("HOTEN", txt_Hoten.Text),
                    new SqlParameter("DIACHI", txt_DiaChi.Text),
                    new SqlParameter("GIOITINH", _checkNam.Checked),
                    new SqlParameter("SDT", txt_SDT.Text),
                    new SqlParameter("EMAIL", txt_Email.Text),
                    new SqlParameter("DANTOC", txt_DanToc.Text),
                    new SqlParameter("TONGIAO", txt_TonGiao.Text),
                    new SqlParameter("CMTND", txt_CMTND.Text),
                    new SqlParameter("NGAYCAP", date_NgayCap.Text),
                    new SqlParameter("NGAYBATDAUVAOLAM", date_ngayBatDauLam.Text),
                    new SqlParameter("MUCLUONG", txt_MucLuong.Text),
                    new SqlParameter("GHICHU", txt_GhiChu.Text),
                    new SqlParameter("MACHUCVU",cb_ChucVu.SelectedValue),
                    new SqlParameter("TAIKHOAN", txt_TaiKhoan.Text),
                    new SqlParameter("MATKHAU", txt_MatKhau.Text)
                });
            if (recordEffect <= 0)
            {
                MessageBox.Show("Không thể thêm mới dữ liệu", 
                    "Lỗi", 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Thêm mới nhân viên thành công!", 
                    "Thông báo", 
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            CleanAllTextOnScreen();
        }
    }
}
