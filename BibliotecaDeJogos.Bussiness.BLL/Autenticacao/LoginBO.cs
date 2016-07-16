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
            var usuerio = _userDAO.ObterUsuarioSenha(nome, senha);
            if (usuerio == null)
            {
                throw new UsuarioNaoCadastrado();
            }
            else
            {
                return usuerio;
            }
        }
    }
}
