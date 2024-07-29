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

            string query = "";

            if (id == 0) // Guardar
            {
                query = @"INSERT INTO reservaciones VALUES(@id_habitacion, @id_cliente, @fecha_entrada, @fecha_salida, 
                                      @estatus, @dias, @precio, @cantidad, @recibido, @cambiar) ";
            } else // Editar
            {
                query = @"UPDATE reservaciones SET id_habitacion = @id_habitacion, id_cliente = @id_cliente, 
                                                fecha_entrada = @fecha_entrada, fecha_salida = @fecha_salida,
                                                estatus = @estatus, dias = @dias, precio = @precio,
                                                cantidad = @cantidad, recibido = @recibido, cambiar = @cambiar 
                                                WHERE id_reservacion = @id";
            }

            try
            {
                Hashtable ht = new Hashtable();
                ht.Add("@id", id);
                ht.Add("@id_habitacion", Convert.ToInt32(cbHabitacion.SelectedValue));
                ht.Add("@id_cliente", Convert.ToInt32(cbCliente.SelectedValue));
                ht.Add("@fecha_entrada", Convert.ToDateTime(txtFechaIn.Text));
                ht.Add("@fecha_salida", Convert.ToDateTime(txtFechaOut.Text));
                ht.Add("@estatus", cbEstado.Text);
                ht.Add("@dias", Convert.ToInt32(txtDias.Text));
                ht.Add("@precio", Convert.ToDouble(txtPrepcio.Text));
                ht.Add("@cantidad", Convert.ToDouble(txtCantidad.Text));
                ht.Add("@recibido", Convert.ToDouble(txtRecibido.Text));
                ht.Add("@cambiar", Convert.ToDouble(txtCambiar.Text));

                int r = MainClass.SQL(query, ht);

                string query2 = "";

                if (cbEstado.Text == "Registrado")
                {
                    query2 = @"UPDATE habitacion SET hab_status = 'Ocupada' WHERE id_habitacion =  
                                " + cbHabitacion.SelectedValue + " ";
                }else
                {
                    query2 = @"UPDATE habitacion SET hab_status = 'Disponible' WHERE id_habitacion =  
                        " + cbHabitacion.SelectedValue + " ";
                }

                Hashtable ht2 = new Hashtable();
                MainClass.SQL(query2, ht2);

                if (r > 0)
                {
                    messageSystem.Icon = MessageDialogIcon.Information;
                    messageSystem.Buttons = MessageDialogButtons.OK;
                    messageSystem.Show("Reservacion guardada con exito");
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                messageError.Icon = MessageDialogIcon.Error;
                messageError.Show(ex.Message);
                messageError.Buttons = MessageDialogButtons.OKCancel;
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void calDays()
        {
            if (txtFechaIn.Text != "" && txtFechaOut.Text != "")
            {
                DateTime d1 = Convert.ToDateTime(txtFechaIn.Text);
                DateTime d2 = Convert.ToDateTime(txtFechaOut.Text);

                int dias = (d2 - d1).Days + 1;
                txtDias.Text = dias.ToString();

                double precion = Convert.ToDouble(txtPrepcio.Text);

                double total = dias * precion;
                txtCantidad.Text = total.ToString();
            }
        }

        private void txtRecibido_TextChanged(object sender, EventArgs e)
        {
            if (txtPrepcio.Text != "" && txtRecibido.Text != "")
            {
                double total = Convert.ToDouble(txtCantidad.Text);
                double recibido = Convert.ToDouble(txtRecibido.Text);

                txtCambiar.Text = (total - recibido).ToString();
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
                idHabitacion = Convert.ToInt32(cbHabitacion.SelectedValue);

                string query = @"SELECT hab_precio FROM habitacion WHERE id_habitacion = @id_habitacion";
                SqlCommand con = new SqlCommand(query, MainClass.con);
                con.Parameters.AddWithValue("@id_habitacion", idHabitacion);

                SqlDataAdapter da = new SqlDataAdapter(con);
                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    txtPrepcio.Text = dt.Rows[0]["hab_precio"].ToString();
                } else
                {
                    txtPrepcio.Text = "";
                }
            }
        }

        private void footerPanel_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {

        }
    }
}
