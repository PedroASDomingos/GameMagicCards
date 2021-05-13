using ClassMagic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExercicioMagic
{
    public partial class frmJogo : Form
    {
        string Pasta = Directory.GetCurrentDirectory();
        int Count = 1;
        int ManaP1 = 10;
        int ManaP2 = 10;
        int deckP1 = 60;
        int deckP2 = 60;
        int VidaP1 = 100;
        int VidaP2 = 100;
        int AtaqueP1 = 0;
        int AtaqueP2 = 0;
        int DefesaP1 = 0;
        int DefesaP2 = 0;
        int PoderAtaqueP1 = 0;
        int PoderAtaqueP2 = 0;
        public frmJogo()
        {
            InitializeComponent();
            lbl_nomeP1.Text = "";
            lbl_tipoP1.Text = "";
            lbl_custoP1.Text = "";
            tb_descricaoP1.Text = "";
            tb_ataqueP1.Text = "";
            tb_habilidadeP1.Text = "";
            tb_resistenciaP1.Text = "";
            lbl_nomeP2.Text = "";
            lbl_tipoP2.Text = "";
            lbl_custoP2.Text = "";
            tb_descricaoP2.Text = "";
            tb_ataqueP2.Text = "";
            tb_habilidadeP2.Text = "";
            tb_resistenciaP2.Text = "";
            label10.Visible = false;
            label8.Visible = false; 
            Listas.ListasConstroiListaNomes();
            Criaturas.ConstroiListaCriaturas();
            Encantamentos.ConstroiListaEncantamentos();
            Feiticos.ConstroiListaEncantamentos();
            MagicaInstantaneas.ConstroiListaEncantamentos();
        }
        
        private void btn_jogar_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel2.Visible = true;
            btn_jogar.Visible = false;
            btn_close.Visible = true;
            btn_fight.Visible = true;
        }
        private void btn_fight_Click(object sender, EventArgs e)
        {
            pictureBox2.Visible = false;
            panelPlayer1.Visible = true;
            panelPlayer2.Visible = true;
            btn_fight.Visible = false;
            btn_round.Visible = true;
            lbl_manaP1.Text = ManaP1.ToString();
            lbl_deckP1.Text = deckP1.ToString();
            lbl_manaP2.Text = ManaP2.ToString();
            lbl_deckP2.Text = deckP2.ToString();
            lbl_valvidaP1.Text = VidaP1.ToString();
            lbl_valvidaP2.Text = VidaP2.ToString();
        }
        private void btn_round_Click(object sender, EventArgs e)
        {
            Count = Count + 1;
            deckP1 = deckP1 - 1;
            deckP2 = deckP2 - 1;
            if (deckP1 == 0)
            {
                MessageBox.Show("Jogo terminou empatado!!!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            ManaP1 = 10;
            ManaP2 = 10;
            lbl_deckP1.Text = deckP1.ToString();
            lbl_deckP2.Text = deckP2.ToString();
            btn_round.Text = "Round " + Count;
            PoderAtaqueP1 = 0;
            PoderAtaqueP2 = 0;
            SorteiaTipoDeCartaP1();
            SorteiaTipoDeCartaP2();
            CalculosDanos();
        }

        private void SorteiaTipoDeCartaP1()
        {
            Random randomP1 = new Random();
            //Player 1
            string[] TiposCartasP1;
            TiposCartasP1 = new string[8];
            TiposCartasP1[0] = "Criatura";
            TiposCartasP1[1] = "Encantamento";
            TiposCartasP1[2] = "Feitiço";
            TiposCartasP1[3] = "Magica instantânea";
            TiposCartasP1[4] = "Magica instantânea";
            TiposCartasP1[5] = "Feitiço";
            TiposCartasP1[6] = "Encantamento";
            TiposCartasP1[7] = "Criatura";



            int indexP1 = randomP1.Next(0, TiposCartasP1.Length);
            if (indexP1 == 0 || indexP1 == 7)
            {
                ColocaCartaCriaturaP1(TiposCartasP1[indexP1]);
            }
            if (indexP1 == 1 || indexP1 == 6)
            {
                ColocaCartaEncantamentoP1(TiposCartasP1[indexP1]);
            }
            if (indexP1 == 2 || indexP1 == 5)
            {
                ColocaCartaFeiticoP1(TiposCartasP1[indexP1]);
            }
            if (indexP1 == 3 || indexP1 == 4)
            {
                ColocaCartaMagicaP1(TiposCartasP1[indexP1]);
            }
        }
        private void SorteiaTipoDeCartaP2()
        {
            Random randomP2 = new Random();
            //Player 1
            string[] TiposCartasP2;
            TiposCartasP2 = new string[8];
            TiposCartasP2[0] = "Criatura";
            TiposCartasP2[1] = "Encantamento";
            TiposCartasP2[2] = "Feitiço";
            TiposCartasP2[3] = "Magica instantânea";
            TiposCartasP2[4] = "Criatura";
            TiposCartasP2[5] = "Encantamento";
            TiposCartasP2[6] = "Feitiço";
            TiposCartasP2[7] = "Magica instantânea";
            int indexP2= randomP2.Next(0, TiposCartasP2.Length);
            if (indexP2 == 0 || indexP2 == 4)
            {
                ColocaCartaCriaturaP2(TiposCartasP2[indexP2]);
            }
            if (indexP2 == 1 || indexP2 == 5)
            {
                ColocaCartaEncantamentoP2(TiposCartasP2[indexP2]);
            }
            if (indexP2 == 2 || indexP2 == 6)
            {
                ColocaCartaFeiticoP2(TiposCartasP2[indexP2]);
            }
            if (indexP2 == 3 || indexP2 == 7)
            {
                ColocaCartaMagicaP2(TiposCartasP2[indexP2]);
            }
        }
        private void ColocaCartaCriaturaP1(string tipo)
        {
            label10.Visible = true;
            lbl_tipoP1.Text = tipo;
            Random randomP1 = new Random();
            int randP1 = randomP1.Next(0, Criaturas.ListaCriaturas.Count);
            int randfoto = randomP1.Next(0, Listas.ListaImagens.Count);
            lbl_nomeP1.Text = Criaturas.ListaCriaturas[randP1].Nome;
            lbl_custoP1.Text = Criaturas.ListaCriaturas[randP1].Custo.ToString();
            ManaP1 = ManaP1 - Criaturas.ListaCriaturas[randP1].Custo;
            lbl_manaP1.Text = ManaP1.ToString();
            tb_descricaoP1.Text = Criaturas.ListaCriaturas[randP1].Descricao;
            tb_ataqueP1.Text = Criaturas.ListaCriaturas[randP1].Ataque.ToString();
            AtaqueP1 = Criaturas.ListaCriaturas[randP1].Ataque;
            tb_habilidadeP1.Text = Criaturas.ListaCriaturas[randP1].Habilidade;
            tb_resistenciaP1.Text = Criaturas.ListaCriaturas[randP1].Resistencia.ToString();
            DefesaP1 = Criaturas.ListaCriaturas[randP1].Resistencia;
            lbl_ataqueP1.Text = AtaqueP1.ToString();
            lbl_defesaP1.Text = DefesaP1.ToString();
            pictureCriaturaP1.Image = Image.FromFile(Pasta+ Listas.ListaImagens[randfoto]);
            if (Criaturas.ListaCriaturas[randP1].Cor == "Verde")
            {
                pictureBox1.BackColor = Color.Green;
            }
            if (Criaturas.ListaCriaturas[randP1].Cor == "Azul")
            {
                pictureBox1.BackColor = Color.Blue;
            }
            if (Criaturas.ListaCriaturas[randP1].Cor == "Vermelho")
            {
                pictureBox1.BackColor = Color.Red;
            }
            if (Criaturas.ListaCriaturas[randP1].Cor == "Preto")
            {
                pictureBox1.BackColor = Color.Black;
            }
            if (Criaturas.ListaCriaturas[randP1].Cor == "Branco")
            {
                pictureBox1.BackColor = Color.White;
            }
            if (Criaturas.ListaCriaturas[randP1].Cor == "Sem Cor")
            {
                pictureBox1.BackColor = Color.Gold;
            }
        }
        private void ColocaCartaCriaturaP2(string tipo)
        {
            lbl_tipoP2.Text = tipo;
            label8.Visible = true;
            Random randomP2 = new Random();
            int randP2 = randomP2.Next(0, Criaturas.ListaCriaturas.Count);
            int randfoto = randomP2.Next(0, Listas.ListaImagens.Count);
            lbl_nomeP2.Text = Criaturas.ListaCriaturas[randP2].Nome;
            lbl_custoP2.Text = Criaturas.ListaCriaturas[randP2].Custo.ToString();
            ManaP2 = ManaP2 - Criaturas.ListaCriaturas[randP2].Custo;
            lbl_manaP2.Text = ManaP2.ToString();
            tb_descricaoP2.Text = Criaturas.ListaCriaturas[randP2].Descricao;
            tb_ataqueP2.Text = Criaturas.ListaCriaturas[randP2].Ataque.ToString();
            AtaqueP2 = Criaturas.ListaCriaturas[randP2].Ataque;
            tb_habilidadeP2.Text = Criaturas.ListaCriaturas[randP2].Habilidade;
            tb_resistenciaP2.Text = Criaturas.ListaCriaturas[randP2].Resistencia.ToString();
            DefesaP2 = Criaturas.ListaCriaturas[randP2].Resistencia;
            lbl_ataqueP2.Text = AtaqueP2.ToString();
            lbl_defesaP2.Text = DefesaP2.ToString();
            pictureCriaturaP2.Image = Image.FromFile(Pasta + Listas.ListaImagens[randfoto]);
            if (Criaturas.ListaCriaturas[randP2].Cor == "Verde")
            {
                pictureBox4.BackColor = Color.Green;
            }
            if (Criaturas.ListaCriaturas[randP2].Cor == "Azul")
            {
                pictureBox4.BackColor = Color.Blue;
            }
            if (Criaturas.ListaCriaturas[randP2].Cor == "Vermelho")
            {
                pictureBox4.BackColor = Color.Red;
            }
            if (Criaturas.ListaCriaturas[randP2].Cor == "Preto")
            {
                pictureBox4.BackColor = Color.Black;
            }
            if (Criaturas.ListaCriaturas[randP2].Cor == "Branco")
            {
                pictureBox4.BackColor = Color.White;
            }
            if (Criaturas.ListaCriaturas[randP2].Cor == "Sem Cor")
            {
                pictureBox4.BackColor = Color.Gold;
            }
        }
        private void ColocaCartaEncantamentoP1(string tipo)
        {
            label10.Visible = false;
            lbl_tipoP1.Text = tipo;
            Random randomP1 = new Random();
            int randP1 = randomP1.Next(0, Encantamentos.ListaEncantamentos.Count);
            int randfoto = randomP1.Next(0, Listas.ListaImagens.Count);
            AtaqueP1 = randomP1.Next(0, 9);
            DefesaP1 = 0;
            lbl_nomeP1.Text = Encantamentos.ListaEncantamentos[randP1].Nome;
            lbl_custoP1.Text = Encantamentos.ListaEncantamentos[randP1].Custo.ToString();
            ManaP1 = ManaP1 - Encantamentos.ListaEncantamentos[randP1].Custo;
            lbl_manaP1.Text = ManaP1.ToString();
            tb_descricaoP1.Text = Encantamentos.ListaEncantamentos[randP1].Descricao + AtaqueP1;
            tb_habilidadeP1.Text = Encantamentos.ListaEncantamentos[randP1].Habilidade;
            tb_ataqueP1.Text = "";
            tb_resistenciaP1.Text = "";
            lbl_ataqueP1.Text = AtaqueP1.ToString();
            lbl_defesaP1.Text = DefesaP1.ToString();
            pictureCriaturaP1.Image = Image.FromFile(Pasta + Listas.ListaImagens[randfoto]);
            if (Encantamentos.ListaEncantamentos[randP1].Cor == "Verde")
            {
                pictureBox1.BackColor = Color.Green;
            }
            if (Encantamentos.ListaEncantamentos[randP1].Cor == "Azul")
            {
                pictureBox1.BackColor = Color.Blue;
            }
            if (Encantamentos.ListaEncantamentos[randP1].Cor == "Vermelho")
            {
                pictureBox1.BackColor = Color.Red;
            }
            if (Encantamentos.ListaEncantamentos[randP1].Cor == "Preto")
            {
                pictureBox1.BackColor = Color.Black;
            }
            if (Encantamentos.ListaEncantamentos[randP1].Cor == "Branco")
            {
                pictureBox1.BackColor = Color.White;
            }
            if (Encantamentos.ListaEncantamentos[randP1].Cor == "Sem Cor")
            {
                pictureBox1.BackColor = Color.Gold;
            }
        }
        private void ColocaCartaEncantamentoP2(string tipo)
        {
            label8.Visible = false;
            lbl_tipoP2.Text = tipo;
            Random randomP2 = new Random();
            int randP2 = randomP2.Next(0, Encantamentos.ListaEncantamentos.Count);
            int randfoto = randomP2.Next(0, Listas.ListaImagens.Count);
            AtaqueP2 = randomP2.Next(0, 9);
            DefesaP2 = 0;
            lbl_nomeP2.Text = Encantamentos.ListaEncantamentos[randP2].Nome;
            lbl_custoP2.Text = Encantamentos.ListaEncantamentos[randP2].Custo.ToString();
            ManaP2 = ManaP2 - Encantamentos.ListaEncantamentos[randP2].Custo;
            lbl_manaP2.Text = ManaP2.ToString();
            tb_descricaoP2.Text = Encantamentos.ListaEncantamentos[randP2].Descricao + AtaqueP2;
            tb_habilidadeP2.Text = Encantamentos.ListaEncantamentos[randP2].Habilidade;
            tb_ataqueP2.Text = "";
            tb_resistenciaP2.Text = "";
            lbl_ataqueP2.Text = AtaqueP2.ToString();
            lbl_defesaP2.Text = DefesaP2.ToString();
            pictureCriaturaP2.Image = Image.FromFile(Pasta + Listas.ListaImagens[randfoto]);
            if (Encantamentos.ListaEncantamentos[randP2].Cor == "Verde")
            {
                pictureBox4.BackColor = Color.Green;
            }
            if (Encantamentos.ListaEncantamentos[randP2].Cor == "Azul")
            {
                pictureBox4.BackColor = Color.Blue;
            }
            if (Encantamentos.ListaEncantamentos[randP2].Cor == "Vermelho")
            {
                pictureBox4.BackColor = Color.Red;
            }
            if (Encantamentos.ListaEncantamentos[randP2].Cor == "Preto")
            {
                pictureBox4.BackColor = Color.Black;
            }
            if (Encantamentos.ListaEncantamentos[randP2].Cor == "Branco")
            {
                pictureBox4.BackColor = Color.White;
            }
            if (Encantamentos.ListaEncantamentos[randP2].Cor == "Sem Cor")
            {
                pictureBox4.BackColor = Color.Gold;
            }
        }
        private void ColocaCartaFeiticoP1(string tipo)
        {
            label10.Visible = false;
            lbl_tipoP1.Text = tipo;
            Random randomP1 = new Random();
            int randP1 = randomP1.Next(0, Feiticos.ListaFeiticos.Count);
            int randfoto = randomP1.Next(0, Listas.ListaImagens.Count);
            AtaqueP1 = randomP1.Next(0, 9);
            DefesaP1 = 0;
            lbl_nomeP1.Text = Feiticos.ListaFeiticos[randP1].Nome;
            lbl_custoP1.Text = Feiticos.ListaFeiticos[randP1].Custo.ToString();
            ManaP1 = ManaP1 - Feiticos.ListaFeiticos[randP1].Custo;
            lbl_manaP1.Text = ManaP1.ToString();
            tb_descricaoP1.Text = Feiticos.ListaFeiticos[randP1].Descricao + AtaqueP1;
            tb_habilidadeP1.Text = Feiticos.ListaFeiticos[randP1].Efeito;
            tb_ataqueP1.Text = "";
            tb_resistenciaP1.Text = "";
            lbl_ataqueP1.Text = AtaqueP1.ToString();
            lbl_defesaP1.Text = DefesaP1.ToString();
            pictureCriaturaP1.Image = Image.FromFile(Pasta + Listas.ListaImagens[randfoto]);
            if (Feiticos.ListaFeiticos[randP1].Cor == "Verde")
            {
                pictureBox1.BackColor = Color.Green;
            }
            if (Feiticos.ListaFeiticos[randP1].Cor == "Azul")
            {
                pictureBox1.BackColor = Color.Blue;
            }
            if (Feiticos.ListaFeiticos[randP1].Cor == "Vermelho")
            {
                pictureBox1.BackColor = Color.Red;
            }
            if (Feiticos.ListaFeiticos[randP1].Cor == "Preto")
            {
                pictureBox1.BackColor = Color.Black;
            }
            if (Feiticos.ListaFeiticos[randP1].Cor == "Branco")
            {
                pictureBox1.BackColor = Color.White;
            }
            if (Feiticos.ListaFeiticos[randP1].Cor == "Sem Cor")
            {
                pictureBox1.BackColor = Color.Gold;
            }
        }
        private void ColocaCartaFeiticoP2(string tipo)
        {
            label8.Visible = false;
            lbl_tipoP2.Text = tipo;
            Random randomP2 = new Random();
            int randP2 = randomP2.Next(0, Feiticos.ListaFeiticos.Count);
            int randfoto = randomP2.Next(0, Listas.ListaImagens.Count);
            AtaqueP2 = randomP2.Next(0, 9);
            DefesaP2 = 0;
            lbl_nomeP2.Text = Feiticos.ListaFeiticos[randP2].Nome;
            lbl_custoP2.Text = Feiticos.ListaFeiticos[randP2].Custo.ToString();
            ManaP2 = ManaP2 - Feiticos.ListaFeiticos[randP2].Custo;
            lbl_manaP2.Text = ManaP2.ToString();
            tb_descricaoP2.Text = Feiticos.ListaFeiticos[randP2].Descricao + AtaqueP2;
            tb_habilidadeP2.Text = Feiticos.ListaFeiticos[randP2].Efeito;
            tb_ataqueP2.Text = "";
            tb_resistenciaP2.Text = "";
            lbl_ataqueP2.Text = AtaqueP2.ToString();
            lbl_defesaP2.Text = DefesaP2.ToString();
            pictureCriaturaP2.Image = Image.FromFile(Pasta + Listas.ListaImagens[randfoto]);
            if (Feiticos.ListaFeiticos[randP2].Cor == "Verde")
            {
                pictureBox4.BackColor = Color.Green;
            }
            if (Feiticos.ListaFeiticos[randP2].Cor == "Azul")
            {
                pictureBox4.BackColor = Color.Blue;
            }
            if (Feiticos.ListaFeiticos[randP2].Cor == "Vermelho")
            {
                pictureBox4.BackColor = Color.Red;
            }
            if (Feiticos.ListaFeiticos[randP2].Cor == "Preto")
            {
                pictureBox4.BackColor = Color.Black;
            }
            if (Feiticos.ListaFeiticos[randP2].Cor == "Branco")
            {
                pictureBox4.BackColor = Color.White;
            }
            if (Feiticos.ListaFeiticos[randP2].Cor == "Sem Cor")
            {
                pictureBox4.BackColor = Color.Gold;
            }
        }
        private void ColocaCartaMagicaP1(string tipo)
        {
            label10.Visible = false;
            lbl_tipoP1.Text = tipo;
            Random randomP1 = new Random();
            int randP1 = randomP1.Next(0, MagicaInstantaneas.ListaMagicaInstantanea.Count);
            int randfoto = randomP1.Next(0, Listas.ListaImagens.Count);
            AtaqueP1 = randomP1.Next(0, 9);
            DefesaP1 = 0;
            lbl_nomeP1.Text = MagicaInstantaneas.ListaMagicaInstantanea[randP1].Nome;
            lbl_custoP1.Text = MagicaInstantaneas.ListaMagicaInstantanea[randP1].Custo.ToString();
            ManaP1 = ManaP1 - MagicaInstantaneas.ListaMagicaInstantanea[randP1].Custo;
            lbl_manaP1.Text = ManaP1.ToString();
            tb_descricaoP1.Text = MagicaInstantaneas.ListaMagicaInstantanea[randP1].Descricao + AtaqueP1;
            tb_habilidadeP1.Text = MagicaInstantaneas.ListaMagicaInstantanea[randP1].Efeito;
            tb_ataqueP1.Text = "";
            tb_resistenciaP1.Text = "";
            lbl_ataqueP1.Text = AtaqueP1.ToString();
            lbl_defesaP1.Text = DefesaP1.ToString();
            pictureCriaturaP1.Image = Image.FromFile(Pasta + Listas.ListaImagens[randfoto]);
            if (MagicaInstantaneas.ListaMagicaInstantanea[randP1].Cor == "Verde")
            {
                pictureBox1.BackColor = Color.Green;
            }
            if (MagicaInstantaneas.ListaMagicaInstantanea[randP1].Cor == "Azul")
            {
                pictureBox1.BackColor = Color.Blue;
            }
            if (MagicaInstantaneas.ListaMagicaInstantanea[randP1].Cor == "Vermelho")
            {
                pictureBox1.BackColor = Color.Red;
            }
            if (MagicaInstantaneas.ListaMagicaInstantanea[randP1].Cor == "Preto")
            {
                pictureBox1.BackColor = Color.Black;
            }
            if (MagicaInstantaneas.ListaMagicaInstantanea[randP1].Cor == "Branco")
            {
                pictureBox1.BackColor = Color.White;
            }
            if (MagicaInstantaneas.ListaMagicaInstantanea[randP1].Cor == "Sem Cor")
            {
                pictureBox1.BackColor = Color.Gold;
            }
        }
        private void ColocaCartaMagicaP2(string tipo)
        {
            label8.Visible = false;
            lbl_tipoP2.Text = tipo;
            Random randomP2 = new Random();
            int randP2 = randomP2.Next(0, MagicaInstantaneas.ListaMagicaInstantanea.Count);
            int randfoto = randomP2.Next(0, Listas.ListaImagens.Count);
            AtaqueP2 = randomP2.Next(0, 9);
            DefesaP2 = 0;
            lbl_nomeP2.Text = MagicaInstantaneas.ListaMagicaInstantanea[randP2].Nome;
            lbl_custoP2.Text = MagicaInstantaneas.ListaMagicaInstantanea[randP2].Custo.ToString();
            ManaP2 = ManaP2 - MagicaInstantaneas.ListaMagicaInstantanea[randP2].Custo;
            lbl_manaP2.Text = ManaP2.ToString();
            tb_descricaoP2.Text = MagicaInstantaneas.ListaMagicaInstantanea[randP2].Descricao + AtaqueP2;
            tb_habilidadeP2.Text = MagicaInstantaneas.ListaMagicaInstantanea[randP2].Efeito;
            tb_ataqueP2.Text = "";
            tb_resistenciaP2.Text = "";
            lbl_ataqueP2.Text = AtaqueP2.ToString();
            lbl_defesaP2.Text = DefesaP2.ToString();
            pictureCriaturaP2.Image = Image.FromFile(Pasta + Listas.ListaImagens[randfoto]);
            if (MagicaInstantaneas.ListaMagicaInstantanea[randP2].Cor == "Verde")
            {
                pictureBox4.BackColor = Color.Green;
            }
            if (MagicaInstantaneas.ListaMagicaInstantanea[randP2].Cor == "Azul")
            {
                pictureBox4.BackColor = Color.Blue;
            }
            if (MagicaInstantaneas.ListaMagicaInstantanea[randP2].Cor == "Vermelho")
            {
                pictureBox4.BackColor = Color.Red;
            }
            if (MagicaInstantaneas.ListaMagicaInstantanea[randP2].Cor == "Preto")
            {
                pictureBox4.BackColor = Color.Black;
            }
            if (MagicaInstantaneas.ListaMagicaInstantanea[randP2].Cor == "Branco")
            {
                pictureBox4.BackColor = Color.White;
            }
            if (MagicaInstantaneas.ListaMagicaInstantanea[randP2].Cor == "Sem Cor")
            {
                pictureBox4.BackColor = Color.Gold;
            }
        }

        private void CalculosDanos()
        {
            PoderAtaqueP2 = AtaqueP2 - DefesaP1;
            PoderAtaqueP1 = AtaqueP1 - DefesaP2;
            if (PoderAtaqueP1 < 0)
            {
                PoderAtaqueP1 = 0;
            }
            if (PoderAtaqueP2 < 0)
            {
                PoderAtaqueP2 = 0;
            }
            VidaP1 = VidaP1 - PoderAtaqueP2;
            lbl_valvidaP1.Text = VidaP1.ToString();
            VidaP2 = VidaP2 - PoderAtaqueP1;
            lbl_valvidaP2.Text = VidaP2.ToString();
            AtualizaValores();
        }
        private void AtualizaValores()
        {
            lbl_manaP1.Text = ManaP1.ToString();
            lbl_deckP1.Text = deckP1.ToString();
            if (VidaP1 <= 0)
            {
                VidaP1 = 0;
                MessageBox.Show("Player 2 venceu o jogo!!!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            if (VidaP2 <= 0)
            {
                VidaP2 = 0;
                MessageBox.Show("Player 1 venceu o jogo!!!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            progressBar1.Value = VidaP1;
            lbl_manaP2.Text = ManaP2.ToString();
            lbl_deckP2.Text = deckP2.ToString();
            progressBar2.Value = VidaP2;
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem a certeza que pretende abandonar o jogo?", "SAIR", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) return;
            this.Close();
        }
    }
}
