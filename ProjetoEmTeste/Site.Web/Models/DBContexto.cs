using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;

namespace Site.Web.Models
{
    public class DBContexto
    {
        string _conexaoMySQL = "";
        protected MySqlCommand com;
        protected MySqlConnection con = null;
        protected MySqlDataReader Dr;
        public DBContexto()
        {


            _conexaoMySQL = "Server=localhost; Uid=root; Pwd=1234; Database=ntur;";
        }

        public void SemRetorno(string sql)
        {
            try
            {
                con = new MySqlConnection(_conexaoMySQL);
                MySqlCommand cmd = new MySqlCommand(sql, con);
                con.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }
        }
        //*******************************************************************************


        //método que Lista Clientes
        public List<Cliente> Listar()
        {
            try
            {
                con = new MySqlConnection(_conexaoMySQL);
                MySqlCommand cmd = new MySqlCommand("select * FROM ntur.cliente;", con);
                con.Open();
                Dr = cmd.ExecuteReader();
                List<Cliente> lista = new List<Cliente>();
                while (Dr.Read())
                {
                    Cliente cliente = new Cliente();
                    cliente.Codigo = Convert.ToInt32(Dr["Codigo"]);
                    cliente.Nome = Convert.ToString(Dr["Nome"]);
                    cliente.Email = Convert.ToString(Dr["Email"]);
                    cliente.Senha = Convert.ToString(Dr["Senha"]);
                    lista.Add(cliente);
                }
                return lista;

            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                con.Close();
            }
        }
        //+++++++++++++++++++++++++


        //método que faz a consulta no bd e obtém o cliente 
        //cujo o id é informado pelo parâmetro 
        public Cliente ObterClientePorId(int id)
        {

            try
            {
                //objeto cliente que será retornado pelo método 
                Cliente cliente = new Cliente();

                //instância da conexão 
                con = new MySqlConnection(_conexaoMySQL);

                //string com o comando a ser executado 
                string sql = "select * FROM ntur.cliente WHERE Codigo=@id";

                //instância do comando recebendo como parâmetro 
                //a string com o comando e a conexão 
                MySqlCommand cmd = new MySqlCommand(sql, con);

                //informo o parâmetro do comando 
                cmd.Parameters.AddWithValue("@id", id);

                //abro conexão 
                con.Open();

                //instância do leitor 
                MySqlDataReader leitor = cmd.ExecuteReader();

                //enquanto leitor lê 
                while (leitor.Read())
                {
                    //passo os valores para o objeto cliente 
                    //que será retornado 
                    cliente.Codigo = Convert.ToInt32(leitor["Codigo"].ToString());
                    cliente.Nome = leitor["Nome"].ToString();
                    cliente.Email = leitor["Email"].ToString();
                    cliente.Senha = leitor["Senha"].ToString();
                }


                //Retorno o objeto cliente cujo o  
                //nome é igual ao informado no parâmetro 
                return cliente;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                //fecha conexão 
                con.Close();
            }
        }



        //método que faz a Atualização no bd
        public void Update(Cliente cliente)
        {
            try
            {
                try
                {
                    string sql = "UPDATE ntur.cliente SET Nome = '" + cliente.Nome + "', Email = '" + cliente.Email + "', Senha = '" + cliente.Senha + "' WHERE Codigo =" + cliente.Codigo + ";";

                    con = new MySqlConnection(_conexaoMySQL);
                    MySqlCommand cmd = new MySqlCommand(sql, con);

                    con.Open();
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    con.Close();
                }
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                //fecha conexão 
                con.Close();
            }
        }

        //método que Deleta no bd
        public void Delete(int id)
        {
            try
            {
                try
                {
                    string sql = "DELETE FROM ntur.cliente  WHERE Codigo =" + id + ";";

                    con = new MySqlConnection(_conexaoMySQL);
                    MySqlCommand cmd = new MySqlCommand(sql, con);

                    con.Open();
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    con.Close();
                }
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                //fecha conexão 
                con.Close();
            }
        }
        //método que faz a Atualização no bd
        public void Insert(Cliente cliente)
        {
            try
            {
                try
                {
                    string sql = "INSERT INTO Cliente (Nome,Email,Senha) VALUES ('" + cliente.Nome + "','" + cliente.Email + "','" + cliente.Senha + "')";
                    con = new MySqlConnection(_conexaoMySQL);
                    MySqlCommand cmd = new MySqlCommand(sql, con);

                    con.Open();
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    con.Close();
                }
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                //fecha conexão 
                con.Close();
            }
        }

      
        //método que Lista Clientes na consulta
        public List<Cliente> ListarBusca(string texto)
        {
            try
            {
                con = new MySqlConnection(_conexaoMySQL);


                //SELECT* FROM ntur.cliente WHERE (Nome  LIKE 'warleson%' or Email LIKE 'p%');

                MySqlCommand cmd = new MySqlCommand("SELECT * FROM ntur.cliente WHERE (Nome LIKE  @criterio or Email LIKE @criterio)", con);
                con.Open();
                // Define o parâmetro @criterio e seu tipo de dados
                cmd.Parameters.Add(
                    new MySqlParameter(
                    "@criterio",                                  // o nome do parametro
                    MySql.Data.MySqlClient.MySqlDbType.VarChar, // o tipo de dado SqlDbType
                    40,                                              // o tamanho do parametro
                    "ProductName"));                          // o nome da coluna na tabela a qual se aplica
                                                              // Preenche o valor do parâmetro com o texto informado
                                                              // na caixa de texto : txtcriterio
                cmd.Parameters["@criterio"].Value = texto + "%";
                Dr = cmd.ExecuteReader();
                List<Cliente> lista = new List<Cliente>();
                while (Dr.Read())
                {
                    Cliente cliente = new Cliente();
                    cliente.Codigo = Convert.ToInt32(Dr["Codigo"]);
                    cliente.Nome = Convert.ToString(Dr["Nome"]);
                    cliente.Email = Convert.ToString(Dr["Email"]);
                    cliente.Senha = Convert.ToString(Dr["Senha"]);
                    lista.Add(cliente);
                }
                return lista;

            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                con.Close();
            }
        }
    }
}
