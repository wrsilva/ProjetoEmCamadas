using BibliotecaDeJogos.Entidades.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeJogos.Data.DAL
{
    public class UsuariosDAO
    {



        public Usuario ObterUsuarioSenha(string usuario, string senha)
        {
          
            try
            {
                
                var command = new SqlCommand();
                string comandoSql = "SELECT * FROM Usuarios WHERE Email = '" + usuario + "'  AND Senha = '" + senha + "'".ToString();
                SqlDataReader reader = ConexaoBD.ExecReader(comandoSql);


                Usuario user = new Usuario();
                while (reader.Read())
                {
                    user = new Usuario();
                    user.Id = Convert.ToInt32(reader["Id"]);
                    user.Email = Convert.ToString(reader["Email"]);
                    user.Senha = Convert.ToString(reader["Senha"]);
                    user.Nome = Convert.ToString(reader["Nome"]);
                    user.Tipo = Convert.ToInt32(reader["Tipo"]);

                }
                return user;
            }
            catch (Exception)
            {

                throw;
            }

         

        }
    }

    //public Usuario ObterUsuarioSenha(string usuario, string senha)
    //{
        //try
        //{

        //    var command = new SqlCommand();
        //    command.Connection = Conexao.connection;
        //    command.CommandText = "SELECT * FROM Usuarios WHERE Email =  @usuario  AND  Senha = @senha";

        //    command.Parameters.AddWithValue("@usuario", usuario.ToString());
        //    command.Parameters.AddWithValue("@senha", senha.ToString());

        //    Conexao.Abrir();
        //    var reader = command.ExecuteReader();
        //    Usuario user = null;
        //    while (reader.Read())
        //    {
        //        user = new Usuario();
        //        user.Id = Convert.ToInt32(reader["Id"]);
        //        user.Email = Convert.ToString(reader["Email"]);
        //        user.Senha = Convert.ToString(reader["Senha"]);
        //        user.Nome = Convert.ToString(reader["Nome"]);
        //        user.Tipo = Convert.ToInt32(reader["Tipo"]);

        //    }
        //    return user;


        //}
        //catch (Exception)
        //{

        //    throw;
        //}
        //finally
        //{
        //    Conexao.Desconectar();
        //}

    //}
}

