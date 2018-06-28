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
    public partial class frm_personas : Form
    {
        public frm_personas()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            PL_SCN.CatyMan.Mantenimientos.Persona.frm_Add_Persona addPer = new Mantenimientos.Persona.frm_Add_Persona();
            addPer.ShowDialog();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            PL_SCN.CatyMan.Mantenimientos.Persona.frm_Mod_Persona frmMod = new Mantenimientos.Persona.frm_Mod_Persona();
            frmMod.ShowDialog();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            PL_SCN.CatyMan.Mantenimientos.Persona.frm_Del_Persona frmDel = new Mantenimientos.Persona.frm_Del_Persona();
            frmDel.ShowDialog();
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
