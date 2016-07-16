using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;

namespace BibliotecaDeJogos.Data.DAL
{
    public class Conexao
    {
       
        public static string conection = ConfigurationManager.ConnectionStrings["conectionString"].ToString();
        public static SqlConnection connection = new SqlConnection(conection);

        static public void Abrir()
        {

            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
        }


        static public void Desconectar()
        {

            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
        }
    }
}
