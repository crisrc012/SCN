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
                        foreach (System.Data.DataRow dr in Obj_bd_DAL.Obj_DT_Param.Rows)
                        {
                            Obj_bd_DAL.Obj_SQL_CMD.Parameters.Add(
                                dr[0].ToString(),
                                (System.Data.SqlDbType)Enum.Parse(typeof(System.Data.SqlDbType), dr[1].ToString(), true)).Value =
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

        public void Ejecutar_NonQuery(ref Cls_BD_DAL Obj_bd_DAL)
        {
            try
            {
                Obj_bd_DAL.sCadena = ConfigurationManager.ConnectionStrings["CNXSTRING"].ToString().Trim();
                Obj_bd_DAL.Obj_SQL_CNX = new SqlConnection(Obj_bd_DAL.sCadena);
                if (Obj_bd_DAL.Obj_SQL_CNX.State == System.Data.ConnectionState.Closed)
                {
                    Obj_bd_DAL.Obj_SQL_CNX.Open();
                    Obj_bd_DAL.Obj_SQL_CMD = new SqlCommand(Obj_bd_DAL.sSentencia, Obj_bd_DAL.Obj_SQL_CNX);
                    if (Obj_bd_DAL.Obj_DT_Param.Rows.Count >= 1)
                    {
                        foreach (System.Data.DataRow dr in Obj_bd_DAL.Obj_DT_Param.Rows)
                        {
                            Obj_bd_DAL.Obj_SQL_CMD.Parameters.Add(
                                dr[0].ToString(),
                                (System.Data.SqlDbType)Enum.Parse(typeof(System.Data.SqlDbType), dr[1].ToString(), true)).Value =
                                dr[2].ToString();
                        }
                        Obj_bd_DAL.Obj_SQL_CMD.CommandType = System.Data.CommandType.StoredProcedure;

                        Obj_bd_DAL.Obj_SQL_CMD.ExecuteNonQuery();
                    }
                    Obj_bd_DAL.sMsjError = string.Empty;
                }
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

        public void Ejecutar_Scalar(ref Cls_BD_DAL Obj_BD_DAL)
        {
            // Devuelve un valor numérico
            try
            {
                Obj_BD_DAL.sCadena = ConfigurationManager.ConnectionStrings["CNXSTRING"].ToString().Trim();
                Obj_BD_DAL.Obj_SQL_CNX = new SqlConnection(Obj_BD_DAL.sCadena);
                if (Obj_BD_DAL.Obj_SQL_CNX.State == System.Data.ConnectionState.Closed)
                {
                    Obj_BD_DAL.Obj_SQL_CNX.Open();
                    Obj_BD_DAL.Obj_SQL_CMD = new SqlCommand(Obj_BD_DAL.sSentencia, Obj_BD_DAL.Obj_SQL_CNX);
                    if (Obj_BD_DAL.Obj_DT_Param.Rows.Count >= 1)
                    {
                        foreach (System.Data.DataRow dr in Obj_BD_DAL.Obj_DT_Param.Rows)
                        {
                            Obj_BD_DAL.Obj_SQL_CMD.Parameters.Add(
                                dr[0].ToString(),
                                (System.Data.SqlDbType)Enum.Parse(typeof(System.Data.SqlDbType), dr[1].ToString(), true)).Value = 
                                dr[2].ToString();
                        }
                    }
                    // Se especifica que sólo se puede ejecutar procedimientos almacenados
                    Obj_BD_DAL.Obj_SQL_CMD.CommandType = System.Data.CommandType.StoredProcedure;
                    // Se ejecuta y no devuelve ningún dato
                    Obj_BD_DAL.iValorScalar = Convert.ToInt32(Obj_BD_DAL.Obj_SQL_CMD.ExecuteScalar().ToString());
                }
                Obj_BD_DAL.sMsjError = string.Empty;
            }
            catch (SqlException ex)
            {
                Obj_BD_DAL.sMsjError = ex.Message.ToString();
            }
            finally
            {
                // si el objeto no es nulo
                if (Obj_BD_DAL.Obj_SQL_CNX != null)
                {
                    // comprueba si está abrierta para cerrarla
                    if (Obj_BD_DAL.Obj_SQL_CNX.State == System.Data.ConnectionState.Open)
                    {
                        Obj_BD_DAL.Obj_SQL_CNX.Close();
                    }
                    // Destruye el objeto
                    Obj_BD_DAL.Obj_SQL_CNX.Dispose();
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
