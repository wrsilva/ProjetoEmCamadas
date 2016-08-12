using Site.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Site.Web.Administrativo.Clientes
{
    public partial class Deletar : System.Web.UI.Page
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
                        lbnEmail.Text = cliente.Email;
                        lbnSenha.Text = cliente.Senha;
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

        protected void btnDeletar_Click(object sender, EventArgs e)
        {
            DBContexto db = new DBContexto();
            db.Delete(Convert.ToInt32(Session["CodigoCliente"]));
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