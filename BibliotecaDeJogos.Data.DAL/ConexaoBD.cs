using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeJogos.Data.DAL
{
    public class ConexaoBD
    {



        //===============================================
        // classe destinada à gestão da base de dados
        //===============================================
        public static SqlConnection sqlconnection = null;
        private static SqlCommand comando = null;

        //================================================





        /// <summary>
        /// Método que retorna a conexão com  a base de dados.
        /// </summary>
        /// <returns></returns>
        private static SqlConnection connection()
        {
            try
            {

                //Instância o sqlconnection com a string de conexão.
                sqlconnection = new SqlConnection(ConfigurationManager.ConnectionStrings["conectionString"].ToString());

                //Verifica se a conexão esta fechada.
                if (sqlconnection.State == ConnectionState.Closed)
                {
                    //Abri a conexão.
                    sqlconnection.Open();
                }

                //Retorna o sqlconnection.
                return sqlconnection;


            }
            catch (SqlException ex)
            {
                throw ex;
            }

        }


        /// <summary>
        /// Método que retorna um datareader com o resultado da query.
        /// </summary>
        /// <param name="query"></param>
        /// <returns></returns>
        public static SqlDataReader ExecReader(string query)
        {
            try
            {
                //Instância o sqlcommand com a query sql que será executada e a conexão.
                comando = new SqlCommand(query, connection());

                //Executa a query sql.
                var retornaQuery = comando.ExecuteReader();

                //Fecha a conexão.
                connection().Close();

                //Retorna o dataReader com o resultado
                return retornaQuery;

            }
            catch (SqlException ex)
            {
                throw ex;
            }

        }
    }

}