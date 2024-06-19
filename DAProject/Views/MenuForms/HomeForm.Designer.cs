namespace DAProject.Views
{
    partial class HomeForm
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
            this.siticoneGradientPanel1 = new Siticone.Desktop.UI.WinForms.SiticoneGradientPanel();
            this.funcCombo = new Siticone.Desktop.UI.WinForms.SiticoneComboBox();
            this.updateBtn = new System.Windows.Forms.Button();
            this.funcUsername = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.CalendarLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.lblMonthYear = new MaterialSkin.Controls.MaterialLabel();
            this.btnNext = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.btnPrevious = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.updateCalendar = new System.Windows.Forms.Button();
            this.siticoneGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // siticoneGradientPanel1
            // 
            this.siticoneGradientPanel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.siticoneGradientPanel1.BorderRadius = 10;
            this.siticoneGradientPanel1.BorderThickness = 3;
            this.siticoneGradientPanel1.Controls.Add(this.funcCombo);
            this.siticoneGradientPanel1.Controls.Add(this.updateBtn);
            this.siticoneGradientPanel1.Controls.Add(this.funcUsername);
            this.siticoneGradientPanel1.Controls.Add(this.pictureBox1);
            this.siticoneGradientPanel1.CustomBorderColor = System.Drawing.Color.RosyBrown;
            this.siticoneGradientPanel1.CustomizableEdges.TopLeft = false;
            this.siticoneGradientPanel1.CustomizableEdges.TopRight = false;
            this.siticoneGradientPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.siticoneGradientPanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.siticoneGradientPanel1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.siticoneGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.siticoneGradientPanel1.Name = "siticoneGradientPanel1";
            this.siticoneGradientPanel1.Size = new System.Drawing.Size(814, 90);
            this.siticoneGradientPanel1.TabIndex = 2;
            // 
            // funcCombo
            // 
            this.funcCombo.BackColor = System.Drawing.Color.Transparent;
            this.funcCombo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.funcCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.funcCombo.Enabled = false;
            this.funcCombo.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.funcCombo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.funcCombo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.funcCombo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.funcCombo.ItemHeight = 30;
            this.funcCombo.Location = new System.Drawing.Point(95, 7);
            this.funcCombo.Name = "funcCombo";
            this.funcCombo.Size = new System.Drawing.Size(154, 36);
            this.funcCombo.TabIndex = 3;
            this.funcCombo.Visible = false;
            this.funcCombo.SelectedIndexChanged += new System.EventHandler(this.funcCombo_SelectedIndexChanged);
            // 
            // updateBtn
            // 
            this.updateBtn.BackColor = System.Drawing.Color.Transparent;
            this.updateBtn.BackgroundImage = global::DAProject.Properties.Resources.Change;
            this.updateBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.updateBtn.FlatAppearance.BorderSize = 0;
            this.updateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateBtn.Location = new System.Drawing.Point(95, 49);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(30, 28);
            this.updateBtn.TabIndex = 8;
            this.updateBtn.UseVisualStyleBackColor = false;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // funcUsername
            // 
            this.funcUsername.AutoSize = true;
            this.funcUsername.BackColor = System.Drawing.Color.Transparent;
            this.funcUsername.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.funcUsername.Location = new System.Drawing.Point(95, 9);
            this.funcUsername.Name = "funcUsername";
            this.funcUsername.Size = new System.Drawing.Size(87, 21);
            this.funcUsername.TabIndex = 3;
            this.funcUsername.Text = "Username";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::DAProject.Properties.Resources.active_user;
            this.pictureBox1.Location = new System.Drawing.Point(12, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(77, 75);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // CalendarLayout
            // 
            this.CalendarLayout.AutoScroll = true;
            this.CalendarLayout.BackColor = System.Drawing.SystemColors.Control;
            this.CalendarLayout.Location = new System.Drawing.Point(29, 195);
            this.CalendarLayout.Name = "CalendarLayout";
            this.CalendarLayout.Size = new System.Drawing.Size(772, 486);
            this.CalendarLayout.TabIndex = 5;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel1.Location = new System.Drawing.Point(39, 163);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(67, 24);
            this.materialLabel1.TabIndex = 6;
            this.materialLabel1.Text = "Sunday";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel2.Location = new System.Drawing.Point(137, 163);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(73, 24);
            this.materialLabel2.TabIndex = 7;
            this.materialLabel2.Text = "Monday";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel3.Location = new System.Drawing.Point(243, 163);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(77, 24);
            this.materialLabel3.TabIndex = 8;
            this.materialLabel3.Text = "Tuesday";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel4.Location = new System.Drawing.Point(336, 163);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(105, 24);
            this.materialLabel4.TabIndex = 9;
            this.materialLabel4.Text = "Wednesday";
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel5.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel5.Location = new System.Drawing.Point(447, 163);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(84, 24);
            this.materialLabel5.TabIndex = 10;
            this.materialLabel5.Text = "Thursday";
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel6.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel6.Location = new System.Drawing.Point(561, 163);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(56, 24);
            this.materialLabel6.TabIndex = 11;
            this.materialLabel6.Text = "Friday";
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel7.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel7.Location = new System.Drawing.Point(655, 163);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(81, 24);
            this.materialLabel7.TabIndex = 12;
            this.materialLabel7.Text = "Saturday";
            // 
            // lblMonthYear
            // 
            this.lblMonthYear.AutoSize = true;
            this.lblMonthYear.Depth = 0;
            this.lblMonthYear.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblMonthYear.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.lblMonthYear.Location = new System.Drawing.Point(326, 112);
            this.lblMonthYear.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblMonthYear.Name = "lblMonthYear";
            this.lblMonthYear.Size = new System.Drawing.Size(152, 29);
            this.lblMonthYear.TabIndex = 39;
            this.lblMonthYear.Text = "MONTH YEAR";
            // 
            // btnNext
            // 
            this.btnNext.Animated = true;
            this.btnNext.BackColor = System.Drawing.Color.Transparent;
            this.btnNext.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnNext.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnNext.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnNext.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnNext.FillColor = System.Drawing.Color.Transparent;
            this.btnNext.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnNext.ForeColor = System.Drawing.Color.White;
            this.btnNext.Image = global::DAProject.Properties.Resources.Right_Arrow;
            this.btnNext.Location = new System.Drawing.Point(507, 116);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(46, 25);
            this.btnNext.TabIndex = 38;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Animated = true;
            this.btnPrevious.BackColor = System.Drawing.Color.Transparent;
            this.btnPrevious.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPrevious.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPrevious.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPrevious.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPrevious.FillColor = System.Drawing.Color.Transparent;
            this.btnPrevious.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnPrevious.ForeColor = System.Drawing.Color.White;
            this.btnPrevious.Image = global::DAProject.Properties.Resources.Left_Arrow1;
            this.btnPrevious.Location = new System.Drawing.Point(246, 116);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(40, 25);
            this.btnPrevious.TabIndex = 37;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // updateCalendar
            // 
            this.updateCalendar.BackColor = System.Drawing.SystemColors.Control;
            this.updateCalendar.BackgroundImage = global::DAProject.Properties.Resources.updateflowlayoutpanel;
            this.updateCalendar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.updateCalendar.FlatAppearance.BorderSize = 0;
            this.updateCalendar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateCalendar.Location = new System.Drawing.Point(29, 687);
            this.updateCalendar.Name = "updateCalendar";
            this.updateCalendar.Size = new System.Drawing.Size(30, 30);
            this.updateCalendar.TabIndex = 40;
            this.updateCalendar.UseVisualStyleBackColor = false;
            this.updateCalendar.Click += new System.EventHandler(this.updateCalendar_Click);
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(814, 732);
            this.Controls.Add(this.updateCalendar);
            this.Controls.Add(this.lblMonthYear);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.materialLabel7);
            this.Controls.Add(this.materialLabel6);
            this.Controls.Add(this.materialLabel5);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.CalendarLayout);
            this.Controls.Add(this.siticoneGradientPanel1);
            this.Controls.Add(this.btnPrevious);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HomeForm";
            this.Text = "HomeForm";
            this.siticoneGradientPanel1.ResumeLayout(false);
            this.siticoneGradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Siticone.Desktop.UI.WinForms.SiticoneGradientPanel siticoneGradientPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label funcUsername;
        private System.Windows.Forms.Button updateBtn;
        private Siticone.Desktop.UI.WinForms.SiticoneComboBox funcCombo;
        private System.Windows.Forms.FlowLayoutPanel CalendarLayout;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private Siticone.Desktop.UI.WinForms.SiticoneButton btnPrevious;
        private Siticone.Desktop.UI.WinForms.SiticoneButton btnNext;
        private MaterialSkin.Controls.MaterialLabel lblMonthYear;
        private System.Windows.Forms.Button updateCalendar;
    }
}