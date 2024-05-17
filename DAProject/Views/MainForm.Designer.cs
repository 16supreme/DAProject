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
            this.label1 = new System.Windows.Forms.Label();
            this.pnFormControls = new System.Windows.Forms.Panel();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonMaximize = new System.Windows.Forms.Button();
            this.buttonMinimize = new System.Windows.Forms.Button();
            this.btnSideBar = new System.Windows.Forms.PictureBox();
            this.sideBar = new System.Windows.Forms.FlowLayoutPanel();
            this.pnHome = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.sidebarTransition = new System.Windows.Forms.Timer(this.components);
            this.panel4 = new System.Windows.Forms.Panel();
            this.pnReservas = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.pnPratos = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.pnExtras = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.pnMenus = new System.Windows.Forms.Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.pnMultas = new System.Windows.Forms.Button();
            this.panel9 = new System.Windows.Forms.Panel();
            this.pnClientes = new System.Windows.Forms.Button();
            this.panel10 = new System.Windows.Forms.Panel();
            this.pnFuncionarios = new System.Windows.Forms.Button();
            this.pnHeader.SuspendLayout();
            this.pnFormControls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSideBar)).BeginInit();
            this.sideBar.SuspendLayout();
            this.pnHome.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel10.SuspendLayout();
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
            // sideBar
            // 
            this.sideBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.sideBar.Controls.Add(this.pnHome);
            this.sideBar.Controls.Add(this.panel4);
            this.sideBar.Controls.Add(this.panel5);
            this.sideBar.Controls.Add(this.panel6);
            this.sideBar.Controls.Add(this.panel7);
            this.sideBar.Controls.Add(this.panel8);
            this.sideBar.Controls.Add(this.panel9);
            this.sideBar.Controls.Add(this.panel10);
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
            this.pnHome.Controls.Add(this.button1);
            this.pnHome.Location = new System.Drawing.Point(3, 18);
            this.pnHome.Name = "pnHome";
            this.pnHome.Padding = new System.Windows.Forms.Padding(0, 0, 0, 40);
            this.pnHome.Size = new System.Drawing.Size(196, 67);
            this.pnHome.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(-9, -20);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.button1.Size = new System.Drawing.Size(223, 114);
            this.button1.TabIndex = 2;
            this.button1.Text = "                      Home";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseCompatibleTextRendering = true;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // sidebarTransition
            // 
            this.sidebarTransition.Interval = 10;
            this.sidebarTransition.Tick += new System.EventHandler(this.sidebarTransition_Tick);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.pnReservas);
            this.panel4.Location = new System.Drawing.Point(3, 91);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(0, 0, 0, 40);
            this.panel4.Size = new System.Drawing.Size(196, 67);
            this.panel4.TabIndex = 4;
            // 
            // pnReservas
            // 
            this.pnReservas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.pnReservas.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnReservas.ForeColor = System.Drawing.Color.White;
            this.pnReservas.Image = global::DAProject.Properties.Resources.Two_Tickets;
            this.pnReservas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.pnReservas.Location = new System.Drawing.Point(-9, -20);
            this.pnReservas.Name = "pnReservas";
            this.pnReservas.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.pnReservas.Size = new System.Drawing.Size(223, 114);
            this.pnReservas.TabIndex = 2;
            this.pnReservas.Text = "                      Reservas";
            this.pnReservas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.pnReservas.UseCompatibleTextRendering = true;
            this.pnReservas.UseVisualStyleBackColor = false;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.pnPratos);
            this.panel5.Location = new System.Drawing.Point(3, 164);
            this.panel5.Name = "panel5";
            this.panel5.Padding = new System.Windows.Forms.Padding(0, 0, 0, 40);
            this.panel5.Size = new System.Drawing.Size(196, 67);
            this.panel5.TabIndex = 4;
            // 
            // pnPratos
            // 
            this.pnPratos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.pnPratos.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnPratos.ForeColor = System.Drawing.Color.White;
            this.pnPratos.Image = global::DAProject.Properties.Resources.Meal;
            this.pnPratos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.pnPratos.Location = new System.Drawing.Point(-9, -20);
            this.pnPratos.Name = "pnPratos";
            this.pnPratos.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.pnPratos.Size = new System.Drawing.Size(223, 114);
            this.pnPratos.TabIndex = 2;
            this.pnPratos.Text = "                      Pratos";
            this.pnPratos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.pnPratos.UseCompatibleTextRendering = true;
            this.pnPratos.UseVisualStyleBackColor = false;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.pnExtras);
            this.panel6.Location = new System.Drawing.Point(3, 237);
            this.panel6.Name = "panel6";
            this.panel6.Padding = new System.Windows.Forms.Padding(0, 0, 0, 40);
            this.panel6.Size = new System.Drawing.Size(196, 67);
            this.panel6.TabIndex = 4;
            // 
            // pnExtras
            // 
            this.pnExtras.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.pnExtras.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnExtras.ForeColor = System.Drawing.Color.White;
            this.pnExtras.Image = global::DAProject.Properties.Resources.EXtras;
            this.pnExtras.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.pnExtras.Location = new System.Drawing.Point(-9, -20);
            this.pnExtras.Name = "pnExtras";
            this.pnExtras.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.pnExtras.Size = new System.Drawing.Size(223, 114);
            this.pnExtras.TabIndex = 2;
            this.pnExtras.Text = "                      Extras";
            this.pnExtras.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.pnExtras.UseCompatibleTextRendering = true;
            this.pnExtras.UseVisualStyleBackColor = false;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.pnMenus);
            this.panel7.Location = new System.Drawing.Point(3, 310);
            this.panel7.Name = "panel7";
            this.panel7.Padding = new System.Windows.Forms.Padding(0, 0, 0, 40);
            this.panel7.Size = new System.Drawing.Size(196, 67);
            this.panel7.TabIndex = 4;
            // 
            // pnMenus
            // 
            this.pnMenus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.pnMenus.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnMenus.ForeColor = System.Drawing.Color.White;
            this.pnMenus.Image = global::DAProject.Properties.Resources.Restaurant_Menu;
            this.pnMenus.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.pnMenus.Location = new System.Drawing.Point(-9, -20);
            this.pnMenus.Name = "pnMenus";
            this.pnMenus.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.pnMenus.Size = new System.Drawing.Size(223, 114);
            this.pnMenus.TabIndex = 2;
            this.pnMenus.Text = "                      Menus";
            this.pnMenus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.pnMenus.UseCompatibleTextRendering = true;
            this.pnMenus.UseVisualStyleBackColor = false;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.pnMultas);
            this.panel8.Location = new System.Drawing.Point(3, 383);
            this.panel8.Name = "panel8";
            this.panel8.Padding = new System.Windows.Forms.Padding(0, 0, 0, 40);
            this.panel8.Size = new System.Drawing.Size(196, 67);
            this.panel8.TabIndex = 4;
            // 
            // pnMultas
            // 
            this.pnMultas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.pnMultas.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnMultas.ForeColor = System.Drawing.Color.White;
            this.pnMultas.Image = global::DAProject.Properties.Resources.Multas;
            this.pnMultas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.pnMultas.Location = new System.Drawing.Point(-9, -20);
            this.pnMultas.Name = "pnMultas";
            this.pnMultas.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.pnMultas.Size = new System.Drawing.Size(223, 114);
            this.pnMultas.TabIndex = 2;
            this.pnMultas.Text = "                      Multas";
            this.pnMultas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.pnMultas.UseCompatibleTextRendering = true;
            this.pnMultas.UseVisualStyleBackColor = false;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.pnClientes);
            this.panel9.Location = new System.Drawing.Point(3, 456);
            this.panel9.Name = "panel9";
            this.panel9.Padding = new System.Windows.Forms.Padding(0, 0, 0, 40);
            this.panel9.Size = new System.Drawing.Size(196, 67);
            this.panel9.TabIndex = 4;
            // 
            // pnClientes
            // 
            this.pnClientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.pnClientes.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnClientes.ForeColor = System.Drawing.Color.White;
            this.pnClientes.Image = global::DAProject.Properties.Resources.clients;
            this.pnClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.pnClientes.Location = new System.Drawing.Point(-9, -20);
            this.pnClientes.Name = "pnClientes";
            this.pnClientes.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.pnClientes.Size = new System.Drawing.Size(223, 114);
            this.pnClientes.TabIndex = 2;
            this.pnClientes.Text = "                      Clientes";
            this.pnClientes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.pnClientes.UseCompatibleTextRendering = true;
            this.pnClientes.UseVisualStyleBackColor = false;
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.pnFuncionarios);
            this.panel10.Location = new System.Drawing.Point(3, 529);
            this.panel10.Name = "panel10";
            this.panel10.Padding = new System.Windows.Forms.Padding(0, 0, 0, 40);
            this.panel10.Size = new System.Drawing.Size(196, 67);
            this.panel10.TabIndex = 4;
            // 
            // pnFuncionarios
            // 
            this.pnFuncionarios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.pnFuncionarios.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnFuncionarios.ForeColor = System.Drawing.Color.White;
            this.pnFuncionarios.Image = global::DAProject.Properties.Resources.Management;
            this.pnFuncionarios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.pnFuncionarios.Location = new System.Drawing.Point(-9, -20);
            this.pnFuncionarios.Name = "pnFuncionarios";
            this.pnFuncionarios.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.pnFuncionarios.Size = new System.Drawing.Size(223, 114);
            this.pnFuncionarios.TabIndex = 2;
            this.pnFuncionarios.Text = "                      Funcionários";
            this.pnFuncionarios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.pnFuncionarios.UseCompatibleTextRendering = true;
            this.pnFuncionarios.UseVisualStyleBackColor = false;
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
            this.pnHeader.ResumeLayout(false);
            this.pnHeader.PerformLayout();
            this.pnFormControls.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnSideBar)).EndInit();
            this.sideBar.ResumeLayout(false);
            this.pnHome.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel pnHome;
        private System.Windows.Forms.Timer sidebarTransition;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button pnReservas;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button pnPratos;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button pnExtras;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button pnMenus;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button pnMultas;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Button pnClientes;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Button pnFuncionarios;
    }
}

