using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMagic
{
    public class Feiticos
    {
        public static List<Feitico> ListaFeiticos;

        public static void ConstroiListaEncantamentos()
        {
            ListaFeiticos = new List<Feitico>();
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
                Feitico feitico = new Feitico();
                feitico.Nome = Listas.ListanomesFeiticos[iNome];
                feitico.Cor = Listas.Listacores[iCor];
                feitico.Descricao = Listas.ListanomesFeiticos[iNome] + " é uma Feitiço que causa dano de ";
                feitico.Custo = iCusto;
                feitico.Efeito = Listas.Listahabilidades[iHabilidade];
                ListaFeiticos.Add(feitico);
            }
        }
    }
}
