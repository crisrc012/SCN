namespace PL_SCN.CatyMan
{
    partial class frmCatalogo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCatalogo));
            this.dgdDatos = new System.Windows.Forms.DataGridView();
            this.mnuMantenimiento = new System.Windows.Forms.ToolStrip();
            this.mniAgregar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mniModificar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.mniEliminar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tstxtFiltrar = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.mniSalir = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgdDatos)).BeginInit();
            this.mnuMantenimiento.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgdDatos
            // 
            this.dgdDatos.AllowUserToAddRows = false;
            this.dgdDatos.AllowUserToDeleteRows = false;
            this.dgdDatos.AllowUserToOrderColumns = true;
            this.dgdDatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgdDatos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgdDatos.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgdDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgdDatos.Location = new System.Drawing.Point(12, 28);
            this.dgdDatos.MultiSelect = false;
            this.dgdDatos.Name = "dgdDatos";
            this.dgdDatos.ReadOnly = true;
            this.dgdDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgdDatos.Size = new System.Drawing.Size(763, 397);
            this.dgdDatos.TabIndex = 0;
            // 
            // mnuMantenimiento
            // 
            this.mnuMantenimiento.AutoSize = false;
            this.mnuMantenimiento.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniAgregar,
            this.toolStripSeparator1,
            this.mniModificar,
            this.toolStripSeparator2,
            this.mniEliminar,
            this.toolStripSeparator3,
            this.tstxtFiltrar,
            this.toolStripButton4,
            this.toolStripSeparator4,
            this.mniSalir});
            this.mnuMantenimiento.Location = new System.Drawing.Point(0, 0);
            this.mnuMantenimiento.Name = "mnuMantenimiento";
            this.mnuMantenimiento.Size = new System.Drawing.Size(787, 25);
            this.mnuMantenimiento.TabIndex = 1;
            this.mnuMantenimiento.Text = "Mantenimiento";
            // 
            // mniAgregar
            // 
            this.mniAgregar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mniAgregar.Image = ((System.Drawing.Image)(resources.GetObject("mniAgregar.Image")));
            this.mniAgregar.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.mniAgregar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mniAgregar.Name = "mniAgregar";
            this.mniAgregar.Size = new System.Drawing.Size(77, 22);
            this.mniAgregar.Text = "Agregar";
            this.mniAgregar.Click += new System.EventHandler(this.mniAgregar_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // mniModificar
            // 
            this.mniModificar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mniModificar.Image = ((System.Drawing.Image)(resources.GetObject("mniModificar.Image")));
            this.mniModificar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mniModificar.Name = "mniModificar";
            this.mniModificar.Size = new System.Drawing.Size(87, 22);
            this.mniModificar.Text = "Modificar";
            this.mniModificar.Click += new System.EventHandler(this.mniModificar_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // mniEliminar
            // 
            this.mniEliminar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mniEliminar.Image = ((System.Drawing.Image)(resources.GetObject("mniEliminar.Image")));
            this.mniEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mniEliminar.Name = "mniEliminar";
            this.mniEliminar.Size = new System.Drawing.Size(79, 22);
            this.mniEliminar.Text = "Eliminar";
            this.mniEliminar.Click += new System.EventHandler(this.mniEliminar_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // tstxtFiltrar
            // 
            this.tstxtFiltrar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tstxtFiltrar.Name = "tstxtFiltrar";
            this.tstxtFiltrar.Size = new System.Drawing.Size(100, 25);
            this.tstxtFiltrar.Click += new System.EventHandler(this.tstxtFiltrar_Click);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(65, 22);
            this.toolStripButton4.Text = "Filtrar";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // mniSalir
            // 
            this.mniSalir.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mniSalir.Image = ((System.Drawing.Image)(resources.GetObject("mniSalir.Image")));
            this.mniSalir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mniSalir.Name = "mniSalir";
            this.mniSalir.Size = new System.Drawing.Size(55, 22);
            this.mniSalir.Text = "Salir";
            this.mniSalir.Click += new System.EventHandler(this.mniSalir_Click);
            // 
            // frmCatalogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Turquoise;
            this.ClientSize = new System.Drawing.Size(787, 437);
            this.Controls.Add(this.mnuMantenimiento);
            this.Controls.Add(this.dgdDatos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCatalogo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frm_catalogo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgdDatos)).EndInit();
            this.mnuMantenimiento.ResumeLayout(false);
            this.mnuMantenimiento.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgdDatos;
        private System.Windows.Forms.ToolStrip mnuMantenimiento;
        private System.Windows.Forms.ToolStripButton mniAgregar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton mniModificar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton mniEliminar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripTextBox tstxtFiltrar;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton mniSalir;
    }
}