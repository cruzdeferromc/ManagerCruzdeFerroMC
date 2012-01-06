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
    public partial class FrmFaccao : Form
    {
        Faccao oFaccao = new Faccao();
        public FrmFaccao()
        {
            InitializeComponent();

            tabControl.SelectedIndex = 0;

            grEventos.DataSource = new FaccaoDAO().GetAllFaccao();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 1;

            oFaccao = new Faccao();
            txtEmail.Text =
            txtCep.Text =
            txtCidade.Text =
            txtEstado.Text =
            txtLogradouro.Text = string.Empty;

            ckPossuiSede.Checked = false;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            List<Faccao> oListFaccaos = new List<Faccao>();
            oListFaccaos = ((List<Faccao>)grEventos.DataSource);
            oFaccao = oListFaccaos[grEventos.SelectedRows[0].Index];

            tabControl.SelectedIndex = 1;

            ckPossuiSede.Checked = oFaccao.PossuiSede;
            txtEmail.Text = oFaccao.Email;
            txtCep.Text = oFaccao.EnderecoSede.CEP;
            txtCidade.Text = oFaccao.EnderecoSede.Cidade;
            txtEstado.Text = oFaccao.EnderecoSede.Estado;
            txtLogradouro.Text = oFaccao.EnderecoSede.Logradouro;
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            List<Faccao> oListFaccaos = new List<Faccao>();
            oListFaccaos = ((List<Faccao>)grEventos.DataSource);
            oFaccao = oListFaccaos[grEventos.SelectedRows[0].Index];

            new FaccaoDAO().ExcluirFaccao(oFaccao);

            MessageBox.Show("Faccao Excluido com Sucesso!");
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            oFaccao.Email = txtEmail.Text;
            oFaccao.PossuiSede = ckPossuiSede.Checked;
            
            Endereco oEndereco = new Endereco();
            oEndereco.CEP = txtCep.Text;
            oEndereco.Cidade = txtCidade.Text;
            oEndereco.Estado = txtEstado.Text;
            oEndereco.Logradouro = txtLogradouro.Text;

            oFaccao.EnderecoSede = oEndereco;

            new FaccaoDAO().SalvarFaccao(oFaccao);

            MessageBox.Show("Facção Salva com Sucesso!");

            tabControl.SelectedIndex = 0;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 0; 
        }
    }
}
