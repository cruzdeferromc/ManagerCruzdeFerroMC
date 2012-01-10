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
            //Sql de update dos Eventos
            if (oIntegrante.IntegranteID != 0)
            {
                CFConexao.ExecSQL(String.Format("UPDATE cfIntegrante SET cfIntegranteName = '{0}', cfIntegranteHierarquia = {1}, cfIntegranteCidade = '{2}', cfIntegranteLogradouro = '{3}', cfIntegranteCep = '{4}', cfIntegranteEstado = '{5}', cfIntegranteCelular = '{6}', cfIntegranteTelefone = '{7}', cfIntegranteFoto = '{8}', cfIntegrante_cfFaccaoID = {10}  WHERE cfIntegranteID = {9}", oIntegrante.Name, (short)oIntegrante.Hierarquia, oIntegrante.oEndereco.Cidade, oIntegrante.oEndereco.Logradouro, oIntegrante.oEndereco.CEP, oIntegrante.oEndereco.Estado, oIntegrante.Celular, oIntegrante.Telefone, oIntegrante.Foto, oIntegrante.IntegranteID, oIntegrante.oFaccao.FaccaoID));
            }
            //Sql de Inserção dos Eventos
            else
            {
                CFConexao.ExecSQL(String.Format("INSERT INTO cfIntegrante VALUES('{0}',{1},'{2}','{3}','{4}','{5}','{6}','{7}','{8}',{9})", oIntegrante.Name, (short)oIntegrante.Hierarquia, oIntegrante.oEndereco.Cidade, oIntegrante.oEndereco.Logradouro, oIntegrante.oEndereco.CEP, oIntegrante.oEndereco.Estado, oIntegrante.Celular, oIntegrante.Telefone, oIntegrante.Foto, oIntegrante.oFaccao.FaccaoID));
            }
        }

        /// <summary>
        /// INTEGRANTES
        /// GetAll Integrantes
        /// </summary>
        /// <returns>Lista de Integrantes Retornados</returns>
        public List<Integrante> GetAllIntegrantes()
        {
            SqlDataReader oReader = CFConexao.ExecuteSelect("SELECT * FROM cfIntegrante");

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
            CFConexao.Conexao.Close();

            return oListIntegrantes;
        }

        /// <summary>
        /// INTEGRANTES
        /// GetAll Integrantes
        /// </summary>
        /// <returns>Lista de Integrantes Retornados</returns>
        public List<Integrante> GetAllIntegrantesbyFaccao(int faccaoid)
        {
            //Sql de busca dos Integrantes
            SqlDataReader oReader = CFConexao.ExecuteSelect(string.Format("SELECT * FROM cfIntegrante WHERE cfIntegrante_cfFaccaoID = {0}", faccaoid));

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
            CFConexao.Conexao.Close();

            return oListIntegrantes;
        }

        /// <summary>
        /// INTEGRANTES
        /// Excluir Integrante
        /// </summary>
        /// <param name="oIntegrante">Objeto de Integrante</param>
        public void ExcluirIntegrante(Integrante oIntegrante)
        {
            //Sql de excluir dos Integrantes
            CFConexao.ExecSQL(String.Format("DELETE FROM cfIntegrante WHERE cfIntegranteID = {0}", oIntegrante.IntegranteID));
        }
        #endregion
    }
}
