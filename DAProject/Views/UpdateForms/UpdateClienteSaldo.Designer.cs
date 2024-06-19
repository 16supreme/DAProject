namespace DAProject.Views.UpdateForms
{
    partial class UpdateClienteSaldo
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
            this.txtSaldo = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.siticoneButton2 = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.SuspendLayout();
            // 
            // txtSaldo
            // 
            this.txtSaldo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSaldo.DefaultText = "";
            this.txtSaldo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSaldo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSaldo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSaldo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSaldo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSaldo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSaldo.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSaldo.Location = new System.Drawing.Point(6, 79);
            this.txtSaldo.Name = "txtSaldo";
            this.txtSaldo.PasswordChar = '\0';
            this.txtSaldo.PlaceholderText = "Saldo";
            this.txtSaldo.SelectedText = "";
            this.txtSaldo.Size = new System.Drawing.Size(200, 43);
            this.txtSaldo.TabIndex = 15;
            // 
            // siticoneButton2
            // 
            this.siticoneButton2.BorderRadius = 10;
            this.siticoneButton2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.siticoneButton2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.siticoneButton2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.siticoneButton2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.siticoneButton2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.siticoneButton2.ForeColor = System.Drawing.Color.White;
            this.siticoneButton2.Location = new System.Drawing.Point(6, 128);
            this.siticoneButton2.Name = "siticoneButton2";
            this.siticoneButton2.Size = new System.Drawing.Size(95, 30);
            this.siticoneButton2.TabIndex = 14;
            this.siticoneButton2.Text = "Salvar";
            this.siticoneButton2.Click += new System.EventHandler(this.siticoneButton2_Click);
            // 
            // UpdateClienteSaldo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 164);
            this.Controls.Add(this.txtSaldo);
            this.Controls.Add(this.siticoneButton2);
            this.Name = "UpdateClienteSaldo";
            this.Text = "Carregamento de Saldo";
            this.ResumeLayout(false);

        }

        #endregion

        private Siticone.Desktop.UI.WinForms.SiticoneTextBox txtSaldo;
        private Siticone.Desktop.UI.WinForms.SiticoneButton siticoneButton2;
    }
}