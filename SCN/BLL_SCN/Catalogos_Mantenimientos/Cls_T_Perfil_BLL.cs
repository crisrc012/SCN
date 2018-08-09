using BLL_SCN.BD;
using DAL_SCN.BD;
using DAL_SCN.Catalogos_Mantenimientos;

namespace BLL_SCN.Catalogos_Mantenimientos
{
    public class Cls_T_Perfil_BLL
    {
        public void insertar_UsuarioPerfil(ref Cls_T_Perfil_DAL Obj_UsuarioPerfil_DAL)
        {
            Cls_BD_BLL Obj_BD_BLL = new Cls_BD_BLL();
            Cls_BD_DAL Obj_BD_DAL = new Cls_BD_DAL();
            // Esta nombre es el del datatable, no tiene que se el nombre real
            Obj_BD_DAL.sNombreTabla = "";
            Obj_BD_DAL.sSentencia = "SP_INSERTAR_T_Perfil";
            Obj_BD_BLL.Crear_DT_Parametros(ref Obj_BD_DAL);
            Obj_BD_DAL.Obj_DT_Param.Rows.Add("@Descripcion", System.Data.SqlDbType.VarChar, Obj_UsuarioPerfil_DAL.sDescripcion);
            Obj_BD_DAL.Obj_DT_Param.Rows.Add("@ID_Estado", System.Data.SqlDbType.Char, Obj_UsuarioPerfil_DAL.cID_Estado);
            Obj_BD_BLL.Ejecutar_Scalar(ref Obj_BD_DAL);
            if (Obj_BD_DAL.sMsjError == string.Empty)
            {
                // Se obtiene el identificador creado
                Obj_UsuarioPerfil_DAL.iID_Perfil = Obj_BD_DAL.iValorScalar;
                Obj_UsuarioPerfil_DAL.sMsjError = string.Empty;
                Obj_UsuarioPerfil_DAL.bEstAx = true;
                Obj_UsuarioPerfil_DAL.sAx = "U";
            }
            else
            {
                Obj_UsuarioPerfil_DAL.sMsjError = Obj_BD_DAL.sMsjError;
                Obj_UsuarioPerfil_DAL.bEstAx = false;
                Obj_UsuarioPerfil_DAL.sAx = "I";
            }
        }
        public void modificar_UsuarioPerfil(ref Cls_T_Perfil_DAL Obj_UsuarioPerfil_DAL)
        {
            Cls_BD_BLL Obj_BD_BLL = new Cls_BD_BLL();
            Cls_BD_DAL Obj_BD_DAL = new Cls_BD_DAL();
            // Esta nombre es el del datatable, no tiene que se el nombre real
            Obj_BD_DAL.sNombreTabla = "Tbl";
            Obj_BD_DAL.sSentencia = "SP_MODIFICAR_T_Perfil";
            Obj_BD_BLL.Crear_DT_Parametros(ref Obj_BD_DAL);
            Obj_BD_DAL.Obj_DT_Param.Rows.Add("@ID_Perfil", System.Data.SqlDbType.Int, Obj_UsuarioPerfil_DAL.iID_Perfil);
            Obj_BD_DAL.Obj_DT_Param.Rows.Add("@Descripcion", System.Data.SqlDbType.VarChar, Obj_UsuarioPerfil_DAL.sDescripcion);
            Obj_BD_DAL.Obj_DT_Param.Rows.Add("@ID_Estado", System.Data.SqlDbType.Char, Obj_UsuarioPerfil_DAL.cID_Estado);
            Obj_BD_BLL.Ejecutar_NonQuery(ref Obj_BD_DAL);
            if (Obj_BD_DAL.sMsjError == string.Empty)
            {
                Obj_UsuarioPerfil_DAL.sMsjError = string.Empty;
                Obj_UsuarioPerfil_DAL.bEstAx = true;
                Obj_UsuarioPerfil_DAL.sAx = "U";
            }
            else
            {
                Obj_UsuarioPerfil_DAL.sMsjError = Obj_BD_DAL.sMsjError;
                Obj_UsuarioPerfil_DAL.bEstAx = false;
                Obj_UsuarioPerfil_DAL.sAx = "U";
            }
        }
        public void eliminar_UsuarioPerfil(ref Cls_T_Perfil_DAL Obj_UsuarioPerfil_DAL)
        {
            Cls_BD_BLL Obj_BD_BLL = new Cls_BD_BLL();
            Cls_BD_DAL Obj_BD_DAL = new Cls_BD_DAL();
            Obj_BD_DAL.sSentencia = "SP_ELIMINAR_T_Perfil";

            Obj_BD_BLL.Crear_DT_Parametros(ref Obj_BD_DAL);
            Obj_BD_DAL.Obj_DT_Param.Rows.Add("@ID_Perfil", System.Data.SqlDbType.Int, Obj_UsuarioPerfil_DAL.iID_Perfil);
            Obj_BD_BLL.Ejecutar_NonQuery(ref Obj_BD_DAL);
            if (Obj_BD_DAL.sMsjError == string.Empty)
            {
                Obj_UsuarioPerfil_DAL.sMsjError = string.Empty;
                Obj_UsuarioPerfil_DAL.bEstAx = true;
                Obj_UsuarioPerfil_DAL.sAx = "D";
            }
            else
            {
                Obj_UsuarioPerfil_DAL.sMsjError = Obj_BD_DAL.sMsjError;
                Obj_UsuarioPerfil_DAL.bEstAx = false;
                Obj_UsuarioPerfil_DAL.sAx = "D";
            }
        }
    }
}
