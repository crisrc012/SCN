using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PL_SCN.CatyMan.Mantenimientos.Usuario
{
    public partial class frm_Del_Usr : Form
    {
        public frm_Del_Usr()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("El registro se eliminó con exito!!!", "Eliminar registro",
                                   MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
