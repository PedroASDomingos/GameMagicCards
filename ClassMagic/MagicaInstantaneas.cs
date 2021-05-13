using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMagic
{
    public class MagicaInstantaneas
    {
        public static List<MagicaInstantanea> ListaMagicaInstantanea;

        public static void ConstroiListaEncantamentos()
        {
            ListaMagicaInstantanea = new List<MagicaInstantanea>();
            var random = new Random();
            int iNome;
            int iCor;
            int iCusto;
            int iHabilidade;
            for (int i = 0; i < 80; i++)
            {
                iNome = random.Next(0, Listas.ListanomesFeiticos.Count);
                iCor = random.Next(0, Listas.Listacores.Count);
                iCusto = random.Next(0, 9);
                iHabilidade = random.Next(0, Listas.Listacores.Count);
                MagicaInstantanea magicaInstantanea = new MagicaInstantanea();
                magicaInstantanea.Nome = Listas.ListanomesFeiticos[iNome];
                magicaInstantanea.Cor = Listas.Listacores[iCor];
                magicaInstantanea.Descricao = Listas.ListanomesFeiticos[iNome] + " é uma Magica Instantanea que causa dano de ";
                magicaInstantanea.Custo = iCusto;
                magicaInstantanea.Efeito = Listas.Listahabilidades[iHabilidade];
                ListaMagicaInstantanea.Add(magicaInstantanea);
            }
        }
    }
}
