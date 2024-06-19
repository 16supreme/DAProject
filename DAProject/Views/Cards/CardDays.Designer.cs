namespace DAProject.Views.Cards
{
    partial class CardDays
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
            this.lblDay = new System.Windows.Forms.Label();
            this.menuIDs = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblDay
            // 
            this.lblDay.AutoSize = true;
            this.lblDay.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDay.Location = new System.Drawing.Point(3, 0);
            this.lblDay.Name = "lblDay";
            this.lblDay.Size = new System.Drawing.Size(19, 13);
            this.lblDay.TabIndex = 0;
            this.lblDay.Text = "00";
            // 
            // menuIDs
            // 
            this.menuIDs.FormattingEnabled = true;
            this.menuIDs.HorizontalScrollbar = true;
            this.menuIDs.Location = new System.Drawing.Point(3, 16);
            this.menuIDs.Name = "menuIDs";
            this.menuIDs.Size = new System.Drawing.Size(91, 56);
            this.menuIDs.TabIndex = 1;
            // 
            // CardDays
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.menuIDs);
            this.Controls.Add(this.lblDay);
            this.Name = "CardDays";
            this.Size = new System.Drawing.Size(97, 72);
            this.Load += new System.EventHandler(this.CardDays_Load);
            this.Click += new System.EventHandler(this.CardDays_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDay;
        private System.Windows.Forms.ListBox menuIDs;
    }
}
