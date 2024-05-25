namespace DAProject.Views
{
    partial class CardEstudante
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
            this.lblNumEstudante = new MaterialSkin.Controls.MaterialLabel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblNome = new MaterialSkin.Controls.MaterialLabel();
            this.lblNif = new MaterialSkin.Controls.MaterialLabel();
            this.lblSaldo = new MaterialSkin.Controls.MaterialLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.atualizarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deletarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNumEstudante
            // 
            this.lblNumEstudante.AutoSize = true;
            this.lblNumEstudante.Depth = 0;
            this.lblNumEstudante.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblNumEstudante.FontType = MaterialSkin.MaterialSkinManager.fontType.Caption;
            this.lblNumEstudante.Location = new System.Drawing.Point(87, 59);
            this.lblNumEstudante.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblNumEstudante.Name = "lblNumEstudante";
            this.lblNumEstudante.Size = new System.Drawing.Size(81, 14);
            this.lblNumEstudante.TabIndex = 24;
            this.lblNumEstudante.Text = "numEstudante";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::DAProject.Properties.Resources.More;
            this.pictureBox2.Location = new System.Drawing.Point(235, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(23, 24);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 23;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Depth = 0;
            this.lblNome.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblNome.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle2;
            this.lblNome.Location = new System.Drawing.Point(87, 4);
            this.lblNome.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(39, 17);
            this.lblNome.TabIndex = 22;
            this.lblNome.Text = "Nome";
            // 
            // lblNif
            // 
            this.lblNif.AutoSize = true;
            this.lblNif.Depth = 0;
            this.lblNif.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblNif.FontType = MaterialSkin.MaterialSkinManager.fontType.Caption;
            this.lblNif.Location = new System.Drawing.Point(87, 46);
            this.lblNif.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblNif.Name = "lblNif";
            this.lblNif.Size = new System.Drawing.Size(20, 14);
            this.lblNif.TabIndex = 21;
            this.lblNif.Text = "NIF";
            // 
            // lblSaldo
            // 
            this.lblSaldo.AutoSize = true;
            this.lblSaldo.Depth = 0;
            this.lblSaldo.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblSaldo.FontType = MaterialSkin.MaterialSkinManager.fontType.Caption;
            this.lblSaldo.Location = new System.Drawing.Point(87, 32);
            this.lblSaldo.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(32, 14);
            this.lblSaldo.TabIndex = 20;
            this.lblSaldo.Text = "Saldo";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DAProject.Properties.Resources.Man_Student;
            this.pictureBox1.Location = new System.Drawing.Point(3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(78, 74);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.atualizarToolStripMenuItem,
            this.deletarToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(185, 78);
            // 
            // atualizarToolStripMenuItem
            // 
            this.atualizarToolStripMenuItem.Image = global::DAProject.Properties.Resources.Edit;
            this.atualizarToolStripMenuItem.Name = "atualizarToolStripMenuItem";
            this.atualizarToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.atualizarToolStripMenuItem.Text = "Editar";
            this.atualizarToolStripMenuItem.Click += new System.EventHandler(this.atualizarToolStripMenuItem_Click);
            // 
            // deletarToolStripMenuItem
            // 
            this.deletarToolStripMenuItem.Image = global::DAProject.Properties.Resources.Delete_User_Data;
            this.deletarToolStripMenuItem.Name = "deletarToolStripMenuItem";
            this.deletarToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.deletarToolStripMenuItem.Text = "Deletar";
            this.deletarToolStripMenuItem.Click += new System.EventHandler(this.deletarToolStripMenuItem_Click);
            // 
            // CardEstudante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblNumEstudante);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.lblNif);
            this.Controls.Add(this.lblSaldo);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "CardEstudante";
            this.Size = new System.Drawing.Size(261, 83);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel lblNumEstudante;
        private System.Windows.Forms.PictureBox pictureBox2;
        private MaterialSkin.Controls.MaterialLabel lblNome;
        private MaterialSkin.Controls.MaterialLabel lblNif;
        private MaterialSkin.Controls.MaterialLabel lblSaldo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem atualizarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deletarToolStripMenuItem;
    }
}
