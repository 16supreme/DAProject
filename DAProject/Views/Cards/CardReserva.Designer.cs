namespace DAProject.Views.Cards
{
    partial class CardReserva
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.siticoneGroupBox1 = new Siticone.Desktop.UI.WinForms.SiticoneGroupBox();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.extrasListBox = new System.Windows.Forms.ListBox();
            this.lblPrato = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.lblCliente = new MaterialSkin.Controls.MaterialLabel();
            this.lblNIF = new MaterialSkin.Controls.MaterialLabel();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deletarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.utilizadaNãoUtilizadaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblID = new MaterialSkin.Controls.MaterialLabel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.siticoneGroupBox1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // siticoneGroupBox1
            // 
            this.siticoneGroupBox1.Controls.Add(this.materialLabel2);
            this.siticoneGroupBox1.Controls.Add(this.extrasListBox);
            this.siticoneGroupBox1.Controls.Add(this.lblPrato);
            this.siticoneGroupBox1.Controls.Add(this.materialLabel1);
            this.siticoneGroupBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.siticoneGroupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.siticoneGroupBox1.Location = new System.Drawing.Point(3, 112);
            this.siticoneGroupBox1.Name = "siticoneGroupBox1";
            this.siticoneGroupBox1.Size = new System.Drawing.Size(241, 185);
            this.siticoneGroupBox1.TabIndex = 22;
            this.siticoneGroupBox1.Text = "Menu";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.FontType = MaterialSkin.MaterialSkinManager.fontType.Caption;
            this.materialLabel2.Location = new System.Drawing.Point(11, 91);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(35, 14);
            this.materialLabel2.TabIndex = 15;
            this.materialLabel2.Text = "Extras";
            // 
            // extrasListBox
            // 
            this.extrasListBox.FormattingEnabled = true;
            this.extrasListBox.ItemHeight = 15;
            this.extrasListBox.Location = new System.Drawing.Point(24, 108);
            this.extrasListBox.Name = "extrasListBox";
            this.extrasListBox.Size = new System.Drawing.Size(196, 64);
            this.extrasListBox.TabIndex = 14;
            // 
            // lblPrato
            // 
            this.lblPrato.AutoSize = true;
            this.lblPrato.Depth = 0;
            this.lblPrato.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblPrato.FontType = MaterialSkin.MaterialSkinManager.fontType.Overline;
            this.lblPrato.Location = new System.Drawing.Point(21, 69);
            this.lblPrato.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblPrato.Name = "lblPrato";
            this.lblPrato.Size = new System.Drawing.Size(64, 13);
            this.lblPrato.TabIndex = 1;
            this.lblPrato.Text = "materialLabel2";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.Caption;
            this.materialLabel1.Location = new System.Drawing.Point(11, 45);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(31, 14);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "Prato";
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Depth = 0;
            this.lblCliente.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblCliente.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle1;
            this.lblCliente.Location = new System.Drawing.Point(109, 35);
            this.lblCliente.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(43, 19);
            this.lblCliente.TabIndex = 18;
            this.lblCliente.Text = "Nome";
            // 
            // lblNIF
            // 
            this.lblNIF.AutoSize = true;
            this.lblNIF.Depth = 0;
            this.lblNIF.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblNIF.FontType = MaterialSkin.MaterialSkinManager.fontType.Caption;
            this.lblNIF.Location = new System.Drawing.Point(110, 54);
            this.lblNIF.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblNIF.Name = "lblNIF";
            this.lblNIF.Size = new System.Drawing.Size(20, 14);
            this.lblNIF.TabIndex = 16;
            this.lblNIF.Text = "NIF";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deletarToolStripMenuItem,
            this.utilizadaNãoUtilizadaToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(185, 78);
            // 
            // deletarToolStripMenuItem
            // 
            this.deletarToolStripMenuItem.Image = global::DAProject.Properties.Resources.Delete_User_Data;
            this.deletarToolStripMenuItem.Name = "deletarToolStripMenuItem";
            this.deletarToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.deletarToolStripMenuItem.Text = "Deletar";
            this.deletarToolStripMenuItem.Click += new System.EventHandler(this.deletarToolStripMenuItem_Click);
            // 
            // utilizadaNãoUtilizadaToolStripMenuItem
            // 
            this.utilizadaNãoUtilizadaToolStripMenuItem.Image = global::DAProject.Properties.Resources.Combi_Ticket;
            this.utilizadaNãoUtilizadaToolStripMenuItem.Name = "utilizadaNãoUtilizadaToolStripMenuItem";
            this.utilizadaNãoUtilizadaToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.utilizadaNãoUtilizadaToolStripMenuItem.Text = "Utilizada";
            this.utilizadaNãoUtilizadaToolStripMenuItem.Click += new System.EventHandler(this.utilizadaNãoUtilizadaToolStripMenuItem_Click);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Depth = 0;
            this.lblID.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblID.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.lblID.Location = new System.Drawing.Point(113, 4);
            this.lblID.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(12, 24);
            this.lblID.TabIndex = 24;
            this.lblID.Text = "0";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Enabled = false;
            this.pictureBox3.Image = global::DAProject.Properties.Resources.Bookmark;
            this.pictureBox3.Location = new System.Drawing.Point(179, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(36, 37);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 16;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Visible = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::DAProject.Properties.Resources.More;
            this.pictureBox2.Location = new System.Drawing.Point(221, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(23, 24);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 19;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DAProject.Properties.Resources.Combi_Ticket;
            this.pictureBox1.Location = new System.Drawing.Point(3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(104, 102);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // CardReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.siticoneGroupBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.lblNIF);
            this.Controls.Add(this.pictureBox1);
            this.Name = "CardReserva";
            this.Size = new System.Drawing.Size(248, 303);
            this.siticoneGroupBox1.ResumeLayout(false);
            this.siticoneGroupBox1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Siticone.Desktop.UI.WinForms.SiticoneGroupBox siticoneGroupBox1;
        private MaterialSkin.Controls.MaterialLabel lblPrato;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.ListBox extrasListBox;
        private System.Windows.Forms.PictureBox pictureBox2;
        private MaterialSkin.Controls.MaterialLabel lblCliente;
        private MaterialSkin.Controls.MaterialLabel lblNIF;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem deletarToolStripMenuItem;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel lblID;
        private System.Windows.Forms.ToolStripMenuItem utilizadaNãoUtilizadaToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}
