using System;
using System.Windows.Forms;

namespace SunriseHotel
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            btnMaxi.PerformClick();
        }
    }
}
