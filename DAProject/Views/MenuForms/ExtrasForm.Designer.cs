﻿namespace DAProject.Views
{
    partial class ExtrasForm
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
            this.addCard = new MaterialSkin.Controls.MaterialFloatingActionButton();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.siticoneTextBox1 = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.updateBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addCard
            // 
            this.addCard.Depth = 0;
            this.addCard.Icon = global::DAProject.Properties.Resources.Plus;
            this.addCard.Location = new System.Drawing.Point(12, 418);
            this.addCard.Mini = true;
            this.addCard.MouseState = MaterialSkin.MouseState.HOVER;
            this.addCard.Name = "addCard";
            this.addCard.Size = new System.Drawing.Size(40, 46);
            this.addCard.TabIndex = 2;
            this.addCard.Text = "materialFloatingActionButton1";
            this.addCard.UseVisualStyleBackColor = true;
            this.addCard.Click += new System.EventHandler(this.addCard_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 65);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(793, 347);
            this.flowLayoutPanel1.TabIndex = 4;
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
            this.siticoneTextBox1.Location = new System.Drawing.Point(12, 8);
            this.siticoneTextBox1.Name = "siticoneTextBox1";
            this.siticoneTextBox1.PasswordChar = '\0';
            this.siticoneTextBox1.PlaceholderText = "Pesquisar (Descrição)";
            this.siticoneTextBox1.SelectedText = "";
            this.siticoneTextBox1.Size = new System.Drawing.Size(253, 51);
            this.siticoneTextBox1.TabIndex = 3;
            this.siticoneTextBox1.TextChanged += new System.EventHandler(this.siticoneTextBox1_TextChanged);
            // 
            // updateBtn
            // 
            this.updateBtn.BackColor = System.Drawing.SystemColors.Control;
            this.updateBtn.BackgroundImage = global::DAProject.Properties.Resources.updateflowlayoutpanel;
            this.updateBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.updateBtn.FlatAppearance.BorderSize = 0;
            this.updateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateBtn.Location = new System.Drawing.Point(765, 418);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(30, 30);
            this.updateBtn.TabIndex = 8;
            this.updateBtn.UseVisualStyleBackColor = false;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // ExtrasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 493);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.addCard);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.siticoneTextBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ExtrasForm";
            this.Text = "ExtrasForm";
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialFloatingActionButton addCard;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox siticoneTextBox1;
        private System.Windows.Forms.Button updateBtn;
    }
}