namespace PL_SCN
{
    partial class frmIniciarSesion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmIniciarSesion));
            this.btnEntrar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblContraseña = new System.Windows.Forms.Label();
            this.gbxCredenciales = new System.Windows.Forms.GroupBox();
            this.txtContrasena = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gbxCredenciales.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnEntrar
            // 
            this.btnEntrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnEntrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEntrar.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnEntrar.ForeColor = System.Drawing.Color.Green;
            this.btnEntrar.Image = ((System.Drawing.Image)(resources.GetObject("btnEntrar.Image")));
            this.btnEntrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEntrar.Location = new System.Drawing.Point(272, 120);
            this.btnEntrar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(82, 33);
            this.btnEntrar.TabIndex = 2;
            this.btnEntrar.Text = "Login";
            this.btnEntrar.UseVisualStyleBackColor = true;
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSalir.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnSalir.ForeColor = System.Drawing.Color.Red;
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir.Location = new System.Drawing.Point(372, 120);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(82, 33);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblUsuario.Location = new System.Drawing.Point(131, 33);
            this.lblUsuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(133, 17);
            this.lblUsuario.TabIndex = 2;
            this.lblUsuario.Text = "Nombre de usuario: ";
            // 
            // lblContraseña
            // 
            this.lblContraseña.AutoSize = true;
            this.lblContraseña.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblContraseña.Location = new System.Drawing.Point(180, 79);
            this.lblContraseña.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblContraseña.Name = "lblContraseña";
            this.lblContraseña.Size = new System.Drawing.Size(84, 17);
            this.lblContraseña.TabIndex = 3;
            this.lblContraseña.Text = "Contraseña: ";
            // 
            // gbxCredenciales
            // 
            this.gbxCredenciales.BackColor = System.Drawing.Color.Transparent;
            this.gbxCredenciales.Controls.Add(this.panel2);
            this.gbxCredenciales.Controls.Add(this.txtContrasena);
            this.gbxCredenciales.Controls.Add(this.txtUsuario);
            this.gbxCredenciales.Controls.Add(this.btnEntrar);
            this.gbxCredenciales.Controls.Add(this.btnSalir);
            this.gbxCredenciales.Controls.Add(this.lblUsuario);
            this.gbxCredenciales.Controls.Add(this.lblContraseña);
            this.gbxCredenciales.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.gbxCredenciales.ForeColor = System.Drawing.Color.White;
            this.gbxCredenciales.Location = new System.Drawing.Point(5, 39);
            this.gbxCredenciales.Margin = new System.Windows.Forms.Padding(4);
            this.gbxCredenciales.Name = "gbxCredenciales";
            this.gbxCredenciales.Padding = new System.Windows.Forms.Padding(4);
            this.gbxCredenciales.Size = new System.Drawing.Size(489, 171);
            this.gbxCredenciales.TabIndex = 4;
            this.gbxCredenciales.TabStop = false;
            this.gbxCredenciales.Text = "Credenciales";
            // 
            // txtContrasena
            // 
            this.txtContrasena.Location = new System.Drawing.Point(272, 76);
            this.txtContrasena.MaxLength = 26;
            this.txtContrasena.Name = "txtContrasena";
            this.txtContrasena.Size = new System.Drawing.Size(182, 25);
            this.txtContrasena.TabIndex = 1;
            this.txtContrasena.UseSystemPasswordChar = true;
            this.txtContrasena.Validating += new System.ComponentModel.CancelEventHandler(this.txtContrasena_Validating);
            // 
            // txtUsuario
            // 
            this.txtUsuario.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txtUsuario.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtUsuario.Location = new System.Drawing.Point(272, 30);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.txtUsuario.MaxLength = 32;
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(182, 25);
            this.txtUsuario.TabIndex = 0;
            this.txtUsuario.Validating += new System.ComponentModel.CancelEventHandler(this.txtUsuario_Validating);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkCyan;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(502, 41);
            this.panel1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(13, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "SCN - Iniciar Sesión";
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel2.Location = new System.Drawing.Point(7, 16);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(117, 137);
            this.panel2.TabIndex = 4;
            // 
            // frmIniciarSesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(500, 234);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gbxCredenciales);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmIniciarSesion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.gbxCredenciales.ResumeLayout(false);
            this.gbxCredenciales.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEntrar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblContraseña;
        private System.Windows.Forms.GroupBox gbxCredenciales;
        private System.Windows.Forms.TextBox txtContrasena;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}