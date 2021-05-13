using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMagic
{
    public abstract class Carta
    {
        public int _custo;
        public string Nome { get; set; }
        public string Cor { get; set; }
        public string Descricao { get; set; }
        public int Custo { get; set; }
    }
}