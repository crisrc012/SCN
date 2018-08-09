namespace DAL_SCN.Catalogos_Mantenimientos
{
    public class Cls_T_Perfil_DAL
    {
        private int _iID_Perfil;
        private char _cID_Estado;
        private string _sDescripcion, _sMsjError, _sAx;
        private bool _bEstAx;

        public int iID_Perfil
        {
            get
            {
                return _iID_Perfil;
            }

            set
            {
                _iID_Perfil = value;
            }
        }

        public char cID_Estado
        {
            get
            {
                return _cID_Estado;
            }

            set
            {
                _cID_Estado = value;
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

        public string sAx
        {
            get
            {
                return _sAx;
            }

            set
            {
                _sAx = value;
            }
        }

        public bool bEstAx
        {
            get
            {
                return _bEstAx;
            }

            set
            {
                _bEstAx = value;
            }
        }

        public string sDescripcion
        {
            get
            {
                return _sDescripcion;
            }

            set
            {
                _sDescripcion = value;
            }
        }
    }
}
