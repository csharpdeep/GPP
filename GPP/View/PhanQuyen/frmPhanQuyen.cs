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
    public partial class frmPhanQuyen : Form
    {
        private readonly Color _colorChecked = Color.Yellow;
        private readonly Color _colorUnChecked = Color.Gray;

        public frmPhanQuyen()
        {
            InitializeComponent();
            CheckAndInsertTo_PhanQuyen();

            LoadDataChucVu();

            if (_dataGridViewChucVu.RowCount > 0)
            {
                string maChucVu = _dataGridViewChucVu[0, 0].Value.ToString();
                LoadDataPhanQuyen(maChucVu);
            }
        }

        private void LoadDataChucVu()
        {
            _dataGridViewChucVu.DataSource = SqlHelper.Instance.ExecuteDataTable("SELECT * FROM CHUCVU");
        }

        private void LoadDataPhanQuyen(string maChucVu)
        {
            maCV = maChucVu;

            string str1 = "SELECT PHANQUYEN.MAPHANQUYEN, CHUCNANG.MACHUCNANG, CHUCNANG.MOTA, PHANQUYEN.XEM, PHANQUYEN.THEM, PHANQUYEN.SUA, PHANQUYEN.XOA";
            string str2 = " FROM PHANQUYEN, CHUCNANG";
            string str3 = " WHERE PHANQUYEN.MACHUCNANG = CHUCNANG.MACHUCNANG";
            string str4 = " AND PHANQUYEN.MACHUCVU = '" + maChucVu + "'";

            string strSQL = str1 + str2 + str3 + str4;

            DataTable dtb = SqlHelper.Instance.ExecuteDataTable(strSQL);
            _dataGridViewPhanQuyen.DataSource = dtb;
        }

        private void CheckAndInsertTo_PhanQuyen()
        {
            //Lấy toàn bộ dữ liệu bảng ChucNang
            DataTable dtbChucNang = SqlHelper.Instance.ExecuteDataTable("SELECT MACHUCNANG FROM CHUCNANG");

            //Lấy toàn bộ dữ liệu bảng ChucVu
            DataTable dtbChucVu = SqlHelper.Instance.ExecuteDataTable("SELECT MACHUCVU FROM CHUCVU");

            for (int i = 0; i < dtbChucVu.Rows.Count; i++)
            {
                //Lấy ra mã chức vụ
                string maChucVu = dtbChucVu.Rows[i][0].ToString();

                for (int j = 0; j < dtbChucNang.Rows.Count; j++)
                {
                    //Lấy ra mã chức năng
                    string maChucNang = dtbChucNang.Rows[j][0].ToString();

                    //kiểm tra xem đã tồn tại chức năng và phân quyền hay chưa
                    //nếu chưa có thì thêm mới dữ liệu

                    string strSQL = string.Format("SELECT COUNT(*) FROM PHANQUYEN WHERE MACHUCVU = '{0}' AND MACHUCNANG = '{1}'",
                        maChucVu,
                        maChucNang);
                    int rowEffect = SqlHelper.Instance.SelectScalarInt(strSQL);

                    if (rowEffect == 0)
                    {
                        //Tạo ra mã phân quyền mới
                        string maPhanQuyen = SqlHelper.Instance.GetNextPrimaryKey("PHANQUYEN", "MAPHANQUYEN", "PQ000001");

                        //Tạo ra giá trị mặc định cho XEM, THÊM, SỬA, XÓA là 0
                        bool xem = false;
                        bool them = false;
                        bool sua = false;
                        bool xoa = false;

                        rowEffect = (int)SqlHelper.Instance.Insert("PHANQUYEN", new SqlParameter[]
                        {
                            new SqlParameter("MAPHANQUYEN", maPhanQuyen),
                            new SqlParameter("MACHUCVU", maChucVu),
                            new SqlParameter("MACHUCNANG", maChucNang),
                            new SqlParameter("XEM", xem),
                            new SqlParameter("THEM", them),
                            new SqlParameter("SUA", sua),
                            new SqlParameter("XOA", xoa),
                        });
                        if (rowEffect == 0)
                        {
                            throw new ArgumentException("Thêm mới dữ liệu phân quyền lỗi");
                        }
                    }
                }
            }
        }

        private void _dataGridViewChucNang_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            var ckCell = _dataGridViewPhanQuyen.Rows[e.RowIndex].Cells[e.ColumnIndex] as DataGridViewCheckBoxCell;
            if (ckCell != null)
            {
                DataGridViewCellStyle style = new DataGridViewCellStyle();
                if ((bool)ckCell.Value)
                {
                    style.BackColor = _colorChecked;
                }
                else
                {
                    style.BackColor = _colorUnChecked;
                }
                ckCell.Style = style;

                //Lưu vào trong CSDL
                string columnNameNeedToUpdate = _dataGridViewPhanQuyen.Columns[e.ColumnIndex].DataPropertyName;

                string maChucVu = maCV;
                string maChucNang = _dataGridViewPhanQuyen.Rows[e.RowIndex].Cells[1].Value.ToString();
                string maPhanQuyen = _dataGridViewPhanQuyen.Rows[e.RowIndex].Cells[0].Value.ToString();

                int rowEffect = (int)SqlHelper.Instance.Update("PHANQUYEN", 
                    new SqlParameter[]
                    {
                        new SqlParameter(columnNameNeedToUpdate, ckCell.Value)
                    }, new SqlParameter[]
                    {
                        new SqlParameter("MACHUCVU",maChucVu),
                        new SqlParameter("MACHUCNANG",maChucNang),
                        new SqlParameter("MAPHANQUYEN",maPhanQuyen),
                    });
                if (rowEffect == 0)
                {
                    throw new ArgumentException("Update dữ liệu phân quyền lỗi");
                }
            }
        }

        private void _dataGridViewChucNang_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            for (int i = 0; i < _dataGridViewPhanQuyen.RowCount; i++)
            {
                for (int j = 0; j < _dataGridViewPhanQuyen.ColumnCount; j++)
                {
                    var ckCell = _dataGridViewPhanQuyen.Rows[i].Cells[j] as DataGridViewCheckBoxCell;
                    if (ckCell != null)
                    {
                        DataGridViewCellStyle style = new DataGridViewCellStyle();
                        if ((bool)ckCell.Value)
                        {
                            style.BackColor = _colorChecked;
                        }
                        else
                        {
                            style.BackColor = _colorUnChecked;
                        }
                        ckCell.Style = style;
                    }
                }
            }
        }

        string maCV;
        private void _dataGridViewChucVu_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            string maChucVu = _dataGridViewChucVu[0, e.RowIndex].Value.ToString();
            LoadDataPhanQuyen(maChucVu);
        }
    }
}
