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
    public partial class Form8 : Form
    {
        private int pontos;
        private int preco;
        public Form8(int preco, int pontos)
        {
            this.pontos = pontos;
            this.preco = preco;
            InitializeComponent();
        }
        public Form8()
        {
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            /*Comando que faz com que o botão altere a página*/
            Form9 PayPalPagar = new Form9(preco,pontos);
            this.Hide();
            PayPalPagar.ShowDialog();
            this.Dispose();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            /*Comando que faz com que o botão altere a página*/
            Form11 Adicionar = new Form11();
            this.Hide();
            Adicionar.ShowDialog();
            this.Dispose();
        }
    }
}
