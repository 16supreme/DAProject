namespace DAProject.Views.UpdateForms
{
    partial class UpdateClienteForm
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
            this.siticoneButton1 = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.siticoneGroupBox1 = new Siticone.Desktop.UI.WinForms.SiticoneGroupBox();
            this.numEstudantetb = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.emailtb = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.tbNIF = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.tbNome = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.siticoneGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // siticoneButton1
            // 
            this.siticoneButton1.BorderRadius = 10;
            this.siticoneButton1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.siticoneButton1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.siticoneButton1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.siticoneButton1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.siticoneButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.siticoneButton1.ForeColor = System.Drawing.Color.White;
            this.siticoneButton1.Location = new System.Drawing.Point(373, 261);
            this.siticoneButton1.Name = "siticoneButton1";
            this.siticoneButton1.Size = new System.Drawing.Size(127, 47);
            this.siticoneButton1.TabIndex = 9;
            this.siticoneButton1.Text = "Salvar";
            this.siticoneButton1.Click += new System.EventHandler(this.siticoneButton1_Click);
            // 
            // siticoneGroupBox1
            // 
            this.siticoneGroupBox1.Controls.Add(this.numEstudantetb);
            this.siticoneGroupBox1.Controls.Add(this.emailtb);
            this.siticoneGroupBox1.Controls.Add(this.tbNIF);
            this.siticoneGroupBox1.Controls.Add(this.tbNome);
            this.siticoneGroupBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.siticoneGroupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.siticoneGroupBox1.Location = new System.Drawing.Point(193, 67);
            this.siticoneGroupBox1.Name = "siticoneGroupBox1";
            this.siticoneGroupBox1.Size = new System.Drawing.Size(307, 188);
            this.siticoneGroupBox1.TabIndex = 8;
            this.siticoneGroupBox1.Text = "Detalhes";
            // 
            // numEstudantetb
            // 
            this.numEstudantetb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.numEstudantetb.DefaultText = "";
            this.numEstudantetb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.numEstudantetb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.numEstudantetb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.numEstudantetb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.numEstudantetb.Enabled = false;
            this.numEstudantetb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.numEstudantetb.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.numEstudantetb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.numEstudantetb.Location = new System.Drawing.Point(14, 136);
            this.numEstudantetb.Name = "numEstudantetb";
            this.numEstudantetb.PasswordChar = '\0';
            this.numEstudantetb.PlaceholderText = "numEstudante";
            this.numEstudantetb.SelectedText = "";
            this.numEstudantetb.Size = new System.Drawing.Size(200, 36);
            this.numEstudantetb.TabIndex = 6;
            this.numEstudantetb.Visible = false;
            // 
            // emailtb
            // 
            this.emailtb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.emailtb.DefaultText = "";
            this.emailtb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.emailtb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.emailtb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.emailtb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.emailtb.Enabled = false;
            this.emailtb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.emailtb.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.emailtb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.emailtb.Location = new System.Drawing.Point(14, 136);
            this.emailtb.Name = "emailtb";
            this.emailtb.PasswordChar = '\0';
            this.emailtb.PlaceholderText = "email";
            this.emailtb.SelectedText = "";
            this.emailtb.Size = new System.Drawing.Size(200, 36);
            this.emailtb.TabIndex = 7;
            this.emailtb.Visible = false;
            // 
            // tbNIF
            // 
            this.tbNIF.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbNIF.DefaultText = "";
            this.tbNIF.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbNIF.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbNIF.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbNIF.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbNIF.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbNIF.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbNIF.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbNIF.Location = new System.Drawing.Point(14, 94);
            this.tbNIF.MaxLength = 9;
            this.tbNIF.Name = "tbNIF";
            this.tbNIF.PasswordChar = '\0';
            this.tbNIF.PlaceholderText = "NIF";
            this.tbNIF.SelectedText = "";
            this.tbNIF.Size = new System.Drawing.Size(200, 36);
            this.tbNIF.TabIndex = 2;
            // 
            // tbNome
            // 
            this.tbNome.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbNome.DefaultText = "";
            this.tbNome.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbNome.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbNome.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbNome.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbNome.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbNome.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbNome.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbNome.Location = new System.Drawing.Point(14, 52);
            this.tbNome.Name = "tbNome";
            this.tbNome.PasswordChar = '\0';
            this.tbNome.PlaceholderText = "Nome";
            this.tbNome.SelectedText = "";
            this.tbNome.Size = new System.Drawing.Size(200, 36);
            this.tbNome.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DAProject.Properties.Resources.client;
            this.pictureBox1.Location = new System.Drawing.Point(6, 67);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(181, 188);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // UpdateClienteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 314);
            this.Controls.Add(this.siticoneButton1);
            this.Controls.Add(this.siticoneGroupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "UpdateClienteForm";
            this.Text = "Atualizar Cliente";
            this.siticoneGroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Siticone.Desktop.UI.WinForms.SiticoneButton siticoneButton1;
        private Siticone.Desktop.UI.WinForms.SiticoneGroupBox siticoneGroupBox1;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox numEstudantetb;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox emailtb;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox tbNIF;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox tbNome;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}