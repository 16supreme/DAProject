namespace DAProject.Views.InsertForms
{
    partial class NewMenuForm
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.siticoneGroupBox1 = new Siticone.Desktop.UI.WinForms.SiticoneGroupBox();
            this.siticoneGroupBox3 = new Siticone.Desktop.UI.WinForms.SiticoneGroupBox();
            this.extraChecked = new System.Windows.Forms.CheckedListBox();
            this.siticoneGroupBox2 = new Siticone.Desktop.UI.WinForms.SiticoneGroupBox();
            this.veggieCombo = new Siticone.Desktop.UI.WinForms.SiticoneComboBox();
            this.fishCombo = new Siticone.Desktop.UI.WinForms.SiticoneComboBox();
            this.meatCombo = new Siticone.Desktop.UI.WinForms.SiticoneComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtprecoProfessor = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.txtprecoEstudante = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.txtqntdDisponivel = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.siticoneButton1 = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.siticoneGroupBox1.SuspendLayout();
            this.siticoneGroupBox3.SuspendLayout();
            this.siticoneGroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd/MM/yyyy hh:mm tt";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(13, 59);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(151, 23);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // siticoneGroupBox1
            // 
            this.siticoneGroupBox1.Controls.Add(this.siticoneGroupBox3);
            this.siticoneGroupBox1.Controls.Add(this.siticoneGroupBox2);
            this.siticoneGroupBox1.Controls.Add(this.txtprecoProfessor);
            this.siticoneGroupBox1.Controls.Add(this.txtprecoEstudante);
            this.siticoneGroupBox1.Controls.Add(this.txtqntdDisponivel);
            this.siticoneGroupBox1.Controls.Add(this.dateTimePicker1);
            this.siticoneGroupBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.siticoneGroupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.siticoneGroupBox1.Location = new System.Drawing.Point(192, 78);
            this.siticoneGroupBox1.Name = "siticoneGroupBox1";
            this.siticoneGroupBox1.Size = new System.Drawing.Size(466, 410);
            this.siticoneGroupBox1.TabIndex = 2;
            this.siticoneGroupBox1.Text = "Detalhes";
            
            // 
            // siticoneGroupBox3
            // 
            this.siticoneGroupBox3.Controls.Add(this.extraChecked);
            this.siticoneGroupBox3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.siticoneGroupBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.siticoneGroupBox3.Location = new System.Drawing.Point(13, 284);
            this.siticoneGroupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.siticoneGroupBox3.Name = "siticoneGroupBox3";
            this.siticoneGroupBox3.Size = new System.Drawing.Size(438, 120);
            this.siticoneGroupBox3.TabIndex = 5;
            this.siticoneGroupBox3.Text = "Extras";
            // 
            // extraChecked
            // 
            this.extraChecked.FormattingEnabled = true;
            this.extraChecked.Location = new System.Drawing.Point(3, 41);
            this.extraChecked.Name = "extraChecked";
            this.extraChecked.Size = new System.Drawing.Size(432, 76);
            this.extraChecked.TabIndex = 5;
            // 
            // siticoneGroupBox2
            // 
            this.siticoneGroupBox2.Controls.Add(this.veggieCombo);
            this.siticoneGroupBox2.Controls.Add(this.fishCombo);
            this.siticoneGroupBox2.Controls.Add(this.meatCombo);
            this.siticoneGroupBox2.Controls.Add(this.label3);
            this.siticoneGroupBox2.Controls.Add(this.label2);
            this.siticoneGroupBox2.Controls.Add(this.label1);
            this.siticoneGroupBox2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.siticoneGroupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.siticoneGroupBox2.Location = new System.Drawing.Point(226, 43);
            this.siticoneGroupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.siticoneGroupBox2.Name = "siticoneGroupBox2";
            this.siticoneGroupBox2.Size = new System.Drawing.Size(225, 236);
            this.siticoneGroupBox2.TabIndex = 3;
            this.siticoneGroupBox2.Text = "Pratos";
            this.siticoneGroupBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // veggieCombo
            // 
            this.veggieCombo.BackColor = System.Drawing.Color.Transparent;
            this.veggieCombo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.veggieCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.veggieCombo.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.veggieCombo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.veggieCombo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.veggieCombo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.veggieCombo.ItemHeight = 30;
            this.veggieCombo.Location = new System.Drawing.Point(14, 190);
            this.veggieCombo.Margin = new System.Windows.Forms.Padding(2);
            this.veggieCombo.Name = "veggieCombo";
            this.veggieCombo.Size = new System.Drawing.Size(159, 36);
            this.veggieCombo.TabIndex = 5;
            // 
            // fishCombo
            // 
            this.fishCombo.BackColor = System.Drawing.Color.Transparent;
            this.fishCombo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.fishCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.fishCombo.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.fishCombo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.fishCombo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.fishCombo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.fishCombo.ItemHeight = 30;
            this.fishCombo.Location = new System.Drawing.Point(14, 131);
            this.fishCombo.Margin = new System.Windows.Forms.Padding(2);
            this.fishCombo.Name = "fishCombo";
            this.fishCombo.Size = new System.Drawing.Size(159, 36);
            this.fishCombo.TabIndex = 4;
            // 
            // meatCombo
            // 
            this.meatCombo.BackColor = System.Drawing.Color.Transparent;
            this.meatCombo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.meatCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.meatCombo.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.meatCombo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.meatCombo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.meatCombo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.meatCombo.ItemHeight = 30;
            this.meatCombo.Location = new System.Drawing.Point(13, 61);
            this.meatCombo.Margin = new System.Windows.Forms.Padding(2);
            this.meatCombo.Name = "meatCombo";
            this.meatCombo.Size = new System.Drawing.Size(160, 36);
            this.meatCombo.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 171);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Vegetariano";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 108);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Peixe";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 44);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Carne";
            // 
            // txtprecoProfessor
            // 
            this.txtprecoProfessor.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtprecoProfessor.DefaultText = "";
            this.txtprecoProfessor.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtprecoProfessor.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtprecoProfessor.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtprecoProfessor.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtprecoProfessor.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtprecoProfessor.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtprecoProfessor.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtprecoProfessor.Location = new System.Drawing.Point(13, 188);
            this.txtprecoProfessor.MaxLength = 9;
            this.txtprecoProfessor.Name = "txtprecoProfessor";
            this.txtprecoProfessor.PasswordChar = '\0';
            this.txtprecoProfessor.PlaceholderText = "Preço Professor";
            this.txtprecoProfessor.SelectedText = "";
            this.txtprecoProfessor.Size = new System.Drawing.Size(200, 36);
            this.txtprecoProfessor.TabIndex = 2;
            // 
            // txtprecoEstudante
            // 
            this.txtprecoEstudante.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtprecoEstudante.DefaultText = "";
            this.txtprecoEstudante.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtprecoEstudante.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtprecoEstudante.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtprecoEstudante.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtprecoEstudante.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtprecoEstudante.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtprecoEstudante.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtprecoEstudante.Location = new System.Drawing.Point(13, 146);
            this.txtprecoEstudante.Name = "txtprecoEstudante";
            this.txtprecoEstudante.PasswordChar = '\0';
            this.txtprecoEstudante.PlaceholderText = "Preço Estudante";
            this.txtprecoEstudante.SelectedText = "";
            this.txtprecoEstudante.Size = new System.Drawing.Size(200, 36);
            this.txtprecoEstudante.TabIndex = 1;
            // 
            // txtqntdDisponivel
            // 
            this.txtqntdDisponivel.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtqntdDisponivel.DefaultText = "";
            this.txtqntdDisponivel.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtqntdDisponivel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtqntdDisponivel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtqntdDisponivel.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtqntdDisponivel.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtqntdDisponivel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtqntdDisponivel.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtqntdDisponivel.Location = new System.Drawing.Point(13, 104);
            this.txtqntdDisponivel.Name = "txtqntdDisponivel";
            this.txtqntdDisponivel.PasswordChar = '\0';
            this.txtqntdDisponivel.PlaceholderText = "Quantidade Disponível";
            this.txtqntdDisponivel.SelectedText = "";
            this.txtqntdDisponivel.Size = new System.Drawing.Size(200, 36);
            this.txtqntdDisponivel.TabIndex = 0;
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
            this.siticoneButton1.Location = new System.Drawing.Point(32, 441);
            this.siticoneButton1.Name = "siticoneButton1";
            this.siticoneButton1.Size = new System.Drawing.Size(127, 47);
            this.siticoneButton1.TabIndex = 3;
            this.siticoneButton1.Text = "Salvar";
            this.siticoneButton1.Click += new System.EventHandler(this.siticoneButton1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DAProject.Properties.Resources.NewMenu;
            this.pictureBox1.Location = new System.Drawing.Point(5, 78);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(181, 206);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            
            // 
            // NewMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 499);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.siticoneButton1);
            this.Controls.Add(this.siticoneGroupBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "NewMenuForm";
            this.Padding = new System.Windows.Forms.Padding(2, 52, 2, 2);
            this.Text = "Insira um novo Menu";
            this.siticoneGroupBox1.ResumeLayout(false);
            this.siticoneGroupBox3.ResumeLayout(false);
            this.siticoneGroupBox2.ResumeLayout(false);
            this.siticoneGroupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private Siticone.Desktop.UI.WinForms.SiticoneGroupBox siticoneGroupBox1;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox txtprecoProfessor;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox txtprecoEstudante;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox txtqntdDisponivel;
        private Siticone.Desktop.UI.WinForms.SiticoneButton siticoneButton1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Siticone.Desktop.UI.WinForms.SiticoneGroupBox siticoneGroupBox3;
        private Siticone.Desktop.UI.WinForms.SiticoneGroupBox siticoneGroupBox2;
        private Siticone.Desktop.UI.WinForms.SiticoneComboBox fishCombo;
        private Siticone.Desktop.UI.WinForms.SiticoneComboBox meatCombo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Siticone.Desktop.UI.WinForms.SiticoneComboBox veggieCombo;
        private System.Windows.Forms.CheckedListBox extraChecked;
    }
}