using System;
using System.Collections;
using Guna.UI2.WinForms;

namespace SunriseHotel.Models
{
    public partial class frmUsuarioAdd : frmAddInfo
    {
        public frmUsuarioAdd()
        {
            InitializeComponent();
        }

        public int id = 0;

        public override void btnGuardar_Click(object sender, EventArgs e)
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
                query = @"INSERT INTO usuarios VALUES(@nombre,@apellido,@email,@telefono,@clave) ";
            }
            else // Editar
            {
                query = @"UPDATE usuarios SET nombre=@nombre,apellido=@apellido,email=@email,telefono=@telefono,clave=@clave
                            WHERE id_usuario = @id_usuario ";
            }

            Hashtable ht = new Hashtable();
            ht.Add("@id_usuario", id);
            ht.Add("@nombre", txtNombre.Text);
            ht.Add("@apellido", txtApellido.Text);
            ht.Add("@email", txtCorreo.Text);
            ht.Add("@telefono", txtTelefono.Text);
            ht.Add("@clave", txtPass.Text);

            int r = MainClass.SQL(query, ht);

            if (r > 0)
            {
                MainClass.ClearAll(this);
                txtNombre.Focus();
                messageSystem.Show("Datos guardados correctamente.");
                id = 0;
            }   
        }
    }
}
