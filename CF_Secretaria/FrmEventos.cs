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

            abaList.Show();

            grEventos.DataSource = new EventoDAO().GetAllEventos();
            
        }

        protected void btnSalvar_Click(object sender, EventArgs e)
        {
            Evento oEvento = new Evento();
            oEvento.DataFim = Convert.ToDateTime(dtFinal.Value);
            oEvento.DataInicio = Convert.ToDateTime(dtFinal.Value);
            oEvento.MotoClube = txtMotoclube.Text;

            new EventoDAO().SalvarEvento(oEvento);

            abaList.Show();
                        
        }

        protected void btnNovo_Click(object sender, EventArgs e)
        {
            //pnEventosList.Visible = false;
            //pnFormEventos.Visible = true;

            abaForm.Show();

            txtMotoclube.Text = 
            dtFinal.Text = 
            dtInicio.Text = string.Empty;            
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            abaList.Show();
        }

        protected void btnEditar_Click(object sender, EventArgs e)
        {
            List<Evento> oListEventos = new List<Evento>();
            oListEventos = ((List<Evento>)grEventos.DataSource);
            Evento oEventos = oListEventos[grEventos.SelectedRows[0].Index];

            abaForm.Show();

            txtMotoclube.Text = oEventos.MotoClube;
            dtFinal.Value = oEventos.DataFim;
            dtInicio.Value = oEventos.DataInicio;
        }
    }
}
