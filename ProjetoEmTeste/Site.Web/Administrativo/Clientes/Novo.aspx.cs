using Site.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Site.Web.Administrativo.Clientes
{
    public partial class Novo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSalvar_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            cliente.Nome = txtNome.Text;
            cliente.Email = txtEmail.Text;
            cliente.Senha = txtSenha.Text;
            DBContexto db = new DBContexto();
            db.Insert(cliente);
            Session.Remove("CodigoCliente");
            Response.Redirect("~/Administrativo/Clientes/");
        }

        protected void btnVoltar_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Administrativo/Clientes/");
        }
    }
}