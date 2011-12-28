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
            SqlConnection oSqlConnection = new SqlConnection("packet size=4096;persist security info=TRUE;initial catalog=CF_Secretaria;user id=sa;password=123456;data source=LOVIEIRA-PC\\SQL_SOLUTIO42");
            oSqlConnection.Open();
            SqlCommand oSqlCommand = new SqlCommand("SELECT * FROM cfEvento");
            oSqlCommand.ExecuteNonQuery();

            oSqlConnection.Close();
        }
    }
}
