using SunriseHotel.Models;
using System;
using System.Collections;
using System.Windows.Forms;

namespace SunriseHotel.Views
{
    public partial class frmReservasView : frmHone
    {
        public frmReservasView()
        {
            InitializeComponent();
        }

        private void frmReservasView_Load(object sender, EventArgs e)
        {
            CargarDataUsers();
        }

        private void CargarDataUsers()
        {
            ListBox lb = new ListBox();
            lb.Items.Add(dgvID);
            lb.Items.Add(dgvIdCliente);
            lb.Items.Add(dgvCliente);
            lb.Items.Add(dgvIDHabit);
            lb.Items.Add(dgvHabitacion);
            lb.Items.Add(dgvIn);
            lb.Items.Add(dgvOut);
            lb.Items.Add(dgvDia);
            lb.Items.Add(dgvPrecio);
            lb.Items.Add(dgvCantidad);
            lb.Items.Add(dgvEstatus);
            lb.Items.Add(dgvCambiar);
            lb.Items.Add(dgvRecibido);

            string query = @"SELECT r.id_reservacion, r.id_cliente, c.nombre, r.id_habitacion, h.hab_nombre, 
                                    r.fecha_entrada, r.fecha_salida, r.dias, r.precio, r.cantidad, r.estatus,
                                    r.cambiar, r.recibido
                                    FROM reservaciones r
                                    INNER JOIN clientes c ON c.id_cliente = r.id_cliente
                                    INNER JOIN habitacion h ON h.id_habitacion = r.id_habitacion
                                    WHERE h.hab_nombre LIKE '%" + txtBuscar.Text + "%'";

            MainClass.CargarData(query, tablaHabitacion, lb);
        }

        private void tablaHabitacion_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Actualizar
            if (tablaHabitacion.CurrentCell.OwningColumn.Name == "dgvedit" && e.RowIndex != -1)
            {
                frmAddReservas frm = new frmAddReservas();

                frm.id = Convert.ToInt32(tablaHabitacion.CurrentRow.Cells["dgvID"].Value);
                frm.idCliente = Convert.ToInt32(tablaHabitacion.CurrentRow.Cells["dgvIdCliente"].Value);
                frm.idHabitacion = Convert.ToInt32(tablaHabitacion.CurrentRow.Cells["dgvIDHabit"].Value);
                frm.txtFechaIn.Text = Convert.ToDateTime(tablaHabitacion.CurrentRow.Cells["dgvIn"].Value).ToString("dd/MM/yyyy");
                frm.txtFechaOut.Text = Convert.ToDateTime(tablaHabitacion.CurrentRow.Cells["dgvOut"].Value).ToString("dd/MM/yyyy");
                frm.txtDias.Text = Convert.ToString(tablaHabitacion.CurrentRow.Cells["dgvDia"].Value);
                frm.txtPrepcio.Text = Convert.ToString(tablaHabitacion.CurrentRow.Cells["dgvPrecio"].Value);
                frm.txtCantidad.Text = Convert.ToString(tablaHabitacion.CurrentRow.Cells["dgvCantidad"].Value);
                frm.cbEstado.Text = Convert.ToString(tablaHabitacion.CurrentRow.Cells["dgvEstatus"].Value);
                frm.txtCambiar.Text = Convert.ToString(tablaHabitacion.CurrentRow.Cells["dgvCambiar"].Value);
                frm.txtRecibido.Text = Convert.ToString(tablaHabitacion.CurrentRow.Cells["dgvRecibido"].Value);

                MainClass.BlurBackground(frm);
                CargarDataUsers();
            }

            // Eliminar
            if (tablaHabitacion.CurrentCell.OwningColumn.Name == "dgvDel" && e.RowIndex != -1)
            {
                DataGridViewRow row = tablaHabitacion.CurrentRow;
                int ID = Convert.ToInt32(row.Cells["dgvID"].Value);

                if (ID != 0)
                {
                    messageSystem.Buttons = Guna.UI2.WinForms.MessageDialogButtons.YesNo;
                    messageSystem.Icon = Guna.UI2.WinForms.MessageDialogIcon.Error;

                    if (messageSystem.Show("Estas segura que quieres eliminar") == DialogResult.Yes)
                    {
                        try
                        {
                            string query = @"DELETE FROM reservaciones WHERE id_reservacion = " + ID + "";
                            Hashtable ht = new Hashtable();

                            int r = MainClass.SQL(query, ht);

                            if (r > 0)
                            {
                                messageSystem.Icon = Guna.UI2.WinForms.MessageDialogIcon.Information;
                                messageSystem.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
                                messageSystem.Show("Datos eliminados correctamente");
                                ID = 0;
                                CargarDataUsers();
                            }
                            else
                            {
                                messageSystem.Icon = Guna.UI2.WinForms.MessageDialogIcon.Error;
                                messageSystem.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
                                messageSystem.Show("No se pudo eliminar");
                            }
                        }
                        catch (Exception ex)
                        {
                            messageSystem.Show(ex.Message.ToString());
                            MainClass.con.Close();
                        }
                    }
                }
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            MainClass.BlurBackground(new frmAddReservas());

            CargarDataUsers();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            CargarDataUsers();
        }
    }
}
