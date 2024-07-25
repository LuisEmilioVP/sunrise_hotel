using SunriseHotel.Models;
using System.Collections;
using System.Windows.Forms;
using System;

namespace SunriseHotel.Views
{
    public partial class frmClientesView : frmHone
    {
        public frmClientesView()
        {
            InitializeComponent();
        }

        private void frmClientesView_Load(object sender, System.EventArgs e)
        {
            CargarDataUsers();
        }

        private void CargarDataUsers()
        {
            ListBox lb = new ListBox();
            lb.Items.Add(dgvID);
            lb.Items.Add(dgvNombre);
            lb.Items.Add(dgvApellido);
            lb.Items.Add(dgvEmail);
            lb.Items.Add(dgvTelefono);

            string query = @"SELECT * FROM clientes WHERE nombre LIKE '%" + txtBuscar.Text + "%'";

            MainClass.CargarData(query, tablaCliente, lb);
        }

        private void tablaCliente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Actualizar
            if (tablaCliente.CurrentCell.OwningColumn.Name == "dgvedit" && e.RowIndex != -1)
            {
                frmAddCliente frm = new frmAddCliente();

                frm.id = Convert.ToInt32(tablaCliente.CurrentRow.Cells["dgvID"].Value);
                frm.txtNombre.Text = Convert.ToString(tablaCliente.CurrentRow.Cells["dgvNombre"].Value);
                frm.txtApellido.Text = Convert.ToString(tablaCliente.CurrentRow.Cells["dgvApellido"].Value);
                frm.txtEmail.Text = Convert.ToString(tablaCliente.CurrentRow.Cells["dgvEmail"].Value);
                frm.txtTelefono.Text = Convert.ToString(tablaCliente.CurrentRow.Cells["dgvTelefono"].Value);

                MainClass.BlurBackground(frm);
                CargarDataUsers();
            }

            // Eliminar
            if (tablaCliente.CurrentCell.OwningColumn.Name == "dgvDel" && e.RowIndex != -1)
            {
                DataGridViewRow row = tablaCliente.CurrentRow;
                int ID = Convert.ToInt32(row.Cells["dgvID"].Value);

                if (ID != 0)
                {
                    messageSystem.Buttons = Guna.UI2.WinForms.MessageDialogButtons.YesNo;
                    messageSystem.Icon = Guna.UI2.WinForms.MessageDialogIcon.Error;

                    if (messageSystem.Show("Estas segura que quieres eliminar") == DialogResult.Yes)
                    {
                        try
                        {
                            string query = @"DELETE FROM clientes WHERE id_cliente = " + ID + "";
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
            MainClass.BlurBackground(new frmAddCliente());

            CargarDataUsers();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            CargarDataUsers();
        }
    }
}
