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
    public partial class FrmIntegrante : Form
    {
        Integrante oIntegrante = new Integrante();
        public FrmIntegrante()
        {
            InitializeComponent();

            tabControl.SelectedIndex = 0;

            grEventos.DataSource = new IntegranteDAO().GetAllIntegrantes();
            

            //POPULANDO AS FACÇÕES
            cbFaccao.DataSource = new FaccaoDAO().GetAllFaccao();
            cbFaccao.DisplayMember = "FaccaoNome";
            cbFaccao.ValueMember = "FaccaoID";
            
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 1;

            oIntegrante = new Integrante();

            txtCelular.Text =
            txtCep.Text =
            txtCidade.Text =
            txtEstado.Text =
            txtLogradouro.Text =
            txtNome.Text =
            txtTelefone.Text = string.Empty;

            cbHierarquia.SelectedIndex = 0;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            //POPULANDO OS INTEGRANTES
            oIntegrante.Celular = txtCelular.Text;
            oIntegrante.Hierarquia = (EscudoEnum)(Convert.ToInt16(cbHierarquia.SelectedValue));
            oIntegrante.Name = txtNome.Text;
            oIntegrante.Telefone = txtTelefone.Text;

            //POPULANDO OS ENDEREÇOS
            Endereco oEndereco = new Endereco();
            oEndereco.CEP = txtCep.Text;
            oEndereco.Cidade = txtCidade.Text;
            oEndereco.Estado = txtEstado.Text;
            oEndereco.Logradouro = txtLogradouro.Text;
            oIntegrante.oEndereco = oEndereco;

            //POPULANDO A FACÇÃO
            List<Faccao> oListFaccao = (List<Faccao>)cbFaccao.DataSource;
            oIntegrante.oFaccao = oListFaccao[cbFaccao.SelectedIndex];

            new IntegranteDAO().SalvarIntegrante(oIntegrante);
            
            MessageBox.Show("Integrante Salvo com Sucesso!");

            tabControl.SelectedIndex = 0;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 0;  
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            //POPULANDO O FORM - INTEGRANTES
            List<Integrante> oListIntegrantes = new List<Integrante>();
            oListIntegrantes = ((List<Integrante>)grEventos.DataSource);
            oIntegrante = oListIntegrantes[grEventos.SelectedRows[0].Index];

            tabControl.SelectedIndex = 1;

            txtCelular.Text = oIntegrante.Celular;
            txtCep.Text = oIntegrante.oEndereco.CEP;
            txtCidade.Text = oIntegrante.oEndereco.Cidade;
            txtEstado.Text = oIntegrante.oEndereco.Estado;
            txtLogradouro.Text = oIntegrante.oEndereco.Logradouro;
            txtNome.Text = oIntegrante.Name;
            txtTelefone.Text = oIntegrante.Telefone;

            List<Faccao> oListFaccao = (List<Faccao>)cbFaccao.DataSource;
            int FaccaoID = oIntegrante.oFaccao.FaccaoID;

            foreach (Faccao oFaccao in oListFaccao)
            {
                if (oFaccao.FaccaoID == FaccaoID)
                {
                    oIntegrante.oFaccao = oFaccao;
                }
            }

            cbHierarquia.SelectedIndex = (short)oIntegrante.Hierarquia;
            cbFaccao.SelectedIndex = cbFaccao.Items.IndexOf(oIntegrante.oFaccao);
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            List<Integrante> oListIntegrantes = new List<Integrante>();
            oListIntegrantes = ((List<Integrante>)grEventos.DataSource);
            oIntegrante = oListIntegrantes[grEventos.SelectedRows[0].Index];

            new IntegranteDAO().ExcluirIntegrante(oIntegrante);

            MessageBox.Show("Integrante Excluido com Sucesso!");
        }
    }
}
