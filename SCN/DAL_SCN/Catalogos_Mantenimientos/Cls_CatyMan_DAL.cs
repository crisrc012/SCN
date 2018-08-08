namespace DAL_SCN.Catalogos_Mantenimientos
{
    public class Cls_CatyMan_DAL
    {
        private string _sMsjError;
        public System.Data.DataSet Obj_DS = new System.Data.DataSet();

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
    }
}
