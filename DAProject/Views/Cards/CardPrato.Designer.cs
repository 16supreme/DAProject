namespace DAProject.Views
{
    partial class CardPrato
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
            this.lblNome = new MaterialSkin.Controls.MaterialLabel();
            this.lblNif = new MaterialSkin.Controls.MaterialLabel();
            this.lblSaldo = new MaterialSkin.Controls.MaterialLabel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.atualizarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deletarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Depth = 0;
            this.lblNome.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblNome.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.lblNome.Location = new System.Drawing.Point(91, 3);
            this.lblNome.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(82, 24);
            this.lblNome.TabIndex = 13;
            this.lblNome.Text = "Descição";
            // 
            // lblNif
            // 
            this.lblNif.AutoSize = true;
            this.lblNif.Depth = 0;
            this.lblNif.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblNif.Location = new System.Drawing.Point(92, 58);
            this.lblNif.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblNif.Name = "lblNif";
            this.lblNif.Size = new System.Drawing.Size(37, 19);
            this.lblNif.TabIndex = 12;
            this.lblNif.Text = "Ativo";
            // 
            // lblSaldo
            // 
            this.lblSaldo.AutoSize = true;
            this.lblSaldo.Depth = 0;
            this.lblSaldo.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblSaldo.Location = new System.Drawing.Point(91, 39);
            this.lblSaldo.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(33, 19);
            this.lblSaldo.TabIndex = 11;
            this.lblSaldo.Text = "Tipo";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::DAProject.Properties.Resources.More;
            this.pictureBox2.Location = new System.Drawing.Point(208, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(23, 24);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DAProject.Properties.Resources.Func;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(82, 79);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
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
            // atualizarToolStripMenuItem
            // 
            this.atualizarToolStripMenuItem.Image = global::DAProject.Properties.Resources.Edit;
            this.atualizarToolStripMenuItem.Name = "atualizarToolStripMenuItem";
            this.atualizarToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.atualizarToolStripMenuItem.Text = "Editar";
            // 
            // deletarToolStripMenuItem
            // 
            this.deletarToolStripMenuItem.Image = global::DAProject.Properties.Resources.Delete_User_Data;
            this.deletarToolStripMenuItem.Name = "deletarToolStripMenuItem";
            this.deletarToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.deletarToolStripMenuItem.Text = "Deletar";
            // 
            // CardPrato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.lblNif);
            this.Controls.Add(this.lblSaldo);
            this.Controls.Add(this.pictureBox1);
            this.Name = "CardPrato";
            this.Size = new System.Drawing.Size(234, 85);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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
