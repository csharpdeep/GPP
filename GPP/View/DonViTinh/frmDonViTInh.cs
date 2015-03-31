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
    public partial class frmDonViTInh : UserControl
    {
        public frmDonViTInh()
        {
            InitializeComponent();
            _dataGridView.DataSource = SqlHelper.Instance.ExecuteDataTable("SELECT * FROM DONVITINH");
        }

        private void OnDataGridviewCellEndEdited(object sender, DataGridViewCellEventArgs e)
        {
            //khi 1 row nào đó sửa dữ liệu xong thì row đó
            // có thể là row mới hoặc row cũ cần update
            int index = e.RowIndex;
            string maDonVi = _dataGridView[0, index].Value.ToString();
            string moTa = _dataGridView[1, index].Value.ToString();

            bool isUpdate = SqlHelper.Instance.CheckExistKey("DONVITINH", "MaDonVi", maDonVi);
            if (isUpdate)
            {
                int recordEffect = SqlHelper.Instance.Update("DONVITINH", new SqlParameter[]
                {
                    new SqlParameter("MoTa", moTa)
                },
                new SqlParameter[]
                {
                    new SqlParameter("MaDonVi", maDonVi)
                });

                if (recordEffect <= 0)
                {
                    MessageBox.Show("Không thể sửa dữ liệu này", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                //them moi du lieu
                int recordEffect = (int)SqlHelper.Instance.Insert("DONVITINH", new SqlParameter[]
                {
                    new SqlParameter("MaDonVi",maDonVi),
                    new SqlParameter("MoTa",moTa),
                });

                if (recordEffect <= 0)
                {
                    MessageBox.Show("Không thể thêm mới dữ liệu", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void OnUserAddedRow(object sender, DataGridViewRowEventArgs e)
        {
            //khi user thêm 1 dòng mới thì ta sẽ lấy mã kế tiếp
            int rowIndex = e.Row.Index - 1;
            _dataGridView[0, rowIndex].Value = SqlHelper.Instance.GetNextPrimaryKey("DONVITINH", "MaDonVi", "DV00000000001");
        }

        private void OnUserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            int index = e.Row.Index;
            string maChucVu = _dataGridView[0, index].Value.ToString();
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
                int recordEffect = SqlHelper.Instance.Delete("DONVITINH", new SqlParameter[]
                {
                    new SqlParameter("MaDonVi",maChucVu)
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
