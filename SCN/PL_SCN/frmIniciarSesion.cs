using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace PL_SCN
{
    public partial class frmIniciarSesion : Form
    {
        private ErrorProvider errorProvider;
        private frmSCN frmSCNInstancia;
        public frmIniciarSesion()
        {
            InitializeComponent();
            errorProvider = new ErrorProvider();
        }

        private void txtUsuario_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtUsuario.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider.SetError(txtUsuario, "Por favor digite su nombre de usuario.");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(txtUsuario, null);
            }
        }
        private void txtContrasena_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtContrasena.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider.SetError(txtContrasena,
                    "Por favor digite su contraseña.");
            }
            else if (txtContrasena.Text.Trim().Length < 6)
            {
                e.Cancel = true;
                errorProvider.SetError(txtContrasena,
                    "La contraseña debe de tener al menos 6 caracteres.");
            }
            else if (txtContrasena.Text.Trim().Length > 25)
            {
                e.Cancel = true;
                errorProvider.SetError(txtContrasena,
                    "La contraseña no puede más de 25 caracteres.");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(txtContrasena, null);
            }
        }
        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                if (true)
                {
                    // Si autentica
                    Visible = false;
                    frmSCNInstancia = new frmSCN();
                    frmSCNInstancia.Show();
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña inválido",
                        "Error de inicio de sesión", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
