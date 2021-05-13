using ClassMagic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExercicioMagic
{
    public partial class Form1 : Form
    {
        int clicktest = 0;
        public Form1()
        {
            InitializeComponent();

        }

        private void btn_criar_Click(object sender, EventArgs e)
        {
            if (clicktest == 0)
            {
                btn_criatura.Visible = true;
                btn_encantamento.Visible = true;
                //btn_feitico.Visible = true;
                //btn_magica.Visible = true;
                //btn_terreno.Visible = true;
                clicktest = 1;
                //btn_sobre.Visible = false;
                return;
            }
            if (clicktest == 1)
            {
                btn_criatura.Visible = false;
                btn_encantamento.Visible = false;
                //btn_feitico.Visible = false;
                //btn_magica.Visible = false;
                //btn_terreno.Visible = false;
                clicktest = 0;
                //btn_sobre.Visible = true;
                return;
            }


        }

        private void btn_jogar_Click(object sender, EventArgs e)
        {
            frmJogo jogo = new frmJogo();
            jogo.Show();
        }
        private void btn_criatura_Click(object sender, EventArgs e)
        {
            UC_Criatura ucCartas = new UC_Criatura();
            AdicionarControladorAoPainel(ucCartas);
        }

        private void btn_encantamento_Click(object sender, EventArgs e)
        {
            UC_Encantamento ucEncantamento = new UC_Encantamento();
            AdicionarControladorAoPainel(ucEncantamento);
        }

        private void AdicionarControladorAoPainel(Control c)
        {
            c.Dock = DockStyle.Fill;
            panelControls.Controls.Clear();
            panelControls.Controls.Add(c);
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            //Pergunta se pretende sair da aplicação
            if (MessageBox.Show("Deseja sair da aplicação?", "SAIR", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) return;

            //Botão fecha a aplicação
            Application.Exit();
        }

        private void btn_sobre_Click(object sender, EventArgs e)
        {
            UC_Home uchome = new UC_Home();
            AdicionarControladorAoPainel(uchome);
            
        }
    }
}
