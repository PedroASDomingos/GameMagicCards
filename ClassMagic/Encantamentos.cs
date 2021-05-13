using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMagic
{
    public class Encantamentos
    {
        public static List<Encantamento> ListaEncantamentos;

        public static void ConstroiListaEncantamentos()
        {
            ListaEncantamentos = new List<Encantamento>();
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
                Encantamento encantamento = new Encantamento();
                encantamento.Nome = Listas.ListanomesFeiticos[iNome];
                encantamento.Cor = Listas.Listacores[iCor];
                encantamento.Descricao = Listas.ListanomesFeiticos[iNome] + " é uma Encantamento que causa dano de ";
                encantamento.Custo = iCusto;
                encantamento.Habilidade = Listas.Listahabilidades[iHabilidade];
                ListaEncantamentos.Add(encantamento);
            }
        }
    }
}
