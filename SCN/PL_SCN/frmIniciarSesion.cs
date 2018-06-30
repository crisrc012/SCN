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
        #region Validaciones
        private void txtUsuario_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtUsuario.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider.SetError(txtUsuario, 
                    "Por favor digite su nombre de usuario.");
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
            else
            {
                e.Cancel = false;
                errorProvider.SetError(txtContrasena, null);
            }
        }
        private void txtContrasena_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Space)
            {
                // Valida que el nombre de usuario no tenga espacios en blanco
                errorProvider.SetError(txtContrasena,
                    "La contraseña no puede contener espacios en blanco.");
                e.Handled = true;
            }
            else if (txtContrasena.Text.Trim().Length < 6)
            {
                errorProvider.SetError(txtContrasena,
                    "La contraseña debe de tener al menos 6 caracteres.");
            }
            else if (txtContrasena.Text.Trim().Length > 25)
            {
                errorProvider.SetError(txtContrasena,
                    "La contraseña no puede más de 25 caracteres.");
            }
            else if (e.KeyChar == (char)Keys.Enter)
            {
                errorProvider.SetError(txtContrasena, null);
                // Si se presiona la tecla Enter, se da click a btnEntrar
                btnEntrar_Click(null, null);
            }
            else
            {
                errorProvider.SetError(txtContrasena, null);
            }
        }
        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Space)
            {
                // Valida que el nombre de usuario no tenga espacios en blanco
                errorProvider.SetError(txtUsuario,
                    "El nombre de usuario no puede contener espacios en blanco.");
                e.Handled = true;
            }
            else if (e.KeyChar == (char)Keys.Enter)
            {
                errorProvider.SetError(txtUsuario, null);
                // Si se presiona la tecla Enter, se mueve al campo de contraseña
                txtContrasena.Focus();
            }
            else
            {
                errorProvider.SetError(txtUsuario, null);
            }
        }
        #endregion
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
    }
}
