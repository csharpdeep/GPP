using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using DongTX.Core;

namespace GPP
{
    public partial class frmChucVu : Form,IUserControlBase
    {
        public frmChucVu()
        {
            InitializeComponent();
            _datagridView.DataSource = SqlHelper.Instance.ExecuteDataTable("SELECT * FROM CHUCVU");
        }

        private void OnDataGridViewCellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            //khi 1 row nào đó sửa dữ liệu xong thì row đó
            // có thể là row mới hoặc row cũ cần update
            int index = e.RowIndex;
            string maChucVu = _datagridView[0, index].Value.ToString();
            string moTa = _datagridView[1, index].Value.ToString();

            bool isUpdate = SqlHelper.Instance.CheckExistKey("CHUCVU", "MACHUCVU", maChucVu);
            if (isUpdate)
            {
                int recordEffect = SqlHelper.Instance.Update("CHUCVU", new SqlParameter[]
                {
                    new SqlParameter("MOTA", moTa)
                }, 
                new SqlParameter[]
                {
                    new SqlParameter("MACHUCVU", maChucVu)
                });

                if (recordEffect <= 0)
                {
                    MessageBox.Show("Không thể sửa dữ liệu này", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                //them moi du lieu
                int recordEffect = (int)SqlHelper.Instance.Insert("CHUCVU", new SqlParameter[]
                {
                    new SqlParameter("MACHUCVU",maChucVu),
                    new SqlParameter("MOTA",moTa),
                });

                if (recordEffect <= 0)
                {
                    MessageBox.Show("Không thể thêm mới dữ liệu", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void OnDatagridViewUserAddedRow(object sender, DataGridViewRowEventArgs e)
        {
            //khi user thêm 1 dòng mới thì ta sẽ lấy mã kế tiếp
            int rowIndex = e.Row.Index - 1;
            _datagridView[0, rowIndex].Value = SqlHelper.Instance.GetNextPrimaryKey("CHUCVU", "MACHUCVU", "CV001");
        }

        private void OnDatagridViewUserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            int index = e.Row.Index;
            string maChucVu = _datagridView[0, index].Value.ToString();
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
                int recordEffect = SqlHelper.Instance.Delete("CHUCVU", new SqlParameter[]
                {
                    new SqlParameter("MaChucVu",maChucVu)
                });

                if (recordEffect <=0)
                {
                    MessageBox.Show("Không thể xóa dữ liệu này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                e.Cancel = true;
            }
        }

        public void Search(string keyWords)
        {
            throw new NotImplementedException();
        }

        public void ProcessKeyUp(ref Message msg, Keys keyData)
        {
            throw new NotImplementedException();
        }
    }
}
