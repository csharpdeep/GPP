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
        private int vt;
        void loadData(bool change)
        {
            if (change == true)
            {
                _dataGridView.Rows.Clear();
                _dataGridView.DataSource = SqlHelper.Instance.ExecuteDataTable("SELECT *FROM THUOC");
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

        private void buttonX3_Click(object sender, EventArgs e)
        {
            String maThuoc = SqlHelper.Instance.GetNextPrimaryKey("LOAITHUOC", "MALOAITHUOC", "T00001");
            popupThuoc pt = new popupThuoc(false, maThuoc);
            pt._send = new popupThuoc.send(loadData);
            pt.ShowDialog();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (vt >= 0 && vt < _dataGridView.Rows.Count);
            {
                popupThuoc pt = new popupThuoc(true, _dataGridView.Rows[vt].Cells[0].Value.ToString());
                pt._send = new popupThuoc.send(loadData);
                pt.ShowDialog();
            }
        }
    }
}
