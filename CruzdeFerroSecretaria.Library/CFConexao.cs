using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace CruzdeFerroSecretaria.Library
{
    class CFConexao
    {
        private const String UserId = "";
        private const String Password = "";
        private const String Database = "36Manager";
        private const String DataSource = "(local)";
        
        // Para Windows Authentication Mode, user "Trusted_Connection=Yes";
        private const String ConnectionString = "Trusted_Connection=Yes;packet size=4096;persist security info=TRUE;initial catalog=" + Database + ";user id=" + UserId + ";password=" + Password + ";data source=" + DataSource;

        private static SqlConnection oSqlConnection = null;

        public static SqlConnection Conexao { get { return getConexao(); } }

        private static SqlConnection getConexao()
        {
            if (oSqlConnection == null)
            {
                oSqlConnection = new SqlConnection(ConnectionString);
            }

            if (oSqlConnection.State == ConnectionState.Closed)
            {
                oSqlConnection.Open();
            }

            return oSqlConnection;
        }

        public static SqlDataReader ExecuteSelect(string SQL)
        {
            SqlCommand oSqlCommand = new SqlCommand(SQL, Conexao);
            SqlDataReader oReader = oSqlCommand.ExecuteReader();

            return oReader;
        }

        public static void ExecSQL(string SQL)
        {          
            SqlCommand oSqlCommand = new SqlCommand();

            oSqlCommand = new SqlCommand(SQL, Conexao);
            oSqlCommand.ExecuteNonQuery();

            Conexao.Close();
        }

    }
}
