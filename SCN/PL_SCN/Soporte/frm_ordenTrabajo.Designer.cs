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
            this.lbl_NOrden = new System.Windows.Forms.Label();
            this.lbl_NCliente = new System.Windows.Forms.Label();
            this.txt_NumeroCliente = new System.Windows.Forms.TextBox();
            this.lbl_NomCliente = new System.Windows.Forms.Label();
            this.txt_NombreCliente = new System.Windows.Forms.TextBox();
            this.lbl_Fecha = new System.Windows.Forms.Label();
            this.lbl_fechaActual = new System.Windows.Forms.Label();
            this.lbl_CCliente = new System.Windows.Forms.Label();
            this.txt_ContactoCliente = new System.Windows.Forms.TextBox();
            this.lbl_Dir = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_DireccionCliente = new System.Windows.Forms.RichTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.Lbl_PReportado = new System.Windows.Forms.Label();
            this.txt_ProblemaReportado = new System.Windows.Forms.RichTextBox();
            this.lbl_CTecnico = new System.Windows.Forms.Label();
            this.cbx_CodigoTecnico = new System.Windows.Forms.ComboBox();
            this.lbl_NombreTec = new System.Windows.Forms.Label();
            this.txt_NombreTecnico = new System.Windows.Forms.TextBox();
            this.cbx_Prioridad = new System.Windows.Forms.ComboBox();
            this.lbl_Prioridad = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tls_Menu_OrdenTrabajo = new System.Windows.Forms.ToolStrip();
            this.btn_GenerarReporte = new System.Windows.Forms.ToolStripButton();
            this.lbl_GenerarReporte = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
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
            // lbl_NOrden
            // 
            this.lbl_NOrden.AutoSize = true;
            this.lbl_NOrden.BackColor = System.Drawing.Color.Transparent;
            this.lbl_NOrden.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbl_NOrden.Location = new System.Drawing.Point(532, 47);
            this.lbl_NOrden.Name = "lbl_NOrden";
            this.lbl_NOrden.Size = new System.Drawing.Size(122, 17);
            this.lbl_NOrden.TabIndex = 1;
            this.lbl_NOrden.Text = "Número de Orden:";
            // 
            // lbl_NCliente
            // 
            this.lbl_NCliente.AutoSize = true;
            this.lbl_NCliente.BackColor = System.Drawing.Color.Transparent;
            this.lbl_NCliente.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbl_NCliente.Location = new System.Drawing.Point(12, 47);
            this.lbl_NCliente.Name = "lbl_NCliente";
            this.lbl_NCliente.Size = new System.Drawing.Size(125, 17);
            this.lbl_NCliente.TabIndex = 3;
            this.lbl_NCliente.Text = "Número de Cliente:";
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
            // lbl_NomCliente
            // 
            this.lbl_NomCliente.AutoSize = true;
            this.lbl_NomCliente.BackColor = System.Drawing.Color.Transparent;
            this.lbl_NomCliente.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbl_NomCliente.Location = new System.Drawing.Point(12, 98);
            this.lbl_NomCliente.Name = "lbl_NomCliente";
            this.lbl_NomCliente.Size = new System.Drawing.Size(106, 17);
            this.lbl_NomCliente.TabIndex = 5;
            this.lbl_NomCliente.Text = "Nombre Cliente:";
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
            // lbl_Fecha
            // 
            this.lbl_Fecha.AutoSize = true;
            this.lbl_Fecha.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Fecha.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbl_Fecha.Location = new System.Drawing.Point(312, 44);
            this.lbl_Fecha.Name = "lbl_Fecha";
            this.lbl_Fecha.Size = new System.Drawing.Size(46, 17);
            this.lbl_Fecha.TabIndex = 7;
            this.lbl_Fecha.Text = "Fecha:";
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
            // lbl_CCliente
            // 
            this.lbl_CCliente.AutoSize = true;
            this.lbl_CCliente.BackColor = System.Drawing.Color.Transparent;
            this.lbl_CCliente.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbl_CCliente.Location = new System.Drawing.Point(12, 163);
            this.lbl_CCliente.Name = "lbl_CCliente";
            this.lbl_CCliente.Size = new System.Drawing.Size(111, 17);
            this.lbl_CCliente.TabIndex = 10;
            this.lbl_CCliente.Text = "Contacto Cliente:";
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
            // lbl_Dir
            // 
            this.lbl_Dir.AutoSize = true;
            this.lbl_Dir.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Dir.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbl_Dir.Location = new System.Drawing.Point(358, 98);
            this.lbl_Dir.Name = "lbl_Dir";
            this.lbl_Dir.Size = new System.Drawing.Size(66, 17);
            this.lbl_Dir.TabIndex = 11;
            this.lbl_Dir.Text = "Dirección:";
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
            // Lbl_PReportado
            // 
            this.Lbl_PReportado.AutoSize = true;
            this.Lbl_PReportado.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_PReportado.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.Lbl_PReportado.Location = new System.Drawing.Point(12, 295);
            this.Lbl_PReportado.Name = "Lbl_PReportado";
            this.Lbl_PReportado.Size = new System.Drawing.Size(137, 17);
            this.Lbl_PReportado.TabIndex = 15;
            this.Lbl_PReportado.Text = "Problema Reportado:";
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
            // lbl_CTecnico
            // 
            this.lbl_CTecnico.AutoSize = true;
            this.lbl_CTecnico.BackColor = System.Drawing.Color.Transparent;
            this.lbl_CTecnico.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbl_CTecnico.Location = new System.Drawing.Point(382, 297);
            this.lbl_CTecnico.Name = "lbl_CTecnico";
            this.lbl_CTecnico.Size = new System.Drawing.Size(102, 17);
            this.lbl_CTecnico.TabIndex = 17;
            this.lbl_CTecnico.Text = "Código Técnico:";
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
            // lbl_NombreTec
            // 
            this.lbl_NombreTec.AutoSize = true;
            this.lbl_NombreTec.BackColor = System.Drawing.Color.Transparent;
            this.lbl_NombreTec.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbl_NombreTec.Location = new System.Drawing.Point(384, 340);
            this.lbl_NombreTec.Name = "lbl_NombreTec";
            this.lbl_NombreTec.Size = new System.Drawing.Size(61, 17);
            this.lbl_NombreTec.TabIndex = 20;
            this.lbl_NombreTec.Text = "Nombre:";
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
            // lbl_Prioridad
            // 
            this.lbl_Prioridad.AutoSize = true;
            this.lbl_Prioridad.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Prioridad.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbl_Prioridad.Location = new System.Drawing.Point(382, 383);
            this.lbl_Prioridad.Name = "lbl_Prioridad";
            this.lbl_Prioridad.Size = new System.Drawing.Size(66, 17);
            this.lbl_Prioridad.TabIndex = 21;
            this.lbl_Prioridad.Text = "Prioridad:";
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
            this.Controls.Add(this.lbl_Prioridad);
            this.Controls.Add(this.lbl_NombreTec);
            this.Controls.Add(this.txt_NombreTecnico);
            this.Controls.Add(this.cbx_CodigoTecnico);
            this.Controls.Add(this.lbl_CTecnico);
            this.Controls.Add(this.txt_ProblemaReportado);
            this.Controls.Add(this.Lbl_PReportado);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txt_DireccionCliente);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lbl_Dir);
            this.Controls.Add(this.lbl_CCliente);
            this.Controls.Add(this.txt_ContactoCliente);
            this.Controls.Add(this.lbl_fechaActual);
            this.Controls.Add(this.lbl_Fecha);
            this.Controls.Add(this.lbl_NomCliente);
            this.Controls.Add(this.txt_NombreCliente);
            this.Controls.Add(this.lbl_NCliente);
            this.Controls.Add(this.txt_NumeroCliente);
            this.Controls.Add(this.lbl_NOrden);
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
        private System.Windows.Forms.Label lbl_NOrden;
        private System.Windows.Forms.Label lbl_NCliente;
        private System.Windows.Forms.TextBox txt_NumeroCliente;
        private System.Windows.Forms.Label lbl_NomCliente;
        private System.Windows.Forms.TextBox txt_NombreCliente;
        private System.Windows.Forms.Label lbl_Fecha;
        private System.Windows.Forms.Label lbl_fechaActual;
        private System.Windows.Forms.Label lbl_CCliente;
        private System.Windows.Forms.TextBox txt_ContactoCliente;
        private System.Windows.Forms.Label lbl_Dir;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RichTextBox txt_DireccionCliente;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label Lbl_PReportado;
        private System.Windows.Forms.RichTextBox txt_ProblemaReportado;
        private System.Windows.Forms.Label lbl_CTecnico;
        private System.Windows.Forms.ComboBox cbx_CodigoTecnico;
        private System.Windows.Forms.Label lbl_NombreTec;
        private System.Windows.Forms.TextBox txt_NombreTecnico;
        private System.Windows.Forms.ComboBox cbx_Prioridad;
        private System.Windows.Forms.Label lbl_Prioridad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ToolStrip tls_Menu_OrdenTrabajo;
        private System.Windows.Forms.ToolStripButton btn_GenerarReporte;
        private System.Windows.Forms.ToolStripLabel lbl_GenerarReporte;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btn_Salir;
        private System.Windows.Forms.ToolStripLabel lbl_Salir;
    }
}