namespace DAProject.Views
{
    partial class ReservasForm
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
            this.siticoneTabControl1 = new Siticone.Desktop.UI.WinForms.SiticoneTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.siticoneGroupBox3 = new Siticone.Desktop.UI.WinForms.SiticoneGroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.platesCombo = new Siticone.Desktop.UI.WinForms.SiticoneComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.extraChecked = new System.Windows.Forms.CheckedListBox();
            this.menuCombo = new Siticone.Desktop.UI.WinForms.SiticoneComboBox();
            this.addCard = new MaterialSkin.Controls.MaterialFloatingActionButton();
            this.txtNIF = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.clientTypeCB = new Siticone.Desktop.UI.WinForms.SiticoneComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.updateBtn = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.siticoneTextBox1 = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.siticoneTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.siticoneGroupBox3.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // siticoneTabControl1
            // 
            this.siticoneTabControl1.Controls.Add(this.tabPage1);
            this.siticoneTabControl1.Controls.Add(this.tabPage2);
            this.siticoneTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.siticoneTabControl1.HotTrack = true;
            this.siticoneTabControl1.ItemSize = new System.Drawing.Size(180, 40);
            this.siticoneTabControl1.Location = new System.Drawing.Point(0, 0);
            this.siticoneTabControl1.Name = "siticoneTabControl1";
            this.siticoneTabControl1.SelectedIndex = 0;
            this.siticoneTabControl1.Size = new System.Drawing.Size(800, 567);
            this.siticoneTabControl1.TabButtonHoverState.BorderColor = System.Drawing.Color.Empty;
            this.siticoneTabControl1.TabButtonHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.siticoneTabControl1.TabButtonHoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.siticoneTabControl1.TabButtonHoverState.ForeColor = System.Drawing.Color.White;
            this.siticoneTabControl1.TabButtonHoverState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.siticoneTabControl1.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty;
            this.siticoneTabControl1.TabButtonIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.siticoneTabControl1.TabButtonIdleState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.siticoneTabControl1.TabButtonIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(160)))), ((int)(((byte)(167)))));
            this.siticoneTabControl1.TabButtonIdleState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.siticoneTabControl1.TabButtonSelectedState.BorderColor = System.Drawing.Color.Empty;
            this.siticoneTabControl1.TabButtonSelectedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(37)))), ((int)(((byte)(49)))));
            this.siticoneTabControl1.TabButtonSelectedState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.siticoneTabControl1.TabButtonSelectedState.ForeColor = System.Drawing.Color.White;
            this.siticoneTabControl1.TabButtonSelectedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            this.siticoneTabControl1.TabButtonSize = new System.Drawing.Size(180, 40);
            this.siticoneTabControl1.TabIndex = 0;
            this.siticoneTabControl1.TabMenuBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.siticoneTabControl1.TabMenuOrientation = Siticone.Desktop.UI.WinForms.TabMenuOrientation.HorizontalTop;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Controls.Add(this.siticoneGroupBox3);
            this.tabPage1.Controls.Add(this.menuCombo);
            this.tabPage1.Controls.Add(this.addCard);
            this.tabPage1.Controls.Add(this.txtNIF);
            this.tabPage1.Controls.Add(this.dateTimePicker1);
            this.tabPage1.Controls.Add(this.clientTypeCB);
            this.tabPage1.Location = new System.Drawing.Point(4, 44);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 519);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Efetuar Reserva";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DAProject.Properties.Resources.New_Ticket;
            this.pictureBox1.Location = new System.Drawing.Point(8, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 97);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // siticoneGroupBox3
            // 
            this.siticoneGroupBox3.Controls.Add(this.label2);
            this.siticoneGroupBox3.Controls.Add(this.platesCombo);
            this.siticoneGroupBox3.Controls.Add(this.label1);
            this.siticoneGroupBox3.Controls.Add(this.extraChecked);
            this.siticoneGroupBox3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneGroupBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.siticoneGroupBox3.Location = new System.Drawing.Point(26, 200);
            this.siticoneGroupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.siticoneGroupBox3.Name = "siticoneGroupBox3";
            this.siticoneGroupBox3.Size = new System.Drawing.Size(438, 244);
            this.siticoneGroupBox3.TabIndex = 16;
            this.siticoneGroupBox3.Text = "Menu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 127);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Extras";
            // 
            // platesCombo
            // 
            this.platesCombo.BackColor = System.Drawing.Color.Transparent;
            this.platesCombo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.platesCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.platesCombo.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.platesCombo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.platesCombo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.platesCombo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.platesCombo.ItemHeight = 30;
            this.platesCombo.Location = new System.Drawing.Point(25, 74);
            this.platesCombo.Margin = new System.Windows.Forms.Padding(2);
            this.platesCombo.Name = "platesCombo";
            this.platesCombo.Size = new System.Drawing.Size(160, 36);
            this.platesCombo.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 48);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Carne";
            // 
            // extraChecked
            // 
            this.extraChecked.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.extraChecked.FormattingEnabled = true;
            this.extraChecked.Location = new System.Drawing.Point(25, 155);
            this.extraChecked.Name = "extraChecked";
            this.extraChecked.Size = new System.Drawing.Size(390, 72);
            this.extraChecked.TabIndex = 5;
            // 
            // menuCombo
            // 
            this.menuCombo.BackColor = System.Drawing.Color.Transparent;
            this.menuCombo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.menuCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.menuCombo.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.menuCombo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.menuCombo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.menuCombo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.menuCombo.ItemHeight = 30;
            this.menuCombo.Location = new System.Drawing.Point(26, 149);
            this.menuCombo.Margin = new System.Windows.Forms.Padding(2);
            this.menuCombo.Name = "menuCombo";
            this.menuCombo.Size = new System.Drawing.Size(185, 36);
            this.menuCombo.TabIndex = 19;
            this.menuCombo.SelectedIndexChanged += new System.EventHandler(this.menuCombo_SelectedIndexChanged);
            // 
            // addCard
            // 
            this.addCard.Depth = 0;
            this.addCard.Icon = global::DAProject.Properties.Resources.Plus;
            this.addCard.Location = new System.Drawing.Point(8, 470);
            this.addCard.Mini = true;
            this.addCard.MouseState = MaterialSkin.MouseState.HOVER;
            this.addCard.Name = "addCard";
            this.addCard.Size = new System.Drawing.Size(40, 46);
            this.addCard.TabIndex = 14;
            this.addCard.Text = "addCard";
            this.addCard.UseVisualStyleBackColor = true;
            this.addCard.Click += new System.EventHandler(this.addCard_Click);
            // 
            // txtNIF
            // 
            this.txtNIF.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNIF.DefaultText = "";
            this.txtNIF.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNIF.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNIF.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNIF.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNIF.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNIF.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNIF.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNIF.Location = new System.Drawing.Point(135, 59);
            this.txtNIF.MaxLength = 9;
            this.txtNIF.Name = "txtNIF";
            this.txtNIF.PasswordChar = '\0';
            this.txtNIF.PlaceholderText = "NIF";
            this.txtNIF.SelectedText = "";
            this.txtNIF.Size = new System.Drawing.Size(200, 36);
            this.txtNIF.TabIndex = 17;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd/MM/yyyy ";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(26, 122);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(151, 20);
            this.dateTimePicker1.TabIndex = 15;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
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
            this.clientTypeCB.Location = new System.Drawing.Point(135, 17);
            this.clientTypeCB.Name = "clientTypeCB";
            this.clientTypeCB.Size = new System.Drawing.Size(140, 36);
            this.clientTypeCB.TabIndex = 18;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage2.Controls.Add(this.updateBtn);
            this.tabPage2.Controls.Add(this.flowLayoutPanel1);
            this.tabPage2.Controls.Add(this.siticoneTextBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 44);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 519);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Marcar Reserva como Efetuada";
            // 
            // updateBtn
            // 
            this.updateBtn.BackColor = System.Drawing.SystemColors.Control;
            this.updateBtn.BackgroundImage = global::DAProject.Properties.Resources.updateflowlayoutpanel;
            this.updateBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.updateBtn.FlatAppearance.BorderSize = 0;
            this.updateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateBtn.Location = new System.Drawing.Point(8, 481);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(30, 30);
            this.updateBtn.TabIndex = 13;
            this.updateBtn.UseVisualStyleBackColor = false;
            this.updateBtn.TextChanged += new System.EventHandler(this.updateBtn_Click);
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(8, 63);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(794, 412);
            this.flowLayoutPanel1.TabIndex = 12;
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
            this.siticoneTextBox1.Location = new System.Drawing.Point(8, 6);
            this.siticoneTextBox1.Name = "siticoneTextBox1";
            this.siticoneTextBox1.PasswordChar = '\0';
            this.siticoneTextBox1.PlaceholderText = "Pesquisar (NIF)";
            this.siticoneTextBox1.SelectedText = "";
            this.siticoneTextBox1.Size = new System.Drawing.Size(253, 51);
            this.siticoneTextBox1.TabIndex = 11;
            this.siticoneTextBox1.TextChanged += new System.EventHandler(this.siticoneTextBox1_TextChanged);
            // 
            // ReservasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 567);
            this.Controls.Add(this.siticoneTabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ReservasForm";
            this.Text = "ReservasForm";
            this.siticoneTabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.siticoneGroupBox3.ResumeLayout(false);
            this.siticoneGroupBox3.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Siticone.Desktop.UI.WinForms.SiticoneTabControl siticoneTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox siticoneTextBox1;
        private System.Windows.Forms.Button updateBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneGroupBox siticoneGroupBox3;
        private System.Windows.Forms.Label label2;
        private Siticone.Desktop.UI.WinForms.SiticoneComboBox platesCombo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox extraChecked;
        private Siticone.Desktop.UI.WinForms.SiticoneComboBox menuCombo;
        private MaterialSkin.Controls.MaterialFloatingActionButton addCard;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox txtNIF;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private Siticone.Desktop.UI.WinForms.SiticoneComboBox clientTypeCB;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}