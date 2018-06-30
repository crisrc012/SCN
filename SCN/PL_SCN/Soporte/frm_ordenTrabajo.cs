using System;
using System.Windows.Forms;

namespace PL_SCN.Soporte
{
    public partial class frm_ordenTrabajo : Form
    {
        public frm_ordenTrabajo()
        {
            InitializeComponent();
        }

        private void frm_ordenTrabajo_Load(object sender, EventArgs e)
        {
            DateTime fechaActual = DateTime.Now;
            this.lbl_fechaActual.Text = fechaActual.ToString("d");
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {

            SalirOrdenTrabajo();
        }


        private void SalirOrdenTrabajo()
        {
            if (txt_NumeroCliente.Text != string.Empty || txt_ProblemaReportado.Text != string.Empty)
            {
                if (MessageBox.Show("¿Realmente Desea Salir, no se guardarán los cambios?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Close();
                }
            }
            else
            {
                if (MessageBox.Show("¿Realmente Desea Salir?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Close();
                }
            }
        }

        private void txt_NumeroCliente_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {

            }
            else if (e.KeyCode == Keys.F8)
            {

            }
            else if (e.KeyCode == Keys.Escape)
            {
                SalirOrdenTrabajo();
            }
        }

        private void txt_ProblemaReportado_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {

            }
            else if (e.KeyCode == Keys.F8)
            {

            }
            else if (e.KeyCode == Keys.Escape)
            {
                SalirOrdenTrabajo();
            }
        }

        private void cbx_CodigoTecnico_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {

            }
            else if (e.KeyCode == Keys.F8)
            {

            }
            else if (e.KeyCode == Keys.Escape)
            {
                SalirOrdenTrabajo();
            }
        }

        private void cbx_Prioridad_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {

            }
            else if (e.KeyCode == Keys.F8)
            {

            }
            else if (e.KeyCode == Keys.Escape)
            {
                SalirOrdenTrabajo();
            }
        }
    }
}
