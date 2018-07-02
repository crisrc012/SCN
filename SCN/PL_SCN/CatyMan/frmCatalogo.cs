using PL_SCN.CatyMan.Mantenimientos.Usuario;
using PL_SCN.CatyMan.Mantenimientos.Perfiles;
using PL_SCN.CatyMan.Mantenimientos.Departamentos;
using PL_SCN.CatyMan.Mantenimientos.Persona;
using PL_SCN.CatyMan.Mantenimientos.Inventario;
using PL_SCN.CatyMan.Mantenimientos.Contrato;
using System;
using System.Windows.Forms;

namespace PL_SCN.CatyMan
{
    public partial class frmCatalogo : Form
    {
        #region frmObjetos
        private frm_Man_Usuario       frmAddUsr, frmModUsr, frmDelUsr;
        private frm_Man_Perfiles      frmAddTipUsr, frmModTipUsr, frmDelTipUsr;
        private frm_Man_Departamentos frmAddDep, frmModDep, frmDelDep;
        private frm_Man_Persona       frmAddPersona, frmModPersona, frmDelPersona;
        private frm_Man_Stock         frmAddStock, frmModStock, frmDelStock;
        private frm_Man_Productos     frmAddProductos, frmModProductos, frmDelProductos;
        private frm_Man_Contrato      frmAddContratos, frmModContratos, frmDelContratos;
        private frm_Pago_Comisiones   frmAddPagoComisiones;
        #endregion

        public enum Mantenimiento { Usuarios, TipoUsuario,   Departamento,
                                    Persona,  Suscripciones, Productos,
                                    Stock,    Contrato,      Pago_Comisiones }

        private Mantenimiento _mMantenimiento;
        public frmCatalogo(Mantenimiento _mMantenimiento)
        {
            InitializeComponent();
            this._mMantenimiento = _mMantenimiento;
        }
        private void frm_catalogo_Load(object sender, EventArgs e)
        {
            // Se especifica el tipo de la ventana
            switch (_mMantenimiento)
            {
                case Mantenimiento.Usuarios:
                    Text = "Mantenimiento de Usuarios";
                    break;
                case Mantenimiento.TipoUsuario:
                    Text = "Mantenimiento de Tipos de Usuarios";
                    break;
                case Mantenimiento.Departamento:
                    Text = "Mantenimiento de Departamentos";
                    break;
                case Mantenimiento.Persona:
                    Text = "Mantenimiento de Personas";
                    break;
                case Mantenimiento.Suscripciones:
                    Text = "Mantenimiento de Suscripciones";
                    break;
                case Mantenimiento.Stock:
                    Text = "Mantenimiento de Stock";
                    break;
                case Mantenimiento.Productos:
                    Text = "Mantenimiento de Productos";
                    break;
                case Mantenimiento.Contrato:
                    Text = "Mantenimiento de Contratos";
                    break;
                case Mantenimiento.Pago_Comisiones:
                    Text = "Pago Comisiones";
                    mniEliminar.Visible = false;
                    mniEliminar.Enabled = false;
                    mniModificar.Visible = false;
                    mniModificar.Enabled = false;
                    break;
                default:
                    break;
            }
        }

        private void mniSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        #region Agregar
        private void mniAgregar_Click(object sender, EventArgs e)
        {
            // Se llama al formulario de agregar indicado
            switch (_mMantenimiento)
            {
                case Mantenimiento.Usuarios:
                    frmAddUsr_FormOpen();
                    break;
                case Mantenimiento.TipoUsuario:
                    frmAddTipUsr_FormOpen();
                    break;
                case Mantenimiento.Departamento:
                    frmAddDep_FormOpen();
                    break;
                case Mantenimiento.Persona:
                    frmAddPersona_FormOpen();
                    break;
                case Mantenimiento.Stock:
                    frmAddStock_FormOpen();
                    break;
                case Mantenimiento.Productos:
                    frmAddProductos_FormOpen();
                    break;
                case Mantenimiento.Contrato:
                    frmAddContratos_FormOpen();
                    break;
                case Mantenimiento.Pago_Comisiones:
                    frmAddPagoComisiones_FormOpen();
                    break;
                default:
                    break;
            }
        }

        #region Agregar Usuario
        private void frmAddUsr_FormOpen()
        {
            // Abre el formulario, si está establecido en null
            // Esto para evitar que se ejecute más de una instancia
            if (frmAddUsr == null)
            {
                frmAddUsr = new frm_Man_Usuario(frm_Man_Usuario.Accion.Agregar);
                frmAddUsr.MdiParent = MdiParent;
                frmAddUsr.FormClosed +=
                    new FormClosedEventHandler(frmAddUsr_FormClosed);
                frmAddUsr.Show();
            }
            else
            {
                // Si ya está abierto el formulario se activa
                frmAddUsr.Activate();
            }
        }
        private void frmAddUsr_FormClosed(object sender,
            FormClosedEventArgs e)
        {
            // Cuando se cierre el formulario se establece en null
            // para que pueda volver a ser abierto al presionar el
            // menuitem
            frmAddUsr = null;
        }
        #endregion

        #region Agregar TipoUsuario
        private void frmAddTipUsr_FormOpen()
        {
            // Abre el formulario, si está establecido en null
            // Esto para evitar que se ejecute más de una instancia
            if (frmAddTipUsr == null)
            {
                frmAddTipUsr = new frm_Man_Perfiles(frm_Man_Perfiles.Accion.Agregar);
                frmAddTipUsr.MdiParent = MdiParent;
                frmAddTipUsr.FormClosed +=
                    new FormClosedEventHandler(frmAddTipUsr_FormClosed);
                frmAddTipUsr.Show();
            }
            else
            {
                // Si ya está abierto el formulario se activa
                frmAddTipUsr.Activate();
            }
        }
        private void frmAddTipUsr_FormClosed(object sender,
            FormClosedEventArgs e)
        {
            // Cuando se cierre el formulario se establece en null
            // para que pueda volver a ser abierto al presionar el
            // menuitem
            frmAddTipUsr = null;
        }
        #endregion

        #region Agregar Departamento
        private void frmAddDep_FormOpen()
        {
            // Abre el formulario, si está establecido en null
            // Esto para evitar que se ejecute más de una instancia
            if (frmAddDep == null)
            {
                frmAddDep = new frm_Man_Departamentos(frm_Man_Departamentos.Accion.Agregar);
                frmAddDep.MdiParent = MdiParent;
                frmAddDep.FormClosed +=
                    new FormClosedEventHandler(frmAddDep_FormClosed);
                frmAddDep.Show();
            }
            else
            {
                // Si ya está abierto el formulario se activa
                frmAddDep.Activate();
            }
        }
        private void frmAddDep_FormClosed(object sender,
            FormClosedEventArgs e)
        {
            // Cuando se cierre el formulario se establece en null
            // para que pueda volver a ser abierto al presionar el
            // menuitem
            frmAddDep = null;
        }
        #endregion

        #region Agregar Persona
        private void frmAddPersona_FormOpen()
        {
            // Abre el formulario, si está establecido en null
            // Esto para evitar que se ejecute más de una instancia
            if (frmAddPersona == null)
            {
                frmAddPersona = new frm_Man_Persona(frm_Man_Persona.Accion.Agregar);
                frmAddPersona.MdiParent = MdiParent;
                frmAddPersona.FormClosed +=
                    new FormClosedEventHandler(frmAddPersona_FormClosed);
                frmAddPersona.Show();
            }
            else
            {
                // Si ya está abierto el formulario se activa
                frmAddPersona.Activate();
            }
        }
        private void frmAddPersona_FormClosed(object sender,
            FormClosedEventArgs e)
        {
            // Cuando se cierre el formulario se establece en null
            // para que pueda volver a ser abierto al presionar el
            // menuitem
            frmAddPersona = null;
        }
        #endregion

        #region Agregar Stock
        private void frmAddStock_FormOpen()
        {
            // Abre el formulario, si está establecido en null
            // Esto para evitar que se ejecute más de una instancia
            if (frmAddStock == null)
            {
                frmAddStock = new frm_Man_Stock(frm_Man_Stock.Accion.Agregar);
                frmAddStock.MdiParent = MdiParent;
                frmAddStock.FormClosed +=
                    new FormClosedEventHandler(frmAddStock_FormClosed);
                frmAddStock.Show();
            }
            else
            {
                // Si ya está abierto el formulario se activa
                frmAddStock.Activate();
            }
        }
        private void frmAddStock_FormClosed(object sender,
            FormClosedEventArgs e)
        {
            // Cuando se cierre el formulario se establece en null
            // para que pueda volver a ser abierto al presionar el
            // menuitem
            frmAddStock = null;
        }
        #endregion

        #region Agregar Productos
        private void frmAddProductos_FormOpen()
        {
            // Abre el formulario, si está establecido en null
            // Esto para evitar que se ejecute más de una instancia
            if (frmAddProductos == null)
            {
                frmAddProductos = new frm_Man_Productos(frm_Man_Productos.Accion.Agregar);
                frmAddProductos.MdiParent = MdiParent;
                frmAddProductos.FormClosed +=
                    new FormClosedEventHandler(frmAddProductos_FormClosed);
                frmAddProductos.Show();
            }
            else
            {
                // Si ya está abierto el formulario se activa
                frmAddProductos.Activate();
            }
        }
        private void frmAddProductos_FormClosed(object sender,
            FormClosedEventArgs e)
        {
            // Cuando se cierre el formulario se establece en null
            // para que pueda volver a ser abierto al presionar el
            // menuitem
            frmAddProductos = null;
        }
        #endregion

        #region Agregar Contratos
        private void frmAddContratos_FormOpen()
        {
            // Abre el formulario, si está establecido en null
            // Esto para evitar que se ejecute más de una instancia
            if (frmAddContratos == null)
            {
                frmAddContratos = new frm_Man_Contrato(frm_Man_Contrato.Accion.Agregar);
                frmAddContratos.MdiParent = MdiParent;
                frmAddContratos.FormClosed +=
                    new FormClosedEventHandler(frmAddContratos_FormClosed);
                frmAddContratos.Show();
            }
            else
            {
                // Si ya está abierto el formulario se activa
                frmAddContratos.Activate();
            }
        }
        private void frmAddContratos_FormClosed(object sender,
            FormClosedEventArgs e)
        {
            // Cuando se cierre el formulario se establece en null
            // para que pueda volver a ser abierto al presionar el
            // menuitem
            frmAddContratos = null;
        }

        #endregion

        #region Agregar Pagos de Comisiones
        private void frmAddPagoComisiones_FormOpen()
        {
            // Abre el formulario, si está establecido en null
            // Esto para evitar que se ejecute más de una instancia
            if (frmAddPagoComisiones == null)
            {
                frmAddPagoComisiones = new frm_Pago_Comisiones(frm_Pago_Comisiones.Accion.Agregar);
                frmAddPagoComisiones.MdiParent = MdiParent;
                frmAddPagoComisiones.FormClosed +=
                    new FormClosedEventHandler(frmAddPagoComisiones_FormClosed);
                frmAddPagoComisiones.Show();
            }
            else
            {
                // Si ya está abierto el formulario se activa
                frmAddPagoComisiones.Activate();
            }
        }
        private void frmAddPagoComisiones_FormClosed(object sender,
            FormClosedEventArgs e)
        {
            // Cuando se cierre el formulario se establece en null
            // para que pueda volver a ser abierto al presionar el
            // menuitem
            frmAddPagoComisiones = null;
        }
        #endregion

        #endregion

        #region Modificar
        private void mniModificar_Click(object sender, EventArgs e)
        {
            switch (_mMantenimiento)
            {
                case Mantenimiento.Usuarios:
                    frmModUsr_FormOpen();
                    break;
                case Mantenimiento.TipoUsuario:
                    frmModTipUsr_FormOpen();
                    break;
                case Mantenimiento.Departamento:
                    frmModDep_FormOpen();
                    break;
                case Mantenimiento.Persona:
                    frmModPersona_FormOpen();
                    break;
                case Mantenimiento.Stock:
                    frmModStock_FormOpen();
                    break;
                case Mantenimiento.Productos:
                    frmModProductos_FormOpen();
                    break;
                case Mantenimiento.Contrato:
                    frmModContratos_FormOpen();
                    break;
                default:
                    break;
            }
        }
        #region Modificar Usuario
        private void frmModUsr_FormOpen()
        {
            // Abre el formulario, si está establecido en null
            // Esto para evitar que se ejecute más de una instancia
            if (frmModUsr == null)
            {
                frmModUsr = new frm_Man_Usuario(frm_Man_Usuario.Accion.Modificar);
                frmModUsr.MdiParent = MdiParent;
                frmModUsr.FormClosed +=
                    new FormClosedEventHandler(frmModUsr_FormClosed);
                frmModUsr.Show();
            }
            else
            {
                // Si ya está abierto el formulario se activa
                frmModUsr.Activate();
            }
        }
        private void frmModUsr_FormClosed(object sender,
            FormClosedEventArgs e)
        {
            // Cuando se cierre el formulario se establece en null
            // para que pueda volver a ser abierto al presionar el
            // menuitem
            frmModUsr = null;
        }
        #endregion
        #region Modificar TipoUsuario
        private void frmModTipUsr_FormOpen()
        {
            // Abre el formulario, si está establecido en null
            // Esto para evitar que se ejecute más de una instancia
            if (frmModTipUsr == null)
            {
                frmModTipUsr = new frm_Man_Perfiles(frm_Man_Perfiles.Accion.Modificar);
                frmModTipUsr.MdiParent = MdiParent;
                frmModTipUsr.FormClosed +=
                    new FormClosedEventHandler(frmModTipUsr_FormClosed);
                frmModTipUsr.Show();
            }
            else
            {
                // Si ya está abierto el formulario se activa
                frmModTipUsr.Activate();
            }
        }
        private void frmModTipUsr_FormClosed(object sender,
            FormClosedEventArgs e)
        {
            // Cuando se cierre el formulario se establece en null
            // para que pueda volver a ser abierto al presionar el
            // menuitem
            frmModTipUsr = null;
        }
        #endregion
        #region Modificar Departamento
        private void frmModDep_FormOpen()
        {
            // Abre el formulario, si está establecido en null
            // Esto para evitar que se ejecute más de una instancia
            if (frmModDep == null)
            {
                frmModDep = new frm_Man_Departamentos(frm_Man_Departamentos.Accion.Modificar);
                frmModDep.MdiParent = MdiParent;
                frmModDep.FormClosed +=
                    new FormClosedEventHandler(frmModDep_FormClosed);
                frmModDep.Show();
            }
            else
            {
                // Si ya está abierto el formulario se activa
                frmModDep.Activate();
            }
        }
        private void frmModDep_FormClosed(object sender,
            FormClosedEventArgs e)
        {
            // Cuando se cierre el formulario se establece en null
            // para que pueda volver a ser abierto al presionar el
            // menuitem
            frmModDep = null;
        }
        #endregion
        #region Modificar Persona
        private void frmModPersona_FormOpen()
        {
            // Abre el formulario, si está establecido en null
            // Esto para evitar que se ejecute más de una instancia
            if (frmModPersona == null)
            {
                frmModPersona = new frm_Man_Persona(frm_Man_Persona.Accion.Modificar);
                frmModPersona.MdiParent = MdiParent;
                frmModPersona.FormClosed +=
                    new FormClosedEventHandler(frmModPersona_FormClosed);
                frmModPersona.Show();
            }
            else
            {
                // Si ya está abierto el formulario se activa
                frmModPersona.Activate();
            }
        }
        private void frmModPersona_FormClosed(object sender,
            FormClosedEventArgs e)
        {
            // Cuando se cierre el formulario se establece en null
            // para que pueda volver a ser abierto al presionar el
            // menuitem
            frmModPersona = null;
        }
        #endregion
        #region Modificar Stock
        private void frmModStock_FormOpen()
        {
            // Abre el formulario, si está establecido en null
            // Esto para evitar que se ejecute más de una instancia
            if (frmModStock == null)
            {
                frmModStock = new frm_Man_Stock(frm_Man_Stock.Accion.Modificar);
                frmModStock.MdiParent = MdiParent;
                frmModStock.FormClosed +=
                    new FormClosedEventHandler(frmModStock_FormClosed);
                frmModStock.Show();
            }
            else
            {
                // Si ya está abierto el formulario se activa
                frmModStock.Activate();
            }
        }
        private void frmModStock_FormClosed(object sender,
            FormClosedEventArgs e)
        {
            // Cuando se cierre el formulario se establece en null
            // para que pueda volver a ser abierto al presionar el
            // menuitem
            frmModStock = null;
        }
        #endregion
        #region Modificar Productos
        private void frmModProductos_FormOpen()
        {
            // Abre el formulario, si está establecido en null
            // Esto para evitar que se ejecute más de una instancia
            if (frmModProductos == null)
            {
                frmModProductos = new frm_Man_Productos(frm_Man_Productos.Accion.Modificar);
                frmModProductos.MdiParent = MdiParent;
                frmModProductos.FormClosed +=
                    new FormClosedEventHandler(frmModProductos_FormClosed);
                frmModProductos.Show();
            }
            else
            {
                // Si ya está abierto el formulario se activa
                frmModProductos.Activate();
            }
        }
        private void frmModProductos_FormClosed(object sender,
            FormClosedEventArgs e)
        {
            // Cuando se cierre el formulario se establece en null
            // para que pueda volver a ser abierto al presionar el
            // menuitem
            frmModProductos = null;
        }
        #endregion

        #region Modificar Contrato
        private void frmModContratos_FormOpen()
        {
            // Abre el formulario, si está establecido en null
            // Esto para evitar que se ejecute más de una instancia
            if (frmModContratos == null)
            {
                frmModContratos = new frm_Man_Contrato(frm_Man_Contrato.Accion.Modificar);
                frmModContratos.MdiParent = MdiParent;
                frmModContratos.FormClosed +=
                    new FormClosedEventHandler(frmModContratos_FormClosed);
                frmModContratos.Show();
            }
            else
            {
                // Si ya está abierto el formulario se activa
                frmModContratos.Activate();
            }
        }
        private void frmModContratos_FormClosed(object sender,
            FormClosedEventArgs e)
        {
            // Cuando se cierre el formulario se establece en null
            // para que pueda volver a ser abierto al presionar el
            // menuitem
            frmModContratos = null;
        }
        #endregion

        #endregion

        #region Eliminar
        private void mniEliminar_Click(object sender, EventArgs e)
        {
            switch (_mMantenimiento)
            {
                case Mantenimiento.Usuarios:
                    frmDelUsr_FormOpen();
                    break;
                case Mantenimiento.TipoUsuario:
                    frmDelTipUsr_FormOpen();
                    break;
                case Mantenimiento.Departamento:
                    frmDelDep_FormOpen();
                    break;
                case Mantenimiento.Persona:
                    frmDelPersona_FormOpen();
                    break;
                case Mantenimiento.Stock:
                    frmDelStock_FormOpen();
                    break;
                case Mantenimiento.Productos:
                    frmDelProductos_FormOpen();
                    break;
                case Mantenimiento.Contrato:
                    frmDelContratos_FormOpen();
                    break;
                default:
                    break;
            }
        }
        #region Eliminar Usuario
        private void frmDelUsr_FormOpen()
        {
            // Abre el formulario, si está establecido en null
            // Esto para evitar que se ejecute más de una instancia
            if (frmDelUsr == null)
            {
                frmDelUsr = new frm_Man_Usuario(frm_Man_Usuario.Accion.Eliminar);
                frmDelUsr.MdiParent = MdiParent;
                frmDelUsr.FormClosed +=
                    new FormClosedEventHandler(frmDelUsr_FormClosed);
                frmDelUsr.Show();
            }
            else
            {
                // Si ya está abierto el formulario se activa
                frmDelUsr.Activate();
            }
        }
        private void frmDelUsr_FormClosed(object sender,
            FormClosedEventArgs e)
        {
            // Cuando se cierre el formulario se establece en null
            // para que pueda volver a ser abierto al presionar el
            // menuitem
            frmDelUsr = null;
        }
        #endregion
        #region Eliminar Tipo de Usuario
        private void frmDelTipUsr_FormOpen()
        {
            // Abre el formulario, si está establecido en null
            // Esto para evitar que se ejecute más de una instancia
            if (frmDelTipUsr == null)
            {
                frmDelTipUsr = new frm_Man_Perfiles(frm_Man_Perfiles.Accion.Eliminar);
                frmDelTipUsr.MdiParent = MdiParent;
                frmDelTipUsr.FormClosed +=
                    new FormClosedEventHandler(frmDelTipUsr_FormClosed);
                frmDelTipUsr.Show();
            }
            else
            {
                // Si ya está abierto el formulario se activa
                frmDelTipUsr.Activate();
            }
        }
        private void frmDelTipUsr_FormClosed(object sender,
            FormClosedEventArgs e)
        {
            // Cuando se cierre el formulario se establece en null
            // para que pueda volver a ser abierto al presionar el
            // menuitem
            frmDelTipUsr = null;
        }
        #endregion
        #region Eliminar Departamento
        private void frmDelDep_FormOpen()
        {
            // Abre el formulario, si está establecido en null
            // Esto para evitar que se ejecute más de una instancia
            if (frmDelDep == null)
            {
                frmDelDep = new frm_Man_Departamentos(frm_Man_Departamentos.Accion.Eliminar);
                frmDelDep.MdiParent = MdiParent;
                frmDelDep.FormClosed +=
                    new FormClosedEventHandler(frmDelDep_FormClosed);
                frmDelDep.Show();
            }
            else
            {
                // Si ya está abierto el formulario se activa
                frmDelDep.Activate();
            }
        }
        private void frmDelDep_FormClosed(object sender,
            FormClosedEventArgs e)
        {
            // Cuando se cierre el formulario se establece en null
            // para que pueda volver a ser abierto al presionar el
            // menuitem
            frmDelDep = null;
        }
        #endregion
        #region Eliminar Persona
        private void frmDelPersona_FormOpen()
        {
            // Abre el formulario, si está establecido en null
            // Esto para evitar que se ejecute más de una instancia
            if (frmDelPersona == null)
            {
                frmDelPersona = new frm_Man_Persona(frm_Man_Persona.Accion.Eliminar);
                frmDelPersona.MdiParent = MdiParent;
                frmDelPersona.FormClosed +=
                    new FormClosedEventHandler(frmDelPersona_FormClosed);
                frmDelPersona.Show();
            }
            else
            {
                // Si ya está abierto el formulario se activa
                frmDelPersona.Activate();
            }
        }
        private void frmDelPersona_FormClosed(object sender,
            FormClosedEventArgs e)
        {
            // Cuando se cierre el formulario se establece en null
            // para que pueda volver a ser abierto al presionar el
            // menuitem
            frmDelPersona = null;
        }
        #endregion
        #region Eliminar Stock
        private void frmDelStock_FormOpen()
        {
            // Abre el formulario, si está establecido en null
            // Esto para evitar que se ejecute más de una instancia
            if (frmDelStock == null)
            {
                frmDelStock = new frm_Man_Stock(frm_Man_Stock.Accion.Eliminar);
                frmDelStock.MdiParent = MdiParent;
                frmDelStock.FormClosed +=
                    new FormClosedEventHandler(frmDelStock_FormClosed);
                frmDelStock.Show();
            }
            else
            {
                // Si ya está abierto el formulario se activa
                frmDelStock.Activate();
            }
        }
        private void frmDelStock_FormClosed(object sender,
            FormClosedEventArgs e)
        {
            // Cuando se cierre el formulario se establece en null
            // para que pueda volver a ser abierto al presionar el
            // menuitem
            frmDelStock = null;
        }
        #endregion
        #region Eliminar Productos
        private void frmDelProductos_FormOpen()
        {
            // Abre el formulario, si está establecido en null
            // Esto para evitar que se ejecute más de una instancia
            if (frmDelProductos == null)
            {
                frmDelProductos = new frm_Man_Productos(frm_Man_Productos.Accion.Eliminar);
                frmDelProductos.MdiParent = MdiParent;
                frmDelProductos.FormClosed +=
                    new FormClosedEventHandler(frmDelProductos_FormClosed);
                frmDelProductos.Show();
            }
            else
            {
                // Si ya está abierto el formulario se activa
                frmDelProductos.Activate();
            }
        }
        private void frmDelProductos_FormClosed(object sender,
            FormClosedEventArgs e)
        {
            // Cuando se cierre el formulario se establece en null
            // para que pueda volver a ser abierto al presionar el
            // menuitem
            frmDelProductos = null;
        }
        #endregion

        #region Eliminar Contrato
        private void frmDelContratos_FormOpen()
        {
            // Abre el formulario, si está establecido en null
            // Esto para evitar que se ejecute más de una instancia
            if (frmDelContratos == null)
            {
                frmDelContratos = new frm_Man_Contrato(frm_Man_Contrato.Accion.Eliminar);
                frmDelContratos.MdiParent = MdiParent;
                frmDelContratos.FormClosed +=
                    new FormClosedEventHandler(frmDelContratos_FormClosed);
                frmDelContratos.Show();
            }
            else
            {
                // Si ya está abierto el formulario se activa
                frmDelContratos.Activate();
            }
        }
        private void frmDelContratos_FormClosed(object sender,
            FormClosedEventArgs e)
        {
            // Cuando se cierre el formulario se establece en null
            // para que pueda volver a ser abierto al presionar el
            // menuitem
            frmDelContratos = null;
        }
        #endregion
        #endregion
    }
}
