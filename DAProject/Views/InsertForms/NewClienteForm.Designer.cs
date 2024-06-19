namespace DAProject.Views
{
    partial class NewClienteForm
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
            this.siticoneTextBox3 = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.siticoneTextBox1 = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.clientTypeCB = new Siticone.Desktop.UI.WinForms.SiticoneComboBox();
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
            this.siticoneButton1.Location = new System.Drawing.Point(374, 260);
            this.siticoneButton1.Name = "siticoneButton1";
            this.siticoneButton1.Size = new System.Drawing.Size(127, 36);
            this.siticoneButton1.TabIndex = 5;
            this.siticoneButton1.Text = "Salvar";
            this.siticoneButton1.Click += new System.EventHandler(this.siticoneButton1_Click);
            // 
            // siticoneGroupBox1
            // 
            this.siticoneGroupBox1.Controls.Add(this.numEstudantetb);
            this.siticoneGroupBox1.Controls.Add(this.emailtb);
            this.siticoneGroupBox1.Controls.Add(this.siticoneTextBox3);
            this.siticoneGroupBox1.Controls.Add(this.siticoneTextBox1);
            this.siticoneGroupBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.siticoneGroupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.siticoneGroupBox1.Location = new System.Drawing.Point(192, 66);
            this.siticoneGroupBox1.Name = "siticoneGroupBox1";
            this.siticoneGroupBox1.Size = new System.Drawing.Size(307, 188);
            this.siticoneGroupBox1.TabIndex = 4;
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
            // siticoneTextBox3
            // 
            this.siticoneTextBox3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.siticoneTextBox3.DefaultText = "";
            this.siticoneTextBox3.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.siticoneTextBox3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.siticoneTextBox3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.siticoneTextBox3.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.siticoneTextBox3.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.siticoneTextBox3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.siticoneTextBox3.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.siticoneTextBox3.Location = new System.Drawing.Point(14, 94);
            this.siticoneTextBox3.MaxLength = 9;
            this.siticoneTextBox3.Name = "siticoneTextBox3";
            this.siticoneTextBox3.PasswordChar = '\0';
            this.siticoneTextBox3.PlaceholderText = "NIF";
            this.siticoneTextBox3.SelectedText = "";
            this.siticoneTextBox3.Size = new System.Drawing.Size(200, 36);
            this.siticoneTextBox3.TabIndex = 2;
            // 
            // siticoneTextBox1
            // 
            this.siticoneTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.siticoneTextBox1.DefaultText = "";
            this.siticoneTextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.siticoneTextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.siticoneTextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.siticoneTextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.siticoneTextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.siticoneTextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.siticoneTextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.siticoneTextBox1.Location = new System.Drawing.Point(14, 52);
            this.siticoneTextBox1.Name = "siticoneTextBox1";
            this.siticoneTextBox1.PasswordChar = '\0';
            this.siticoneTextBox1.PlaceholderText = "Nome";
            this.siticoneTextBox1.SelectedText = "";
            this.siticoneTextBox1.Size = new System.Drawing.Size(200, 36);
            this.siticoneTextBox1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DAProject.Properties.Resources.client;
            this.pictureBox1.Location = new System.Drawing.Point(5, 66);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(181, 188);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // clientTypeCB
            // 
            this.clientTypeCB.BackColor = System.Drawing.Color.Transparent;
            this.clientTypeCB.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.clientTypeCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.clientTypeCB.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.clientTypeCB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.clientTypeCB.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.clientTypeCB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.clientTypeCB.ItemHeight = 30;
            this.clientTypeCB.Location = new System.Drawing.Point(23, 260);
            this.clientTypeCB.Name = "clientTypeCB";
            this.clientTypeCB.Size = new System.Drawing.Size(140, 36);
            this.clientTypeCB.TabIndex = 3;
            this.clientTypeCB.SelectedIndexChanged += new System.EventHandler(this.clientTypeCB_SelectedIndexChanged);
            // 
            // NewClienteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 300);
            this.Controls.Add(this.clientTypeCB);
            this.Controls.Add(this.siticoneButton1);
            this.Controls.Add(this.siticoneGroupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "NewClienteForm";
            this.Padding = new System.Windows.Forms.Padding(2, 52, 2, 2);
            this.Text = "Insira um novo cliente";
            this.siticoneGroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Siticone.Desktop.UI.WinForms.SiticoneButton siticoneButton1;
        private Siticone.Desktop.UI.WinForms.SiticoneGroupBox siticoneGroupBox1;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox siticoneTextBox3;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox siticoneTextBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Siticone.Desktop.UI.WinForms.SiticoneComboBox clientTypeCB;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox numEstudantetb;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox emailtb;
    }
}