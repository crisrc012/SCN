namespace PL_SCN.Soporte
{
    partial class frm_Encuesta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Encuesta));
            this.lbl_Fecha = new System.Windows.Forms.Label();
            this.lbl_fechaActual = new System.Windows.Forms.Label();
            this.lbl_P1 = new System.Windows.Forms.Label();
            this.lbl_P2 = new System.Windows.Forms.Label();
            this.lbl_P3 = new System.Windows.Forms.Label();
            this.lbl_Otros = new System.Windows.Forms.Label();
            this.lbl_Si = new System.Windows.Forms.Label();
            this.lbl_No = new System.Windows.Forms.Label();
            this.grb_P1 = new System.Windows.Forms.GroupBox();
            this.rbt_DosPreguntaUno = new System.Windows.Forms.RadioButton();
            this.rbt_UnoPreguntaUno = new System.Windows.Forms.RadioButton();
            this.grb_P2 = new System.Windows.Forms.GroupBox();
            this.rbt_DosPreguntaDos = new System.Windows.Forms.RadioButton();
            this.rbt_UnoPreguntaDos = new System.Windows.Forms.RadioButton();
            this.grb_P3 = new System.Windows.Forms.GroupBox();
            this.rbt_DosPreguntaTres = new System.Windows.Forms.RadioButton();
            this.rbt_UnoPreguntaTres = new System.Windows.Forms.RadioButton();
            this.btn_Enviar = new System.Windows.Forms.Button();
            this.txt_ComentariosOSugerencias = new System.Windows.Forms.RichTextBox();
            this.grb_P1.SuspendLayout();
            this.grb_P2.SuspendLayout();
            this.grb_P3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_Fecha
            // 
            this.lbl_Fecha.AutoSize = true;
            this.lbl_Fecha.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Fecha.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbl_Fecha.Location = new System.Drawing.Point(12, 9);
            this.lbl_Fecha.Name = "lbl_Fecha";
            this.lbl_Fecha.Size = new System.Drawing.Size(46, 17);
            this.lbl_Fecha.TabIndex = 8;
            this.lbl_Fecha.Text = "Fecha:";
            // 
            // lbl_fechaActual
            // 
            this.lbl_fechaActual.AutoSize = true;
            this.lbl_fechaActual.BackColor = System.Drawing.Color.Transparent;
            this.lbl_fechaActual.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbl_fechaActual.Location = new System.Drawing.Point(74, 9);
            this.lbl_fechaActual.Name = "lbl_fechaActual";
            this.lbl_fechaActual.Size = new System.Drawing.Size(82, 17);
            this.lbl_fechaActual.TabIndex = 9;
            this.lbl_fechaActual.Text = "XXXX/XX/XX";
            // 
            // lbl_P1
            // 
            this.lbl_P1.AutoSize = true;
            this.lbl_P1.BackColor = System.Drawing.Color.Transparent;
            this.lbl_P1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbl_P1.Location = new System.Drawing.Point(12, 59);
            this.lbl_P1.Name = "lbl_P1";
            this.lbl_P1.Size = new System.Drawing.Size(350, 17);
            this.lbl_P1.TabIndex = 10;
            this.lbl_P1.Text = "¿Está conforme con el servicio recibido durante la visita?";
            // 
            // lbl_P2
            // 
            this.lbl_P2.AutoSize = true;
            this.lbl_P2.BackColor = System.Drawing.Color.Transparent;
            this.lbl_P2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbl_P2.Location = new System.Drawing.Point(12, 105);
            this.lbl_P2.Name = "lbl_P2";
            this.lbl_P2.Size = new System.Drawing.Size(352, 17);
            this.lbl_P2.TabIndex = 11;
            this.lbl_P2.Text = "¿El problema reportado fue solucionado en su totalidad?";
            // 
            // lbl_P3
            // 
            this.lbl_P3.AutoSize = true;
            this.lbl_P3.BackColor = System.Drawing.Color.Transparent;
            this.lbl_P3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbl_P3.Location = new System.Drawing.Point(12, 149);
            this.lbl_P3.Name = "lbl_P3";
            this.lbl_P3.Size = new System.Drawing.Size(442, 17);
            this.lbl_P3.TabIndex = 12;
            this.lbl_P3.Text = "¿Se siente conforme con el apoyo y la asesoría que el técnico le brindó?";
            // 
            // lbl_Otros
            // 
            this.lbl_Otros.AutoSize = true;
            this.lbl_Otros.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Otros.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbl_Otros.Location = new System.Drawing.Point(12, 207);
            this.lbl_Otros.Name = "lbl_Otros";
            this.lbl_Otros.Size = new System.Drawing.Size(185, 17);
            this.lbl_Otros.TabIndex = 13;
            this.lbl_Otros.Text = "Comentarios y/o Sugerencias";
            // 
            // lbl_Si
            // 
            this.lbl_Si.AutoSize = true;
            this.lbl_Si.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Si.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbl_Si.Location = new System.Drawing.Point(491, 28);
            this.lbl_Si.Name = "lbl_Si";
            this.lbl_Si.Size = new System.Drawing.Size(19, 17);
            this.lbl_Si.TabIndex = 14;
            this.lbl_Si.Text = "SI";
            // 
            // lbl_No
            // 
            this.lbl_No.AutoSize = true;
            this.lbl_No.BackColor = System.Drawing.Color.Transparent;
            this.lbl_No.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbl_No.Location = new System.Drawing.Point(548, 28);
            this.lbl_No.Name = "lbl_No";
            this.lbl_No.Size = new System.Drawing.Size(28, 17);
            this.lbl_No.TabIndex = 15;
            this.lbl_No.Text = "NO";
            // 
            // grb_P1
            // 
            this.grb_P1.BackColor = System.Drawing.Color.Transparent;
            this.grb_P1.Controls.Add(this.rbt_DosPreguntaUno);
            this.grb_P1.Controls.Add(this.rbt_UnoPreguntaUno);
            this.grb_P1.Location = new System.Drawing.Point(480, 48);
            this.grb_P1.Name = "grb_P1";
            this.grb_P1.Size = new System.Drawing.Size(102, 36);
            this.grb_P1.TabIndex = 16;
            this.grb_P1.TabStop = false;
            // 
            // rbt_DosPreguntaUno
            // 
            this.rbt_DosPreguntaUno.AutoSize = true;
            this.rbt_DosPreguntaUno.Location = new System.Drawing.Point(72, 13);
            this.rbt_DosPreguntaUno.Name = "rbt_DosPreguntaUno";
            this.rbt_DosPreguntaUno.Size = new System.Drawing.Size(14, 13);
            this.rbt_DosPreguntaUno.TabIndex = 1;
            this.rbt_DosPreguntaUno.TabStop = true;
            this.rbt_DosPreguntaUno.UseVisualStyleBackColor = true;
            // 
            // rbt_UnoPreguntaUno
            // 
            this.rbt_UnoPreguntaUno.AutoSize = true;
            this.rbt_UnoPreguntaUno.Location = new System.Drawing.Point(11, 14);
            this.rbt_UnoPreguntaUno.Name = "rbt_UnoPreguntaUno";
            this.rbt_UnoPreguntaUno.Size = new System.Drawing.Size(14, 13);
            this.rbt_UnoPreguntaUno.TabIndex = 0;
            this.rbt_UnoPreguntaUno.TabStop = true;
            this.rbt_UnoPreguntaUno.UseVisualStyleBackColor = true;
            // 
            // grb_P2
            // 
            this.grb_P2.BackColor = System.Drawing.Color.Transparent;
            this.grb_P2.Controls.Add(this.rbt_DosPreguntaDos);
            this.grb_P2.Controls.Add(this.rbt_UnoPreguntaDos);
            this.grb_P2.Location = new System.Drawing.Point(480, 91);
            this.grb_P2.Name = "grb_P2";
            this.grb_P2.Size = new System.Drawing.Size(102, 36);
            this.grb_P2.TabIndex = 17;
            this.grb_P2.TabStop = false;
            // 
            // rbt_DosPreguntaDos
            // 
            this.rbt_DosPreguntaDos.AutoSize = true;
            this.rbt_DosPreguntaDos.Location = new System.Drawing.Point(72, 14);
            this.rbt_DosPreguntaDos.Name = "rbt_DosPreguntaDos";
            this.rbt_DosPreguntaDos.Size = new System.Drawing.Size(14, 13);
            this.rbt_DosPreguntaDos.TabIndex = 21;
            this.rbt_DosPreguntaDos.TabStop = true;
            this.rbt_DosPreguntaDos.UseVisualStyleBackColor = true;
            // 
            // rbt_UnoPreguntaDos
            // 
            this.rbt_UnoPreguntaDos.AutoSize = true;
            this.rbt_UnoPreguntaDos.Location = new System.Drawing.Point(11, 13);
            this.rbt_UnoPreguntaDos.Name = "rbt_UnoPreguntaDos";
            this.rbt_UnoPreguntaDos.Size = new System.Drawing.Size(14, 13);
            this.rbt_UnoPreguntaDos.TabIndex = 0;
            this.rbt_UnoPreguntaDos.TabStop = true;
            this.rbt_UnoPreguntaDos.UseVisualStyleBackColor = true;
            // 
            // grb_P3
            // 
            this.grb_P3.BackColor = System.Drawing.Color.Transparent;
            this.grb_P3.Controls.Add(this.rbt_DosPreguntaTres);
            this.grb_P3.Controls.Add(this.rbt_UnoPreguntaTres);
            this.grb_P3.Location = new System.Drawing.Point(480, 137);
            this.grb_P3.Name = "grb_P3";
            this.grb_P3.Size = new System.Drawing.Size(102, 36);
            this.grb_P3.TabIndex = 18;
            this.grb_P3.TabStop = false;
            // 
            // rbt_DosPreguntaTres
            // 
            this.rbt_DosPreguntaTres.AutoSize = true;
            this.rbt_DosPreguntaTres.Location = new System.Drawing.Point(72, 15);
            this.rbt_DosPreguntaTres.Name = "rbt_DosPreguntaTres";
            this.rbt_DosPreguntaTres.Size = new System.Drawing.Size(14, 13);
            this.rbt_DosPreguntaTres.TabIndex = 21;
            this.rbt_DosPreguntaTres.TabStop = true;
            this.rbt_DosPreguntaTres.UseVisualStyleBackColor = true;
            // 
            // rbt_UnoPreguntaTres
            // 
            this.rbt_UnoPreguntaTres.AutoSize = true;
            this.rbt_UnoPreguntaTres.Location = new System.Drawing.Point(11, 15);
            this.rbt_UnoPreguntaTres.Name = "rbt_UnoPreguntaTres";
            this.rbt_UnoPreguntaTres.Size = new System.Drawing.Size(14, 13);
            this.rbt_UnoPreguntaTres.TabIndex = 21;
            this.rbt_UnoPreguntaTres.TabStop = true;
            this.rbt_UnoPreguntaTres.UseVisualStyleBackColor = true;
            // 
            // btn_Enviar
            // 
            this.btn_Enviar.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_Enviar.Location = new System.Drawing.Point(510, 296);
            this.btn_Enviar.Name = "btn_Enviar";
            this.btn_Enviar.Size = new System.Drawing.Size(84, 34);
            this.btn_Enviar.TabIndex = 19;
            this.btn_Enviar.Text = "ENVIA&R";
            this.btn_Enviar.UseVisualStyleBackColor = true;
            // 
            // txt_ComentariosOSugerencias
            // 
            this.txt_ComentariosOSugerencias.Enabled = false;
            this.txt_ComentariosOSugerencias.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.txt_ComentariosOSugerencias.Location = new System.Drawing.Point(15, 236);
            this.txt_ComentariosOSugerencias.MaxLength = 500;
            this.txt_ComentariosOSugerencias.Name = "txt_ComentariosOSugerencias";
            this.txt_ComentariosOSugerencias.Size = new System.Drawing.Size(447, 76);
            this.txt_ComentariosOSugerencias.TabIndex = 20;
            this.txt_ComentariosOSugerencias.Text = "";
            // 
            // frm_Encuesta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(606, 342);
            this.Controls.Add(this.txt_ComentariosOSugerencias);
            this.Controls.Add(this.btn_Enviar);
            this.Controls.Add(this.grb_P3);
            this.Controls.Add(this.grb_P2);
            this.Controls.Add(this.grb_P1);
            this.Controls.Add(this.lbl_No);
            this.Controls.Add(this.lbl_Si);
            this.Controls.Add(this.lbl_Otros);
            this.Controls.Add(this.lbl_P3);
            this.Controls.Add(this.lbl_P2);
            this.Controls.Add(this.lbl_P1);
            this.Controls.Add(this.lbl_fechaActual);
            this.Controls.Add(this.lbl_Fecha);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frm_Encuesta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Encuesta de Servicio Recibido";
            this.Load += new System.EventHandler(this.frm_Encuesta_Load);
            this.grb_P1.ResumeLayout(false);
            this.grb_P1.PerformLayout();
            this.grb_P2.ResumeLayout(false);
            this.grb_P2.PerformLayout();
            this.grb_P3.ResumeLayout(false);
            this.grb_P3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Fecha;
        private System.Windows.Forms.Label lbl_fechaActual;
        private System.Windows.Forms.Label lbl_P1;
        private System.Windows.Forms.Label lbl_P2;
        private System.Windows.Forms.Label lbl_P3;
        private System.Windows.Forms.Label lbl_Otros;
        private System.Windows.Forms.Label lbl_Si;
        private System.Windows.Forms.Label lbl_No;
        private System.Windows.Forms.GroupBox grb_P1;
        private System.Windows.Forms.GroupBox grb_P2;
        private System.Windows.Forms.GroupBox grb_P3;
        private System.Windows.Forms.Button btn_Enviar;
        private System.Windows.Forms.RadioButton rbt_DosPreguntaUno;
        private System.Windows.Forms.RadioButton rbt_UnoPreguntaUno;
        private System.Windows.Forms.RadioButton rbt_DosPreguntaDos;
        private System.Windows.Forms.RadioButton rbt_UnoPreguntaDos;
        private System.Windows.Forms.RadioButton rbt_DosPreguntaTres;
        private System.Windows.Forms.RadioButton rbt_UnoPreguntaTres;
        private System.Windows.Forms.RichTextBox txt_ComentariosOSugerencias;
    }
}