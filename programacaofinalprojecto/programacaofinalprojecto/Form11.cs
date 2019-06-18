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
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
        }

        
        private void Button_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            int preco = 0;
            int pontos = 0;
            if (b.Text.StartsWith("1000 "))
            {
                preco = 2;
                pontos = 1000;
            }
            else if (b.Text.StartsWith("3000"))
            {
                preco = 4;
                pontos =3000;
            }
            else if (b.Text.StartsWith("6000"))
            {
                preco = 6;
                pontos =6000;
            }
            else if (b.Text.StartsWith("10000"))
            {
                preco = 7;
                pontos =10000;
            }


            /*Comando que faz com que o botão altere a página*/
            Form8 PayPal = new Form8(preco,pontos);
            this.Hide();
            PayPal.ShowDialog();
            this.Dispose();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            /*Comando que faz com que o botão altere a página*/
            Form5 Conta = new Form5();
            this.Hide();
            Conta.ShowDialog();
            this.Dispose();

        }
    }
}
