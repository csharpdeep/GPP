using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GPP.Model;
using GPP.Controller;

namespace GPP.View.PhanQuyen
{
    public partial class userControl_PhanQuyen : UserControl
    {
        public userControl_PhanQuyen()
        {
            InitializeComponent();
        }

        private void userControl_PhanQuyen_Load(object sender, EventArgs e)
        {
            ConnectSQL.Istance.InitInstance();
            string qrChucNang, qrChucVu;
            qrChucNang = "select * from ChucNang";
            qrChucVu = "select * from ChucVu";
            DataTable tableChucNang, tableChucVu;
            tableChucNang = ConnectSQL.Istance.Getdata(qrChucNang);
            tableChucVu = ConnectSQL.Istance.Getdata(qrChucVu);
            dataChucNang.DataSource = tableChucNang;
            dataChucVu.DataSource = tableChucVu;

        }
        private int vtChucVu,
                    vtChucNang;
        private bool isClickCV=false,
                     isClickCN=false;

        private void dataChucVu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            vtChucVu = e.RowIndex;
            lbChucVu.Text = dataChucVu.Rows[vtChucVu].Cells[1].Value.ToString();
            isClickCV = true;
        }

        private void dataChucNang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            vtChucNang = e.RowIndex;
            lbChucNang.Text = dataChucNang.Rows[vtChucNang].Cells[1].Value.ToString();
            isClickCN = true;
            if (isClickCV && isClickCN)
            {
                string maChucNang = dataChucNang.Rows[vtChucNang].Cells[0].Value.ToString();
                string maChucVu = dataChucVu.Rows[vtChucVu].Cells[0].Value.ToString();
                string qr="select xem,them,sua,xoa from PhanQuyen where MaChucNang='"+maChucNang+"' and MaChucVu='"+maChucVu+"'";
                DataTable dataPhanQuyen = ConnectSQL.Istance.Getdata(qr);
                //
                int xem=int.Parse(dataPhanQuyen.Rows[0][0].ToString()),
                    them=int.Parse(dataPhanQuyen.Rows[0][1].ToString()),
                    sua=int.Parse(dataPhanQuyen.Rows[0][2].ToString()),
                    xoa=int.Parse(dataPhanQuyen.Rows[0][3].ToString());
                if (xem == 1)
                {
                    checkboxXem.Checked = true;
                }

                if (them == 1)
                {
                    checkboxThem.Checked = true;
                }
                if (sua == 1)
                {
                    checkboxSua.Checked = true;
                }
                if (xoa == 1)
                {
                    checkboxXoa.Checked = true;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (isClickCN && isClickCV)
            {
                string maChucNang = dataChucNang.Rows[vtChucNang].Cells[0].Value.ToString();
                string maChucVu = dataChucVu.Rows[vtChucVu].Cells[0].Value.ToString();
                Model_PhanQuyen _phanQuyen = new Model_PhanQuyen();
                _phanQuyen.MaChucVu = maChucVu;
                _phanQuyen.MaChucNang = maChucNang;
                if (checkboxXem.Checked)
                {
                    _phanQuyen.Xem = 1;
                }
                else
                {
                    _phanQuyen.Xem = 0;
                }
                //--------------------------
                if (checkboxThem.Checked)
                {
                    _phanQuyen.Them = 1;
                }
                else
                {
                    _phanQuyen.Them = 0;
                }
                //---------------------------
                if (checkboxSua.Checked)
                {
                    _phanQuyen.Sua = 1;
                }
                else
                {
                    _phanQuyen.Sua = 0;
                }
                //----------------------------------------------

                if (checkboxXoa.Checked)
                {
                    _phanQuyen.Xoa = 1;
                }
                else
                {
                    _phanQuyen.Xoa = 0;
                }
                Control_PhanQyen ctPhanQuyen = new Control_PhanQyen();
                ctPhanQuyen.ThayDoiQuyen(_phanQuyen);
            }
            else
            {
                if (isClickCN == false)
                {
                    MessageBox.Show("Bạn chưa chọn chức năng!");
                }
                else
                {
                    MessageBox.Show("Bạn chưa chọn chức vụ!");
                }
            }
        }
    }
}
