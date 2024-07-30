using SunriseHotel.DetallesHabitaciones;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SunriseHotel.Views
{
    public partial class frmDashboard : frmHone
    {
        public frmDashboard()
        {
            InitializeComponent();
        }

        private void guna2Button9_Click(object sender, EventArgs e)
        {
            
            Form detallesHab = new detallesHabitacione();

            detallesHab.ShowDialog();

           
        }

        private void containerPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
