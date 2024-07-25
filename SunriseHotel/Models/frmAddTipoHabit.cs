using Guna.UI2.WinForms;
using System;
using System.Collections;

namespace SunriseHotel.Models
{
    public partial class frmAddTipoHabit : frmHone
    {
        public frmAddTipoHabit()
        {
            InitializeComponent();
        }

        public int id = 0;

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
                query = @"INSERT INTO tipo_habitacion VALUES(@tipo_nombre,@tipo_descripcion) ";
            }
            else // Editar
            {
                query = @"UPDATE tipo_habitacion SET tipo_nombre=@tipo_nombre,tipo_descripcion=@tipo_descripcion
                            WHERE id_tipo_habitacion = @id_tipo_habitacion ";
            }

            Hashtable ht = new Hashtable();
            ht.Add("@id_tipo_habitacion", id);
            ht.Add("@tipo_nombre", txtNombre.Text);
            ht.Add("@tipo_descripcion", txtDescripcion.Text);

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
    }
}
