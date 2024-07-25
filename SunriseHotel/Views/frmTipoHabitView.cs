using SunriseHotel.Models;
using System.Collections;
using System.Windows.Forms;
using System;

namespace SunriseHotel.Views
{
    public partial class frmTipoHabitView : frmHone
    {
        public frmTipoHabitView()
        {
            InitializeComponent();
        }

        private void frmTipoHabitView_Load(object sender, EventArgs e)
        {
            CargarDataUsers();
        }

        private void CargarDataUsers()
        {
            ListBox lb = new ListBox();
            lb.Items.Add(dgvID);
            lb.Items.Add(dgvNombre);
            lb.Items.Add(dgvDescripcion);

            string query = @"SELECT * FROM tipo_habitacion WHERE tipo_nombre LIKE '%" + txtBuscar.Text + "%'";

            MainClass.CargarData(query, tablaTipoHabit, lb);
        }

        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            MainClass.BlurBackground(new frmAddTipoHabit());

            CargarDataUsers();
        }

        private void txtBuscar_TextChanged_1(object sender, EventArgs e)
        {
            CargarDataUsers();
        }

        private void tablaTipoHabit_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Actualizar
            if (tablaTipoHabit.CurrentCell.OwningColumn.Name == "dgvedit" && e.RowIndex != -1)
            {
                frmAddTipoHabit frm = new frmAddTipoHabit();

                frm.id = Convert.ToInt32(tablaTipoHabit.CurrentRow.Cells["dgvID"].Value);
                frm.txtNombre.Text = Convert.ToString(tablaTipoHabit.CurrentRow.Cells["dgvNombre"].Value);
                frm.txtDescripcion.Text = Convert.ToString(tablaTipoHabit.CurrentRow.Cells["dgvDescripcion"].Value);

                MainClass.BlurBackground(frm);
                CargarDataUsers();
            }

            // Eliminar
            if (tablaTipoHabit.CurrentCell.OwningColumn.Name == "dgvDel" && e.RowIndex != -1)
            {
                DataGridViewRow row = tablaTipoHabit.CurrentRow;
                int ID = Convert.ToInt32(row.Cells["dgvID"].Value);

                if (ID != 0)
                {
                    messageSystem.Buttons = Guna.UI2.WinForms.MessageDialogButtons.YesNo;
                    messageSystem.Icon = Guna.UI2.WinForms.MessageDialogIcon.Error;

                    if (messageSystem.Show("Estas segura que quieres eliminar") == DialogResult.Yes)
                    {
                        try
                        {
                            string query = @"DELETE FROM tipo_habitacion WHERE id_tipo_habitacion = " + ID + "";
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
    }
}
