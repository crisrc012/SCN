﻿namespace PL_SCN.Soporte
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
            this.mniModificar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.mniEliminar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.mniSalir = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgdDatos)).BeginInit();
            this.mnuSoporte.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgdDatos
            // 
            this.dgdDatos.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgdDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgdDatos.Location = new System.Drawing.Point(12, 27);
            this.dgdDatos.Name = "dgdDatos";
            this.dgdDatos.Size = new System.Drawing.Size(763, 397);
            this.dgdDatos.TabIndex = 1;
            // 
            // mnuSoporte
            // 
            this.mnuSoporte.AutoSize = false;
            this.mnuSoporte.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniAgregar,
            this.toolStripSeparator1,
            this.mniModificar,
            this.toolStripSeparator2,
            this.mniEliminar,
            this.toolStripSeparator3,
            this.toolStripTextBox1,
            this.toolStripButton4,
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
            this.mniAgregar.Size = new System.Drawing.Size(77, 22);
            this.mniAgregar.Text = "Agregar";
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
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(100, 25);
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
            // toolStripButton4
            // 
            this.toolStripButton4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(65, 22);
            this.toolStripButton4.Text = "Filtrar";
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
        private System.Windows.Forms.ToolStripButton mniModificar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton mniEliminar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton mniSalir;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
    }
}