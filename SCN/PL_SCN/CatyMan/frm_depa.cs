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
    public partial class frm_depa : Form
    {
        public frm_depa()
        {
            InitializeComponent();
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            PL_SCN.CatyMan.Mantenimientos.Departamentos.frm_Add_Depa frmAddDep = new Mantenimientos.Departamentos.frm_Add_Depa();
            frmAddDep.ShowDialog();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            PL_SCN.CatyMan.Mantenimientos.Departamentos.frm_Mod_Depa frmModDep = new Mantenimientos.Departamentos.frm_Mod_Depa();
            frmModDep.ShowDialog();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            PL_SCN.CatyMan.Mantenimientos.Departamentos.frm_Del_Depa frmDelDep = new Mantenimientos.Departamentos.frm_Del_Depa();
            frmDelDep.ShowDialog();
        }
    }
}
