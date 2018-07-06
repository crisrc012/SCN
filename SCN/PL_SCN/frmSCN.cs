using System;
using System.Windows.Forms;
using PL_SCN.CatyMan;
using PL_SCN.Estadistica;
using PL_SCN.Soporte;

namespace PL_SCN
{
    public partial class frmSCN : Form
    {
        #region frmObjetos
        frmAcercaDe frmAcercaDeInstancia;
        frmCatalogo frmUsr, frmPerfiles, frmDepartamentos, frmPersona, frmStock, frmProductos, frmContratos, frmPago_Comisiones;
        frm_estadistica frmEstadistica;
        frm_ordenTrabajo frmOrdenTrabajo;
        #endregion
        public frmSCN()
        {
            InitializeComponent();
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
            // para que pueda volver a ser abierto al presionar el
            // menuitem
            frmAcercaDeInstancia = null;
        }
        #endregion

        #region Seguridad

        #region Usuarios
        private void usuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Abre el formulario, si está establecido en null
            // Esto para evitar que se ejecute más de una instancia
            if (frmUsr == null)
            {
                frmUsr = new frmCatalogo(frmCatalogo.Mantenimiento.Usuarios);
                frmUsr.MdiParent = this;
                frmUsr.FormClosed +=
                    new FormClosedEventHandler(frmUsr_FormClosed);
                frmUsr.Show();
            }
            else
            {
                // Si ya está abierto el formulario se activa
                frmUsr.Activate();
            }
        }
        private void frmUsr_FormClosed(object sender,
            FormClosedEventArgs e)
        {
            // Cuando se cierre el formulario se establece en null
            // para que pueda volver a ser abierto al presionar el
            // menuitem
            frmUsr = null;
        }
        #endregion

        #region TipoUsuario
        private void perfilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Abre el formulario, si está establecido en null
            // Esto para evitar que se ejecute más de una instancia
            if (frmPerfiles == null)
            {
                frmPerfiles = new frmCatalogo(frmCatalogo.Mantenimiento.TipoUsuario);
                frmPerfiles.MdiParent = this;
                frmPerfiles.FormClosed +=
                    new FormClosedEventHandler(frmPerfiles_FormClosed);
                frmPerfiles.Show();
            }
            else
            {
                // Si ya está abierto el formulario se activa
                frmPerfiles.Activate();
            }
        }
        private void frmPerfiles_FormClosed(object sender,
            FormClosedEventArgs e)
        {
            // Cuando se cierre el formulario se establece en null
            // para que pueda volver a ser abierto al presionar el
            // menuitem
            frmPerfiles = null;
        }
        #endregion

        #region Departamentos
        private void departamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Abre el formulario, si está establecido en null
            // Esto para evitar que se ejecute más de una instancia
            if (frmDepartamentos == null)
            {
                frmDepartamentos = new frmCatalogo(frmCatalogo.Mantenimiento.Departamento);
                frmDepartamentos.MdiParent = this;
                frmDepartamentos.FormClosed +=
                    new FormClosedEventHandler(frmDepartamentos_FormClosed);
                frmDepartamentos.Show();
            }
            else
            {
                // Si ya está abierto el formulario se activa
                frmDepartamentos.Activate();
            }
        }
        private void frmDepartamentos_FormClosed(object sender,
            FormClosedEventArgs e)
        {
            // Cuando se cierre el formulario se establece en null
            // para que pueda volver a ser abierto al presionar el
            // menuitem
            frmDepartamentos = null;
        }
        #endregion

        #region Persona
        private void personaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Abre el formulario, si está establecido en null
            // Esto para evitar que se ejecute más de una instancia
            if (frmPersona == null)
            {
                frmPersona = new frmCatalogo(frmCatalogo.Mantenimiento.Persona);
                frmPersona.MdiParent = this;
                frmPersona.FormClosed +=
                    new FormClosedEventHandler(frmPersona_FormClosed);
                frmPersona.Show();
            }
            else
            {
                // Si ya está abierto el formulario se activa
                frmPersona.Activate();
            }
        }
        private void frmPersona_FormClosed(object sender,
            FormClosedEventArgs e)
        {
            // Cuando se cierre el formulario se establece en null
            // para que pueda volver a ser abierto al presionar el
            // menuitem
            frmPersona = null;
        }
        #endregion

        #endregion

        private void frmSCN_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(
                "¿Realmente Desea Salir?", "Advertencia", MessageBoxButtons.YesNo, 
                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        private void ordenDeTrabajoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Abre el formulario, si está establecido en null
            // Esto para evitar que se ejecute más de una instancia
            if (frmOrdenTrabajo == null)
            {
                frmOrdenTrabajo = new frm_ordenTrabajo();
                frmOrdenTrabajo.MdiParent = this;
                frmOrdenTrabajo.FormClosed +=
                    new FormClosedEventHandler(frmProductos_FormClosed);
                frmOrdenTrabajo.Show();
            }
            else
            {
                // Si ya está abierto el formulario se activa
                frmOrdenTrabajo.Activate();
            }
        }
        private void frmOrdenTrabajo_FormClosed(object sender,
            FormClosedEventArgs e)
        {
            // Cuando se cierre el formulario se establece en null
            // para que pueda volver a ser abierto al presionar el
            // menuitem
            frmOrdenTrabajo = null;
        }


        #region Suscripciones

        #region Contratos
        private void contratosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmContratos == null)
            {
                frmContratos = new frmCatalogo(frmCatalogo.Mantenimiento.Contrato);
                frmContratos.MdiParent = this;
                frmContratos.FormClosed +=
                    new FormClosedEventHandler(frmContratos_FormClosed);
                frmContratos.Show();
            }
            else
            {
                // Si ya está abierto el formulario se activa
                frmContratos.Activate();
            }

        } 

        private void frmContratos_FormClosed(object sender,
          FormClosedEventArgs e)
        {
            // Cuando se cierre el formulario se establece en null
            // para que pueda volver a ser abierto al presionar el
            // menuitem
            frmContratos = null;
        }
        #endregion

        #region Pago Comisiones
        private void pagoComisionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmPago_Comisiones == null)
            {
                frmPago_Comisiones = new frmCatalogo(frmCatalogo.Mantenimiento.Pago_Comisiones);
                frmPago_Comisiones.MdiParent = this;
                frmPago_Comisiones.FormClosed +=
                    new FormClosedEventHandler(frmPago_Comisiones_FormClosed);
                frmPago_Comisiones.Show();
            }
            else
            {
                // Si ya está abierto el formulario se activa
                frmPago_Comisiones.Activate();
            }
        }

        

        private void frmPago_Comisiones_FormClosed(object sender,  FormClosedEventArgs e)
        {
            // Cuando se cierre el formulario se establece en null
            // para que pueda volver a ser abierto al presionar el
            // menuitem
            frmPago_Comisiones = null;
        }

        #endregion

        # region Estadistica
        private void estadisticasVentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Abre el formulario, si está establecido en null
            // Esto para evitar que se ejecute más de una instancia
            if (frmEstadistica == null)
            {
                frmEstadistica = new frm_estadistica();
                frmEstadistica.MdiParent = this;
                frmEstadistica.FormClosed +=
                    new FormClosedEventHandler(frmEstadistica_FormClosed);
                frmEstadistica.Show();
            }
            else
            {
                // Si ya está abierto el formulario se activa
                frmEstadistica.Activate();
            }
        }
        private void frmEstadistica_FormClosed(object sender,
    FormClosedEventArgs e)
        {
            // Cuando se cierre el formulario se establece en null
            // para que pueda volver a ser abierto al presionar el
            // menuitem
            frmEstadistica = null;
        }

        #endregion

        #endregion
        private void frmSCN_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show(
                "¿Realmente Desea Salir?", "Advertencia", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                e.Cancel = true;
            }
        }

        #region Inventarios
        private void stockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Abre el formulario, si está establecido en null
            // Esto para evitar que se ejecute más de una instancia
            if (frmStock == null)
            {
                frmStock = new frmCatalogo(frmCatalogo.Mantenimiento.Stock);
                frmStock.MdiParent = this;
                frmStock.FormClosed +=
                    new FormClosedEventHandler(frmStock_FormClosed);
                frmStock.Show();
            }
            else
            {
                // Si ya está abierto el formulario se activa
                frmStock.Activate();
            }
        }
        private void frmStock_FormClosed(object sender,
            FormClosedEventArgs e)
        {
            // Cuando se cierre el formulario se establece en null
            // para que pueda volver a ser abierto al presionar el
            // menuitem
            frmStock = null;
        }
        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Abre el formulario, si está establecido en null
            // Esto para evitar que se ejecute más de una instancia
            if (frmProductos == null)
            {
                frmProductos = new frmCatalogo(frmCatalogo.Mantenimiento.Productos);
                frmProductos.MdiParent = this;
                frmProductos.FormClosed +=
                    new FormClosedEventHandler(frmProductos_FormClosed);
                frmProductos.Show();
            }
            else
            {
                // Si ya está abierto el formulario se activa
                frmProductos.Activate();
            }
        }
        private void frmProductos_FormClosed(object sender,
            FormClosedEventArgs e)
        {
            // Cuando se cierre el formulario se establece en null
            // para que pueda volver a ser abierto al presionar el
            // menuitem
            frmProductos = null;
        }
        #endregion
    }
}
