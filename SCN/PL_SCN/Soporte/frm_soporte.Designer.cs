namespace PL_SCN.Soporte
{
    partial class frm_soporte
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_soporte));
            this.dgdDatos = new System.Windows.Forms.DataGridView();
            this.mnuSoporte = new System.Windows.Forms.ToolStrip();
            this.mniAgregar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.txt_Filtrar = new System.Windows.Forms.ToolStripTextBox();
            this.lbl_Filtrar = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.mniSalir = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgdDatos)).BeginInit();
            this.mnuSoporte.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgdDatos
            // 
            this.dgdDatos.AllowUserToAddRows = false;
            this.dgdDatos.AllowUserToDeleteRows = false;
            this.dgdDatos.AllowUserToResizeColumns = false;
            this.dgdDatos.AllowUserToResizeRows = false;
            this.dgdDatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgdDatos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgdDatos.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgdDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgdDatos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgdDatos.Location = new System.Drawing.Point(12, 27);
            this.dgdDatos.MultiSelect = false;
            this.dgdDatos.Name = "dgdDatos";
            this.dgdDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgdDatos.Size = new System.Drawing.Size(763, 397);
            this.dgdDatos.TabIndex = 1;
            // 
            // mnuSoporte
            // 
            this.mnuSoporte.AutoSize = false;
            this.mnuSoporte.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniAgregar,
            this.toolStripSeparator1,
            this.txt_Filtrar,
            this.lbl_Filtrar,
            this.toolStripSeparator4,
            this.mniSalir});
            this.mnuSoporte.Location = new System.Drawing.Point(0, 0);
            this.mnuSoporte.Name = "mnuSoporte";
            this.mnuSoporte.Size = new System.Drawing.Size(787, 25);
            this.mnuSoporte.TabIndex = 2;
            this.mnuSoporte.Text = "Mantenimiento";
            // 
            // mniAgregar
            // 
            this.mniAgregar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mniAgregar.Image = ((System.Drawing.Image)(resources.GetObject("mniAgregar.Image")));
            this.mniAgregar.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.mniAgregar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mniAgregar.Name = "mniAgregar";
            this.mniAgregar.Size = new System.Drawing.Size(109, 22);
            this.mniAgregar.Text = "Nueva Orden";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // txt_Filtrar
            // 
            this.txt_Filtrar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Filtrar.MaxLength = 10;
            this.txt_Filtrar.Name = "txt_Filtrar";
            this.txt_Filtrar.Size = new System.Drawing.Size(100, 25);
            // 
            // lbl_Filtrar
            // 
            this.lbl_Filtrar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbl_Filtrar.Name = "lbl_Filtrar";
            this.lbl_Filtrar.Size = new System.Drawing.Size(45, 22);
            this.lbl_Filtrar.Text = "Filtrar";
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
            // 
            // frm_soporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Turquoise;
            this.ClientSize = new System.Drawing.Size(787, 437);
            this.Controls.Add(this.mnuSoporte);
            this.Controls.Add(this.dgdDatos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(803, 476);
            this.MinimumSize = new System.Drawing.Size(803, 476);
            this.Name = "frm_soporte";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Información de Soporte";
            ((System.ComponentModel.ISupportInitialize)(this.dgdDatos)).EndInit();
            this.mnuSoporte.ResumeLayout(false);
            this.mnuSoporte.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgdDatos;
        private System.Windows.Forms.ToolStrip mnuSoporte;
        private System.Windows.Forms.ToolStripButton mniAgregar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripTextBox txt_Filtrar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton mniSalir;
        private System.Windows.Forms.ToolStripLabel lbl_Filtrar;
    }
}