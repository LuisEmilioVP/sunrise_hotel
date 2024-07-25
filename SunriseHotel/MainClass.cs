using System;
using System.Collections;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using Guna.UI2.WinForms;


namespace SunriseHotel
{
    class MainClass
    {
        // Server=DESKTOP-I17B7NG;Database=DBVENTA;User ID=sa;Password=@Data-Base;MultipleActiveResultSets=true
        
        public static readonly string connet = "Data Source=DESKTOP-UTP1H92;Initial Catalog=db_sys_hotel;User ID=Alis_1;Password=12345678;";
        public static SqlConnection con = new SqlConnection(connet);

        public static string usuario;

        public static string Usuario
        {
            get { return usuario; }
            set { usuario = value; }
        }

        // METODO VALIDAR USUARIOS
        public static bool isUserValid(string user, string pass)
        {
            bool valid = false;

            string query = "SELECT * FROM usuarios WHERE nombre = '" + user + "' AND clave = '" + pass + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            DataTable data = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(data);

            if (data.Rows.Count > 0)
            {
                valid = true;
                
                Usuario = data.Rows[0]["usuarios"].ToString();
            }

            return valid;
        }

        // METODO BLUR BACKGROUND
        public static void BlurBackground(Form Model)
        {
            Form bgForm = new Form();
            using (Model)
            {
                bgForm.StartPosition = FormStartPosition.Manual;
                bgForm.FormBorderStyle = FormBorderStyle.None;
                bgForm.Opacity = 0.5d;
                bgForm.BackColor = Color.Black;
                bgForm.Size = frmMain.Instance.Size;
                bgForm.Location = frmMain.Instance.Location;
                bgForm.ShowInTaskbar = false;
                bgForm.Show();
                Model.Owner = bgForm;
                Model.ShowDialog(bgForm);
                bgForm.Dispose();
            }
        }

        // METODO CARGAR DATOS
        public static void CargarData(string query, DataGridView data, ListBox lb)
        {
            data.CellFormatting += new DataGridViewCellFormattingEventHandler(data_CellFormatting);

            try
            {
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.CommandType = CommandType.Text;
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                for (int i = 0; i < lb.Items.Count; i++)
                {
                    string columnName = ((DataGridViewColumn)lb.Items[i]).Name;
                    data.Columns[columnName].DataPropertyName = dt.Columns[i].ToString();
                }

                data.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                con.Close();
            }
        }

        // METODO CARGAR DATOS DE UNA TABLA
        private static void data_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            Guna.UI2.WinForms.Guna2DataGridView data = (Guna.UI2.WinForms.Guna2DataGridView)sender;
            int count = 0;

            foreach (DataGridViewRow row in data.Rows)
            {
                count++;
                row.Cells[0].Value = count;
            }
        }

        // METODO SQL DE CONSULTAS - INSERT, UPDATE, DELETE
        public static int SQL (string query, Hashtable ht)
        {
            int res = 0;

            try
            {
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.CommandType = CommandType.Text;

                foreach (DictionaryEntry item in ht)
                {
                    cmd.Parameters.AddWithValue(item.Key.ToString(), item.Value);
                }

                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                res = cmd.ExecuteNonQuery();

                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                con.Close();
            }
            return res;
        }

        // METODO CARGAR COMBOBOX DE DATOS
        public static void CBFill(string query, ComboBox cb)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.CommandType = CommandType.Text;

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                cb.DisplayMember = "name";
                cb.ValueMember = "Id";
                cb.DataSource = dt;
                cb.SelectedIndex = 0;
                cb.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MainClass.con.Close();
                MessageBox.Show(ex.Message.ToString());
            }
        }

        public static void ClearAll (Form form)
        {
            foreach (Control item in form.Controls)
            {
                Type type = item.GetType();

                if(type == typeof(Guna2TextBox))
                {
                    ((Guna2TextBox)item).Text = "";
                }
                else if (type == typeof(Guna2ComboBox))
                {
                    ((Guna2ComboBox)item).SelectedIndex = -1;
                }
                else if (type == typeof(Guna2CheckBox))
                {
                    ((Guna2CheckBox)item).Checked = false;
                }
            }
        }
    }
}
