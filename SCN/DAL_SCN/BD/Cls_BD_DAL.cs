using System.Data.SqlClient;

namespace DAL_SCN.BD
{
    public class Cls_BD_DAL
    {
        #region Variables privadas
        private string _sCadena, _sMsjError, _sSentencia, _sNombreTabla;
        #endregion
        #region Objetos SQL públicos
        public SqlConnection Obj_SQL_CNX;
        public SqlCommand Obj_SQL_CMD;
        public SqlDataAdapter Obj_SQL_DAP;
        public System.Data.DataSet Obj_DS = new System.Data.DataSet();
        public System.Data.DataTable Obj_DT_Param = new System.Data.DataTable("PARAM");
        #endregion

        public string sCadena
        {
            get
            {
                return _sCadena;
            }

            set
            {
                _sCadena = value;
            }
        }

        public string sMsjError
        {
            get
            {
                return _sMsjError;
            }

            set
            {
                _sMsjError = value;
            }
        }

        public string sSentencia
        {
            get
            {
                return _sSentencia;
            }

            set
            {
                _sSentencia = value;
            }
        }

        public string sNombreTabla
        {
            get
            {
                return _sNombreTabla;
            }

            set
            {
                _sNombreTabla = value;
            }
        }
    }
}
