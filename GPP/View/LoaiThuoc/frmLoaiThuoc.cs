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
    public partial class frmLoaiThuoc : UserControl
    {
        public frmLoaiThuoc()
        {
            InitializeComponent();
            _dataGridView.DataSource = SqlHelper.Instance.ExecuteDataTable("SELECT * FROM LOAITHUOC");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void OnDataGridviewEndClick(object sender, DataGridViewCellEventArgs e)
        {
            //khi 1 row nào đó sửa dữ liệu xong thì row đó
            // có thể là row mới hoặc row cũ cần update
            int index = e.RowIndex;
            string maLoaiThuoc = _dataGridView[0, index].Value.ToString();
            string tenLoaiThuoc = _dataGridView[1, index].Value.ToString();

            bool isUpdate = SqlHelper.Instance.CheckExistKey("LOAITHUOC", "MaLoaiThuoc", maLoaiThuoc);
            if (isUpdate)
            {
                int recordEffect = SqlHelper.Instance.Update("LOAITHUOC", new SqlParameter[]
                {
                    new SqlParameter("MaLoaiThuoc", maLoaiThuoc)
                },
                new SqlParameter[]
                {
                    new SqlParameter("TenLoaiThuoc", tenLoaiThuoc)
                });

                if (recordEffect <= 0)
                {
                    MessageBox.Show("Không thể sửa dữ liệu này", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                //them moi du lieu
                int recordEffect = (int)SqlHelper.Instance.Insert("LOAITHUOC", new SqlParameter[]
                {
                    new SqlParameter("MaLoaiThuoc",maLoaiThuoc),
                    new SqlParameter("TenLoaiTHuoc",tenLoaiThuoc),
                });

                if (recordEffect <= 0)
                {
                    MessageBox.Show("Không thể thêm mới dữ liệu", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void OnDataGridviewAddRow(object sender, DataGridViewRowEventArgs e)
        {
            //khi user thêm 1 dòng mới thì ta sẽ lấy mã kế tiếp
            int rowIndex = e.Row.Index - 1;
            _dataGridView[0, rowIndex].Value = SqlHelper.Instance.GetNextPrimaryKey("LoaiTHuoc", "MaLoaiThuoc", "LT000000000000000001");
        }

        private void OnUserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            int index = e.Row.Index;
            string maLoaiThuoc = _dataGridView[0, index].Value.ToString();
            DialogResult dlg = MessageBox.Show(
                "Bạn thực sự muốn xóa "
                + maLoaiThuoc
                + "? \nĐiều này sẽ làm cho các dữ liệu liên quan đến mã này có thể bị xóa theo \nHãy xem xét kỹ lưỡng trước khi xóa!",
                "Cảnh báo",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning,
                MessageBoxDefaultButton.Button2);
            if (dlg == DialogResult.Yes)
            {
                //xoa du lieu trong database
                int recordEffect = SqlHelper.Instance.Delete("LoaiThuoc", new SqlParameter[]
                {
                    new SqlParameter("MaLoaiThuoc",maLoaiThuoc)
                });

                if (recordEffect <= 0)
                {
                    MessageBox.Show("Không thể xóa dữ liệu này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                e.Cancel = true;
            }
        }
    }
}
