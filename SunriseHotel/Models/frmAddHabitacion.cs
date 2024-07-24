using Guna.UI2.WinForms;
using System;
using System.Collections;

namespace SunriseHotel.Models
{
    public partial class frmAddHabitacion : frmHone
    {
        public frmAddHabitacion()
        {
            InitializeComponent();
        }

        public int id = 0;
        public int tipoId = 0;

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (MainClass.ItensIsEmpty(this))
            {
                messageSystem.Icon = MessageDialogIcon.Information;
                messageSystem.Buttons = MessageDialogButtons.OK;
                messageSystem.Show("Por favor llene todos los campos");
                return;
            }

            string query;

            if (id == 0) // Guardar
            {
                query = @"INSERT INTO habitacion VALUES(@hab_nombre,@hab_tipo,@hab_precio,@hab_status) ";
            }
            else // Editar
            {
                query = @"UPDATE habitacion SET hab_nombre=@hab_nombre,hab_tipo=@hab_tipo,hab_precio=@hab_precio,hab_status=@hab_status
                            WHERE id_habitacion = @id ";
            }

            Hashtable ht = new Hashtable();
            ht.Add("@id", id);
            ht.Add("@hab_nombre", txtNombre.Text);
            ht.Add("@hab_tipo", Convert.ToInt32(cbTipo.SelectedValue));
            ht.Add("@hab_precio", Convert.ToDouble(txtPrecio.Text));
            ht.Add("@hab_status", cbEstado.Text);

            int r = MainClass.SQL(query, ht);

            if (r > 0)
            {
                MainClass.ClearAll(this);
                txtNombre.Focus();
                messageSystem.Show("Datos guardados correctamente.");
                id = 0;
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAddHabitacion_Load(object sender, EventArgs e)
        {
            string query = @"SELECT id_tipo_habitacion 'id', tipo_nombre 'name' FROM tipo_habitacion ";
            MainClass.CBFill(query, cbTipo);

            if (id > 0)
            {
                cbTipo.SelectedValue = tipoId;
            }
        }
    }
}
