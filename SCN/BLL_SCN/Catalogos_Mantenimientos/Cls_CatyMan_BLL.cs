using BLL_SCN.BD;
using DAL_SCN.BD;
using DAL_SCN.Catalogos_Mantenimientos;

namespace BLL_SCN.Catalogos_Mantenimientos
{
    public class Cls_CatyMan_BLL
    {
        public void listar_Cat_Man(ref Cls_CatyMan_DAL Obj_CatyMan_DAL, string sSentencia)
        {
            Cls_BD_BLL Obj_BD_BLL = new Cls_BD_BLL();
            Cls_BD_DAL Obj_BD_DAL = new Cls_BD_DAL();
            // Esta nombre es el del datatable, no tiene que se el nombre real
            Obj_BD_DAL.sNombreTabla = "Tbl";
            Obj_BD_DAL.sSentencia = "SP_LISTAR_" + sSentencia;
            Obj_BD_BLL.Ejecutar_adapter(ref Obj_BD_DAL);
            if (Obj_BD_DAL.sMsjError == string.Empty)
            {
                Obj_CatyMan_DAL.sMsjError = string.Empty;
                Obj_CatyMan_DAL.Obj_DS = Obj_BD_DAL.Obj_DS;
            }
            else
            {
                Obj_CatyMan_DAL.sMsjError = Obj_BD_DAL.sMsjError;
                Obj_CatyMan_DAL.Obj_DS = null;
            }
        }
        public void filtrar_Cat_Man(ref Cls_CatyMan_DAL Obj_CatyMan_DAL,
            string sFiltro, string sSentencia, string sParam)
        {
            Cls_BD_BLL Obj_BD_BLL = new Cls_BD_BLL();
            Cls_BD_DAL Obj_BD_DAL = new Cls_BD_DAL();
            Obj_BD_DAL.sNombreTabla = "Tbl";
            Obj_BD_DAL.sSentencia = "SP_FILTRAR_" + sSentencia;
            Obj_BD_BLL.Crear_DT_Parametros(ref Obj_BD_DAL);
            Obj_BD_DAL.Obj_DT_Param.Rows.Add(sParam, 1, sFiltro);
            Obj_BD_BLL.Ejecutar_adapter(ref Obj_BD_DAL);
            if (Obj_BD_DAL.sMsjError == string.Empty)
            {
                Obj_CatyMan_DAL.sMsjError = string.Empty;
                Obj_CatyMan_DAL.Obj_DS = Obj_BD_DAL.Obj_DS;

            }
            else
            {
                Obj_CatyMan_DAL.sMsjError = Obj_BD_DAL.sMsjError;
                Obj_CatyMan_DAL.Obj_DS = null;
            }
        }
        public void insertar_Cat_Man(ref Cls_CatyMan_DAL Obj_activo_DAL)
        {

        }
        public void modificar_Cat_Man(ref Cls_CatyMan_DAL Obj_activo_DAL)
        {

        }
        public void eliminar_activos(ref Cls_CatyMan_DAL Obj_activo_DAL)
        {

        }
    }
}
