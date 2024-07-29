using Guna.UI2.WinForms;
using System;
using System.Collections;
using System.Data;
using System.Data.SqlClient;

namespace SunriseHotel.Models
{
    public partial class frmAddReservas : frmHone
    {
        public frmAddReservas()
        {
            InitializeComponent();
        }

        public int id = 0;
        public int idCliente = 0;
        public int idHabitacion = 0;


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
                query = @"INSERT INTO reservaciones VALUES(@id_habitacion,@id_cliente,@fecha_entrada,@fecha_salida,
                    @dias,@precio,@cantidad,@recibido,@cambiar,@estatus) ";
            }
            else // Editar
            {
                query = @"UPDATE reservaciones SET id_habitacion = @id_habitacion, id_cliente = @id_cliente,
                        fecha_entrada = @fecha_entrada, fecha_salida = @fecha_salida, dias = @dias, precio = @precio,
                        cantidad= @cantidad, recibido = @recibido, cambiar = @cambiar, estatus = @estatus
                            WHERE id_reservacion = @id ";
            }

            Hashtable ht = new Hashtable();
            ht.Add("@id", id);
            ht.Add("@id_habitacion", Convert.ToInt32(cbHabitacion.SelectedValue));
            ht.Add("@id_cliente", Convert.ToInt32(cbCliente.SelectedValue));
            ht.Add("@fecha_entrada", Convert.ToDateTime(txtFechaIn.Text));
            ht.Add("@fecha_salida", Convert.ToDateTime(txtFechaOut.Text));
            ht.Add("@dias", Convert.ToDouble(txtDias.Text));
            ht.Add("@precio", Convert.ToDouble(txtPrepcio.Text));
            ht.Add("@cantidad", Convert.ToDouble(txtCantidad.Text));
            ht.Add("@recibido", Convert.ToDouble(txtRecibido.Text));
            ht.Add("@cambiar", Convert.ToDouble(txtCambiar.Text));
            ht.Add("@estatus", cbEstado.Text);

            int r = MainClass.SQL(query, ht);
            string query2 = "";

            if (cbEstado.Text == "Registrado")
            {
                query2 = @"UPDATE habitacion SET hab_status = 'Ocupada' WHERE id_habitacion =  
                            " + cbHabitacion.SelectedValue + " ";
            }
            else
            {
                query2 = @"UPDATE habitacion SET hab_status = 'Disponible' WHERE id_habitacion =  
                            " + cbHabitacion.SelectedValue + " ";
            }
            Hashtable ht2 = new Hashtable();
            MainClass.SQL(query2, ht2);

            if (r > 0)
            {
                MainClass.ClearAll(this);
                txtFechaIn.Focus();
                messageSystem.Show("Datos guardados correctamente.");
                id = 0;
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void calDays()
        {
            if (txtFechaIn.Text != "" && txtFechaOut.Text != "")
            {
                DateTime d1 = Convert.ToDateTime(txtFechaIn.Text);
                DateTime d2 = Convert.ToDateTime(txtFechaOut.Text);
                int dias = (d2 - d1).Days + 1;

                double monto = Convert.ToDouble(txtPrepcio.Text);

                txtDias.Text = dias.ToString();

                double amt = dias * monto;

                txtCantidad.Text = amt.ToString();
            }
        }

        private void frmAddReservas_Load(object sender, EventArgs e)
        {
            string query = @"SELECT id_cliente 'id', nombre 'name' FROM clientes";
            MainClass.CBFill(query, cbCliente);

            string query1 = @"SELECT id_habitacion 'id', hab_nombre 'name' FROM habitacion";
            MainClass.CBFill(query1, cbHabitacion);

            txtPrepcio.Text = "";

            if (id > 0)
            {
                cbCliente.SelectedValue = idCliente;
                cbHabitacion.SelectedValue = idHabitacion;
            }
        }

        private void txtRecibido_TextChanged(object sender, EventArgs e)
        {
            if (txtPrepcio.Text != "" && txtRecibido.Text != "")
            {
                double amt = Convert.ToDouble(txtCantidad.Text);
                double rec = Convert.ToDouble(txtRecibido.Text);

                txtCambiar.Text = (rec - amt).ToString();
            }
        }

        private void txtFechaIn_Leave(object sender, EventArgs e)
        {
            calDays();
        }

        private void txtFechaOut_Leave(object sender, EventArgs e)
        {
            calDays();
        }

        private void cbHabitacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbHabitacion.SelectedIndex != -1)
            {
                string query = @"SELECT hab_nombre FROM habitacion";
                SqlCommand con = new SqlCommand(query, MainClass.con);
                SqlDataAdapter da = new SqlDataAdapter(con);
                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    txtPrepcio.Text = dt.Rows[0]["hab_nombre"].ToString();
                }
            }
        }

        private void footerPanel_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {

        }
    }
}
