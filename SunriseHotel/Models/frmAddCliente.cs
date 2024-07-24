using Guna.UI2.WinForms;
using System.Collections;

namespace SunriseHotel.Models
{
    public partial class frmAddCliente : frmHone
    {
        public frmAddCliente()
        {
            InitializeComponent();
        }

        public int id = 0;

        private void btnGuardar_Click(object sender, System.EventArgs e)
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
                query = @"INSERT INTO clientes VALUES(@nombre,@apellido,@email,@telefono) ";
            }
            else // Editar
            {
                query = @"UPDATE clientes SET nombre=@nombre,apellido=@apellido,email=@email,telefono=@telefono
                            WHERE id_cliente = @id_cliente ";
            }

            Hashtable ht = new Hashtable();
            ht.Add("@id_cliente", id);
            ht.Add("@nombre", txtNombre.Text);
            ht.Add("@apellido", txtApellido.Text);
            ht.Add("@email", txtEmail.Text);
            ht.Add("@telefono", txtTelefono.Text);

            int r = MainClass.SQL(query, ht);

            if (r > 0)
            {
                MainClass.ClearAll(this);
                txtNombre.Focus();
                messageSystem.Show("Datos guardados correctamente.");
                id = 0;
            }
        }

        private void btnCerrar_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }
    }
}
