using System;
using System.Configuration;
using System.Data.SqlClient;
using DAL_SCN.BD;

namespace BLL_SCN.BD
{
    public class Cls_BD_BLL
    {
        public void Ejecutar_adapter(ref Cls_BD_DAL Obj_bd_DAL)
        {
            try
            {
                Obj_bd_DAL.sCadena = ConfigurationManager.ConnectionStrings["CNXSTRING"].ToString().Trim();
                Obj_bd_DAL.Obj_SQL_CNX = new SqlConnection(Obj_bd_DAL.sCadena);
                if (Obj_bd_DAL.Obj_SQL_CNX.State == System.Data.ConnectionState.Closed)
                {
                    Obj_bd_DAL.Obj_SQL_CNX.Open();
                    Obj_bd_DAL.Obj_SQL_DAP = new SqlDataAdapter(Obj_bd_DAL.sSentencia, Obj_bd_DAL.Obj_SQL_CNX);
                    if (Obj_bd_DAL.Obj_DT_Param.Rows.Count >= 1)
                    {
                        System.Data.SqlDbType Obj_TipoDato = System.Data.SqlDbType.NVarChar;
                        foreach (System.Data.DataRow dr in Obj_bd_DAL.Obj_DT_Param.Rows)
                        {
                            switch (dr[1].ToString())
                            {
                                case "1":
                                    Obj_TipoDato = System.Data.SqlDbType.NVarChar;
                                    break;
                                default:
                                    break;
                            }
                            Obj_bd_DAL.Obj_SQL_DAP.SelectCommand.Parameters.Add(dr[0].ToString(), Obj_TipoDato).Value =
                                dr[2].ToString();
                        }
                    }


                    Obj_bd_DAL.Obj_SQL_DAP.SelectCommand.CommandType = System.Data.CommandType.StoredProcedure;

                    Obj_bd_DAL.Obj_SQL_DAP.Fill(Obj_bd_DAL.Obj_DS, Obj_bd_DAL.sNombreTabla);
                }
                Obj_bd_DAL.sMsjError = string.Empty;
            }
            catch (Exception ex)
            {
                Obj_bd_DAL.sMsjError = ex.ToString();
            }
            finally
            {
                if (Obj_bd_DAL.Obj_SQL_CNX != null)
                {
                    if (Obj_bd_DAL.Obj_SQL_CNX.State == System.Data.ConnectionState.Open)
                    {
                        Obj_bd_DAL.Obj_SQL_CNX.Close();
                    }
                    Obj_bd_DAL.Obj_SQL_CNX.Dispose();
                }
            }

        }

        public void Crear_DT_Parametros(ref Cls_BD_DAL Obj_Conexion_DAL)
        {
            Obj_Conexion_DAL.Obj_DT_Param.Columns.Add("NombreParam");
            Obj_Conexion_DAL.Obj_DT_Param.Columns.Add("TipoDatoParam");
            Obj_Conexion_DAL.Obj_DT_Param.Columns.Add("ValorParam");
        }
    }
}
