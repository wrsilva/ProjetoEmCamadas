using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Site.Web.Models
{
    public class Contexto
    {
        private static SqlConnection connection()
        {
            try
            {
                //cria uma conexão com a ConnectionString
                SqlConnection conexão = new SqlConnection(ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString.ToString());

                //verifica se a conexão está fechada
                if (conexão.State == ConnectionState.Closed)
                {
                    //abre a conexão
                    conexão.Open();
                }

                //retorna a conexão
                return conexão;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }


        public void inserirAnunciante(Cliente anunciante)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO Cliente ( Nome, Email, Senha) VALUES ('@Nome', '@Email', '@Senha')", connection());

            cmd.Parameters.AddWithValue("@Nome", anunciante.Nome);
            cmd.Parameters.AddWithValue("@Email", anunciante.Email);
            cmd.Parameters.AddWithValue("@Senha", anunciante.Senha);
            cmd.ExecuteNonQuery();

            Contexto db = new Contexto();

        }
    }
}
