using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace programacaofinalprojecto
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            /*Comando que faz com que o botão altere a página*/
            Form4 Jogo = new Form4();
            this.Hide();
            Jogo.ShowDialog();
            this.Dispose();
        }

        private void Button2_Click_1(object sender, EventArgs e)
        {
            /*Comando que faz com que o botão altere a página*/
            Form1 Inicio = new Form1();
            this.Hide();
            Inicio.ShowDialog();
            this.Dispose();
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Properties.Settings.Default.Connection);
            con.Open();
            
            string Nome = "";
            int pontos = 0;
            SqlDataReader dr = null ;
            try
            {

               
                string QueryAdmin = ("SELECT Nome, pontos FROM utilizador WHERE Nome = @Utilizador AND Pass = @Palavra_Chave");
                SqlCommand CommandAdmin = new SqlCommand(QueryAdmin, con);

                CommandAdmin.Parameters.AddWithValue("@utilizador", txt_utilizador.Text);
                CommandAdmin.Parameters.AddWithValue("@Palavra_Chave", txt_password.Text);

                dr = CommandAdmin.ExecuteReader();

                while (dr.Read())
                {
                    
                    Nome = dr["Nome"].ToString();
                    pontos = (int)dr["pontos"];
                    
                }
               


                if (dr.HasRows)
                {
                    Jogo jogo = Jogo.getinstance();

                    //buscar os dados do user na base de dados
                    jogo.userajogar = new User(Nome,pontos);

                    /*Comando que faz com que o botão altere a página*/
                    Form4 boom = new Form4();
                    this.Hide();
                    boom.ShowDialog();
                    this.Dispose();
                }
                else
                {
                    MessageBox.Show("Utilizador e/ou Password incorretos!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                dr.Close();
                con.Close();
            }
            

            
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            /*Comando que faz com que o botão altere a página*/
            Form1 Inicio = new Form1();
            this.Hide();
            Inicio.ShowDialog();
            this.Dispose();
        }
        private void Txt_utilizador_Enter(object sender, EventArgs e)
        {
            /*Comando que faz com que o texto desaparaça assim que o utilizador carrega para introduzir texto*/
            if (txt_utilizador.Text == "Digite o nome de utilizador")
            {
                txt_utilizador.Text = "";
                txt_utilizador.ForeColor = Color.Black;
            }
        }
        private void Txt_utilizador_Leave(object sender, EventArgs e)
        {
            if (txt_utilizador.Text == "")
            {
                txt_utilizador.Text = "Digite o nome de utilizador";
                txt_utilizador.ForeColor = Color.DimGray;
            }
        }


        private void Txt_password_Leave(object sender, EventArgs e)
        {
            
            if (txt_password.Text == "")
            {
                txt_password.Text = "Digite a password desejada";
                txt_password.ForeColor = Color.DimGray;
                txt_password.UseSystemPasswordChar = false;
            }
        }

        private void Txt_password_Enter(object sender, EventArgs e)
        {
            /*faz com que o texto mude de cor ao carregar*/

            if (txt_password.Text == "Digite a password desejada")
            {
                txt_password.Text = "";
                txt_password.ForeColor = Color.Black;
                txt_password.UseSystemPasswordChar = true;
            }
        }
    }
}
