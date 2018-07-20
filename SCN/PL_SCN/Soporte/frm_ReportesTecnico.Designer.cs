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
            this.mnuSoporte = new System.Windows.Forms.ToolStrip();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.mniSalir = new System.Windows.Forms.ToolStripButton();
            this.dgdDatos = new System.Windows.Forms.DataGridView();
            this.mnuSoporte.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgdDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // mnuSoporte
            // 
            this.mnuSoporte.AutoSize = false;
            this.mnuSoporte.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBox1,
            this.toolStripButton4,
            this.toolStripSeparator4,
            this.mniSalir});
            this.mnuSoporte.Location = new System.Drawing.Point(0, 0);
            this.mnuSoporte.Name = "mnuSoporte";
            this.mnuSoporte.Size = new System.Drawing.Size(787, 25);
            this.mnuSoporte.TabIndex = 4;
            this.mnuSoporte.Text = "Mantenimiento";
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(100, 25);
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
            // frm_ReportesTecnico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Turquoise;
            this.ClientSize = new System.Drawing.Size(787, 437);
            this.Controls.Add(this.mnuSoporte);
            this.Controls.Add(this.dgdDatos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frm_ReportesTecnico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Visualizador de Reportes";
            this.mnuSoporte.ResumeLayout(false);
            this.mnuSoporte.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgdDatos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStrip mnuSoporte;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton mniSalir;
        private System.Windows.Forms.DataGridView dgdDatos;
    }
}