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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
            User user = Jogo.getinstance().userajogar;
            label1.Text = "Olá, " + user.Username;
            textBox1.Text = "Tem " +user.pontos+ " pontos.";
        }

        

        private void Button2_Click(object sender, EventArgs e)
        {
            /*Comando que faz com que o botão altere a página*/
            Form6 Loja = new Form6();
            this.Hide();
            Loja.ShowDialog();
            this.Dispose();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            /*Comando que faz com que o botão altere a página*/
            Form1 Inicio = new Form1();
            this.Hide();
            Inicio.ShowDialog();
            this.Dispose();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            /*Comando que faz com que o botão altere a página*/
            Form4 Jogo = new Form4();
            this.Hide();
            Jogo.ShowDialog();
            this.Dispose();
        }

        private void Button31_Click(object sender, EventArgs e)
        {
            /*Comando que faz com que o botão altere a página*/
            Form11 Adicionar = new Form11();
            this.Hide();
            Adicionar.ShowDialog();
            this.Dispose();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            User user = Jogo.getinstance().userajogar;
            if (textBox2.Text != "" || txt_utilizador.Text != "")
            {
                user.atualizardados(textBox2.Text, txt_utilizador.Text);
            }
            else
            {
                MessageBox.Show("Por favor! Introduza os dados a atualizar.");
            }

        }
    }
}
