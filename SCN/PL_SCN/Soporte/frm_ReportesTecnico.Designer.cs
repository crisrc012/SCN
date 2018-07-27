namespace PL_SCN.Soporte
{
    partial class frm_ReportesTecnico
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_ReportesTecnico));
            this.mnuVisualizarReportes = new System.Windows.Forms.ToolStrip();
            this.txt_Filtrar = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.dgdDatos = new System.Windows.Forms.DataGridView();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.mniSalir = new System.Windows.Forms.ToolStripButton();
            this.mnuVisualizarReportes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgdDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // mnuVisualizarReportes
            // 
            this.mnuVisualizarReportes.AutoSize = false;
            this.mnuVisualizarReportes.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.txt_Filtrar,
            this.toolStripButton4,
            this.toolStripSeparator4,
            this.mniSalir});
            this.mnuVisualizarReportes.Location = new System.Drawing.Point(0, 0);
            this.mnuVisualizarReportes.Name = "mnuVisualizarReportes";
            this.mnuVisualizarReportes.Size = new System.Drawing.Size(787, 25);
            this.mnuVisualizarReportes.TabIndex = 4;
            this.mnuVisualizarReportes.Text = "Mantenimiento";
            // 
            // txt_Filtrar
            // 
            this.txt_Filtrar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Filtrar.Name = "txt_Filtrar";
            this.txt_Filtrar.Size = new System.Drawing.Size(100, 25);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // dgdDatos
            // 
            this.dgdDatos.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgdDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgdDatos.Location = new System.Drawing.Point(12, 33);
            this.dgdDatos.Name = "dgdDatos";
            this.dgdDatos.Size = new System.Drawing.Size(763, 397);
            this.dgdDatos.TabIndex = 3;
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
            // mniSalir
            // 
            this.mniSalir.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mniSalir.Image = ((System.Drawing.Image)(resources.GetObject("mniSalir.Image")));
            this.mniSalir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mniSalir.Name = "mniSalir";
            this.mniSalir.Size = new System.Drawing.Size(55, 22);
            this.mniSalir.Text = "Salir";
            // 
            // frm_ReportesTecnico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Turquoise;
            this.ClientSize = new System.Drawing.Size(787, 437);
            this.Controls.Add(this.mnuVisualizarReportes);
            this.Controls.Add(this.dgdDatos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frm_ReportesTecnico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Visualizador de Reportes";
            this.mnuVisualizarReportes.ResumeLayout(false);
            this.mnuVisualizarReportes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgdDatos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStrip mnuVisualizarReportes;
        private System.Windows.Forms.ToolStripTextBox txt_Filtrar;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton mniSalir;
        private System.Windows.Forms.DataGridView dgdDatos;
    }
}