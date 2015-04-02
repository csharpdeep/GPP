using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DongTX.Core;
using System.Data.SqlClient;

namespace GPP
{
    public partial class frmNhanVienUC : UserControl
    {
        private int vt;
        private string maNV;

        public frmNhanVienUC()
        {
            InitializeComponent();
            LoadData();
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            maNV = SqlHelper.Instance.GetNextPrimaryKey("NHANVIEN", "MANHANVIEN", "NV001");
            Popup_NhanVien popNv = new Popup_NhanVien(maNV);
            popNv.ShowDialog();
        }

        private void _dataNhanVien_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            string maNV = _dataNhanVien[0, e.RowIndex].Value.ToString();
            vt = e.RowIndex;
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            if (vt >= 0 && vt <= _dataNhanVien.Rows.Count - 1)
            {
                Popup_NhanVien pop = new Popup_NhanVien(_dataNhanVien.Rows[vt].Cells[0].Value.ToString(), true);
                pop.ShowDialog();
            }
            else
            {
                MessageBox.Show("Vi tri chon khong dung",
                                "Thong bao",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }
        }

        private void frmNhanVienUC_Load(object sender, EventArgs e)
        {

        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if (vt >= 0 && vt <= _dataNhanVien.Rows.Count - 1)
            {
                Popup_NhanVien pop = new Popup_NhanVien(_dataNhanVien.Rows[vt].Cells[0].Value.ToString(), true);
                pop.ShowDialog();
            }
            else
            {
                MessageBox.Show("Vi tri chon khong dung, vui lòng chọn lại!",
                                "Thong bao",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }

        }

        private void _dataNhanVien_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            int index = e.Row.Index;
            string maChucVu = _dataNhanVien[0, index].Value.ToString();
            DialogResult dlg = MessageBox.Show(
                "Bạn thực sự muốn xóa "
                + maChucVu
                + "? \nĐiều này sẽ làm cho các dữ liệu liên quan đến mã này có thể bị xóa theo \nHãy xem xét kỹ lưỡng trước khi xóa!",
                "Cảnh báo",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning,
                MessageBoxDefaultButton.Button2);
            if (dlg == DialogResult.Yes)
            {
                //trước khi xóa dữ liệu này, ta sẽ xóa dữ liệu trong bảng ChucNang 
                //tương ứng với mã chức vụ chuẩn bị được xóa
                //xoa du lieu trong database
                int recordEffect = SqlHelper.Instance.Delete("NHANVIEN", new SqlParameter[]
                {
                    new SqlParameter("MANHANVIEN",maNV)
                });

                if (recordEffect <= 0)
                {
                    MessageBox.Show("Không thể xóa dữ liệu này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                MessageBox.Show("Xóa thành công","Thông báo",MessageBoxButtons.OK);
            }
            else
            {
                e.Cancel = true;
            }
        }

        /// <summary>
        /// Get data from database, table NhanVien
        /// </summary>
        private void LoadData()
        {
            string sql = "SELECT NHANVIEN.MANHANVIEN, NHANVIEN.HOTEN, NHANVIEN.DIACHI,NHANVIEN.GIOITINH, "; 
            sql+="NHANVIEN.SDT, NHANVIEN.EMAIL,NHANVIEN.DANTOC,NHANVIEN.TONGIAO, ";
            sql+=   "NHANVIEN.CMTND,NHANVIEN.NGAYCAP, ";
            sql+=  "NHANVIEN.NOICAP,NHANVIEN.NGAYBATDAUVAOLAM, ";
            sql+=  "NHANVIEN.MUCLUONG,NHANVIEN.GHICHU,CHUCVU.MOTA, ";
            sql+=  "NHANVIEN.TAIKHOAN,NHANVIEN.MATKHAU ";
            sql+=  "FROM CHUCVU, NHANVIEN ";
            sql+=  "WHERE CHUCVU.MACHUCVU = NHANVIEN.MACHUCVU";

            _dataNhanVien.DataSource = SqlHelper.Instance.ExecuteDataTable(sql);
        }
    }
}
