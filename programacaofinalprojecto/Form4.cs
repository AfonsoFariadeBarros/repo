using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace programacaofinalprojecto
{
    public partial class Form4 : Form
    {
        public int NumeroDeBombas { get; set; }
        public int NumeroDePontosApostados { get; set; }

        public Form4()
        {

            InitializeComponent();
            Jogo jogo = Jogo.getinstance();
            textBox1.Text = "Tem "+jogo.userajogar.pontos+" pontos.";
        }

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            /*Comando que faz com que o botão altere a página*/
            Form5 Conta = new Form5();
            this.Hide();
            Conta.ShowDialog();
            this.Dispose();
        }

        private void Button30_Click(object sender, EventArgs e)
        {

            /*Comando que faz com que o botão altere a página*/
            User user = Jogo.getinstance().userajogar;
            if (NumeroDePontosApostados <= user.pontos)
            {
                Form7 Bombas = new Form7(NumeroDeBombas, NumeroDePontosApostados);
                Bombas.ShowDialog();
                this.Hide();
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Não tens pontos suficientes!");
            }
           
        }

        private void Button26_Click(object sender, EventArgs e)
        {
            /*Comando que faz com que o botão altere a página*/
            Form12 Scoreboard = new Form12();
            this.Hide();
            Scoreboard.ShowDialog();
            this.Dispose();
        }

        private void NumeroDeBombas_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Text.Equals("1"))
            {
                NumeroDeBombas = 1;
            }


            else if (b.Text.Equals("3"))
            {
                NumeroDeBombas = 3;
            }


            else if (b.Text.Equals("5"))
            {
                NumeroDeBombas = 5;
            }

            else if (b.Text.Equals("24"))
            {
                NumeroDeBombas = 24;
            }

                   
                    
                    }

        private void NumericUpDown1_ValueChanged(object sender, EventArgs e)
        {

            NumeroDePontosApostados = Decimal.ToInt32(numericUpDown1.Value);
        }
    }
}
