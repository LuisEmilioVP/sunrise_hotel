using SunriseHotel.Models;
using System.Collections;
using System.Windows.Forms;
using System;

namespace SunriseHotel.Views
{
    public partial class frmHabitacionesView : frmHone
    {
        public frmHabitacionesView()
        {
            InitializeComponent();
        }

        private void frmHabitacionesView_Load(object sender, EventArgs e)
        {
            CargarDataUsers();
        }

        private void CargarDataUsers()
        {
            ListBox lb = new ListBox();
            lb.Items.Add(dgvID);
            lb.Items.Add(dgvNombre);
            lb.Items.Add(dgvIdTipo);
            lb.Items.Add(dgvTipo);
            lb.Items.Add(dgvPrecio);
            lb.Items.Add(dgvEstatus);

            string query = @"SELECT id_habitacion, hab_nombre, hab_tipo, tipo_nombre, hab_precio, hab_status
                FROM habitacion
                INNER JOIN tipo_habitacion ON habitacion.hab_tipo = tipo_habitacion.id_tipo_habitacion 
                WHERE hab_nombre LIKE '%" + txtBuscar.Text + "%'";

            MainClass.CargarData(query, tablaHabitacion, lb);
        }

        private void tablaHabitacion_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Actualizar
            if (tablaHabitacion.CurrentCell.OwningColumn.Name == "dgvedit" && e.RowIndex != -1)
            {
                frmAddHabitacion frm = new frmAddHabitacion();

                frm.id = Convert.ToInt32(tablaHabitacion.CurrentRow.Cells["dgvID"].Value);
                frm.txtNombre.Text = Convert.ToString(tablaHabitacion.CurrentRow.Cells["dgvNombre"].Value);
                frm.txtPrecio.Text = Convert.ToString(tablaHabitacion.CurrentRow.Cells["dgvPrecio"].Value);
                frm.cbEstado.Text = Convert.ToString(tablaHabitacion.CurrentRow.Cells["dgvEstatus"].Value);
                frm.tipoId = Convert.ToInt32(tablaHabitacion.CurrentRow.Cells["dgvIdTipo"].Value);

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
                            string query = @"DELETE FROM habitacion WHERE id_habitacion = " + ID + "";
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
            MainClass.BlurBackground(new frmAddHabitacion());

            CargarDataUsers();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            CargarDataUsers();
        }
    }
}
