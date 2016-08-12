using Site.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Site.Web.Models
{
    public class ClienteContexto
    {

        public void Inserir(Cliente cliente)
        {
            try
            {
                string sql = "INSERT INTO Cliente (Nome,Email,Senha) VALUES ('" + cliente.Nome + "','" + cliente.Email + "','" + cliente.Senha + "')";
                DBContexto db = new DBContexto();
                db.SemRetorno(sql);


            }
            catch (Exception)
            {

                throw;
            }
        }
       





        }
    }
