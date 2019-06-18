using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace programacaofinalprojecto
{
    public partial class Form12 : Form
    {
        public Form12()
        {
            InitializeComponent();
            Tabela();
        }

        public readonly int Numerodejogadores = 10;


        private void Button5_Click(object sender, EventArgs e)
        {
            /*Comando que faz com que o botão altere a página*/
            Form4 Jogo = new Form4();
            this.Hide();
            Jogo.ShowDialog();
            this.Dispose();
        }

        private User[] Tabela()
        {
            User[] lista = new User[Numerodejogadores];
            DB db = new DB();

            db.connect();
            db.openConnection();
           
            
            string QueryAdmin = ("SELECT top(10) pontos, Nome FROM utilizador ORDER BY pontos DESC");
            SqlCommand CommandAdmin = new SqlCommand(QueryAdmin, db.getConnection());
            SqlDataAdapter dataAdapt = new SqlDataAdapter(CommandAdmin);
            DataTable dtRecord = new DataTable();
            dataAdapt.Fill(dtRecord);
            dataGridView1.DataSource = dtRecord;


            return lista;

        }
    }
}



