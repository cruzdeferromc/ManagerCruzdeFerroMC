using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CruzdeFerroSecretaria.Library;


namespace CF_Secretaria
{
    public partial class FrmEvento : Form
    {
        public FrmEvento()
        {
            InitializeComponent();
            //pnFormEventos.Visible = false;
            //pnEventosList.Visible = true;
        }

        protected void btnSalvar_Click(object sender, EventArgs e)
        {
            Evento oEvento = new Evento();
            oEvento.DataFim = Convert.ToDateTime(dtFinal.Value);
            oEvento.DataInicio = Convert.ToDateTime(dtFinal.Value);
            oEvento.MotoClube = txtMotoclube.Text;

            new EventoDAO().SalvarEvento(oEvento);

            pnFormEventos.Visible = false;
            
        }

        protected void btnNovo_Click(object sender, EventArgs e)
        {
            pnEventosList.Visible = false;
            pnFormEventos.Visible = true;
            

            txtMotoclube.Text = 
            dtFinal.Text = 
            dtInicio.Text = string.Empty;

            
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            pnEventosList.Visible = false;
            pnFormEventos.Visible = true;
        }

        protected void btnEditar_Click(object sender, EventArgs e)
        {
            //Evento oEvento = new Evento(grEventos.SelectedRows);
        }

       


    }
}
