using MySql.Data.MySqlClient;
using Site.Web.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Site.Web.Administrativo.Clientes
{
    public partial class Editar : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                int id = Convert.ToInt32(Session["CodigoCliente"]);
                if (id != 0)
                {
                    try
                    {
                        DBContexto db = new DBContexto();

                        Cliente cliente = db.ObterClientePorId(id);
                        lbnNome.Text = cliente.Nome;
                        txtNome.Text = cliente.Nome;
                        txtEmail.Text = cliente.Email;
                        txtSenha.Text = cliente.Senha;
                    }
                    catch (Exception)
                    {
                        throw;
                    }
                }
                else
                {
                    Response.Redirect("~/Administrativo/Clientes/");
                }
            }
        }

        protected void btnSalvar_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            cliente.Codigo = Convert.ToInt32(Session["CodigoCliente"]);
            cliente.Nome = txtNome.Text;
            cliente.Email = txtEmail.Text;
            cliente.Senha = txtSenha.Text;
            DBContexto db = new DBContexto();
            db.Update(cliente);
            Session.Remove("CodigoCliente");
            Response.Redirect("~/Administrativo/Clientes/");

        }

        protected void btnVoltar_Click(object sender, EventArgs e)
        {
            Session.Remove("CodigoCliente");
            Response.Redirect("~/Administrativo/Clientes/");
        }
    }
}