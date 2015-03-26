using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GPP
{
    public partial class SplashScreen : Form
    {
        private Timer _timer;
        public SplashScreen()
        {
            InitializeComponent();
            _timer = new Timer();
            _timer.Interval = 50;
            _timer.Tick += OnTimerTick;
            _timer.Enabled = true;
            _timer.Start();
        }

        private void OnTimerTick(object sender, EventArgs e)
        {
            _progressBar.Value++;
            if (_progressBar.Value == _progressBar.Maximum)
            {
                _timer.Stop();
                _timer.Dispose();
                MainWindow frmMain = new MainWindow();
                this.ShowInTaskbar = false;
                this.Hide();
                frmMain.ShowDialog();
            }
        }
    }
}
