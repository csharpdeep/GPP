using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using DongTX.Core;
using GPP.View.Thuoc;
using System.Data.SqlClient;

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


                //chen du lieu vao
                ProcessExel exel = new ProcessExel(_fileName);
                DataTable dataThuoc = exel.getDataFromExel();
                for (int i = 0; i < dataThuoc.Rows.Count; i++)
                {
                    string _maThuoc = SqlHelper.Instance.GetNextPrimaryKey("LOAITHUOC", "MALOAITHUOC", "T000001"),
                            _tenThuoc = dataThuoc.Rows[i][2].ToString(),
                            //_loaiTHuoc=dataThuoc.Rows[i][2].ToString(),
                            _hoatChatChinh = dataThuoc.Rows[i][3].ToString(),
                            _donViTinh = dataThuoc.Rows[i][4].ToString(),
                            _DVQD1 = dataThuoc.Rows[i][5].ToString(),
                            _TLQD1 = dataThuoc.Rows[i][6].ToString(),
                            _xuatXu = dataThuoc.Rows[i][15].ToString(),
                            _doAm = "",
                            _nhietDo = "",
                            _congDung = "",
                            _cachDung = "";
                    if (SqlHelper.Instance.CheckExistKey("DONVITINH", "MOTA", _donViTinh.ToString()))
                    {
                        DataTable DVT = SqlHelper.Instance.ExecuteDataTable("Select MADONVI from DONVITINH Where MOTA='" + _donViTinh + "'");
                        _donViTinh = DVT.Rows[0][0].ToString();
                        int recordEffect = (int)SqlHelper.Instance.Insert("THUOC", new SqlParameter[]
                            {
                                new SqlParameter("MATHUOC",_maThuoc),
                                new SqlParameter("TENTHUOC",_tenThuoc),
                                new SqlParameter("MALOAITHUOC",""),
                                new SqlParameter("DONVITINH",_donViTinh),
                                new SqlParameter("DONVIQUYDOICAP_1",_DVQD1),
                                new SqlParameter("TYLEQUYDOICAP_1",_TLQD1),
                                new SqlParameter("DONVIQUYDOI_CAP2",""),
                                new SqlParameter("TYLEQUYDOICAP_2",""),
                                new SqlParameter("HOATCHATCHINH",_hoatChatChinh),
                                new SqlParameter("CONGDUNG",_congDung),
                                new SqlParameter("CACHSUDUNG",_cachDung),
                                new SqlParameter("XUATXU",_xuatXu),
                                new SqlParameter("NHIETDOBAOQUAN",_nhietDo),
                                new SqlParameter("DOAMBAOQUAN",_doAm) 
                            });
                        if (recordEffect <= 0)
                        {
                            //bao loi
                        }
                    }
                    else
                    {
                        inforError.Text="Lỗi dòng "+i+"\n";
                    }
                }
            }
        }
    }
}