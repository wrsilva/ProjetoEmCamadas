using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Site.Model;
using Site.Web.Models;

namespace Site.Web
{
    public partial class Cadastro : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                Cliente cliente = new Cliente();
                cliente.Nome = TextBoxNome.Text + " " + TextBoxSobreNome.Text;
                cliente.Email = TextBoxEmail.Text;
                cliente.Senha = TextBoxSenha.Text;
                ClienteContexto db = new ClienteContexto();
                db.Inserir(cliente);
                Response.Redirect("~/Login.aspx");
            }
            catch (Exception)
            {

                throw;
            }

           
        }
    }
}