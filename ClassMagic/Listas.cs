using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMagic
{
    public class Listas
    {
        public static List<string> Listanomes;
        public static List<string> Listacores;
        public static List<string> Listahabilidades;
        public static List<string> ListanomesFeiticos;
        public static List<string> ListaImagens;

        public static void ListasConstroiListaNomes()
        {
            Listanomes = new List<string>();
            Listanomes.Add("Gnomo anão");
            Listanomes.Add("Gnomo ladrão");
            Listanomes.Add("Ent Abominável");
            Listanomes.Add("Abade da Fortaleza");
            Listanomes.Add("Ent Abominável");
            Listanomes.Add("Abominação de Gudul");
            Listanomes.Add("Abyssal Nightstalker");
            Listanomes.Add("Falcoeiro Abzan");
            Listanomes.Add("Maga Graduada da Academia");
            Listanomes.Add("Salteador da Academia");
            Listanomes.Add("Pesquisadores da Academia");
            Listanomes.Add("Dragonete da Academia");
            Listanomes.Add("Alquimista Talentosa");
            Listanomes.Add("Paladino dos Concordantes");
            Listanomes.Add("Centauro Amaldiçoado");
            Listanomes.Add("Espírito Amaldiçoado");
            Listanomes.Add("Bruxa Amaldiçoada");
            Listanomes.Add("Aranha da Teia Ácida");
            Listanomes.Add("Dragão Cuspidor de Ácido");
            Listanomes.Add("Papão Cajado de Víbora");
            Listanomes.Add("Acólito de Xathrid");
            Listanomes.Add("Saltador Adornado");
            Listanomes.Add("Anjo da Égide");
            Listanomes.Add("Tartaruga da Égide");
            Listanomes.Add("Égide dos Deuses");
            Listanomes.Add("Envenenadora do Éter");
            Listanomes.Add("Saltador Adornado");
            Listanomes.Add("Saltador Adornado");
            Listanomes.Add("Mago do Bosque");
            Listanomes.Add("Goblin Lanhador");
            Listanomes.Add("Ogre Amarelo");
            Listanomes.Add("Lanhador Ousado");
            Listanomes.Add("Cruzado Por-tu-gal");
            Listanomes.Add("Cuzinheiro goblin");
            Listanomes.Add("Rei do Xará");
            Listanomes.Add("Avatar do Pantano");
            Listanomes.Add("Mula-sem-cabeça");
            Listanomes.Add("Cronos e os Titãs");
            Listanomes.Add("Baku");
            Listanomes.Add("Hidra");
            Listanomes.Add("Ninfas");
            Listanomes.Add("Pégaso");
            Listanomes.Add("Corça de Cerineia");
            Listanomes.Add("Ceto");
            Listanomes.Add("Medusa");
            Listanomes.Add("Ratatoskr");
            Listanomes.Add("Caronte");
            Listanomes.Add("Djinn");
            Listanomes.Add("Esfinge");
            Listanomes.Add("Curupira");
            Listanomes.Add("Minotauro");
            Listanomes.Add("Gambala o terrivel");

            ConstroiListaCores();
        }
        public static void ConstroiListaCores()
        {
            Listacores = new List<string>();
            Listacores.Add("Verde");
            Listacores.Add("Azul");
            Listacores.Add("Vermelho");
            Listacores.Add("Preto");
            Listacores.Add("Branco");
            Listacores.Add("Sem Cor");
            ConstroiListaHabilidades();
        }
        public static void ConstroiListaHabilidades()
        {
            Listahabilidades = new List<string>();
            Listahabilidades.Add("Ameaçar");
            Listahabilidades.Add("Absorver");
            Listahabilidades.Add("Armadura de Totem");
            Listahabilidades.Add("Aniquilador");
            Listahabilidades.Add("Conspirar");
            Listahabilidades.Add("Encantar");
            Listahabilidades.Add("Fúria");
            Listahabilidades.Add("Proteção contra raios");
            ConstroiListaNomesFeiticos();
        }

        public static void ConstroiListaNomesFeiticos()
        {
            ListanomesFeiticos = new List<string>();
            ListanomesFeiticos.Add("Accio");
            ListanomesFeiticos.Add("Alarte Ascendare");
            ListanomesFeiticos.Add("Alohomora");
            ListanomesFeiticos.Add("Anapneo");
            ListanomesFeiticos.Add("Aparecium");
            ListanomesFeiticos.Add("Aquamenti");
            ListanomesFeiticos.Add("Avada Kedavra");
            ListanomesFeiticos.Add("Bombarda");
            ListanomesFeiticos.Add("Braquium Remendo");
            ListanomesFeiticos.Add("Colloportus");
            ListanomesFeiticos.Add("Cistem Aperio");
            ListanomesFeiticos.Add("Confringo");
            ListanomesFeiticos.Add("Confundus");
            ListanomesFeiticos.Add("Expecto Patronum");
            ListanomesFeiticos.Add("Expelliarmus");
            ListanomesFeiticos.Add("Fogo maldito");
            ListanomesFeiticos.Add("Immobillus");
            ListanomesFeiticos.Add("Lumos");
            ListanomesFeiticos.Add("Obliviate");
            ListanomesFeiticos.Add("Petrificus Totalus");
            ListanomesFeiticos.Add("Ridikullus");
            ListanomesFeiticos.Add("Magia Branca");
            ListanomesFeiticos.Add("Bruxaria Moderna");
            ListanomesFeiticos.Add("Bruxaria Tradicional");
            ListanomesFeiticos.Add("Ancestral");
            ListanomesFeiticos.Add("Vudu");
            ListanomesFeiticos.Add("Evocação do demo");
            ListanomesFeiticos.Add("Ritual");
            ListanomesFeiticos.Add("Raio");
            ListanomesFeiticos.Add("Bola de fogo");
            ListanomesFeiticos.Add("Magia Negra");
            ListanomesFeiticos.Add("Magica do demo");
            ListanomesFeiticos.Add("Feitiço da vovo");
            ListanomesFeiticos.Add("Feitiço do António");
            ListanomesFeiticos.Add("Encantamento do amor");
            ListanomesFeiticos.Add("Encantamento do terror");
            ListanomesFeiticos.Add("Já fostes!");
            ListanomesFeiticos.Add("Ritual da Lua");
            ListanomesFeiticos.Add("Olho negro");
            ListanomesFeiticos.Add("Varinha do Malfoy");
            ListanomesFeiticos.Add("Magica do Potter");
            ConstroiListaImagens();
        }
        public static void ConstroiListaImagens()
        {
            ListaImagens = new List<string>();
            ListaImagens.Add(@"\Magic\1.jpg");
            ListaImagens.Add(@"\Magic\2.jpg");
            ListaImagens.Add(@"\Magic\3.jpg");
            ListaImagens.Add(@"\Magic\4.jpg");
            ListaImagens.Add(@"\Magic\5.jpg");
            ListaImagens.Add(@"\Magic\6.jpg");
            ListaImagens.Add(@"\Magic\7.jpg");
            ListaImagens.Add(@"\Magic\8.jpg");
            ListaImagens.Add(@"\Magic\11.jpg");
            ListaImagens.Add(@"\Magic\12.jpg");
            ListaImagens.Add(@"\Magic\13.jpg");
            ListaImagens.Add(@"\Magic\14.jpg");
            ListaImagens.Add(@"\Magic\15.jpg");
            ListaImagens.Add(@"\Magic\16.jpg");
            ListaImagens.Add(@"\Magic\20.jpg");
            ListaImagens.Add(@"\Magic\21.jpg");
            ListaImagens.Add(@"\Magic\22.jpg");
            ListaImagens.Add(@"\Magic\23.jpg");
            ListaImagens.Add(@"\Magic\25.jpg");
            ListaImagens.Add(@"\Magic\26.jpg");
            ListaImagens.Add(@"\Magic\28.jpg");
            ListaImagens.Add(@"\Magic\29.jpg");
        }
    }
}
