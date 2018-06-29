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
    public partial class frm_perfiles : Form
    {
        public frm_perfiles()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            PL_SCN.CatyMan.Mantenimientos.Perfiles.frm_Add_Perfil frmAddPer = new Mantenimientos.Perfiles.frm_Add_Perfil();
            frmAddPer.ShowDialog();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            PL_SCN.CatyMan.Mantenimientos.Perfiles.frm_Mod_Perfil frmModPer = new Mantenimientos.Perfiles.frm_Mod_Perfil();
            frmModPer.ShowDialog();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            PL_SCN.CatyMan.Mantenimientos.Perfiles.frm_Del_Perfil frmDelPer = new Mantenimientos.Perfiles.frm_Del_Perfil();
            frmDelPer.ShowDialog();
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
