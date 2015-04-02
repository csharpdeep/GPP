using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GPP
{
    public partial class frmDangNhapUC : UserControl,IUserControlBase
    {
        public frmDangNhapUC()
        {
            InitializeComponent();
        }

        private void OnParentPanelSizeChanged(object sender, EventArgs e)
        {
            Panel parentPanel = sender as Panel;
            if (parentPanel != null)
            {
                int locX = parentPanel.Width / 2 - this.Width / 2;
                int locY = parentPanel.Height / 2 - this.Height / 2;
                this.Location = new Point(locX,locY);
            } 
        }

        private void OnResizeChange(object sender, EventArgs e)
        {
            this.Size = new Size(529, 318);
        }

        private void frmDangNhapUC_Load(object sender, EventArgs e)
        {
            if (this.Parent != null)
            {
                Panel parentPanel = this.Parent as Panel;
                if (parentPanel != null)
                {
                    parentPanel.Resize += OnParentPanelSizeChanged;
                }
            }
        }

        private void _btnDangNhap_Click(object sender, EventArgs e)
        {
            //Neu dang nhap thanh cong
            string maNV = "NV001";
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
