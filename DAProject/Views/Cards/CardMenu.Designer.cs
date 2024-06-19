namespace DAProject.Views.Cards
{
    partial class CardMenu
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
            this.lblDataHora = new MaterialSkin.Controls.MaterialLabel();
            this.lblPrecoProfessor = new MaterialSkin.Controls.MaterialLabel();
            this.lblPrecoEstudante = new MaterialSkin.Controls.MaterialLabel();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.lblQtnd = new MaterialSkin.Controls.MaterialLabel();
            this.siticoneGroupBox2 = new Siticone.Desktop.UI.WinForms.SiticoneGroupBox();
            this.extrasListBox = new System.Windows.Forms.ListBox();
            this.siticoneGroupBox1 = new Siticone.Desktop.UI.WinForms.SiticoneGroupBox();
            this.lblVeggie = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.lblPeixe = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.lblCarne = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.atualizarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deletarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.siticoneGroupBox2.SuspendLayout();
            this.siticoneGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDataHora
            // 
            this.lblDataHora.AutoSize = true;
            this.lblDataHora.Depth = 0;
            this.lblDataHora.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblDataHora.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle1;
            this.lblDataHora.Location = new System.Drawing.Point(112, 3);
            this.lblDataHora.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblDataHora.Name = "lblDataHora";
            this.lblDataHora.Size = new System.Drawing.Size(41, 19);
            this.lblDataHora.TabIndex = 8;
            this.lblDataHora.Text = "00:00";
            // 
            // lblPrecoProfessor
            // 
            this.lblPrecoProfessor.AutoSize = true;
            this.lblPrecoProfessor.Depth = 0;
            this.lblPrecoProfessor.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblPrecoProfessor.FontType = MaterialSkin.MaterialSkinManager.fontType.Caption;
            this.lblPrecoProfessor.Location = new System.Drawing.Point(113, 48);
            this.lblPrecoProfessor.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblPrecoProfessor.Name = "lblPrecoProfessor";
            this.lblPrecoProfessor.Size = new System.Drawing.Size(8, 14);
            this.lblPrecoProfessor.TabIndex = 7;
            this.lblPrecoProfessor.Text = "€";
            // 
            // lblPrecoEstudante
            // 
            this.lblPrecoEstudante.AutoSize = true;
            this.lblPrecoEstudante.Depth = 0;
            this.lblPrecoEstudante.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblPrecoEstudante.FontType = MaterialSkin.MaterialSkinManager.fontType.Caption;
            this.lblPrecoEstudante.Location = new System.Drawing.Point(113, 25);
            this.lblPrecoEstudante.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblPrecoEstudante.Name = "lblPrecoEstudante";
            this.lblPrecoEstudante.Size = new System.Drawing.Size(8, 14);
            this.lblPrecoEstudante.TabIndex = 6;
            this.lblPrecoEstudante.Text = "€";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.atualizarToolStripMenuItem,
            this.deletarToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(116, 56);
            // 
            // lblQtnd
            // 
            this.lblQtnd.AutoSize = true;
            this.lblQtnd.Depth = 0;
            this.lblQtnd.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblQtnd.FontType = MaterialSkin.MaterialSkinManager.fontType.Body2;
            this.lblQtnd.Location = new System.Drawing.Point(112, 71);
            this.lblQtnd.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblQtnd.Name = "lblQtnd";
            this.lblQtnd.Size = new System.Drawing.Size(74, 17);
            this.lblQtnd.TabIndex = 12;
            this.lblQtnd.Text = "Quantidade";
            // 
            // siticoneGroupBox2
            // 
            this.siticoneGroupBox2.Controls.Add(this.extrasListBox);
            this.siticoneGroupBox2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.siticoneGroupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.siticoneGroupBox2.Location = new System.Drawing.Point(205, 111);
            this.siticoneGroupBox2.Name = "siticoneGroupBox2";
            this.siticoneGroupBox2.Size = new System.Drawing.Size(144, 192);
            this.siticoneGroupBox2.TabIndex = 13;
            this.siticoneGroupBox2.Text = "Extras";
            // 
            // extrasListBox
            // 
            this.extrasListBox.FormattingEnabled = true;
            this.extrasListBox.ItemHeight = 15;
            this.extrasListBox.Location = new System.Drawing.Point(6, 45);
            this.extrasListBox.Name = "extrasListBox";
            this.extrasListBox.Size = new System.Drawing.Size(131, 139);
            this.extrasListBox.TabIndex = 14;
            // 
            // siticoneGroupBox1
            // 
            this.siticoneGroupBox1.Controls.Add(this.lblVeggie);
            this.siticoneGroupBox1.Controls.Add(this.materialLabel6);
            this.siticoneGroupBox1.Controls.Add(this.lblPeixe);
            this.siticoneGroupBox1.Controls.Add(this.materialLabel4);
            this.siticoneGroupBox1.Controls.Add(this.lblCarne);
            this.siticoneGroupBox1.Controls.Add(this.materialLabel1);
            this.siticoneGroupBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.siticoneGroupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.siticoneGroupBox1.Location = new System.Drawing.Point(3, 111);
            this.siticoneGroupBox1.Name = "siticoneGroupBox1";
            this.siticoneGroupBox1.Size = new System.Drawing.Size(196, 192);
            this.siticoneGroupBox1.TabIndex = 14;
            this.siticoneGroupBox1.Text = "Pratos";
            // 
            // lblVeggie
            // 
            this.lblVeggie.AutoSize = true;
            this.lblVeggie.Depth = 0;
            this.lblVeggie.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblVeggie.FontType = MaterialSkin.MaterialSkinManager.fontType.Overline;
            this.lblVeggie.Location = new System.Drawing.Point(21, 162);
            this.lblVeggie.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblVeggie.Name = "lblVeggie";
            this.lblVeggie.Size = new System.Drawing.Size(64, 13);
            this.lblVeggie.TabIndex = 5;
            this.lblVeggie.Text = "materialLabel5";
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel6.FontType = MaterialSkin.MaterialSkinManager.fontType.Caption;
            this.materialLabel6.Location = new System.Drawing.Point(11, 139);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(67, 14);
            this.materialLabel6.TabIndex = 4;
            this.materialLabel6.Text = "Vegetariano";
            // 
            // lblPeixe
            // 
            this.lblPeixe.AutoSize = true;
            this.lblPeixe.Depth = 0;
            this.lblPeixe.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblPeixe.FontType = MaterialSkin.MaterialSkinManager.fontType.Overline;
            this.lblPeixe.Location = new System.Drawing.Point(21, 115);
            this.lblPeixe.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblPeixe.Name = "lblPeixe";
            this.lblPeixe.Size = new System.Drawing.Size(64, 13);
            this.lblPeixe.TabIndex = 3;
            this.lblPeixe.Text = "materialLabel3";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.FontType = MaterialSkin.MaterialSkinManager.fontType.Caption;
            this.materialLabel4.Location = new System.Drawing.Point(11, 92);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(30, 14);
            this.materialLabel4.TabIndex = 2;
            this.materialLabel4.Text = "Peixe";
            // 
            // lblCarne
            // 
            this.lblCarne.AutoSize = true;
            this.lblCarne.Depth = 0;
            this.lblCarne.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblCarne.FontType = MaterialSkin.MaterialSkinManager.fontType.Overline;
            this.lblCarne.Location = new System.Drawing.Point(21, 68);
            this.lblCarne.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblCarne.Name = "lblCarne";
            this.lblCarne.Size = new System.Drawing.Size(64, 13);
            this.lblCarne.TabIndex = 1;
            this.lblCarne.Text = "materialLabel2";
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
            this.materialLabel1.Size = new System.Drawing.Size(33, 14);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "Carne";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::DAProject.Properties.Resources.More;
            this.pictureBox2.Location = new System.Drawing.Point(329, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(23, 24);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DAProject.Properties.Resources.NewMenu;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(104, 102);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // atualizarToolStripMenuItem
            // 
            this.atualizarToolStripMenuItem.Image = global::DAProject.Properties.Resources.Edit;
            this.atualizarToolStripMenuItem.Name = "atualizarToolStripMenuItem";
            this.atualizarToolStripMenuItem.Size = new System.Drawing.Size(115, 26);
            this.atualizarToolStripMenuItem.Text = "Editar";
            this.atualizarToolStripMenuItem.Click += new System.EventHandler(this.atualizarToolStripMenuItem_Click);
            // 
            // deletarToolStripMenuItem
            // 
            this.deletarToolStripMenuItem.Image = global::DAProject.Properties.Resources.Delete_User_Data;
            this.deletarToolStripMenuItem.Name = "deletarToolStripMenuItem";
            this.deletarToolStripMenuItem.Size = new System.Drawing.Size(115, 26);
            this.deletarToolStripMenuItem.Text = "Deletar";
            this.deletarToolStripMenuItem.Click += new System.EventHandler(this.deletarToolStripMenuItem_Click);
            // 
            // CardMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.siticoneGroupBox1);
            this.Controls.Add(this.siticoneGroupBox2);
            this.Controls.Add(this.lblQtnd);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lblDataHora);
            this.Controls.Add(this.lblPrecoProfessor);
            this.Controls.Add(this.lblPrecoEstudante);
            this.Controls.Add(this.pictureBox1);
            this.Name = "CardMenu";
            this.Size = new System.Drawing.Size(355, 309);
            this.contextMenuStrip1.ResumeLayout(false);
            this.siticoneGroupBox2.ResumeLayout(false);
            this.siticoneGroupBox1.ResumeLayout(false);
            this.siticoneGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private MaterialSkin.Controls.MaterialLabel lblDataHora;
        private MaterialSkin.Controls.MaterialLabel lblPrecoProfessor;
        private MaterialSkin.Controls.MaterialLabel lblPrecoEstudante;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem atualizarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deletarToolStripMenuItem;
        private MaterialSkin.Controls.MaterialLabel lblQtnd;
        private Siticone.Desktop.UI.WinForms.SiticoneGroupBox siticoneGroupBox2;
        private System.Windows.Forms.ListBox extrasListBox;
        private Siticone.Desktop.UI.WinForms.SiticoneGroupBox siticoneGroupBox1;
        private MaterialSkin.Controls.MaterialLabel lblVeggie;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialLabel lblPeixe;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel lblCarne;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
    }
}
