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
    public partial class UC_Encantamento : UserControl
    {
        public UC_Encantamento()
        {
            InitializeComponent();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
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
            if (string.IsNullOrEmpty(tb_habilidade.Text))
            {
                MessageBox.Show("Introduza a habilidade da criatura", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            panelTemplate.Visible = true;
            lbl_Snome.Text = tb_nome.Text;
            lbl_tipo.Text = "Encantamento";
            lbl_Scusto.Text = tb_custo.Text;
            tb_Sdescricao.Text = tb_descricao.Text;
            pictureCriatura.Image = Image.FromFile(@"D:\Transferências\enchantment.jpg");
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
            tb_habilidade.Text = "";
            label11.Visible = true;
        }
    }
}
