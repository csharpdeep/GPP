using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevComponents.DotNetBar;

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
                LoadData();
            }
        }
        private void _btnNhapTuFile_Click(object sender, EventArgs e)
        {
            new frmImportThuoc().ShowDialog();
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
            string sql = "SELECT THUOC.MATHUOC, THUOC.TENTHUOC, LOAITHUOC.MOTA, DONVITINH.MOTA AS DVT, THUOC.DONVIQUYDOICAP_1, THUOC.TYLEQUYDOICAP_1, ";
                   sql+="THUOC.DONVIQUYDOI_CAP2, THUOC.TYLEQUYDOICAP_2, THUOC.HOATCHATCHINH, THUOC.CONGDUNG, THUOC.CACHSUDUNG, ";
                   sql+= "THUOC.XUATXU, THUOC.NHIETDOBAOQUAN, THUOC.DOAMBAOQUAN ";
                   sql+= "FROM THUOC, LOAITHUOC,DONVITINH ";
                   sql+= "WHERE THUOC.MALOAITHUOC=LOAITHUOC.MALOAITHUOC AND THUOC.DONVITINH=DONVITINH.MADONVI ";

            _dataGridView.DataSource = SqlHelper.Instance.ExecuteDataTable(sql);
        }

        private void buttonX5_Click(object sender, EventArgs e)
        {
            ToastNotification.Show(this, "Hello");
        }
    }
}
