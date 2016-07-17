using BibliotecaDeJogos.Bussiness.BLL.ErroException;
using BibliotecaDeJogos.Data.DAL;
using BibliotecaDeJogos.Entidades.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeJogos.Bussiness.BLL.Autenticacao
{
    public class LoginBO
    {
        private UsuariosDAO _userDAO;
        public Usuario UsuarioCadastrado(string nome, string senha)
        {
            _userDAO = new UsuariosDAO();
            var usuario = _userDAO.ObterUsuarioSenha(nome, senha);
            if ((usuario.Nome == null )&&(usuario.Email== null)&&(usuario.Id <= 0))
            {
                throw new UsuarioNaoCadastrado();
            }
            else
            {
                return usuario;
            }
        }
    }
}
