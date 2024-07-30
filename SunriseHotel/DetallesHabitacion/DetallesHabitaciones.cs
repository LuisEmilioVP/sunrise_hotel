using SunriseHotel.DetallesHabitacion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SunriseHotel.DetallesHabitaciones
{
    public partial class detallesHabitacione : Form
    {
        public detallesHabitacione()
        {
            InitializeComponent();
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        public void loadform (object Form)
        {
            if (this.mainpanel.Controls.Count > 0)
                this.mainpanel.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.mainpanel.Controls.Add(f);
            this.mainpanel.Tag = f;
            f.Show();

        }

        private void boton2_Click(object sender, EventArgs e)
        {
            loadform(new villa());
        }

        private void boton3_Click(object sender, EventArgs e)
        {
            loadform(new hab1());
        }

        private void boton4_Click(object sender, EventArgs e)
        {
            loadform(new hab2());
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
          
        }

        private void boton1_Click(object sender, EventArgs e)
        {
            loadform(new habcero());
        }

        private void guna2HtmlLabel3_Click(object sender, EventArgs e)
        {

        }

        private void mainpanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void itenTipoHabit_Click(object sender, EventArgs e)
        {
           

        }
    }
}
