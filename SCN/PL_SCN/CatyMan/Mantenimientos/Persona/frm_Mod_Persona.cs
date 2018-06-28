using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PL_SCN.CatyMan.Mantenimientos.Persona
{
    public partial class frm_Mod_Persona : Form
    {
        public frm_Mod_Persona()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("El registro se modificó con exito!!!", "Modificar registro",
            MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
        }
    }
}
