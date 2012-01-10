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
    public partial class FrmAta : Form
    {
        List<string> oListAvisos = new List<string>();

        public FrmAta()
        {
            InitializeComponent();

            //POPULANDO AS FACCÕES
            cbFaccao.DataSource = new FaccaoDAO().GetAllFaccao();
            cbFaccao.DisplayMember = "FaccaoNome";
            cbFaccao.ValueMember = "FaccaoID";

            //LISTA DE AVISOS            
            grAvisos.DataSource = oListAvisos;

            //POPULANDO OS EVENTOS ATUAIS E PASSADOS 
            grEventosPassados.DataSource = new EventoDAO().GetAllEventosByMes(dtReuniao.Value.Month - 1);
            grEventosProximos.DataSource = new EventoDAO().GetAllEventosByMes(dtReuniao.Value.Month);

        }

        private void btnNovo_Click(object sender, EventArgs e)
        {

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {

        }

        private void cbFaccao_SelectedIndexChanged(object sender, EventArgs e)
        {
            //POPULANDO A CHAMADA PELA FACÇÃO
            cklIntegrantes.DataSource = new IntegranteDAO().GetAllIntegrantesbyFaccao(((Faccao)(((ComboBox)sender).SelectedItem)).FaccaoID);
            cklIntegrantes.DisplayMember = "Name";
            cklIntegrantes.ValueMember = "IntegranteID";
        }

        private void btnAvisoNovo_Click(object sender, EventArgs e)
        {
            //GERENCIANDO OS CONTROLES DE AVISOS
            rtAvisos.ReadOnly = false;
            btnAvisoCancelar.Enabled = btnAvisoSalvar.Enabled = true;
            btnAvisoEditar.Enabled = btnAvisoExcluir.Enabled = btnAvisoNovo.Enabled = false;
        }

        private void btnAvisoSalvar_Click(object sender, EventArgs e)
        {
            //ADICIONANDO O AVISO
            oListAvisos.Add(rtAvisos.Text);
            rtAvisos.Text = string.Empty;

            //REPOPULANDO A LISTA DE AVISOS 
            grAvisos.DataSource = oListAvisos;

            //GERENCIANDO OS CONTROLES DE AVISOS
            rtAvisos.ReadOnly = true;
            btnAvisoCancelar.Enabled = btnAvisoSalvar.Enabled = false;
            btnAvisoEditar.Enabled = btnAvisoExcluir.Enabled = btnAvisoNovo.Enabled = true;
        }

        private void btnAvisoEditar_Click(object sender, EventArgs e)
        {

        }

        private void btnAvisoCancelar_Click(object sender, EventArgs e)
        {
            //GERENCIANDO OS CONTROLES DE AVISOS
            rtAvisos.ReadOnly = true;
            btnAvisoCancelar.Enabled = btnAvisoSalvar.Enabled = false;
            btnAvisoEditar.Enabled = btnAvisoExcluir.Enabled = btnAvisoNovo.Enabled = true;
        }

        private void btnAvisoExcluir_Click(object sender, EventArgs e)
        {

        }
    }
}
