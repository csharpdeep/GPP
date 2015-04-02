using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GPP.View.ChucVu
{
    public partial class frm_ThemChucVu : Form
    {
        public frm_ThemChucVu()
        {
            InitializeComponent();
        }

        private void frm_ThemChucVu_Load(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            frmChucVuUC uc_chucvu = new frmChucVuUC();
            uc_chucvu.Dock = DockStyle.Fill;
            panel1.Controls.Add(uc_chucvu);
        }
    }
}
