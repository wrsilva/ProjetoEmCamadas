using BibliotecaDeJogos.Bussiness.BLL.Autenticacao;
using BibliotecaDeJogos.Bussiness.BLL.ErroException;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BibliotecaDeJogos.Interface.UI.Autenticacao
{
    public partial class Login : System.Web.UI.Page
    {
        private LoginBO _loginBO;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_Entrar(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                if ((txtLogin.Text != "") && (txtSenha.Text != ""))
                {
                    _loginBO = new LoginBO();
                    var nomeUser = txtLogin.Text;
                    var senhaUser = txtSenha.Text;

                    try
                    {

                        var usuario = _loginBO.UsuarioCadastrado(nomeUser, senhaUser);
                        Response.Redirect("/");
                    }
                    catch (UsuarioNaoCadastrado)
                    {
                        lbnStatus.Text = "Email ou senha incorreta";
                    }
                    catch (Exception ex)
                    {

                        lbnStatus.Text = ex.ToString();
                        //lbnStatus.Text = "Ocorreu um erro inesperado, favor consultar o administrador do sistema";
                    }
                }
                else
                {
                    lbnStatus.Text = "Preencha os camapo email e senha";
                }
            }

        }
    }
}