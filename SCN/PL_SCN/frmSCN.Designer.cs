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
            this.suscripcionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mniEstadisticas = new System.Windows.Forms.ToolStripMenuItem();
            this.mniInventarios = new System.Windows.Forms.ToolStripMenuItem();
            this.mniOrdenesDeTrabajo = new System.Windows.Forms.ToolStripMenuItem();
            this.mniSeguridad = new System.Windows.Forms.ToolStripMenuItem();
            this.mniSoporte = new System.Windows.Forms.ToolStripMenuItem();
            this.mniSuscripciones = new System.Windows.Forms.ToolStripMenuItem();
            this.mniAcercaDe = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuModulos.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuModulos
            // 
            this.mnuModulos.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("mnuModulos.BackgroundImage")));
            this.mnuModulos.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuModulos.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniCatalogos,
            this.mniEstadisticas,
            this.mniInventarios,
            this.mniOrdenesDeTrabajo,
            this.mniSeguridad,
            this.mniSoporte,
            this.mniSuscripciones,
            this.mniAcercaDe,
            this.salirToolStripMenuItem});
            this.mnuModulos.Location = new System.Drawing.Point(0, 0);
            this.mnuModulos.Name = "mnuModulos";
            this.mnuModulos.Size = new System.Drawing.Size(1004, 25);
            this.mnuModulos.TabIndex = 1;
            this.mnuModulos.Text = "Módulos";
            // 
            // mniCatalogos
            // 
            this.mniCatalogos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuarioToolStripMenuItem,
            this.perfilToolStripMenuItem,
            this.departamentoToolStripMenuItem,
            this.suscripcionesToolStripMenuItem});
            this.mniCatalogos.Name = "mniCatalogos";
            this.mniCatalogos.Size = new System.Drawing.Size(194, 21);
            this.mniCatalogos.Text = "Catálogos y Mantenimientos";
            // 
            // usuarioToolStripMenuItem
            // 
            this.usuarioToolStripMenuItem.Name = "usuarioToolStripMenuItem";
            this.usuarioToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.usuarioToolStripMenuItem.Text = "Usuarios";
            this.usuarioToolStripMenuItem.Click += new System.EventHandler(this.usuarioToolStripMenuItem_Click);
            // 
            // perfilToolStripMenuItem
            // 
            this.perfilToolStripMenuItem.Name = "perfilToolStripMenuItem";
            this.perfilToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.perfilToolStripMenuItem.Text = "Perfiles";
            this.perfilToolStripMenuItem.Click += new System.EventHandler(this.perfilToolStripMenuItem_Click);
            // 
            // departamentoToolStripMenuItem
            // 
            this.departamentoToolStripMenuItem.Name = "departamentoToolStripMenuItem";
            this.departamentoToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.departamentoToolStripMenuItem.Text = "Departamentos";
            this.departamentoToolStripMenuItem.Click += new System.EventHandler(this.departamentoToolStripMenuItem_Click);
            // 
            // suscripcionesToolStripMenuItem
            // 
            this.suscripcionesToolStripMenuItem.Name = "suscripcionesToolStripMenuItem";
            this.suscripcionesToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.suscripcionesToolStripMenuItem.Text = "Suscripciones";
            this.suscripcionesToolStripMenuItem.Click += new System.EventHandler(this.suscripcionesToolStripMenuItem_Click);
            // 
            // mniEstadisticas
            // 
            this.mniEstadisticas.Name = "mniEstadisticas";
            this.mniEstadisticas.Size = new System.Drawing.Size(92, 21);
            this.mniEstadisticas.Text = "Estadísiticas";
            // 
            // mniInventarios
            // 
            this.mniInventarios.Name = "mniInventarios";
            this.mniInventarios.Size = new System.Drawing.Size(88, 21);
            this.mniInventarios.Text = "Inventarios";
            // 
            // mniOrdenesDeTrabajo
            // 
            this.mniOrdenesDeTrabajo.Name = "mniOrdenesDeTrabajo";
            this.mniOrdenesDeTrabajo.Size = new System.Drawing.Size(138, 21);
            this.mniOrdenesDeTrabajo.Text = "Ordenes de Trabajo";
            // 
            // mniSeguridad
            // 
            this.mniSeguridad.Name = "mniSeguridad";
            this.mniSeguridad.Size = new System.Drawing.Size(81, 21);
            this.mniSeguridad.Text = "Seguridad";
            // 
            // mniSoporte
            // 
            this.mniSoporte.Name = "mniSoporte";
            this.mniSoporte.Size = new System.Drawing.Size(68, 21);
            this.mniSoporte.Text = "Soporte";
            // 
            // mniSuscripciones
            // 
            this.mniSuscripciones.Name = "mniSuscripciones";
            this.mniSuscripciones.Size = new System.Drawing.Size(101, 21);
            this.mniSuscripciones.Text = "Suscripciones";
            // 
            // mniAcercaDe
            // 
            this.mniAcercaDe.Name = "mniAcercaDe";
            this.mniAcercaDe.Size = new System.Drawing.Size(79, 21);
            this.mniAcercaDe.Text = "Acerca de";
            this.mniAcercaDe.Click += new System.EventHandler(this.mniAcercaDe_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(45, 21);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // frmSCN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1004, 557);
            this.Controls.Add(this.mnuModulos);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Transparent;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mnuModulos;
            this.Name = "frmSCN";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SCN - Sistema de Control de Negocio";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmSCN_FormClosed);
            this.mnuModulos.ResumeLayout(false);
            this.mnuModulos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuModulos;
        private System.Windows.Forms.ToolStripMenuItem mniCatalogos;
        private System.Windows.Forms.ToolStripMenuItem mniEstadisticas;
        private System.Windows.Forms.ToolStripMenuItem mniInventarios;
        private System.Windows.Forms.ToolStripMenuItem mniOrdenesDeTrabajo;
        private System.Windows.Forms.ToolStripMenuItem mniSeguridad;
        private System.Windows.Forms.ToolStripMenuItem mniSoporte;
        private System.Windows.Forms.ToolStripMenuItem mniSuscripciones;
        private System.Windows.Forms.ToolStripMenuItem mniAcercaDe;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem perfilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem departamentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem suscripcionesToolStripMenuItem;
    }
}

