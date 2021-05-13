using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMagic
{
    public class Criaturas
    {
        public static List<Criatura> ListaCriaturas;

        public static void ConstroiListaCriaturas()
        {
            ListaCriaturas = new List<Criatura>();
            var random = new Random();
            int iNome;
            int iCor;
            int iCusto;
            int iAtaque;
            int iResistencia;
            int iHabilidade;
            for (int i = 0; i < 80; i++)
            {
            iNome = random.Next(0, Listas.Listanomes.Count);
            iCor = random.Next(0, Listas.Listacores.Count);
            iCusto = random.Next(0, 9);
            iAtaque = random.Next(0, 9);
            iResistencia = random.Next(0, 9);
            iHabilidade = random.Next(0, Listas.Listacores.Count);
            Criatura criatura = new Criatura();
            criatura.Nome = Listas.Listanomes[iNome];
            criatura.Cor = Listas.Listacores[iCor];
            criatura.Descricao = Listas.Listanomes[iNome] + " é uma criatura com a habilidade " + Listas.Listahabilidades[iHabilidade];
            criatura.Custo = iCusto;
            criatura.Ataque = iAtaque;
            criatura.Resistencia = iResistencia;
            criatura.Habilidade = Listas.Listahabilidades[iHabilidade];
            ListaCriaturas.Add(criatura);
            }
        }
    }
}
