using SunriseHotel.Models;
using System;
using System.Collections;
using System.Windows.Forms;

namespace SunriseHotel.Views
{
    public partial class frmUsuariosView : frmHone
    {

        public frmUsuariosView()
        {
            InitializeComponent();
        }

        private void frmUsuarioView_Load(object sender, EventArgs e)
        {
            CargarDataUsers();
        }

        private void CargarDataUsers()
        {
            ListBox lb = new ListBox();
            lb.Items.Add(dgvID);
            lb.Items.Add(dgvNombre);
            lb.Items.Add(dgvApellido);
            lb.Items.Add(dgvTel);
            lb.Items.Add(dgvEmail);
            lb.Items.Add(dgvPass);

            string query = @"SELECT * FROM usuarios WHERE nombre LIKE '%" + txtBuscar.Text + "%'";

            MainClass.CargarData(query, tablaUsuario, lb);
        }

        private void tablaUsuario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Actualizar
            if (tablaUsuario.CurrentCell.OwningColumn.Name == "dgvedit" && e.RowIndex != -1)
            {
                frmUsuarioAdd frm = new frmUsuarioAdd();
                frm.id = Convert.ToInt32(tablaUsuario.CurrentRow.Cells["dgvID"].Value);
                frm.txtNombre.Text = Convert.ToString(tablaUsuario.CurrentRow.Cells["dgvNombre"].Value);
                frm.txtApellido.Text = Convert.ToString(tablaUsuario.CurrentRow.Cells["dgvApellido"].Value);
                frm.txtTelefono.Text = Convert.ToString(tablaUsuario.CurrentRow.Cells["dgvTel"].Value);
                frm.txtCorreo.Text = Convert.ToString(tablaUsuario.CurrentRow.Cells["dgvEmail"].Value);
                frm.txtPass.Text = Convert.ToString(tablaUsuario.CurrentRow.Cells["dgvPass"].Value);

                MainClass.BlurBackground(frm);
                CargarDataUsers();
            }

            // Eliminar
            if (tablaUsuario.CurrentCell.OwningColumn.Name == "dgvDel" && e.RowIndex != -1)
            {
                DataGridViewRow row = tablaUsuario.CurrentRow;
                int ID = Convert.ToInt32(row.Cells["dgvID"].Value);

                if (ID != 0)
                {
                    messageSystem.Buttons = Guna.UI2.WinForms.MessageDialogButtons.YesNo;
                    messageSystem.Icon = Guna.UI2.WinForms.MessageDialogIcon.Error;

                    if (messageSystem.Show("Estas segura que quieres eliminar") == DialogResult.Yes)
                    {
                        try
                        {
                            string query = @"DELETE FROM usuarios WHERE id_usuario = " + ID + "";
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
            MainClass.BlurBackground(new frmUsuarioAdd());

            CargarDataUsers();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            CargarDataUsers();
        }
    }
}
