namespace SunriseHotel
{
    partial class frmHone
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
            this.messageError = new Guna.UI2.WinForms.Guna2MessageDialog();
            this.messageSystem = new Guna.UI2.WinForms.Guna2MessageDialog();
            this.SuspendLayout();
            // 
            // messageError
            // 
            this.messageError.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
            this.messageError.Caption = "Sunrise Hotel";
            this.messageError.Icon = Guna.UI2.WinForms.MessageDialogIcon.Error;
            this.messageError.Parent = null;
            this.messageError.Style = Guna.UI2.WinForms.MessageDialogStyle.Light;
            this.messageError.Text = null;
            // 
            // messageSystem
            // 
            this.messageSystem.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
            this.messageSystem.Caption = "Sunrise Hotel";
            this.messageSystem.Icon = Guna.UI2.WinForms.MessageDialogIcon.Information;
            this.messageSystem.Parent = null;
            this.messageSystem.Style = Guna.UI2.WinForms.MessageDialogStyle.Light;
            this.messageSystem.Text = null;
            // 
            // frmHone
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1040, 642);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "frmHone";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmHone";
            this.ResumeLayout(false);

        }

        #endregion

        public Guna.UI2.WinForms.Guna2MessageDialog messageError;
        public Guna.UI2.WinForms.Guna2MessageDialog messageSystem;
    }
}