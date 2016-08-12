using Site.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Site.Web
{
    public partial class Default1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            ClienteContexto db = new ClienteContexto();
            cliente.Nome = "Warleson";
            cliente.Senha = "123";
            cliente.Email = "Jose@Warleson";
            db.Inserir(cliente);
        }
    }
}