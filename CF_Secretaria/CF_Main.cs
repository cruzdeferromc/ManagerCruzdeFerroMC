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

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

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
    }
}
