using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeJogos.Entidades.Entity
{
    public class Jogo
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public double ValorPago { get; set; }
        public string imagem { get; set; }
        public DateTime DataCompra { get; set; }
        public virtual Editor editor { get; set; }
        public virtual Genero Genero { get; set; }
        public int EditorId { get; set; }
        public int GeneroId { get; set; }
    }

}
