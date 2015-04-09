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

            LoadData();
        }
        private int vt;
        void loadData(bool change)
        {
            if (change == true)
            {
                _dataGridView.DataSource = null;
                LoadData();
            }
        }
        private void _btnNhapTuFile_Click(object sender, EventArgs e)
        {
            frmImportThuoc pt = new frmImportThuoc();
            pt._send = new frmImportThuoc.send(loadData);
            pt.ShowDialog();

        }

        private void buttonX3_Click(object sender, EventArgs e)
        {
            String maThuoc = SqlHelper.Instance.GetNextPrimaryKey("THUOC", "MATHUOC", "T000001");
            popupThuoc pt = new popupThuoc(false, maThuoc);
            pt._send = new popupThuoc.send(loadData);
            pt.ShowDialog();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (vt >= 0 && vt < _dataGridView.Rows.Count)
            {
                popupThuoc pt = new popupThuoc(true, _dataGridView.Rows[vt].Cells[0].Value.ToString());
                pt._send = new popupThuoc.send(loadData);
                pt.ShowDialog();
            }
        }

        private void _dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            vt = e.RowIndex;
        }
        private void LoadData()
        {
            string sql = "SELECT THUOC.MATHUOC, THUOC.TENTHUOC, LOAITHUOC.MOTA, THUOC.DONVITINH, THUOC.DONVIQUYDOICAP_1, THUOC.TYLEQUYDOICAP_1,";
                   sql+="THUOC.DONVIQUYDOI_CAP2, THUOC.TYLEQUYDOICAP_2, NHACUNGCAP.TENNHACUNGCAP, THUOC.CONGDUNG, THUOC.CACHSUDUNG,";
                   sql+= "THUOC.XUATXU, THUOC.NHIETDOBAOQUAN, THUOC.DOAMBAOQUAN ";
                   sql+= "FROM THUOC, LOAITHUOC, NHACUNGCAP ";
                   sql+= "WHERE THUOC.MANHACUNGCAP=NHACUNGCAP.MANHACUNGCAP AND THUOC.MALOAITHUOC=LOAITHUOC.MALOAITHUOC ";

            _dataGridView.DataSource = SqlHelper.Instance.ExecuteDataTable(sql);
        }
    }
}
