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
    public partial class frm_Add_Usuario : Form
    {
        public frm_Add_Usuario()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("El registro se Agregó con exito!!!", "Agregar registro",
                                    MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
        }
    }
}
