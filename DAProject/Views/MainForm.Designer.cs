namespace DAProject
{
    partial class MainForm
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

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.pnHeader = new System.Windows.Forms.Panel();
            this.btnSideBar = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnFormControls = new System.Windows.Forms.Panel();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonMaximize = new System.Windows.Forms.Button();
            this.buttonMinimize = new System.Windows.Forms.Button();
            this.sideBar = new System.Windows.Forms.FlowLayoutPanel();
            this.pnHome = new System.Windows.Forms.Panel();
            this.btnHome = new System.Windows.Forms.Button();
            this.pnReservas = new System.Windows.Forms.Panel();
            this.btnReservas = new System.Windows.Forms.Button();
            this.pnPratos = new System.Windows.Forms.Panel();
            this.btnPratos = new System.Windows.Forms.Button();
            this.pnExtras = new System.Windows.Forms.Panel();
            this.btnExtras = new System.Windows.Forms.Button();
            this.pnMenus = new System.Windows.Forms.Panel();
            this.btnMenus = new System.Windows.Forms.Button();
            this.pnMultas = new System.Windows.Forms.Panel();
            this.btnMultas = new System.Windows.Forms.Button();
            this.pnClientes = new System.Windows.Forms.Panel();
            this.btnClientes = new System.Windows.Forms.Button();
            this.pnFuncionarios = new System.Windows.Forms.Panel();
            this.btnFuncionarios = new System.Windows.Forms.Button();
            this.sidebarTransition = new System.Windows.Forms.Timer(this.components);
            this.pnHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSideBar)).BeginInit();
            this.pnFormControls.SuspendLayout();
            this.sideBar.SuspendLayout();
            this.pnHome.SuspendLayout();
            this.pnReservas.SuspendLayout();
            this.pnPratos.SuspendLayout();
            this.pnExtras.SuspendLayout();
            this.pnMenus.SuspendLayout();
            this.pnMultas.SuspendLayout();
            this.pnClientes.SuspendLayout();
            this.pnFuncionarios.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnHeader
            // 
            this.pnHeader.BackColor = System.Drawing.Color.White;
            this.pnHeader.Controls.Add(this.btnSideBar);
            this.pnHeader.Controls.Add(this.label1);
            this.pnHeader.Controls.Add(this.pnFormControls);
            this.pnHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnHeader.Location = new System.Drawing.Point(0, 0);
            this.pnHeader.Name = "pnHeader";
            this.pnHeader.Size = new System.Drawing.Size(1026, 66);
            this.pnHeader.TabIndex = 0;
            this.pnHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnMouseDown);
            // 
            // btnSideBar
            // 
            this.btnSideBar.Image = ((System.Drawing.Image)(resources.GetObject("btnSideBar.Image")));
            this.btnSideBar.Location = new System.Drawing.Point(33, 17);
            this.btnSideBar.Name = "btnSideBar";
            this.btnSideBar.Size = new System.Drawing.Size(41, 32);
            this.btnSideBar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnSideBar.TabIndex = 1;
            this.btnSideBar.TabStop = false;
            this.btnSideBar.Click += new System.EventHandler(this.btnSideBar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(99, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "iCantina";
            // 
            // pnFormControls
            // 
            this.pnFormControls.Controls.Add(this.buttonClose);
            this.pnFormControls.Controls.Add(this.buttonMaximize);
            this.pnFormControls.Controls.Add(this.buttonMinimize);
            this.pnFormControls.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnFormControls.Location = new System.Drawing.Point(820, 0);
            this.pnFormControls.Name = "pnFormControls";
            this.pnFormControls.Size = new System.Drawing.Size(206, 66);
            this.pnFormControls.TabIndex = 1;
            // 
            // buttonClose
            // 
            this.buttonClose.BackColor = System.Drawing.Color.Red;
            this.buttonClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonClose.FlatAppearance.BorderSize = 0;
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClose.Image = global::DAProject.Properties.Resources.Close;
            this.buttonClose.Location = new System.Drawing.Point(138, 12);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(56, 48);
            this.buttonClose.TabIndex = 2;
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonMaximize
            // 
            this.buttonMaximize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonMaximize.FlatAppearance.BorderSize = 0;
            this.buttonMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMaximize.Image = global::DAProject.Properties.Resources.Expand;
            this.buttonMaximize.Location = new System.Drawing.Point(75, 12);
            this.buttonMaximize.Name = "buttonMaximize";
            this.buttonMaximize.Size = new System.Drawing.Size(57, 48);
            this.buttonMaximize.TabIndex = 2;
            this.buttonMaximize.UseVisualStyleBackColor = false;
            this.buttonMaximize.Click += new System.EventHandler(this.buttonMaximize_Click);
            // 
            // buttonMinimize
            // 
            this.buttonMinimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonMinimize.FlatAppearance.BorderSize = 0;
            this.buttonMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMinimize.Image = global::DAProject.Properties.Resources.minimized;
            this.buttonMinimize.Location = new System.Drawing.Point(10, 12);
            this.buttonMinimize.Name = "buttonMinimize";
            this.buttonMinimize.Size = new System.Drawing.Size(59, 48);
            this.buttonMinimize.TabIndex = 1;
            this.buttonMinimize.UseVisualStyleBackColor = false;
            this.buttonMinimize.Click += new System.EventHandler(this.buttonMinimize_Click);
            // 
            // sideBar
            // 
            this.sideBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.sideBar.Controls.Add(this.pnHome);
            this.sideBar.Controls.Add(this.pnReservas);
            this.sideBar.Controls.Add(this.pnPratos);
            this.sideBar.Controls.Add(this.pnExtras);
            this.sideBar.Controls.Add(this.pnMenus);
            this.sideBar.Controls.Add(this.pnMultas);
            this.sideBar.Controls.Add(this.pnClientes);
            this.sideBar.Controls.Add(this.pnFuncionarios);
            this.sideBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sideBar.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.sideBar.Location = new System.Drawing.Point(0, 66);
            this.sideBar.Name = "sideBar";
            this.sideBar.Padding = new System.Windows.Forms.Padding(0, 15, 0, 0);
            this.sideBar.Size = new System.Drawing.Size(200, 613);
            this.sideBar.TabIndex = 1;
            // 
            // pnHome
            // 
            this.pnHome.Controls.Add(this.btnHome);
            this.pnHome.Location = new System.Drawing.Point(3, 18);
            this.pnHome.Name = "pnHome";
            this.pnHome.Padding = new System.Windows.Forms.Padding(0, 0, 0, 40);
            this.pnHome.Size = new System.Drawing.Size(196, 67);
            this.pnHome.TabIndex = 3;
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.btnHome.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(-9, -20);
            this.btnHome.Name = "btnHome";
            this.btnHome.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnHome.Size = new System.Drawing.Size(223, 114);
            this.btnHome.TabIndex = 2;
            this.btnHome.Text = "                      Home";
            this.btnHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.UseCompatibleTextRendering = true;
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // pnReservas
            // 
            this.pnReservas.Controls.Add(this.btnReservas);
            this.pnReservas.Location = new System.Drawing.Point(3, 91);
            this.pnReservas.Name = "pnReservas";
            this.pnReservas.Padding = new System.Windows.Forms.Padding(0, 0, 0, 40);
            this.pnReservas.Size = new System.Drawing.Size(196, 67);
            this.pnReservas.TabIndex = 4;
            // 
            // btnReservas
            // 
            this.btnReservas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.btnReservas.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReservas.ForeColor = System.Drawing.Color.White;
            this.btnReservas.Image = global::DAProject.Properties.Resources.Two_Tickets;
            this.btnReservas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReservas.Location = new System.Drawing.Point(-9, -20);
            this.btnReservas.Name = "btnReservas";
            this.btnReservas.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnReservas.Size = new System.Drawing.Size(223, 114);
            this.btnReservas.TabIndex = 2;
            this.btnReservas.Text = "                      Reservas";
            this.btnReservas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReservas.UseCompatibleTextRendering = true;
            this.btnReservas.UseVisualStyleBackColor = false;
            this.btnReservas.Click += new System.EventHandler(this.btnReservas_Click);
            // 
            // pnPratos
            // 
            this.pnPratos.Controls.Add(this.btnPratos);
            this.pnPratos.Location = new System.Drawing.Point(3, 164);
            this.pnPratos.Name = "pnPratos";
            this.pnPratos.Padding = new System.Windows.Forms.Padding(0, 0, 0, 40);
            this.pnPratos.Size = new System.Drawing.Size(196, 67);
            this.pnPratos.TabIndex = 4;
            // 
            // btnPratos
            // 
            this.btnPratos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.btnPratos.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPratos.ForeColor = System.Drawing.Color.White;
            this.btnPratos.Image = global::DAProject.Properties.Resources.Meal;
            this.btnPratos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPratos.Location = new System.Drawing.Point(-9, -20);
            this.btnPratos.Name = "btnPratos";
            this.btnPratos.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnPratos.Size = new System.Drawing.Size(223, 114);
            this.btnPratos.TabIndex = 2;
            this.btnPratos.Text = "                      Pratos";
            this.btnPratos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPratos.UseCompatibleTextRendering = true;
            this.btnPratos.UseVisualStyleBackColor = false;
            this.btnPratos.Click += new System.EventHandler(this.btnPratos_Click);
            // 
            // pnExtras
            // 
            this.pnExtras.Controls.Add(this.btnExtras);
            this.pnExtras.Location = new System.Drawing.Point(3, 237);
            this.pnExtras.Name = "pnExtras";
            this.pnExtras.Padding = new System.Windows.Forms.Padding(0, 0, 0, 40);
            this.pnExtras.Size = new System.Drawing.Size(196, 67);
            this.pnExtras.TabIndex = 4;
            // 
            // btnExtras
            // 
            this.btnExtras.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.btnExtras.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExtras.ForeColor = System.Drawing.Color.White;
            this.btnExtras.Image = global::DAProject.Properties.Resources.EXtras;
            this.btnExtras.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExtras.Location = new System.Drawing.Point(-9, -20);
            this.btnExtras.Name = "btnExtras";
            this.btnExtras.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnExtras.Size = new System.Drawing.Size(223, 114);
            this.btnExtras.TabIndex = 2;
            this.btnExtras.Text = "                      Extras";
            this.btnExtras.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExtras.UseCompatibleTextRendering = true;
            this.btnExtras.UseVisualStyleBackColor = false;
            this.btnExtras.Click += new System.EventHandler(this.btnExtras_Click);
            // 
            // pnMenus
            // 
            this.pnMenus.Controls.Add(this.btnMenus);
            this.pnMenus.Location = new System.Drawing.Point(3, 310);
            this.pnMenus.Name = "pnMenus";
            this.pnMenus.Padding = new System.Windows.Forms.Padding(0, 0, 0, 40);
            this.pnMenus.Size = new System.Drawing.Size(196, 67);
            this.pnMenus.TabIndex = 4;
            // 
            // btnMenus
            // 
            this.btnMenus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.btnMenus.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenus.ForeColor = System.Drawing.Color.White;
            this.btnMenus.Image = global::DAProject.Properties.Resources.Restaurant_Menu;
            this.btnMenus.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenus.Location = new System.Drawing.Point(-9, -20);
            this.btnMenus.Name = "btnMenus";
            this.btnMenus.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnMenus.Size = new System.Drawing.Size(223, 114);
            this.btnMenus.TabIndex = 2;
            this.btnMenus.Text = "                      Menus";
            this.btnMenus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenus.UseCompatibleTextRendering = true;
            this.btnMenus.UseVisualStyleBackColor = false;
            this.btnMenus.Click += new System.EventHandler(this.btnMenus_Click);
            // 
            // pnMultas
            // 
            this.pnMultas.Controls.Add(this.btnMultas);
            this.pnMultas.Location = new System.Drawing.Point(3, 383);
            this.pnMultas.Name = "pnMultas";
            this.pnMultas.Padding = new System.Windows.Forms.Padding(0, 0, 0, 40);
            this.pnMultas.Size = new System.Drawing.Size(196, 67);
            this.pnMultas.TabIndex = 4;
            // 
            // btnMultas
            // 
            this.btnMultas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.btnMultas.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMultas.ForeColor = System.Drawing.Color.White;
            this.btnMultas.Image = global::DAProject.Properties.Resources.Multas;
            this.btnMultas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMultas.Location = new System.Drawing.Point(-9, -20);
            this.btnMultas.Name = "btnMultas";
            this.btnMultas.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnMultas.Size = new System.Drawing.Size(223, 114);
            this.btnMultas.TabIndex = 2;
            this.btnMultas.Text = "                      Multas";
            this.btnMultas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMultas.UseCompatibleTextRendering = true;
            this.btnMultas.UseVisualStyleBackColor = false;
            this.btnMultas.Click += new System.EventHandler(this.btnMultas_Click);
            // 
            // pnClientes
            // 
            this.pnClientes.Controls.Add(this.btnClientes);
            this.pnClientes.Location = new System.Drawing.Point(3, 456);
            this.pnClientes.Name = "pnClientes";
            this.pnClientes.Padding = new System.Windows.Forms.Padding(0, 0, 0, 40);
            this.pnClientes.Size = new System.Drawing.Size(196, 67);
            this.pnClientes.TabIndex = 4;
            // 
            // btnClientes
            // 
            this.btnClientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.btnClientes.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientes.ForeColor = System.Drawing.Color.White;
            this.btnClientes.Image = global::DAProject.Properties.Resources.clients;
            this.btnClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClientes.Location = new System.Drawing.Point(-9, -20);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnClientes.Size = new System.Drawing.Size(223, 114);
            this.btnClientes.TabIndex = 2;
            this.btnClientes.Text = "                      Clientes";
            this.btnClientes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClientes.UseCompatibleTextRendering = true;
            this.btnClientes.UseVisualStyleBackColor = false;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // pnFuncionarios
            // 
            this.pnFuncionarios.Controls.Add(this.btnFuncionarios);
            this.pnFuncionarios.Location = new System.Drawing.Point(3, 529);
            this.pnFuncionarios.Name = "pnFuncionarios";
            this.pnFuncionarios.Padding = new System.Windows.Forms.Padding(0, 0, 0, 40);
            this.pnFuncionarios.Size = new System.Drawing.Size(196, 67);
            this.pnFuncionarios.TabIndex = 4;
            // 
            // btnFuncionarios
            // 
            this.btnFuncionarios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.btnFuncionarios.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFuncionarios.ForeColor = System.Drawing.Color.White;
            this.btnFuncionarios.Image = global::DAProject.Properties.Resources.Management;
            this.btnFuncionarios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFuncionarios.Location = new System.Drawing.Point(-9, -20);
            this.btnFuncionarios.Name = "btnFuncionarios";
            this.btnFuncionarios.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnFuncionarios.Size = new System.Drawing.Size(223, 114);
            this.btnFuncionarios.TabIndex = 2;
            this.btnFuncionarios.Text = "                      Funcionários";
            this.btnFuncionarios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFuncionarios.UseCompatibleTextRendering = true;
            this.btnFuncionarios.UseVisualStyleBackColor = false;
            this.btnFuncionarios.Click += new System.EventHandler(this.btnFuncionarios_Click);
            // 
            // sidebarTransition
            // 
            this.sidebarTransition.Interval = 10;
            this.sidebarTransition.Tick += new System.EventHandler(this.sidebarTransition_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1026, 679);
            this.Controls.Add(this.sideBar);
            this.Controls.Add(this.pnHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.Text = "Página Inicial";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.pnHeader.ResumeLayout(false);
            this.pnHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSideBar)).EndInit();
            this.pnFormControls.ResumeLayout(false);
            this.sideBar.ResumeLayout(false);
            this.pnHome.ResumeLayout(false);
            this.pnReservas.ResumeLayout(false);
            this.pnPratos.ResumeLayout(false);
            this.pnExtras.ResumeLayout(false);
            this.pnMenus.ResumeLayout(false);
            this.pnMultas.ResumeLayout(false);
            this.pnClientes.ResumeLayout(false);
            this.pnFuncionarios.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnHeader;
        private System.Windows.Forms.PictureBox btnSideBar;
        private System.Windows.Forms.Button buttonMinimize;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonMaximize;
        private System.Windows.Forms.Panel pnFormControls;
        private System.Windows.Forms.FlowLayoutPanel sideBar;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Panel pnHome;
        private System.Windows.Forms.Timer sidebarTransition;
        private System.Windows.Forms.Panel pnReservas;
        private System.Windows.Forms.Button btnReservas;
        private System.Windows.Forms.Panel pnPratos;
        private System.Windows.Forms.Button btnPratos;
        private System.Windows.Forms.Panel pnExtras;
        private System.Windows.Forms.Button btnExtras;
        private System.Windows.Forms.Panel pnMenus;
        private System.Windows.Forms.Button btnMenus;
        private System.Windows.Forms.Panel pnMultas;
        private System.Windows.Forms.Button btnMultas;
        private System.Windows.Forms.Panel pnClientes;
        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.Panel pnFuncionarios;
        private System.Windows.Forms.Button btnFuncionarios;
    }
}

