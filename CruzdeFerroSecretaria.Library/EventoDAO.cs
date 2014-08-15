using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace CruzdeFerroSecretaria.Library
{
    public class EventoDAO
    {
        #region METHODS EVENTOS
        /// <summary>
        /// EVENTOS
        /// Salvando os Eventos
        /// </summary>
        /// <param name="oEvento">Objeto de Evento</param>
        public void SalvarEvento(Evento oEvento)
        {
            //Sql de update dos Eventos
            if (oEvento.EventoID != 0)
            {
                CFConexao.ExecSQL(String.Format("UPDATE cfEvento SET cfEventoMotoClube = '{0}', cfEventoDataFim = '{1}', cfEventoDataInicio = '{2}',cfEventoCidade = '{4}',cfEventoLogradouro = '{5}',cfEventoCep = '{6}',cfEventoEstado = '{7}',cfEventoEntrada = '{8}'WHERE cfEventoID = {3}", oEvento.MotoClube, oEvento.DataFim.ToString("dd/MM/yyyy"), oEvento.DataInicio.ToString("dd/MM/yyyy"), oEvento.EventoID, oEvento.oEndereco.Cidade, oEvento.oEndereco.Logradouro, oEvento.oEndereco.CEP, oEvento.oEndereco.Estado, oEvento.Entrada));
            }
            //Sql de Inserção dos Eventos
            else 
            {
                CFConexao.ExecSQL(String.Format("INSERT INTO cfEvento VALUES('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}')", oEvento.MotoClube, oEvento.DataInicio.ToString("dd/MM/yyyy"), oEvento.DataFim.ToString("dd/MM/yyyy"), oEvento.oEndereco.Cidade, oEvento.oEndereco.Logradouro, oEvento.oEndereco.CEP, oEvento.oEndereco.Estado, oEvento.Entrada));
            }
        }

        /// <summary>
        /// EVENTOS
        /// GetAll Eventos
        /// </summary>
        /// <returns>Lista de Eventos Retornados</returns>
        public List<Evento> GetAllEventos()
        {
            //Sql de busca dos Eventos
            SqlDataReader oReader = CFConexao.ExecuteSelect("SELECT * FROM cfEvento");

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
            CFConexao.Conexao.Close();

            return oListEventos;
        }

        /// <summary>
        /// EVENTOS
        /// Get Eventos by Month
        /// </summary>
        /// <returns>Lista de Eventos Retornados</returns>
        public List<Evento> GetAllEventosByMes(int Mes)
        {
            int Ano = DateTime.Now.Year;

            if (Mes < 1)
            {
                Mes = 12;
                Ano = DateTime.Now.Year - 1;
            }

            //Data Inicial
            string DataInicial = "01/" + Mes.ToString() + "/" + Ano;
            string DataFinal = "30/" + Mes.ToString() + "/" + Ano;

            SqlDataReader oReader = CFConexao.ExecuteSelect(string.Format("SELECT * FROM cfEvento WHERE cfEventoDataInicio >= '{0}' AND cfEventoDataInicio <= '{1}'", Convert.ToDateTime(DataInicial), Convert.ToDateTime(DataFinal))); ;

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
            CFConexao.Conexao.Close();

            return oListEventos;
        }

        /// <summary>
        /// EVENTOS
        /// Excluir Evento
        /// </summary>
        /// <param name="oEvento">Objeto de Evento</param>
        public void ExcluirEvento(Evento oEvento)
        {
            //Sql de excluir dos Eventos
            CFConexao.ExecSQL(String.Format("DELETE FROM cfEvento WHERE cfEventoID = {0}", oEvento.EventoID));
        }
        #endregion
    }
}
