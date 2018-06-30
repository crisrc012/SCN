using System;
using System.Windows.Forms;

namespace PL_SCN.CatyMan.Mantenimientos.Departamentos
{
    public partial class frm_Man_Departamentos : Form
    {
        public enum Accion { Agregar, Modificar, Eliminar }
        private Accion _aAccion;
        public frm_Man_Departamentos(Accion _aAccion)
        {
            InitializeComponent();
            this._aAccion = _aAccion;
        }

        private void frm_Man_Departamentos_Load(object sender, EventArgs e)
        {
            switch (_aAccion)
            {
                case Accion.Agregar:
                    Text = "Agregar Departamento";
                    btnAccion.Text = "Agregar";
                    break;
                case Accion.Modificar:
                    Text = "Modificar Departamento";
                    btnAccion.Text = "Modificar";
                    break;
                case Accion.Eliminar:
                    Text = "Eliminar Departamento";
                    btnAccion.Text = "Eliminar";
                    break;
                default:
                    MessageBox.Show("Ha ocurrido un problema al abrir el mantenimiento de Departamentos",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Close();
                    break;
            }
        }
        #region btnAccion
        private void btnAccion_Click(object sender, EventArgs e)
        {
            switch (_aAccion)
            {
                case Accion.Agregar:
                    btnAccion_Agregar();
                    break;
                case Accion.Modificar:
                    btnAccion_Modificar();
                    break;
                case Accion.Eliminar:
                    btnAccion_Eliminar();
                    break;
                default:
                    break;
            }
        }
        private void btnAccion_Agregar()
        {
            MessageBox.Show("El registro se Agregó con éxito!!!", "Agregar registro",
                        MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
        private void btnAccion_Modificar()
        {
            MessageBox.Show("El registro se modificó con éxito!!!", "Modificar registro",
                        MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
        private void btnAccion_Eliminar()
        {
            MessageBox.Show("El registro se Eliminó con éxito!!!", "Eliminar registro",
                        MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
        #endregion

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
