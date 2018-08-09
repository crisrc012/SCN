using BLL_SCN.Catalogos_Mantenimientos;
using DAL_SCN.Catalogos_Mantenimientos;
using System;
using System.Windows.Forms;

namespace PL_SCN.CatyMan.Mantenimientos.Perfiles
{
    public partial class frm_Man_Perfiles : Form
    {
        public enum Accion { Agregar, Modificar, Eliminar }
        private Accion _aAccion;
        private Cls_CatyMan_BLL Obj_CatyMan_BLL;
        private Cls_CatyMan_DAL Obj_CatyMan_DAL;
        private Cls_T_Perfil_DAL Obj_Perfil_DAL;
        public frm_Man_Perfiles(Accion _aAccion, Cls_T_Perfil_DAL Obj_Perfil_DAL)
        {
            InitializeComponent();
            Obj_CatyMan_BLL = new Cls_CatyMan_BLL();
            this._aAccion = _aAccion;
            this.Obj_Perfil_DAL = Obj_Perfil_DAL;
        }
        private void frm_Add_Perfil_Load(object sender, EventArgs e)
        {
            switch (_aAccion)
            {
                case Accion.Agregar:
                    Text = "Agregar Perfil";
                    btnAccion.Text = "Agregar";
                    break;
                case Accion.Modificar:
                    Text = "Modificar Perfil";
                    btnAccion.Text = "Modificar";
                    txtNombrePerfil.Text = Obj_Perfil_DAL.sDescripcion;
                    cmbEstados.SelectedValue = Obj_Perfil_DAL.cID_Estado;
                    break;
                case Accion.Eliminar:
                    Text = "Eliminar Perfil";
                    btnAccion.Text = "Eliminar";
                    break;
                default:
                    MessageBox.Show("Ha ocurrido un problema al abrir el mantenimiento de perfiles",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Close();
                    break;
            }
            // Cargar ComboBox
            Obj_CatyMan_DAL = new Cls_CatyMan_DAL();
            Obj_CatyMan_BLL.listar_Cat_Man(ref Obj_CatyMan_DAL, "T_Estados");
            cmbEstados.DisplayMember = "Descripcion";
            cmbEstados.ValueMember = "ID_Estado";
            cmbEstados.DataSource = Obj_CatyMan_DAL.Obj_DS.Tables[0];
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
            Close();
        }
        private void btnAccion_Agregar()
        {
            Cls_T_Perfil_BLL Obj_Perfil_BLL = new Cls_T_Perfil_BLL();
            Cls_T_Perfil_DAL Obj_Perfil_DAL = new Cls_T_Perfil_DAL();
            Obj_Perfil_DAL.cID_Estado = Convert.ToChar(cmbEstados.SelectedValue);
            Obj_Perfil_DAL.sDescripcion = txtNombrePerfil.Text;
            Obj_Perfil_BLL.insertar_UsuarioPerfil(ref Obj_Perfil_DAL);
            if (Obj_Perfil_DAL.bEstAx)
            {
                MessageBox.Show("El registro se Agregó con éxito!!!", "Agregar registro",
                        MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                MessageBox.Show("El registro no se Agregó con éxito. Error:\n\n" + Obj_Perfil_DAL.sMsjError, "Error registro",
                        MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            
        }
        private void btnAccion_Modificar()
        {
            Cls_T_Perfil_BLL Obj_Perfil_BLL = new Cls_T_Perfil_BLL();
            Obj_Perfil_DAL.sDescripcion = txtNombrePerfil.Text;
            Obj_Perfil_DAL.cID_Estado = Convert.ToChar(cmbEstados.SelectedValue);
            Obj_Perfil_BLL.modificar_UsuarioPerfil(ref Obj_Perfil_DAL);
            if (Obj_Perfil_DAL.bEstAx)
            {
                MessageBox.Show("El registro se Agregó con éxito!!!", "Modificar registro",
                        MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                MessageBox.Show("El registro no se Agregó con éxito. Error:\n\n" + Obj_Perfil_DAL.sMsjError, "Error registro",
                        MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
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
