using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeJogos.Bussiness.BLL.ErroException
{
    public class UsuarioNaoCadastrado : Exception
    {
        public UsuarioNaoCadastrado()
        {

        }
        public UsuarioNaoCadastrado(string messagem)
        {

        }
        public UsuarioNaoCadastrado(string messagem, Exception inner) : base(messagem, inner)
        {

        }

    }
}
