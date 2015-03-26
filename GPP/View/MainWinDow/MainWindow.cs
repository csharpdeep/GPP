using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GPP.View.PhanQuyen;

namespace GPP
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            userControl_PhanQuyen u = new userControl_PhanQuyen();
            u.Dock = DockStyle.Fill;
            panel1.Controls.Clear();
            panel1.Controls.Add(u);
            
        }
    }
}
