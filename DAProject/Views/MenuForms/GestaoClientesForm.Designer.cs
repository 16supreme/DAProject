namespace DAProject.Views
{
    partial class GestaoClientesForm
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.updateBtn = new System.Windows.Forms.Button();
            this.addCard = new MaterialSkin.Controls.MaterialFloatingActionButton();
            this.siticoneTextBox1 = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.studentRadio = new Siticone.Desktop.UI.WinForms.SiticoneCustomRadioButton();
            this.professorRadio = new Siticone.Desktop.UI.WinForms.SiticoneCustomRadioButton();
            this.AllRadio = new Siticone.Desktop.UI.WinForms.SiticoneCustomRadioButton();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 65);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(801, 352);
            this.flowLayoutPanel1.TabIndex = 4;
            // 
            // updateBtn
            // 
            this.updateBtn.BackColor = System.Drawing.SystemColors.Control;
            this.updateBtn.BackgroundImage = global::DAProject.Properties.Resources.updateflowlayoutpanel;
            this.updateBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.updateBtn.FlatAppearance.BorderSize = 0;
            this.updateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateBtn.Location = new System.Drawing.Point(773, 423);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(30, 30);
            this.updateBtn.TabIndex = 5;
            this.updateBtn.UseVisualStyleBackColor = false;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // addCard
            // 
            this.addCard.Depth = 0;
            this.addCard.Icon = global::DAProject.Properties.Resources.Plus;
            this.addCard.Location = new System.Drawing.Point(12, 428);
            this.addCard.Mini = true;
            this.addCard.MouseState = MaterialSkin.MouseState.HOVER;
            this.addCard.Name = "addCard";
            this.addCard.Size = new System.Drawing.Size(40, 46);
            this.addCard.TabIndex = 2;
            this.addCard.Text = "materialFloatingActionButton1";
            this.addCard.UseVisualStyleBackColor = true;
            this.addCard.Click += new System.EventHandler(this.addCard_Click);
            // 
            // siticoneTextBox1
            // 
            this.siticoneTextBox1.BorderRadius = 15;
            this.siticoneTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.siticoneTextBox1.DefaultText = "";
            this.siticoneTextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.siticoneTextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.siticoneTextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.siticoneTextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.siticoneTextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.siticoneTextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.siticoneTextBox1.ForeColor = System.Drawing.Color.Black;
            this.siticoneTextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.siticoneTextBox1.IconLeft = global::DAProject.Properties.Resources.Search;
            this.siticoneTextBox1.Location = new System.Drawing.Point(12, 9);
            this.siticoneTextBox1.Name = "siticoneTextBox1";
            this.siticoneTextBox1.PasswordChar = '\0';
            this.siticoneTextBox1.PlaceholderText = "Pesquisar (Nome)";
            this.siticoneTextBox1.SelectedText = "";
            this.siticoneTextBox1.Size = new System.Drawing.Size(256, 50);
            this.siticoneTextBox1.TabIndex = 6;
            this.siticoneTextBox1.TextChanged += new System.EventHandler(this.siticoneTextBox1_TextChanged);
            // 
            // studentRadio
            // 
            this.studentRadio.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.studentRadio.CheckedState.BorderThickness = 0;
            this.studentRadio.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.studentRadio.CheckedState.InnerColor = System.Drawing.Color.White;
            this.studentRadio.Location = new System.Drawing.Point(656, 28);
            this.studentRadio.Name = "studentRadio";
            this.studentRadio.Size = new System.Drawing.Size(20, 20);
            this.studentRadio.TabIndex = 7;
            this.studentRadio.Text = "siticoneCustomRadioButton1";
            this.studentRadio.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.studentRadio.UncheckedState.BorderThickness = 2;
            this.studentRadio.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.studentRadio.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.studentRadio.CheckedChanged += new System.EventHandler(this.studentRadio_CheckedChanged);
            // 
            // professorRadio
            // 
            this.professorRadio.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.professorRadio.CheckedState.BorderThickness = 0;
            this.professorRadio.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.professorRadio.CheckedState.InnerColor = System.Drawing.Color.White;
            this.professorRadio.Location = new System.Drawing.Point(782, 28);
            this.professorRadio.Name = "professorRadio";
            this.professorRadio.Size = new System.Drawing.Size(20, 20);
            this.professorRadio.TabIndex = 8;
            this.professorRadio.Text = "siticoneCustomRadioButton1";
            this.professorRadio.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.professorRadio.UncheckedState.BorderThickness = 2;
            this.professorRadio.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.professorRadio.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.professorRadio.CheckedChanged += new System.EventHandler(this.professorRadio_CheckedChanged);
            // 
            // AllRadio
            // 
            this.AllRadio.Checked = true;
            this.AllRadio.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.AllRadio.CheckedState.BorderThickness = 0;
            this.AllRadio.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.AllRadio.CheckedState.InnerColor = System.Drawing.Color.White;
            this.AllRadio.Location = new System.Drawing.Point(532, 28);
            this.AllRadio.Name = "AllRadio";
            this.AllRadio.Size = new System.Drawing.Size(20, 20);
            this.AllRadio.TabIndex = 9;
            this.AllRadio.Text = "siticoneCustomRadioButton1";
            this.AllRadio.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.AllRadio.UncheckedState.BorderThickness = 2;
            this.AllRadio.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.AllRadio.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.AllRadio.CheckedChanged += new System.EventHandler(this.AllRadio_CheckedChanged);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle2;
            this.materialLabel1.Location = new System.Drawing.Point(570, 31);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(80, 17);
            this.materialLabel1.TabIndex = 10;
            this.materialLabel1.Text = "Estudantes :";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle2;
            this.materialLabel2.Location = new System.Drawing.Point(478, 31);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(48, 17);
            this.materialLabel2.TabIndex = 11;
            this.materialLabel2.Text = "Todos :";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle2;
            this.materialLabel3.Location = new System.Drawing.Point(691, 31);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(85, 17);
            this.materialLabel3.TabIndex = 12;
            this.materialLabel3.Text = "Professores :";
            // 
            // GestaoClientesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 486);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.AllRadio);
            this.Controls.Add(this.professorRadio);
            this.Controls.Add(this.studentRadio);
            this.Controls.Add(this.siticoneTextBox1);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.addCard);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GestaoClientesForm";
            this.Text = "GestaoClientesForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialFloatingActionButton addCard;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button updateBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox siticoneTextBox1;
        private Siticone.Desktop.UI.WinForms.SiticoneCustomRadioButton studentRadio;
        private Siticone.Desktop.UI.WinForms.SiticoneCustomRadioButton professorRadio;
        private Siticone.Desktop.UI.WinForms.SiticoneCustomRadioButton AllRadio;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
    }
}