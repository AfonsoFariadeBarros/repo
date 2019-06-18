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
    public partial class Form10 : Form
    {
        private int pontos;
        public Form10(int pontos)
        {
            this.pontos = pontos;
            InitializeComponent();
        }
        public Form10()
        {
            
            InitializeComponent();
        }



        private void Button3_Click(object sender, EventArgs e)
        {
            /*Comando que faz com que o botão altere a página*/
            Form9 PaypalPagar = new Form9();
            this.Hide();
            PaypalPagar.ShowDialog();
            this.Dispose();

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            /*Comando que faz com que o botão crie uma mensagem de alerta ao utilizador*/
            MessageBox.Show("O produto será enviado para si o mais rápido possível.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            User user = Jogo.getinstance().userajogar;
            user.pontos -= pontos;
            user.atualizarpontosbd();
            /*Comando que faz com que o botão altere a página*/
            Form6 Loja = new Form6();
            this.Hide();
            Loja.ShowDialog();
            this.Dispose();
        }
    }
}
