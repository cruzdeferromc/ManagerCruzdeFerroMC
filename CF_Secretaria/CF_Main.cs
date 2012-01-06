using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CF_Secretaria
{
    public partial class CF_Main : Form
    {
        public CF_Main()
        {
            InitializeComponent();
        }

        private void eVENTOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEvento oFrmEvento = new FrmEvento();
            oFrmEvento.Show();
        }

        private void iNTEGRANTESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmIntegrante oFrmIntegrante = new FrmIntegrante();
            oFrmIntegrante.Show();
        }

        private void fACÇÕESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmFaccao oFrmFacao = new FrmFaccao();
            oFrmFacao.Show();
        }

        private void rEUNIÃOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAta oFrmAta = new FrmAta();
            oFrmAta.Show();
        }
    }
}
