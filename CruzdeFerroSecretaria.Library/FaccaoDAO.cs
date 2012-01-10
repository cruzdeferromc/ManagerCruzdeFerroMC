using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace CruzdeFerroSecretaria.Library
{
    public class FaccaoDAO
    {
        #region METHODS FACCAO
        /// <summary>
        /// FACCAO
        /// Salvando os Faccaos
        /// </summary>
        /// <param name="oFaccao">Objeto de Faccao</param>
        public void SalvarFaccao(Faccao oFaccao)
        {
            short PossuiSede = 0;
            if (oFaccao.PossuiSede)
                PossuiSede = 1;
            else
                PossuiSede = 0;

            //Sql de update dos Eventos
            if (oFaccao.FaccaoID != 0)
                CFConexao.ExecSQL(String.Format("UPDATE cfFaccao SET cfFaccaoCidade = '{0}', cfFaccaoEmail = '{1}', cfFaccaoPossuiSede = {2},cfFaccaoLogradouro = '{3}',cfFaccaoCep = '{4}',cfFaccaoEstado = '{5}' WHERE cfFaccaoID = {6}", oFaccao.EnderecoSede.Cidade, oFaccao.Email, PossuiSede, oFaccao.EnderecoSede.Logradouro, oFaccao.EnderecoSede.CEP, oFaccao.EnderecoSede.Estado, oFaccao.FaccaoID));

            //Sql de Inserção dos Eventos
            else
                CFConexao.ExecSQL(String.Format("INSERT INTO cfFaccao VALUES('{0}','{1}',{2},'{3}','{4}','{5}')", oFaccao.EnderecoSede.Cidade, oFaccao.Email, PossuiSede, oFaccao.EnderecoSede.Logradouro, oFaccao.EnderecoSede.CEP, oFaccao.EnderecoSede.Estado));
        }

        /// <summary>
        /// FACCAO
        /// GetAll Faccaos
        /// </summary>
        /// <returns>Lista de Faccaos Retornados</returns>
        public List<Faccao> GetAllFaccao()
        {
            //Sql de busca dos Faccaos
            SqlDataReader oReader = CFConexao.ExecuteSelect("SELECT * FROM cfFaccao");

            //Retornando os Eventos
            List<Faccao> oListFaccaos = new List<Faccao>();
            while (oReader.Read())
            {
                Faccao oFaccao = new Faccao();
                oFaccao.EnderecoSede = new Endereco();
                oFaccao.EnderecoSede.Cidade = oReader["cfFaccaoCidade"].ToString();
                oFaccao.Email = oReader["cfFaccaoEmail"].ToString();
                oFaccao.FaccaoID = Convert.ToInt32(oReader["cfFaccaoID"].ToString());
                oFaccao.PossuiSede = Convert.ToBoolean(oReader["cfFaccaoPossuiSede"].ToString());
                oFaccao.EnderecoSede.CEP = oReader["cfFaccaoCep"].ToString();
                oFaccao.EnderecoSede.Estado = oReader["cfFaccaoEstado"].ToString();
                oFaccao.EnderecoSede.Logradouro = oReader["cfFaccaoLogradouro"].ToString();


                oListFaccaos.Add(oFaccao);
            }

            oReader.Close();
            CFConexao.Conexao.Close();

            return oListFaccaos;
        }

        /// <summary>
        /// FACCAO
        /// Excluir Faccao
        /// </summary>
        /// <param name="oEvento">Objeto de Faccao</param>
        public void ExcluirFaccao(Faccao oFaccao)
        {
            //Sql de excluir das Faccoes
            CFConexao.ExecSQL(String.Format("DELETE FROM cfFaccao WHERE cfFaccaoID = {0}", oFaccao.FaccaoID));
        }
        #endregion
    }
}
