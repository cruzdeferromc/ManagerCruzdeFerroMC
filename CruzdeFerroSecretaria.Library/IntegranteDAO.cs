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
        public void SalvarEvento(Integrante oIntegrante)
        {
            //Conexao
            SqlConnection oSqlConnection = new SqlConnection("packet size=4096;persist security info=TRUE;initial catalog=CF_Secretaria;user id=sa;password=123456;data source=LOVIEIRA-PC\\SQL_SOLUTIO42");
            oSqlConnection.Open();

            SqlCommand oSqlCommand = new SqlCommand();

            //Sql de update dos Eventos
            if (oIntegrante.IntegranteID != 0)
            {
                oSqlCommand = new SqlCommand(String.Format("UPDATE cfEvento SET cfEventoMotoClube = '{0}', cfEventoDataFim = '{1}', cfEventoDataInicio = '{2}',cfEventoCidade = '{4}',cfEventoLogradouro = '{5}',cfEventoCep = '{6}',cfEventoEstado = '{7}',cfEventoEntrada = '{8}'WHERE cfEventoID = {3}", oEvento.MotoClube, oEvento.DataFim.ToString("dd/MM/yyyy"), oEvento.DataInicio.ToString("dd/MM/yyyy"), oEvento.EventoID, oEvento.oEndereco.Cidade, oEvento.oEndereco.Logradouro, oEvento.oEndereco.CEP, oEvento.oEndereco.Estado, oEvento.Entrada), oSqlConnection);
            }
            //Sql de Inserção dos Eventos
            else
            {
                oSqlCommand = new SqlCommand(String.Format("INSERT INTO cfEvento VALUES('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}')", oEvento.MotoClube, oEvento.DataInicio.ToString("dd/MM/yyyy"), oEvento.DataFim.ToString("dd/MM/yyyy"), oEvento.oEndereco.Cidade, oEvento.oEndereco.Logradouro, oEvento.oEndereco.CEP, oEvento.oEndereco.Estado, oEvento.Entrada), oSqlConnection);
            }
            oSqlCommand.ExecuteNonQuery();

            oSqlConnection.Close();
        }

        /// <summary>
        /// EVENTOS
        /// GetAll Eventos
        /// </summary>
        /// <returns>Lista de Eventos Retornados</returns>
        public List<Evento> GetAllEventos()
        {
            //Conexao
            SqlConnection oSqlConnection = new SqlConnection("packet size=4096;persist security info=TRUE;initial catalog=CF_Secretaria;user id=sa;password=123456;data source=LOVIEIRA-PC\\SQL_SOLUTIO42");
            oSqlConnection.Open();

            //Sql de busca dos Eventos
            SqlCommand oSqlCommand = new SqlCommand("SELECT * FROM cfEvento", oSqlConnection);
            SqlDataReader oReader = oSqlCommand.ExecuteReader();

            //Retornando os Eventos
            List<Evento> oListEventos = new List<Evento>();
            while (oReader.Read())
            {
                Evento oEvento = new Evento();
                oEvento.oEndereco = new Endereco();
                oEvento.DataInicio = Convert.ToDateTime(oReader["cfEventoDataInicio"].ToString());
                oEvento.DataFim = Convert.ToDateTime(oReader["cfEventoDataFim"].ToString());
                oEvento.EventoID = Convert.ToInt32(oReader["cfEventoID"].ToString());
                oEvento.MotoClube = oReader["cfEventoMotoClube"].ToString();
                oEvento.Entrada = oReader["cfEventoEntrada"].ToString();
                oEvento.oEndereco.CEP = oReader["cfEventoCep"].ToString();
                oEvento.oEndereco.Cidade = oReader["cfEventoCidade"].ToString();
                oEvento.oEndereco.Estado = oReader["cfEventoEstado"].ToString();
                oEvento.oEndereco.Logradouro = oReader["cfEventoLogradouro"].ToString();


                oListEventos.Add(oEvento);
            }

            oReader.Close();
            oSqlConnection.Close();

            return oListEventos;
        }

        /// <summary>
        /// EVENTOS
        /// Excluir Evento
        /// </summary>
        /// <param name="oEvento">Objeto de Evento</param>
        public void ExcluirEvento(Evento oEvento)
        {
            //Conexao
            SqlConnection oSqlConnection = new SqlConnection("packet size=4096;persist security info=TRUE;initial catalog=CF_Secretaria;user id=sa;password=123456;data source=LOVIEIRA-PC\\SQL_SOLUTIO42");
            oSqlConnection.Open();

            //Sql de excluir dos Eventos
            SqlCommand oSqlCommand = new SqlCommand(String.Format("DELETE FROM cfEvento WHERE cfEventoID = {0}", oEvento.EventoID), oSqlConnection);

            oSqlCommand.ExecuteNonQuery();

            oSqlConnection.Close();
        }
        #endregion
    }
}
