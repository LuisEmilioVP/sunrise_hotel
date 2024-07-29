using SunriseHotel.Views;
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

        static frmMain _object;

        public static frmMain Instance
        {
            get
            {
                if (_object == null || _object.IsDisposed)
                {
                    _object = new frmMain();
                }
                return _object;
            }
        }

        private void AddControll(Form f)
        {
            containerPanel.Controls.Clear();
            f.TopLevel = false;
            containerPanel.Controls.Add(f);
            f.Dock = DockStyle.Fill;
            f.Show();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            btnMaxi.PerformClick();
            _object = this;
        }

        private void itenInicio_Click(object sender, EventArgs e)
        {
            AddControll(new frmDashboard());
        }

        private void itenUsuario_Click(object sender, EventArgs e)
        {
            AddControll(new frmUsuariosView());
        }

        private void itenTipoHabit_Click(object sender, EventArgs e)
        {
            AddControll(new frmTipoHabitView());
        }

        private void itenCliente_Click(object sender, EventArgs e)
        {
            AddControll(new frmClientesView());
        }

        private void itenHabitacion_Click(object sender, EventArgs e)
        {
            AddControll(new frmHabitacionesView());
        }

        private void itenReserva_Click(object sender, EventArgs e)
        {
            AddControll(new frmReservasView());
        }

        private void containerPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {

        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {

        }
    }
}
