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
    public partial class UC_Criatura : UserControl
    {
        public UC_Criatura()
        {
            InitializeComponent();
        }

        private void btn_gravar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tb_nome.Text))
            {
                MessageBox.Show("Introduza  o nome da criatura", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (string.IsNullOrEmpty(cb_cor.Text))
            {
                MessageBox.Show("Introduza a cor da carta", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (cb_cor.Text != "Azul" && cb_cor.Text != "Verde" && cb_cor.Text != "Vermelho" && cb_cor.Text != "Preto" && cb_cor.Text != "Branco" && cb_cor.Text != "Sem Cor")
            {
                MessageBox.Show("Cor inserida inválida", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (string.IsNullOrEmpty(tb_descricao.Text))
            {
                MessageBox.Show("Introduza a descrição da criatura", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (string.IsNullOrEmpty(tb_custo.Text))
            {
                MessageBox.Show("Introduza o custo da carta", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (string.IsNullOrEmpty(tb_ataque.Text))
            {
                MessageBox.Show("Introduza o ataque da criatura", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (string.IsNullOrEmpty(tb_resistencia.Text))
            {
                MessageBox.Show("Introduza o resistência  da criatura", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (string.IsNullOrEmpty(tb_habilidade.Text))
            {
                MessageBox.Show("Introduza a habilidade da criatura", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            panelTemplate.Visible = true;
            lbl_Snome.Text = tb_nome.Text;
            lbl_tipo.Text = "Criatura";
            lbl_Scusto.Text = tb_custo.Text;
            tb_Sdescricao.Text = tb_descricao.Text;
            tb_Sataque.Text = tb_ataque.Text;
            tb_Shabilidade.Text = tb_habilidade.Text;
            tb_Sresistencia.Text = tb_resistencia.Text;
            pictureCriatura.Image = Image.FromFile(@"D:\Transferências\Creature-Animation-Dozer-Mobile.jpg");
            if (cb_cor.Text == "Verde")
            {
                pictureBox1.BackColor = Color.Green;
            }
            if (cb_cor.Text == "Azul")
            {
                pictureBox1.BackColor = Color.Blue;
            }
            if (cb_cor.Text == "Vermelho")
            {
                pictureBox1.BackColor = Color.Red;
            }
            if (cb_cor.Text == "Preto")
            {
                pictureBox1.BackColor = Color.Black;
            }
            if (cb_cor.Text == "Branco")
            {
                pictureBox1.BackColor = Color.White;
            }
            if (cb_cor.Text == "Sem Cor")
            {
                pictureBox1.BackColor = Color.Gold;
            }
            tb_nome.Text = "";
            cb_cor.Text = "";
            tb_custo.Text = "";
            tb_descricao.Text = "";
            tb_ataque.Text = "";
            tb_resistencia.Text = "";
            tb_habilidade.Text = "";
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
