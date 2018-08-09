using PL_SCN.CatyMan.Mantenimientos.Usuario;
using PL_SCN.CatyMan.Mantenimientos.Perfiles;
using PL_SCN.CatyMan.Mantenimientos.Departamentos;
using PL_SCN.CatyMan.Mantenimientos.Persona;
using PL_SCN.CatyMan.Mantenimientos.Inventario;
using PL_SCN.CatyMan.Mantenimientos.Contrato;
using System;
using System.Windows.Forms;
using DAL_SCN.Catalogos_Mantenimientos;
using BLL_SCN.Catalogos_Mantenimientos;

namespace PL_SCN.CatyMan
{
    public partial class frmCatalogo : Form
    {
        #region frmObjetos
        private frm_Man_Usuario       frmAddUsr, frmModUsr;
        private frm_Man_Perfiles      frmAddTipUsr, frmModTipUsr;
        private frm_Man_Departamentos frmAddDep, frmModDep;
        private frm_Man_Persona       frmAddPersona, frmModPersona;
        private frm_Man_Stock         frmAddStock, frmModStock;
        private frm_Man_Productos     frmAddProductos, frmModProductos;
        private frm_Man_Contrato      frmAddContratos, frmModContratos;
        private frm_Pago_Comisiones   frmAddPagoComisiones;
        private frm_Cobro             frmAddCobro, frmModCobro;
        #endregion

        public enum Mantenimiento
        {
            Usuarios, TipoUsuario, Departamento,
            Persona, Suscripciones, Productos,
            Stock, Contrato, Pago_Comisiones,
            Cobro, Estados
        }

        #region Variables para el control de BD
        private string _sSentencia, _sParam;
        private Cls_CatyMan_BLL _Obj_CatyMan_BLL = new Cls_CatyMan_BLL();
        private Cls_CatyMan_DAL _Obj_CatyMan_DAL;
        #endregion

        private Mantenimiento _mMantenimiento;
        public frmCatalogo(Mantenimiento _mMantenimiento, string _sSentencia, string _sParam)
        {
            InitializeComponent();
            this._mMantenimiento = _mMantenimiento;
            this._sSentencia = _sSentencia;
            this._sParam = _sParam;
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
                case Mantenimiento.Cobro:
                    Text = "Mantenimiento de Cobros";
                    mniEliminar.Visible = false;
                    mniEliminar.Enabled = false;
                    break;
                default:
                    break;
            }
            cargarDataGrid();
        }

        private void cargarDataGrid()
        {
            _Obj_CatyMan_DAL = new Cls_CatyMan_DAL();
            if (tstxtFiltrar.Text == string.Empty)
            {
                _Obj_CatyMan_BLL.listar_Cat_Man(ref _Obj_CatyMan_DAL, _sSentencia);
            }
            else
            {
                _Obj_CatyMan_BLL.filtrar_Cat_Man(ref _Obj_CatyMan_DAL,
                    tstxtFiltrar.Text.Trim(), _sSentencia, _sParam);
            }
            if (_Obj_CatyMan_DAL.sMsjError == string.Empty)
            {
                dgdDatos.DataSource = null;
                dgdDatos.DataSource = _Obj_CatyMan_DAL.Obj_DS.Tables[0];
            }
            else
            {
                dgdDatos.DataSource = null;
                MessageBox.Show("Se ha producido un error en tablas categorias \n\n Error: " +
                                _Obj_CatyMan_DAL.sMsjError, "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void mniSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void tstxtFiltrar_Click(object sender, EventArgs e)
        {
            cargarDataGrid();
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
                case Mantenimiento.Cobro:
                    frmAddCobro_FormOpen();
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
                frmAddTipUsr = new frm_Man_Perfiles(frm_Man_Perfiles.Accion.Agregar, null);
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
            cargarDataGrid();
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

        #region Agregar Cobro
        private void frmAddCobro_FormOpen()
        {
            // Abre el formulario, si está establecido en null
            // Esto para evitar que se ejecute más de una instancia
            if (frmAddCobro == null)
            {
                frmAddCobro = new frm_Cobro  (frm_Cobro.Accion.Agregar);
                frmAddCobro.MdiParent = MdiParent;
                frmAddCobro.FormClosed +=
                    new FormClosedEventHandler(frmAddCobro_FormClosed);
                frmAddCobro.Show();
            }
            else
            {
                // Si ya está abierto el formulario se activa
                frmAddCobro.Activate();
            }
        }
        private void frmAddCobro_FormClosed(object sender,
            FormClosedEventArgs e)
        {
            // Cuando se cierre el formulario se establece en null
            // para que pueda volver a ser abierto al presionar el
            // menuitem
            frmAddCobro = null;
        }
        #endregion

        #endregion

        #region Modificar
        private void mniModificar_Click(object sender, EventArgs e)
        {
            if (dgdDatos.SelectedRows.Count == 1)
            {
                switch (_mMantenimiento)
                {
                    case Mantenimiento.Usuarios:
                        frmModUsr_FormOpen();
                        break;
                    case Mantenimiento.TipoUsuario:
                        Cls_T_Perfil_DAL Obj_Perfil_DAL = new Cls_T_Perfil_DAL();
                        Obj_Perfil_DAL.iID_Perfil = Convert.ToInt32(dgdDatos.SelectedRows[0].Cells[0].Value);
                        Obj_Perfil_DAL.sDescripcion = Convert.ToString(dgdDatos.SelectedRows[0].Cells[1].Value);
                        Obj_Perfil_DAL.cID_Estado = Convert.ToChar(dgdDatos.SelectedRows[0].Cells[2].Value);
                        frmModTipUsr_FormOpen(Obj_Perfil_DAL);
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
                    case Mantenimiento.Cobro:
                        frmModCobro_FormOpen();
                        break;
                    default:
                        break;
                }
            }
            else
            {
                MessageBox.Show("Debe de seleccionar una fila.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        private void frmModTipUsr_FormOpen(Cls_T_Perfil_DAL Obj_Perfil_DAL)
        {
            // Abre el formulario, si está establecido en null
            // Esto para evitar que se ejecute más de una instancia
            if (frmModTipUsr == null)
            {
                frmModTipUsr = new frm_Man_Perfiles(frm_Man_Perfiles.Accion.Modificar, Obj_Perfil_DAL);
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
            cargarDataGrid();
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

        #region Modificar Cobro
        private void frmModCobro_FormOpen()
        {
            // Abre el formulario, si está establecido en null
            // Esto para evitar que se ejecute más de una instancia
            if (frmModContratos == null)
            {
                frmModCobro = new frm_Cobro(frm_Cobro.Accion.Modificar);
                frmModCobro.MdiParent = MdiParent;
                frmModCobro.FormClosed +=
                    new FormClosedEventHandler(frmModCobro_FormClosed);
                frmModCobro.Show();
            }
            else
            {
                // Si ya está abierto el formulario se activa
                frmModCobro.Activate();
            }
        }
        private void frmModCobro_FormClosed(object sender,
            FormClosedEventArgs e)
        {
            // Cuando se cierre el formulario se establece en null
            // para que pueda volver a ser abierto al presionar el
            // menuitem
            frmModCobro = null;
        }
        #endregion
        #endregion

        #region Eliminar
        private void mniEliminar_Click(object sender, EventArgs e)
        {
            Cls_CatyMan_BLL Obj_CatyMan_BLL = new Cls_CatyMan_BLL();
            Cls_CatyMan_DAL Obj_CatyMan_DAL = new Cls_CatyMan_DAL();
            if (dgdDatos.SelectedRows[0] != null)
            {
                //Obj_CatyMan_BLL.eliminar_Cat_Man(ref Obj_CatyMan_DAL);
                if (Obj_CatyMan_DAL.sMsjError != string.Empty)
                {
                    MessageBox.Show("Se presentó el siguiente error:\n\n" + Obj_CatyMan_DAL.sMsjError,
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    cargarDataGrid();
                }
            }
            ////
            if (dgdDatos.SelectedRows.Count == 1)
            {
                switch (_mMantenimiento)
                {
                    case Mantenimiento.Usuarios:
                        frmModUsr_FormOpen();
                        break;
                    case Mantenimiento.TipoUsuario:
                        Cls_T_Perfil_DAL Obj_Perfil_DAL = new Cls_T_Perfil_DAL();
                        Cls_T_Perfil_BLL Obj_Perfil_BLL = new Cls_T_Perfil_BLL();
                        Obj_Perfil_DAL.iID_Perfil = Convert.ToInt32(dgdDatos.SelectedRows[0].Cells[0].Value);
                        Obj_Perfil_BLL.eliminar_UsuarioPerfil(ref Obj_Perfil_DAL);
                        if (Obj_Perfil_DAL.bEstAx)
                        {
                            MessageBox.Show("OK");
                        }
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
                    case Mantenimiento.Cobro:
                        frmModCobro_FormOpen();
                        break;
                    default:
                        break;
                }
            }
            else
            {
                MessageBox.Show("Debe de seleccionar una fila.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion
    }
}
