namespace SunriseHotel.Views
{
    partial class frmUsuariosView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tablaUsuario = new Guna.UI2.WinForms.Guna2DataGridView();
            this.dgvSr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvApellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvPass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvedit = new System.Windows.Forms.DataGridViewImageColumn();
            this.dgvDel = new System.Windows.Forms.DataGridViewImageColumn();
            this.headerPanelView = new Guna.UI2.WinForms.Guna2Panel();
            this.lblTitleHeder = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnAgregar = new Guna.UI2.WinForms.Guna2CircleButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBuscar = new Guna.UI2.WinForms.Guna2TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.tablaUsuario)).BeginInit();
            this.headerPanelView.SuspendLayout();
            this.SuspendLayout();
            // 
            // tablaUsuario
            // 
            this.tablaUsuario.AllowUserToAddRows = false;
            this.tablaUsuario.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.tablaUsuario.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.tablaUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(190)))), ((int)(((byte)(118)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tablaUsuario.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.tablaUsuario.ColumnHeadersHeight = 30;
            this.tablaUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.tablaUsuario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvSr,
            this.dgvID,
            this.dgvNombre,
            this.dgvApellido,
            this.dgvTel,
            this.dgvEmail,
            this.dgvPass,
            this.dgvedit,
            this.dgvDel});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tablaUsuario.DefaultCellStyle = dataGridViewCellStyle3;
            this.tablaUsuario.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.tablaUsuario.Location = new System.Drawing.Point(37, 242);
            this.tablaUsuario.Name = "tablaUsuario";
            this.tablaUsuario.ReadOnly = true;
            this.tablaUsuario.RowHeadersVisible = false;
            this.tablaUsuario.RowTemplate.Height = 30;
            this.tablaUsuario.Size = new System.Drawing.Size(942, 309);
            this.tablaUsuario.TabIndex = 7;
            this.tablaUsuario.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.tablaUsuario.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.tablaUsuario.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.tablaUsuario.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.tablaUsuario.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.tablaUsuario.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.tablaUsuario.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.tablaUsuario.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.tablaUsuario.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.tablaUsuario.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tablaUsuario.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.tablaUsuario.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.tablaUsuario.ThemeStyle.HeaderStyle.Height = 30;
            this.tablaUsuario.ThemeStyle.ReadOnly = true;
            this.tablaUsuario.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.tablaUsuario.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.tablaUsuario.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tablaUsuario.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.tablaUsuario.ThemeStyle.RowsStyle.Height = 30;
            this.tablaUsuario.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.tablaUsuario.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.tablaUsuario.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tablaUsuario_CellClick);
            // 
            // dgvSr
            // 
            this.dgvSr.FillWeight = 75.41301F;
            this.dgvSr.HeaderText = "Sr#";
            this.dgvSr.Name = "dgvSr";
            this.dgvSr.ReadOnly = true;
            // 
            // dgvID
            // 
            this.dgvID.FillWeight = 75.41301F;
            this.dgvID.HeaderText = "id";
            this.dgvID.Name = "dgvID";
            this.dgvID.ReadOnly = true;
            this.dgvID.Visible = false;
            // 
            // dgvNombre
            // 
            this.dgvNombre.FillWeight = 75.41301F;
            this.dgvNombre.HeaderText = "Nombre";
            this.dgvNombre.Name = "dgvNombre";
            this.dgvNombre.ReadOnly = true;
            // 
            // dgvApellido
            // 
            this.dgvApellido.FillWeight = 75.41301F;
            this.dgvApellido.HeaderText = "Apellido";
            this.dgvApellido.Name = "dgvApellido";
            this.dgvApellido.ReadOnly = true;
            // 
            // dgvTel
            // 
            this.dgvTel.FillWeight = 75.41301F;
            this.dgvTel.HeaderText = "Teléfono";
            this.dgvTel.Name = "dgvTel";
            this.dgvTel.ReadOnly = true;
            // 
            // dgvEmail
            // 
            this.dgvEmail.FillWeight = 75.41301F;
            this.dgvEmail.HeaderText = "Correo";
            this.dgvEmail.Name = "dgvEmail";
            this.dgvEmail.ReadOnly = true;
            // 
            // dgvPass
            // 
            this.dgvPass.FillWeight = 75.41301F;
            this.dgvPass.HeaderText = "Contraseña";
            this.dgvPass.Name = "dgvPass";
            this.dgvPass.ReadOnly = true;
            this.dgvPass.Visible = false;
            // 
            // dgvedit
            // 
            this.dgvedit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgvedit.FillWeight = 50F;
            this.dgvedit.HeaderText = "";
            this.dgvedit.Image = global::SunriseHotel.Properties.Resources.edit;
            this.dgvedit.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dgvedit.MinimumWidth = 50;
            this.dgvedit.Name = "dgvedit";
            this.dgvedit.ReadOnly = true;
            this.dgvedit.Width = 50;
            // 
            // dgvDel
            // 
            this.dgvDel.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgvDel.FillWeight = 50F;
            this.dgvDel.HeaderText = "";
            this.dgvDel.Image = global::SunriseHotel.Properties.Resources.delete;
            this.dgvDel.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dgvDel.MinimumWidth = 50;
            this.dgvDel.Name = "dgvDel";
            this.dgvDel.ReadOnly = true;
            this.dgvDel.Width = 50;
            // 
            // headerPanelView
            // 
            this.headerPanelView.Controls.Add(this.lblTitleHeder);
            this.headerPanelView.Controls.Add(this.btnAgregar);
            this.headerPanelView.Controls.Add(this.label1);
            this.headerPanelView.Controls.Add(this.txtBuscar);
            this.headerPanelView.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanelView.Location = new System.Drawing.Point(0, 0);
            this.headerPanelView.Name = "headerPanelView";
            this.headerPanelView.Size = new System.Drawing.Size(1021, 199);
            this.headerPanelView.TabIndex = 10;
            // 
            // lblTitleHeder
            // 
            this.lblTitleHeder.BackColor = System.Drawing.Color.Transparent;
            this.lblTitleHeder.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleHeder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.lblTitleHeder.Location = new System.Drawing.Point(24, 67);
            this.lblTitleHeder.Name = "lblTitleHeder";
            this.lblTitleHeder.Size = new System.Drawing.Size(209, 39);
            this.lblTitleHeder.TabIndex = 5;
            this.lblTitleHeder.Text = "Lista de Usuarios";
            // 
            // btnAgregar
            // 
            this.btnAgregar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAgregar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAgregar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAgregar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAgregar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.btnAgregar.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Bold);
            this.btnAgregar.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.Location = new System.Drawing.Point(24, 124);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnAgregar.Size = new System.Drawing.Size(60, 60);
            this.btnAgregar.TabIndex = 8;
            this.btnAgregar.Text = "+";
            this.btnAgregar.TextOffset = new System.Drawing.Point(3, -5);
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.label1.Location = new System.Drawing.Point(629, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 21);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nombre del usuario";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBuscar.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBuscar.DefaultText = "";
            this.txtBuscar.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBuscar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBuscar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBuscar.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBuscar.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.txtBuscar.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtBuscar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtBuscar.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.txtBuscar.Location = new System.Drawing.Point(633, 134);
            this.txtBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.PasswordChar = '\0';
            this.txtBuscar.PlaceholderText = "Buscar aquí";
            this.txtBuscar.SelectedText = "";
            this.txtBuscar.Size = new System.Drawing.Size(328, 50);
            this.txtBuscar.TabIndex = 7;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // frmUsuariosView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1021, 584);
            this.Controls.Add(this.headerPanelView);
            this.Controls.Add(this.tablaUsuario);
            this.Name = "frmUsuariosView";
            this.Text = "frmUsuarioView";
            this.Load += new System.EventHandler(this.frmUsuarioView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tablaUsuario)).EndInit();
            this.headerPanelView.ResumeLayout(false);
            this.headerPanelView.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2DataGridView tablaUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvSr;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvApellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTel;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvPass;
        private System.Windows.Forms.DataGridViewImageColumn dgvedit;
        private System.Windows.Forms.DataGridViewImageColumn dgvDel;
        private Guna.UI2.WinForms.Guna2Panel headerPanelView;
        public Guna.UI2.WinForms.Guna2HtmlLabel lblTitleHeder;
        private Guna.UI2.WinForms.Guna2CircleButton btnAgregar;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txtBuscar;
    }
}