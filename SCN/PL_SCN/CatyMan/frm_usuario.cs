using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PL_SCN.CatyMan
{
    public partial class frm_usuario : Form
    {
        public frm_usuario()
        {
            InitializeComponent();
            toolStrip1.AutoSize = false;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            PL_SCN.CatyMan.Mantenimientos.Usuario.frm_Add_Usuario frmAddUsr = new Mantenimientos.Usuario.frm_Add_Usuario();
            frmAddUsr.ShowDialog();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            PL_SCN.CatyMan.Mantenimientos.Usuario.frm_Mod_Usr frmModUsr = new Mantenimientos.Usuario.frm_Mod_Usr();
            frmModUsr.ShowDialog();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            PL_SCN.CatyMan.Mantenimientos.Usuario.frm_Del_Usr frmDelUsr = new Mantenimientos.Usuario.frm_Del_Usr();
            frmDelUsr.ShowDialog();
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
