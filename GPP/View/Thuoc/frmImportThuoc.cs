using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using DongTX.Core;

namespace GPP
{
    public partial class frmImportThuoc : DevComponents.DotNetBar.OfficeForm
    {

        public frmImportThuoc()
        {
            InitializeComponent();
        }
        private string _fileName;
        //private Exel e=new Exel();
        private bool _isSelectFile = false;
        private void buttonX1_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Title = "Mở file Exel để import dữ liệu";
            if (op.ShowDialog() == DialogResult.OK)
            {
                _fileName = op.FileName;
                txtPatch.Text = _fileName;
                _isSelectFile = true;
            }
        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonX3_Click(object sender, EventArgs e)
        {
            if (_isSelectFile == false)
            {
                MessageBox.Show("Bạn cần phải chọn file để import dữ liệu!");
            }
            else
            {
                if (checkDeleteAllThuoc.Checked == true)
                {
                    SqlHelper.Instance.Execute("DELETE FROM THUOC");
                }

            }
        }
    }
}