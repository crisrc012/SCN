namespace PL_SCN
{
    partial class frmSCN
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSCN));
            this.mnuModulos = new System.Windows.Forms.MenuStrip();
            this.mniCatalogos = new System.Windows.Forms.ToolStripMenuItem();
            this.usuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.perfilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.departamentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contraseñasToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mniSeguridad = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cambiosDeCedulaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.parametrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mniSuscripciones = new System.Windows.Forms.ToolStripMenuItem();
            this.contratosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cobroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pagoComisionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mniInventarios = new System.Windows.Forms.ToolStripMenuItem();
            this.productosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mniSoporte = new System.Windows.Forms.ToolStripMenuItem();
            this.ordenDeTrabajoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mniAcercaDe = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuModulos.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuModulos
            // 
            this.mnuModulos.BackColor = System.Drawing.Color.DarkCyan;
            this.mnuModulos.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.mnuModulos.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniCatalogos,
            this.mniSeguridad,
            this.mniSuscripciones,
            this.mniInventarios,
            this.mniSoporte,
            this.mniAcercaDe,
            this.salirToolStripMenuItem});
            this.mnuModulos.Location = new System.Drawing.Point(0, 0);
            this.mnuModulos.Name = "mnuModulos";
            this.mnuModulos.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.mnuModulos.Size = new System.Drawing.Size(1008, 44);
            this.mnuModulos.TabIndex = 1;
            this.mnuModulos.Text = "Módulos";
            // 
            // mniCatalogos
            // 
            this.mniCatalogos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuarioToolStripMenuItem,
            this.perfilToolStripMenuItem,
            this.departamentoToolStripMenuItem,
            this.contraseñasToolStripMenuItem1});
            this.mniCatalogos.ForeColor = System.Drawing.Color.White;
            this.mniCatalogos.Name = "mniCatalogos";
            this.mniCatalogos.Size = new System.Drawing.Size(81, 40);
            this.mniCatalogos.Text = "Seguridad";
            // 
            // usuarioToolStripMenuItem
            // 
            this.usuarioToolStripMenuItem.Name = "usuarioToolStripMenuItem";
            this.usuarioToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.usuarioToolStripMenuItem.Text = "Usuarios";
            this.usuarioToolStripMenuItem.Click += new System.EventHandler(this.usuarioToolStripMenuItem_Click);
            // 
            // perfilToolStripMenuItem
            // 
            this.perfilToolStripMenuItem.Name = "perfilToolStripMenuItem";
            this.perfilToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.perfilToolStripMenuItem.Text = "Tipos de Usuario";
            this.perfilToolStripMenuItem.Click += new System.EventHandler(this.perfilToolStripMenuItem_Click);
            // 
            // departamentoToolStripMenuItem
            // 
            this.departamentoToolStripMenuItem.Name = "departamentoToolStripMenuItem";
            this.departamentoToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.departamentoToolStripMenuItem.Text = "Departamentos";
            this.departamentoToolStripMenuItem.Click += new System.EventHandler(this.departamentoToolStripMenuItem_Click);
            // 
            // contraseñasToolStripMenuItem1
            // 
            this.contraseñasToolStripMenuItem1.Name = "contraseñasToolStripMenuItem1";
            this.contraseñasToolStripMenuItem1.Size = new System.Drawing.Size(177, 22);
            this.contraseñasToolStripMenuItem1.Text = "Contraseñas";
            // 
            // mniSeguridad
            // 
            this.mniSeguridad.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientesToolStripMenuItem,
            this.cambiosDeCedulaToolStripMenuItem,
            this.parametrosToolStripMenuItem});
            this.mniSeguridad.ForeColor = System.Drawing.Color.White;
            this.mniSeguridad.Name = "mniSeguridad";
            this.mniSeguridad.Size = new System.Drawing.Size(113, 40);
            this.mniSeguridad.Text = "Mantenimiento";
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.clientesToolStripMenuItem.Text = "Clientes";
            // 
            // cambiosDeCedulaToolStripMenuItem
            // 
            this.cambiosDeCedulaToolStripMenuItem.Name = "cambiosDeCedulaToolStripMenuItem";
            this.cambiosDeCedulaToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.cambiosDeCedulaToolStripMenuItem.Text = "Cambios de Cedula";
            // 
            // parametrosToolStripMenuItem
            // 
            this.parametrosToolStripMenuItem.Name = "parametrosToolStripMenuItem";
            this.parametrosToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.parametrosToolStripMenuItem.Text = "Parametros";
            // 
            // mniSuscripciones
            // 
            this.mniSuscripciones.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contratosToolStripMenuItem,
            this.cobroToolStripMenuItem,
            this.pagoComisionesToolStripMenuItem});
            this.mniSuscripciones.ForeColor = System.Drawing.Color.White;
            this.mniSuscripciones.Name = "mniSuscripciones";
            this.mniSuscripciones.Size = new System.Drawing.Size(101, 40);
            this.mniSuscripciones.Text = "Suscripciones";
            // 
            // contratosToolStripMenuItem
            // 
            this.contratosToolStripMenuItem.Name = "contratosToolStripMenuItem";
            this.contratosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.contratosToolStripMenuItem.Text = "Contratos";
            // 
            // cobroToolStripMenuItem
            // 
            this.cobroToolStripMenuItem.Name = "cobroToolStripMenuItem";
            this.cobroToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cobroToolStripMenuItem.Text = "Cobro";
            // 
            // pagoComisionesToolStripMenuItem
            // 
            this.pagoComisionesToolStripMenuItem.Name = "pagoComisionesToolStripMenuItem";
            this.pagoComisionesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.pagoComisionesToolStripMenuItem.Text = "Pago Comisiones";
            // 
            // mniInventarios
            // 
            this.mniInventarios.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.productosToolStripMenuItem,
            this.stockToolStripMenuItem});
            this.mniInventarios.ForeColor = System.Drawing.Color.White;
            this.mniInventarios.Name = "mniInventarios";
            this.mniInventarios.Size = new System.Drawing.Size(88, 40);
            this.mniInventarios.Text = "Inventarios";
            // 
            // productosToolStripMenuItem
            // 
            this.productosToolStripMenuItem.Name = "productosToolStripMenuItem";
            this.productosToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.productosToolStripMenuItem.Text = "Productos";
            // 
            // stockToolStripMenuItem
            // 
            this.stockToolStripMenuItem.Name = "stockToolStripMenuItem";
            this.stockToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.stockToolStripMenuItem.Text = "Stock";
            // 
            // mniSoporte
            // 
            this.mniSoporte.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ordenDeTrabajoToolStripMenuItem});
            this.mniSoporte.ForeColor = System.Drawing.Color.White;
            this.mniSoporte.Name = "mniSoporte";
            this.mniSoporte.Size = new System.Drawing.Size(68, 40);
            this.mniSoporte.Text = "Soporte";
            // 
            // ordenDeTrabajoToolStripMenuItem
            // 
            this.ordenDeTrabajoToolStripMenuItem.Name = "ordenDeTrabajoToolStripMenuItem";
            this.ordenDeTrabajoToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.ordenDeTrabajoToolStripMenuItem.Text = "Orden de Trabajo";
            this.ordenDeTrabajoToolStripMenuItem.Click += new System.EventHandler(this.ordenDeTrabajoToolStripMenuItem_Click);
            // 
            // mniAcercaDe
            // 
            this.mniAcercaDe.ForeColor = System.Drawing.Color.White;
            this.mniAcercaDe.Name = "mniAcercaDe";
            this.mniAcercaDe.Size = new System.Drawing.Size(79, 40);
            this.mniAcercaDe.Text = "Acerca de";
            this.mniAcercaDe.Click += new System.EventHandler(this.mniAcercaDe_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.AutoSize = false;
            this.salirToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(45, 40);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // frmSCN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1008, 561);
            this.Controls.Add(this.mnuModulos);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mnuModulos;
            this.MinimumSize = new System.Drawing.Size(1024, 600);
            this.Name = "frmSCN";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SCN - Sistema de Control de Negocio";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmSCN_FormClosed);
            this.Load += new System.EventHandler(this.frmSCN_Load);
            this.mnuModulos.ResumeLayout(false);
            this.mnuModulos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuModulos;
        private System.Windows.Forms.ToolStripMenuItem mniCatalogos;
        private System.Windows.Forms.ToolStripMenuItem mniInventarios;
        private System.Windows.Forms.ToolStripMenuItem mniSeguridad;
        private System.Windows.Forms.ToolStripMenuItem mniSoporte;
        private System.Windows.Forms.ToolStripMenuItem mniSuscripciones;
        private System.Windows.Forms.ToolStripMenuItem mniAcercaDe;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem perfilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem departamentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contraseñasToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cambiosDeCedulaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem parametrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contratosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cobroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pagoComisionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stockToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ordenDeTrabajoToolStripMenuItem;
    }
}

