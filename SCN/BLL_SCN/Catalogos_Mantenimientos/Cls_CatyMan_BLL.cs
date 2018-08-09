using BLL_SCN.BD;
using DAL_SCN.BD;
using DAL_SCN.Catalogos_Mantenimientos;

namespace BLL_SCN.Catalogos_Mantenimientos
{
    public class Cls_CatyMan_BLL
    {
        private Cls_BD_BLL Obj_BD_BLL;
        public Cls_CatyMan_BLL()
        {
            Obj_BD_BLL = new Cls_BD_BLL();
        }
        private void consultar(ref Cls_CatyMan_DAL Obj_CatyMan_DAL,
            string sFiltro, string sSentencia, string sParam)
        {
            Cls_BD_DAL Obj_BD_DAL = new Cls_BD_DAL();
            Obj_BD_DAL.sNombreTabla = "Tbl";
            if (sParam != null && sFiltro != null)
            {
                Obj_BD_DAL.sSentencia = "SP_FILTRAR_" + sSentencia;
                Obj_BD_DAL.Obj_DT_Param.Rows.Add(sParam, 1, sFiltro);
            }
            else
            {
                Obj_BD_DAL.sSentencia = "SP_LISTAR_" + sSentencia;
            }
            Obj_BD_BLL.Crear_DT_Parametros(ref Obj_BD_DAL);
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
        public void listar_Cat_Man(ref Cls_CatyMan_DAL Obj_CatyMan_DAL, string sSentencia)
        {
            consultar(ref Obj_CatyMan_DAL, null, sSentencia, null);
        }
        public void filtrar_Cat_Man(ref Cls_CatyMan_DAL Obj_CatyMan_DAL,
            string sFiltro, string sSentencia, string sParam)
        {
            consultar(ref Obj_CatyMan_DAL, sFiltro, sSentencia, sParam);
        }
    }
}
