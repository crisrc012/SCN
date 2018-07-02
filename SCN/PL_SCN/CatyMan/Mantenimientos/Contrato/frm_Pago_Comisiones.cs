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
    public partial class frm_Pago_Comisiones : Form
    {

        private Accion _aAccion;
        public enum Accion { Agregar };


        public frm_Pago_Comisiones(Accion _aAccion)
        {
            InitializeComponent();
            this._aAccion = _aAccion;
        }

        private void frm_Pago_Comisiones_Load(object sender, EventArgs e)
        {
            switch (_aAccion)
            {
                case Accion.Agregar:
                    Text = "Agregar Remesa de Pago de Comisiones";
                    btnAccion.Text = "Agregar";
                    break;
                    default:
                    MessageBox.Show("Ha ocurrido un problema al abrir el mantenimiento de usuarios",
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
