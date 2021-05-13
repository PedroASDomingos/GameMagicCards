using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMagic
{
    public class Criatura : Carta
    {
        public int Ataque { get; set; }
        public int Resistencia { get; set; }
        public string Habilidade { get; set; }
    }
}
