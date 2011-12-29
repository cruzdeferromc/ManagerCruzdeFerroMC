using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace CruzdeFerroSecretaria.Library
{
    public class EventoDAO
    {
        /// <summary>
        /// EVENTOS
        /// Salvando os Eventos
        /// </summary>
        /// <param name="oEvento">Objeto de Evento</param>
        public void SalvarEvento(Evento oEvento)
        {
            SqlConnection oSqlConnection = new SqlConnection("packet size=4096;persist security info=TRUE;initial catalog=CF_Secretaria;user id=sa;password=123456;data source=LOVIEIRA-PC\\SQL_SOLUTIO42");
            oSqlConnection.Open();
            SqlCommand oSqlCommand = new SqlCommand(String.Format("INSERT INTO cfEvento VALUES('{0}','{1}','{2}')", oEvento.MotoClube, oEvento.DataInicio.ToString("dd/MM/yyyy"), oEvento.DataFim.ToString("dd/MM/yyyy")), oSqlConnection);
            oSqlCommand.ExecuteNonQuery();

            oSqlConnection.Close();
        }

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
                oEvento.DataInicio = Convert.ToDateTime(oReader["cfEventoDataInicio"].ToString());
                oEvento.DataFim = Convert.ToDateTime(oReader["cfEventoDataFim"].ToString());
                oEvento.EventoID = Convert.ToInt32(oReader["cfEventoID"].ToString());
                oEvento.MotoClube = oReader["cfEventoMotoClube"].ToString();

                oListEventos.Add(oEvento);
            }

            oReader.Close();
            oSqlConnection.Close();

            return oListEventos;
        }
    }
}
