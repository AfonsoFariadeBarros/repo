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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        

        
        private void Button3_Click(object sender, EventArgs e)
        {
            /*Comando que faz com que o botão altere a página*/
            Form5 Conta = new Form5();
            this.Hide();
            Conta.ShowDialog();
            this.Dispose();
        }

       
        private void buttonclick(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            int pontos=0;

            if (b.Name.Equals("button30"))
            {
                pontos = 7000;
            }

            else if (b.Name.Equals("button1"))
            {
                pontos = 10000;
            }

            else if (b.Name.Equals("button2"))
            {
                pontos = 1000;
            }

            User user = Jogo.getinstance().userajogar;




            if (user.pontos >= pontos)
            { 
                Form10 Morada = new Form10(pontos);
                this.Hide();
                Morada.ShowDialog();
                this.Dispose();
            }

            else
            {
                MessageBox.Show("Não tem pontos suficientes.");

            }
        }

    }

       
    
}
