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

namespace GPP
{
    public partial class frmThuocUC : DevComponents.DotNetBar.Office2007Form
    {
        public frmThuocUC()
        {
            InitializeComponent();

            _dataGridView.DataSource = SqlHelper.Instance.ExecuteDataTable("SELECT *FROM THUOC");
        }
        private string fileName;
        private int vt;
        private void bntSelectFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Title = "Chọn file để import dữ liệu vào";
            if (op.ShowDialog() == DialogResult.OK)
            {
            //    fileName = op.FileName;
            //    txtFileName.Text = fileName;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String maThuoc = SqlHelper.Instance.GetNextPrimaryKey("LOAITHUOC", "MALOAITHUOC", "T00001");
            popupThuoc pt = new popupThuoc(false,maThuoc);
            pt.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //if (vt >= 0 && vt < _dataGridView.Rows.Count)_dataGridView.Rows[vt].Cells[0].Value.ToString()
            {
                popupThuoc pt = new popupThuoc(true,"Nhan vien 1");
                pt.ShowDialog();
            }
        }

        private void _dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            vt = e.RowIndex;
        }

        private void _btnNhapTuFile_Click(object sender, EventArgs e)
        {
            new frmImportThuoc().ShowDialog();
        }
    }
}
