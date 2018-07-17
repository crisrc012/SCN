using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PL_SCN.Soporte
{
    public partial class frm_Encuesta : Form
    {
        public frm_Encuesta()
        {
            InitializeComponent();
        }

        private void frm_Encuesta_Load(object sender, EventArgs e)
        {
            DateTime fechaActual = DateTime.Now;
            this.lbl_fechaActual.Text = fechaActual.ToString("d");
            rbt_UnoPreguntaUno.Select();
            rbt_UnoPreguntaDos.Select();
            rbt_UnoPreguntaTres.Select();
        }
    }
}
