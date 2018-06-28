using System;
using System.Windows.Forms;

namespace PL_SCN
{
    public partial class frmSCN : Form
    {
        #region frmObjetos
        frmAcercaDe frmAcercaDeInstancia;
        #endregion
        public frmSCN()
        {
            InitializeComponent();
            //hola
        }

        #region frmAcercaDe
        private void mniAcercaDe_Click(object sender, EventArgs e)
        {
            // Abre el formulario, si está establecido en null
            // Esto para evitar que se ejecute más de una instancia
            if (frmAcercaDeInstancia == null)
            {
                frmAcercaDeInstancia = new frmAcercaDe();
                frmAcercaDeInstancia.MdiParent = this;
                frmAcercaDeInstancia.FormClosed += 
                    new FormClosedEventHandler(frmAcercaDeInstancia_FormClosed);
                frmAcercaDeInstancia.Show();
            }
            else
            {
                // Si ya está abierto el formulario se activa
                frmAcercaDeInstancia.Activate();
            }
        }
        private void frmAcercaDeInstancia_FormClosed(object sender,
            FormClosedEventArgs e)
        {
            // Cuando se cierre el formulario se establece en null
            // para que pueda volver a ser abierto al preionar el
            // menuitem
            frmAcercaDeInstancia = null;
        }
        #endregion

        private void frmSCN_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void usuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PL_SCN.CatyMan.frm_usuario frmUsr = new CatyMan.frm_usuario();
            frmUsr.ShowDialog();
        }

        private void perfilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PL_SCN.CatyMan.frm_perfiles frmPer = new CatyMan.frm_perfiles();
            frmPer.ShowDialog();
        }

        private void departamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PL_SCN.CatyMan.frm_depa frmDepa = new CatyMan.frm_depa();
            frmDepa.ShowDialog();
        }

        private void suscripcionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PL_SCN.CatyMan.frm_suscrip frmSusc = new CatyMan.frm_suscrip();
            frmSusc.ShowDialog();
        }

        private void ventasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PL_SCN.Estadistica.frm_estadistica frmEst = new Estadistica.frm_estadistica();
            frmEst.ShowDialog();
        }

        private void frmSCN_Load(object sender, EventArgs e)
        {

        }

        private void ordenDeTrabajoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PL_SCN.Soporte.frm_ordenTrabajo frmOrdenTrabajo = new Soporte.frm_ordenTrabajo();
            frmOrdenTrabajo.ShowDialog();
        }

        private void personaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PL_SCN.CatyMan.frm_personas frmPer = new CatyMan.frm_personas();
            frmPer.ShowDialog();
        }

        private void estadisticasVentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PL_SCN.Estadistica.frm_estadistica frmEst = new Estadistica.frm_estadistica();
            frmEst.ShowDialog();
        }
    }
}
