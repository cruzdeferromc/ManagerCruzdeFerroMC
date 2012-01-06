using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace CruzdeFerroSecretaria.Library
{
    public class IntegranteDAO
    {
        #region METHODS INTEGRANTES
        /// <summary>
        /// INTEGRANTES
        /// Salvando os Integrantes
        /// </summary>
        /// <param name="oIntegrante">Objeto de Integrante</param>
        public void SalvarIntegrante(Integrante oIntegrante)
        {
            //Conexao
            SqlConnection oSqlConnection = new SqlConnection("packet size=4096;persist security info=TRUE;initial catalog=CF_Secretaria;user id=sa;password=123456;data source=LOVIEIRA-PC\\SQL_SOLUTIO42");
            oSqlConnection.Open();

            SqlCommand oSqlCommand = new SqlCommand();

            //Sql de update dos Eventos
            if (oIntegrante.IntegranteID != 0)
            {
                oSqlCommand = new SqlCommand(String.Format("UPDATE cfIntegrante SET cfIntegranteName = '{0}', cfIntegranteHierarquia = {1}, cfIntegranteCidade = '{2}', cfIntegranteLogradouro = '{3}', cfIntegranteCep = '{4}', cfIntegranteEstado = '{5}', cfIntegranteCelular = '{6}', cfIntegranteTelefone = '{7}', cfIntegranteFoto = '{8}', cfIntegrante_cfFaccaoID = {10}  WHERE cfIntegranteID = {9}", oIntegrante.Name, (short)oIntegrante.Hierarquia, oIntegrante.oEndereco.Cidade, oIntegrante.oEndereco.Logradouro, oIntegrante.oEndereco.CEP, oIntegrante.oEndereco.Estado, oIntegrante.Celular, oIntegrante.Telefone, oIntegrante.Foto, oIntegrante.IntegranteID, oIntegrante.oFaccao.FaccaoID), oSqlConnection);
            }
            //Sql de Inserção dos Eventos
            else
            {
                oSqlCommand = new SqlCommand(String.Format("INSERT INTO cfIntegrante VALUES('{0}',{1},'{2}','{3}','{4}','{5}','{6}','{7}','{8}',{9})", oIntegrante.Name, (short)oIntegrante.Hierarquia, oIntegrante.oEndereco.Cidade, oIntegrante.oEndereco.Logradouro, oIntegrante.oEndereco.CEP, oIntegrante.oEndereco.Estado, oIntegrante.Celular, oIntegrante.Telefone, oIntegrante.Foto, oIntegrante.oFaccao.FaccaoID), oSqlConnection);
            }
            oSqlCommand.ExecuteNonQuery();

            oSqlConnection.Close();
        }

        /// <summary>
        /// INTEGRANTES
        /// GetAll Integrantes
        /// </summary>
        /// <returns>Lista de Integrantes Retornados</returns>
        public List<Integrante> GetAllIntegrantes()
        {
            //Conexao
            SqlConnection oSqlConnection = new SqlConnection("packet size=4096;persist security info=TRUE;initial catalog=CF_Secretaria;user id=sa;password=123456;data source=LOVIEIRA-PC\\SQL_SOLUTIO42");
            oSqlConnection.Open();

            //Sql de busca dos Integrantes
            SqlCommand oSqlCommand = new SqlCommand("SELECT * FROM cfIntegrante", oSqlConnection);
            SqlDataReader oReader = oSqlCommand.ExecuteReader();

            //Retornando os Integrantes
            List<Integrante> oListIntegrantes = new List<Integrante>();
            while (oReader.Read())
            {
                Integrante oIntegrante = new Integrante();
                oIntegrante.oFaccao = new Faccao();
                oIntegrante.oEndereco = new Endereco();
                oIntegrante.Celular = oReader["cfIntegranteCelular"].ToString();
                oIntegrante.Foto = oReader["cfIntegranteFoto"].ToString();
                oIntegrante.Hierarquia = (EscudoEnum)(Convert.ToInt16(oReader["cfIntegranteHierarquia"].ToString()));
                oIntegrante.IntegranteID = Convert.ToInt32(oReader["cfIntegranteID"].ToString());
                oIntegrante.Name = oReader["cfIntegranteName"].ToString();
                oIntegrante.oEndereco.CEP = oReader["cfIntegranteCep"].ToString();
                oIntegrante.oEndereco.Cidade = oReader["cfIntegranteCidade"].ToString();
                oIntegrante.oEndereco.Estado = oReader["cfIntegranteEstado"].ToString();
                oIntegrante.oEndereco.Logradouro = oReader["cfIntegranteLogradouro"].ToString();
                oIntegrante.Telefone = oReader["cfIntegranteTelefone"].ToString();
                oIntegrante.oFaccao.FaccaoID = Convert.ToInt32(oReader["cfIntegrante_cfFaccaoID"].ToString());

                oListIntegrantes.Add(oIntegrante);
            }

            oReader.Close();
            oSqlConnection.Close();

            return oListIntegrantes;
        }

        /// <summary>
        /// INTEGRANTES
        /// GetAll Integrantes
        /// </summary>
        /// <returns>Lista de Integrantes Retornados</returns>
        public List<Integrante> GetAllIntegrantesbyFaccao(int faccaoid)
        {
            //Conexao
            SqlConnection oSqlConnection = new SqlConnection("packet size=4096;persist security info=TRUE;initial catalog=CF_Secretaria;user id=sa;password=123456;data source=LOVIEIRA-PC\\SQL_SOLUTIO42");
            oSqlConnection.Open();

            //Sql de busca dos Integrantes
            SqlCommand oSqlCommand = new SqlCommand(string.Format("SELECT * FROM cfIntegrante WHERE cfIntegrante_cfFaccaoID = {0}", faccaoid), oSqlConnection);
            SqlDataReader oReader = oSqlCommand.ExecuteReader();

            //Retornando os Integrantes
            List<Integrante> oListIntegrantes = new List<Integrante>();
            while (oReader.Read())
            {
                Integrante oIntegrante = new Integrante();
                oIntegrante.oFaccao = new Faccao();
                oIntegrante.oEndereco = new Endereco();
                oIntegrante.Celular = oReader["cfIntegranteCelular"].ToString();
                oIntegrante.Foto = oReader["cfIntegranteFoto"].ToString();
                oIntegrante.Hierarquia = (EscudoEnum)(Convert.ToInt16(oReader["cfIntegranteHierarquia"].ToString()));
                oIntegrante.IntegranteID = Convert.ToInt32(oReader["cfIntegranteID"].ToString());
                oIntegrante.Name = oReader["cfIntegranteName"].ToString();
                oIntegrante.oEndereco.CEP = oReader["cfIntegranteCep"].ToString();
                oIntegrante.oEndereco.Cidade = oReader["cfIntegranteCidade"].ToString();
                oIntegrante.oEndereco.Estado = oReader["cfIntegranteEstado"].ToString();
                oIntegrante.oEndereco.Logradouro = oReader["cfIntegranteLogradouro"].ToString();
                oIntegrante.Telefone = oReader["cfIntegranteTelefone"].ToString();
                oIntegrante.oFaccao.FaccaoID = Convert.ToInt32(oReader["cfIntegrante_cfFaccaoID"].ToString());

                oListIntegrantes.Add(oIntegrante);
            }

            oReader.Close();
            oSqlConnection.Close();

            return oListIntegrantes;
        }

        /// <summary>
        /// INTEGRANTES
        /// Excluir Integrante
        /// </summary>
        /// <param name="oIntegrante">Objeto de Integrante</param>
        public void ExcluirIntegrante(Integrante oIntegrante)
        {
            //Conexao
            SqlConnection oSqlConnection = new SqlConnection("packet size=4096;persist security info=TRUE;initial catalog=CF_Secretaria;user id=sa;password=123456;data source=LOVIEIRA-PC\\SQL_SOLUTIO42");
            oSqlConnection.Open();

            //Sql de excluir dos Integrantes
            SqlCommand oSqlCommand = new SqlCommand(String.Format("DELETE FROM cfIntegrante WHERE cfIntegranteID = {0}", oIntegrante.IntegranteID), oSqlConnection);

            oSqlCommand.ExecuteNonQuery();

            oSqlConnection.Close();
        }
        #endregion
    }
}
