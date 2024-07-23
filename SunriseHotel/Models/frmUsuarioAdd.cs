using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SunriseHotel.Models
{
    public partial class frmUsuarioAdd : frmAddInfo
    {
        public frmUsuarioAdd()
        {
            InitializeComponent();
        }

        public int id = 0;

        public override void btnGuardar_Click(object sender, System.EventArgs e)
        {
            string query;

            if (id == 0) // Guardar
            {
                query = @"INSERT INTO usuarios VALUES(@nombre, @apellido, @email, @telefono, @clave)";
            }
            else // Editar
            {
                query = @"UPDATE usuarios SET nombre=@nombre, apellido=@apellido, email=@email, telefono=@telefono, clave=@clave
                            WHERE id_usuario=@id_usuario";
            }

            Hashtable ht = new Hashtable();
            ht.Add("@id_usuario", id);
            ht.Add("@nombre", id);
            ht.Add("@apellido", id);
            ht.Add("@email", id);
            ht.Add("@telefono", id);
            ht.Add("@clave", id);

            int r = MainClass.SQL(query, ht);

            if (r == 0)
            {
                messageSystem.Show("Datos guardados");
                id = 0;
                MainClass.ClearAll(this);
                txtNombre.Focus();
            }
        }
    }
}
