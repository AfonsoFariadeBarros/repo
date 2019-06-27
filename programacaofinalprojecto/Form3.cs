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
    public partial class Form3 : Form
    {
        
        public Form3()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //Create a new user
            SqlConnection con = new SqlConnection(Properties.Settings.Default.Connection);

            if (txt_utilizador.Text == "" || textBox1.Text == "" || textBox2.Text == "" || txt_utilizador.Text == "Digite o nome de utilizador" || textBox1.Text == "Digite a password desejada" || textBox2.Text == "Digite o seu email")
            {
                MessageBox.Show("Campos não preenchidos!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    con.Open();

                    SqlDataReader dr;
                    string Queryselect = ("SELECT IDUtilizador, Nome, Email FROM utilizador WHERE Nome = @Utilizador OR Email = @Email");
                    SqlCommand Commandselect = new SqlCommand(Queryselect, con);

                    Commandselect.Parameters.AddWithValue("@utilizador", txt_utilizador.Text);
                    Commandselect.Parameters.AddWithValue("@email", textBox2.Text);

                    dr = Commandselect.ExecuteReader();

                    if (dr.Read())
                    {
                        MessageBox.Show("Utilizador ou Email já usados!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        dr.Close();
                    }
                    else
                    {
                        dr.Close();
                        string QueryInsert = "INSERT INTO utilizador (Email, nome, pass) VALUES (@email, @username, @password)";

                        SqlCommand Command = new SqlCommand(QueryInsert, con);
                        Command.Parameters.AddWithValue("@email", textBox2.Text);
                        Command.Parameters.AddWithValue("@username", txt_utilizador.Text);
                        Command.Parameters.AddWithValue("@password", textBox1.Text);
                        Command.ExecuteNonQuery();


                        //Open the connection


                        //Execute  the query
                        MessageBox.Show("Conta Criada");
                        Form2 LogIN = new Form2();
                        this.Hide();
                        LogIN.ShowDialog();
                        this.Dispose();
                    }

                }
                catch (Exception x)
                {
                    MessageBox.Show(x.ToString());
                }
                finally
                {
                    con.Close();
                }
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
            /*Comando que faz com que o texto desaparaça assim que o utilizador carrega para introduzir texto*/
            if (txt_utilizador.Text == "")
            {
                txt_utilizador.Text = "Digite o nome de utilizador";
                txt_utilizador.ForeColor = Color.DimGray;


            }
        }

        private void TextBox2_Enter(object sender, EventArgs e)
        {
            /*Comando que faz com que o texto desaparaça assim que o utilizador carrega para introduzir texto*/
           
            if (txt_utilizador.Text == "Digite a password desejada")
            {
                txt_utilizador.Text = "";
                txt_utilizador.ForeColor = Color.Black;


            }
        }

        private void TextBox2_Leave(object sender, EventArgs e)
        {
            /*Comando que faz com que o texto desaparaça assim que o utilizador carrega para introduzir texto*/
            if (txt_utilizador.Text == "")
            {
                txt_utilizador.Text = "Digite a password desejada";
                txt_utilizador.ForeColor = Color.DimGray;


            }
        }

        private void TextBox3_Enter(object sender, EventArgs e)
        {
            /*Comando que faz com que o texto desaparaça assim que o utilizador carrega para introduzir texto*/
            if (txt_utilizador.Text == "Digite o seu email")
            {
                txt_utilizador.Text = "";
                txt_utilizador.ForeColor = Color.Black;


            }
        }

        private void TextBox3_Leave(object sender, EventArgs e)
        {
            /*Comando que faz com que o texto desaparaça assim que o utilizador carrega para introduzir texto*/
            if (txt_utilizador.Text == "")
            {
                txt_utilizador.Text = "Digite o seu email";
                txt_utilizador.ForeColor = Color.DimGray;


            }
        }

        
    }
}
