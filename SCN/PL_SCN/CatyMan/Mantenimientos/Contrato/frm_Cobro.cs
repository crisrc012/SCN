using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PL_SCN.CatyMan.Mantenimientos.Contrato
{
    public partial class frm_Cobro : Form
    {

        private Accion _aAccion;
        public enum Accion { Agregar, Modificar };

        public frm_Cobro(Accion _aAccion)
        {
            InitializeComponent();
            this._aAccion = _aAccion;
        }

        private void frm_Cobro_Load(object sender, EventArgs e)
        {
            switch (_aAccion)
            {
                case Accion.Agregar:
                    Text = "Agregar Gestion de Cobro";
                    btnAccion.Text = "Agregar";
                    break;
                case Accion.Modificar:
                    Text = "Modificar Gestion de Cobro";
                    btnAccion.Text = "Modificar";
                    break;
     
                default:
                    MessageBox.Show("Ha ocurrido un problema al abrir el Formulario de Cobro",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Close();
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

        private void btnAccion_Click(object sender, EventArgs e)
        {
            btnAccion_Agregar();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

 
    }
}
