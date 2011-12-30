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

        Evento oEvento = new Evento();
        public FrmEvento()
        {
            InitializeComponent();

            tabControl.SelectedIndex = 0;

            grEventos.DataSource = new EventoDAO().GetAllEventos();
            
        }

        protected void btnSalvar_Click(object sender, EventArgs e)
        {
            
            oEvento.DataFim = Convert.ToDateTime(dtFinal.Value);
            oEvento.DataInicio = Convert.ToDateTime(dtFinal.Value);
            oEvento.MotoClube = txtMotoclube.Text;
            oEvento.Entrada = txtEntrada.Text;

            Endereco oEndereco = new Endereco();
            oEndereco.CEP = txtCep.Text;
            oEndereco.Cidade = txtCidade.Text;
            oEndereco.Estado = txtEstado.Text;
            oEndereco.Logradouro = txtLogradouro.Text;

            oEvento.oEndereco = oEndereco;

            new EventoDAO().SalvarEvento(oEvento);

            MessageBox.Show("Evento Salvo com Sucesso!");

            tabControl.SelectedIndex = 0;
                        
        }

        protected void btnNovo_Click(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 1;

            oEvento = new Evento();

            txtMotoclube.Text =
            dtFinal.Text =
            txtCep.Text =
            txtCidade.Text =
            txtEntrada.Text =
            txtEstado.Text =
            txtLogradouro.Text =
            dtInicio.Text = string.Empty;
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 0;            
        }

        protected void btnEditar_Click(object sender, EventArgs e)
        {
            List<Evento> oListEventos = new List<Evento>();
            oListEventos = ((List<Evento>)grEventos.DataSource);
            oEvento = oListEventos[grEventos.SelectedRows[0].Index];

            tabControl.SelectedIndex = 1;

            txtMotoclube.Text = oEvento.MotoClube;
            dtFinal.Value = oEvento.DataFim;
            dtInicio.Value = oEvento.DataInicio;
            txtCep.Text = oEvento.oEndereco.CEP;
            txtCidade.Text = oEvento.oEndereco.Cidade;
            txtEntrada.Text = oEvento.Entrada;
            txtEstado.Text = oEvento.oEndereco.Estado;
            txtLogradouro.Text = oEvento.oEndereco.Logradouro;
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            List<Evento> oListEventos = new List<Evento>();
            oListEventos = ((List<Evento>)grEventos.DataSource);
            oEvento = oListEventos[grEventos.SelectedRows[0].Index];

            new EventoDAO().ExcluirEvento(oEvento);

            MessageBox.Show("Evento Excluido com Sucesso!");
        }

    }
}
