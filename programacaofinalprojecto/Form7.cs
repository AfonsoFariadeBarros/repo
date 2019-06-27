using System;
using System.Collections;
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
    public partial class Form7 : Form
    {
        public List<ButaoSelecionavel> buttoes;
        public readonly int NumeroDeButoes = 25;
        public readonly int NumeroDeBombas;
        private User user;
        private int pontosApostados;
        private int pontosAadicionar = 0;

        private void terminarclick(object Sender, EventArgs e)
        {
            user.pontos += pontosAadicionar;
            user.atualizarpontosbd();
            criarForm4("Ganhou "+pontosAadicionar+" pontos. Parabéns!");
           
        }

        public Form7(int numeroDeBombas, int pontosApostados)
        {
            this.pontosApostados = pontosApostados;
            this.NumeroDeBombas = numeroDeBombas;

            pontosAadicionar = pontosApostados;

            user = Jogo.getinstance().userajogar;
           
                user.pontos -= pontosApostados;
                user.atualizarpontosbd();
               
           
           
            InitializeComponent();
            Init();
            BombasAleatorias();

        }

        /*Colocar as bombas em posiçoes aleatorias*/
        private void BombasAleatorias()
        {
            Random R = new Random();
            List<int> randomList = new List<int>();
            while (randomList.Count < NumeroDeBombas)
            {
                int indice = R.Next(NumeroDeButoes);
                if (!randomList.Contains(indice))
                    randomList.Add(indice);
                
            }
            foreach(int i in randomList)
            {
                ButaoSelecionavel bs = buttoes.ElementAt(i);
                bs.tembomba = true;
            }

            




    }




        /*Código que faz os botões em que quero colocar os botões aleatórios fiquem listados*/
        private void Init()
        {
            buttoes = new List<ButaoSelecionavel>();

            foreach (Control c in Controls)
            {
                if (c is Button)
                {
                    Button b = (Button)c;
                    if (!b.Text.Equals("TERMINAR"))
                    {

                        buttoes.Add(new ButaoSelecionavel(b));
                    }
                }
            }
        }

       

        private void criarForm4(String message)
        {
            MessageBox.Show(message,"Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            /*Comando que faz com que o botão altere a página*/
            Form4 Voltar = new Form4();
            this.Hide();
            Voltar.ShowDialog();
            
             this.Dispose();
        }
 
        public class ButaoSelecionavel

        {
            public bool tembomba { get; set;}
            public Button button { get; }
            
            public ButaoSelecionavel( Button b)
            {
                this.button = b;
            }
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            foreach ( ButaoSelecionavel bs in buttoes)
            {
                if (b.Equals(bs.button))
                {
                    bs.button.Enabled = false;

                    if (bs.tembomba)
                    {

                        criarForm4("Ups! Perdeu os pontos colocados!");
                    }
                    else
                    {
                        pontosAadicionar += (int)(pontosApostados * pontosNumBombas());
                        textBox3.Text =""+pontosAadicionar;
                        bs.button.BackgroundImage = Image.FromFile("C:\\Users\\PSI17F01\\Desktop\\repo-master (1)\\repo-master\\check.png");
                        bs.button.BackgroundImageLayout = ImageLayout.Stretch;
                    }
                }

            }
        }
        private double pontosNumBombas()
        {
            switch (NumeroDeBombas)
            {
                case 1:
                    return 2;
                case 3:
                    return 3;
                case 5:
                    return 4;
                case 24:
                    return 24;
                default:

                   return 0;
            }
        }


    }

}
