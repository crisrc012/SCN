namespace PL_SCN.Soporte
{
    partial class frm_ordenTrabajo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_ordenTrabajo));
            this.txt_NumeroOrden = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_NumeroCliente = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_NombreCliente = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_fechaActual = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_ContactoCliente = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_DireccionCliente = new System.Windows.Forms.RichTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_ProblemaReportado = new System.Windows.Forms.RichTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cbx_CodigoTecnico = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_NombreTecnico = new System.Windows.Forms.TextBox();
            this.cbx_Prioridad = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tls_Menu_OrdenTrabajo = new System.Windows.Forms.ToolStrip();
            this.btn_GenerarReporte = new System.Windows.Forms.ToolStripButton();
            this.lbl_GenerarReporte = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_NuevoReporte = new System.Windows.Forms.ToolStripButton();
            this.lbl_NuevoReporte = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_Salir = new System.Windows.Forms.ToolStripButton();
            this.lbl_Salir = new System.Windows.Forms.ToolStripLabel();
            this.tls_Menu_OrdenTrabajo.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_NumeroOrden
            // 
            this.txt_NumeroOrden.Enabled = false;
            this.txt_NumeroOrden.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.txt_NumeroOrden.Location = new System.Drawing.Point(657, 44);
            this.txt_NumeroOrden.Name = "txt_NumeroOrden";
            this.txt_NumeroOrden.Size = new System.Drawing.Size(100, 25);
            this.txt_NumeroOrden.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(532, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Número de Orden:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(12, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Número de Cliente:";
            // 
            // txt_NumeroCliente
            // 
            this.txt_NumeroCliente.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.txt_NumeroCliente.Location = new System.Drawing.Point(137, 44);
            this.txt_NumeroCliente.Name = "txt_NumeroCliente";
            this.txt_NumeroCliente.Size = new System.Drawing.Size(130, 25);
            this.txt_NumeroCliente.TabIndex = 2;
            this.txt_NumeroCliente.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_NumeroCliente_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(12, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nombre Cliente:";
            // 
            // txt_NombreCliente
            // 
            this.txt_NombreCliente.Enabled = false;
            this.txt_NombreCliente.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.txt_NombreCliente.Location = new System.Drawing.Point(137, 98);
            this.txt_NombreCliente.Name = "txt_NombreCliente";
            this.txt_NombreCliente.Size = new System.Drawing.Size(177, 25);
            this.txt_NombreCliente.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(312, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Fecha:";
            // 
            // lbl_fechaActual
            // 
            this.lbl_fechaActual.AutoSize = true;
            this.lbl_fechaActual.BackColor = System.Drawing.Color.Transparent;
            this.lbl_fechaActual.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbl_fechaActual.Location = new System.Drawing.Point(364, 44);
            this.lbl_fechaActual.Name = "lbl_fechaActual";
            this.lbl_fechaActual.Size = new System.Drawing.Size(82, 17);
            this.lbl_fechaActual.TabIndex = 8;
            this.lbl_fechaActual.Text = "XXXX/XX/XX";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(12, 163);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Contacto Cliente:";
            // 
            // txt_ContactoCliente
            // 
            this.txt_ContactoCliente.Enabled = false;
            this.txt_ContactoCliente.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.txt_ContactoCliente.Location = new System.Drawing.Point(137, 163);
            this.txt_ContactoCliente.Name = "txt_ContactoCliente";
            this.txt_ContactoCliente.Size = new System.Drawing.Size(177, 25);
            this.txt_ContactoCliente.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(358, 98);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 17);
            this.label7.TabIndex = 11;
            this.label7.Text = "Dirección:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(-3, 68);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(798, 17);
            this.label8.TabIndex = 12;
            this.label8.Text = "_________________________________________________________________________________" +
    "_____________________________________________________________________________";
            // 
            // txt_DireccionCliente
            // 
            this.txt_DireccionCliente.Enabled = false;
            this.txt_DireccionCliente.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.txt_DireccionCliente.Location = new System.Drawing.Point(427, 114);
            this.txt_DireccionCliente.MaxLength = 500;
            this.txt_DireccionCliente.Name = "txt_DireccionCliente";
            this.txt_DireccionCliente.Size = new System.Drawing.Size(306, 141);
            this.txt_DireccionCliente.TabIndex = 13;
            this.txt_DireccionCliente.Text = "";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(-6, 261);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(798, 17);
            this.label9.TabIndex = 14;
            this.label9.Text = "_________________________________________________________________________________" +
    "_____________________________________________________________________________";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(12, 295);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(137, 17);
            this.label10.TabIndex = 15;
            this.label10.Text = "Problema Reportado:";
            // 
            // txt_ProblemaReportado
            // 
            this.txt_ProblemaReportado.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.txt_ProblemaReportado.Location = new System.Drawing.Point(155, 295);
            this.txt_ProblemaReportado.MaxLength = 200;
            this.txt_ProblemaReportado.Name = "txt_ProblemaReportado";
            this.txt_ProblemaReportado.Size = new System.Drawing.Size(221, 111);
            this.txt_ProblemaReportado.TabIndex = 16;
            this.txt_ProblemaReportado.Text = "";
            this.txt_ProblemaReportado.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_ProblemaReportado_KeyDown);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.label11.Location = new System.Drawing.Point(382, 297);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(102, 17);
            this.label11.TabIndex = 17;
            this.label11.Text = "Código Técnico:";
            // 
            // cbx_CodigoTecnico
            // 
            this.cbx_CodigoTecnico.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.cbx_CodigoTecnico.FormattingEnabled = true;
            this.cbx_CodigoTecnico.Location = new System.Drawing.Point(490, 295);
            this.cbx_CodigoTecnico.Name = "cbx_CodigoTecnico";
            this.cbx_CodigoTecnico.Size = new System.Drawing.Size(121, 25);
            this.cbx_CodigoTecnico.TabIndex = 18;
            this.cbx_CodigoTecnico.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbx_CodigoTecnico_KeyDown);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.label12.Location = new System.Drawing.Point(384, 340);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(61, 17);
            this.label12.TabIndex = 20;
            this.label12.Text = "Nombre:";
            // 
            // txt_NombreTecnico
            // 
            this.txt_NombreTecnico.Enabled = false;
            this.txt_NombreTecnico.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.txt_NombreTecnico.Location = new System.Drawing.Point(490, 337);
            this.txt_NombreTecnico.Name = "txt_NombreTecnico";
            this.txt_NombreTecnico.Size = new System.Drawing.Size(177, 25);
            this.txt_NombreTecnico.TabIndex = 19;
            // 
            // cbx_Prioridad
            // 
            this.cbx_Prioridad.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.cbx_Prioridad.FormattingEnabled = true;
            this.cbx_Prioridad.Items.AddRange(new object[] {
            "Alta",
            "Media",
            "Baja"});
            this.cbx_Prioridad.Location = new System.Drawing.Point(490, 381);
            this.cbx_Prioridad.Name = "cbx_Prioridad";
            this.cbx_Prioridad.Size = new System.Drawing.Size(121, 25);
            this.cbx_Prioridad.TabIndex = 22;
            this.cbx_Prioridad.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbx_Prioridad_KeyDown);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.label13.Location = new System.Drawing.Point(382, 383);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(66, 17);
            this.label13.TabIndex = 21;
            this.label13.Text = "Prioridad:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(-10, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(798, 17);
            this.label5.TabIndex = 24;
            this.label5.Text = "_________________________________________________________________________________" +
    "_____________________________________________________________________________";
            // 
            // tls_Menu_OrdenTrabajo
            // 
            this.tls_Menu_OrdenTrabajo.BackColor = System.Drawing.Color.Transparent;
            this.tls_Menu_OrdenTrabajo.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.tls_Menu_OrdenTrabajo.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_GenerarReporte,
            this.lbl_GenerarReporte,
            this.toolStripSeparator1,
            this.btn_NuevoReporte,
            this.lbl_NuevoReporte,
            this.toolStripSeparator2,
            this.btn_Salir,
            this.lbl_Salir});
            this.tls_Menu_OrdenTrabajo.Location = new System.Drawing.Point(0, 0);
            this.tls_Menu_OrdenTrabajo.Name = "tls_Menu_OrdenTrabajo";
            this.tls_Menu_OrdenTrabajo.Size = new System.Drawing.Size(787, 25);
            this.tls_Menu_OrdenTrabajo.TabIndex = 25;
            this.tls_Menu_OrdenTrabajo.Text = "toolStrip1";
            // 
            // btn_GenerarReporte
            // 
            this.btn_GenerarReporte.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_GenerarReporte.Image = ((System.Drawing.Image)(resources.GetObject("btn_GenerarReporte.Image")));
            this.btn_GenerarReporte.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_GenerarReporte.Name = "btn_GenerarReporte";
            this.btn_GenerarReporte.Size = new System.Drawing.Size(23, 22);
            this.btn_GenerarReporte.Text = "btn_GenerarReporte";
            this.btn_GenerarReporte.ToolTipText = "Generar Reporte";
            // 
            // lbl_GenerarReporte
            // 
            this.lbl_GenerarReporte.Name = "lbl_GenerarReporte";
            this.lbl_GenerarReporte.Size = new System.Drawing.Size(150, 22);
            this.lbl_GenerarReporte.Text = "GENERAR REPORTE - F1";
            this.lbl_GenerarReporte.ToolTipText = "Generar Reporte";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // btn_NuevoReporte
            // 
            this.btn_NuevoReporte.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_NuevoReporte.Image = ((System.Drawing.Image)(resources.GetObject("btn_NuevoReporte.Image")));
            this.btn_NuevoReporte.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_NuevoReporte.Name = "btn_NuevoReporte";
            this.btn_NuevoReporte.Size = new System.Drawing.Size(23, 22);
            this.btn_NuevoReporte.Text = "btn_NuevoReporte";
            this.btn_NuevoReporte.ToolTipText = "Nuevo Reporte";
            // 
            // lbl_NuevoReporte
            // 
            this.lbl_NuevoReporte.Name = "lbl_NuevoReporte";
            this.lbl_NuevoReporte.Size = new System.Drawing.Size(127, 22);
            this.lbl_NuevoReporte.Text = "Nuevo Reporte - F8";
            this.lbl_NuevoReporte.ToolTipText = "Nuevo Reporte";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // btn_Salir
            // 
            this.btn_Salir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_Salir.Image = ((System.Drawing.Image)(resources.GetObject("btn_Salir.Image")));
            this.btn_Salir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(23, 22);
            this.btn_Salir.Text = "btn_Salir";
            this.btn_Salir.ToolTipText = "Salir";
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click);
            // 
            // lbl_Salir
            // 
            this.lbl_Salir.Name = "lbl_Salir";
            this.lbl_Salir.Size = new System.Drawing.Size(68, 22);
            this.lbl_Salir.Text = "Salir - ESC";
            this.lbl_Salir.ToolTipText = "Salir";
            // 
            // frm_ordenTrabajo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(787, 437);
            this.Controls.Add(this.tls_Menu_OrdenTrabajo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbx_Prioridad);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txt_NombreTecnico);
            this.Controls.Add(this.cbx_CodigoTecnico);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txt_ProblemaReportado);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txt_DireccionCliente);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_ContactoCliente);
            this.Controls.Add(this.lbl_fechaActual);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_NombreCliente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_NumeroCliente);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_NumeroOrden);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(803, 476);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(803, 476);
            this.Name = "frm_ordenTrabajo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ORDENES DE TRABAJO";
            this.Load += new System.EventHandler(this.frm_ordenTrabajo_Load);
            this.tls_Menu_OrdenTrabajo.ResumeLayout(false);
            this.tls_Menu_OrdenTrabajo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_NumeroOrden;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_NumeroCliente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_NombreCliente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_fechaActual;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_ContactoCliente;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RichTextBox txt_DireccionCliente;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RichTextBox txt_ProblemaReportado;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cbx_CodigoTecnico;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt_NombreTecnico;
        private System.Windows.Forms.ComboBox cbx_Prioridad;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ToolStrip tls_Menu_OrdenTrabajo;
        private System.Windows.Forms.ToolStripButton btn_GenerarReporte;
        private System.Windows.Forms.ToolStripLabel lbl_GenerarReporte;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btn_NuevoReporte;
        private System.Windows.Forms.ToolStripLabel lbl_NuevoReporte;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btn_Salir;
        private System.Windows.Forms.ToolStripLabel lbl_Salir;
    }
}