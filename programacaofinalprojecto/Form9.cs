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
    public partial class Form9 : Form
    {
        private int pontos;
        private int preco;
        public Form9(int preco, int pontos)
        {
            this.pontos = pontos;
            this.preco = preco;
            InitializeComponent();
            label1.Text = "" + preco +"€";
        }
        public Form9()
        {
         
            InitializeComponent(); 
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            /*Comando que faz com que o botão altere a página*/
            Form10 Morada = new Form10();
            this.Hide();
            Morada.ShowDialog();
            this.Dispose();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            /*Comando que faz com que o botão altere a página*/
            Form8 Morada = new Form8();
            this.Hide();
            Morada.ShowDialog();
            this.Dispose();
        }

        private void Button2_Click_1(object sender, EventArgs e)
        {
            /*Comando que faz com que o botão crie uma mensagem de alerta ao utilizador*/
            MessageBox.Show("Vão ser adicionados "+pontos+" pontos à sua conta, esta operação pode demorar alguns minutos.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            User user = Jogo.getinstance().userajogar;
            user.pontos += pontos;
            user.atualizarpontosbd();
            /*Comando que faz com que o botão altere a página*/
            Form5 Conta = new Form5();
            this.Hide();
            Conta.ShowDialog();
            this.Dispose();
        }



        
    }
}
