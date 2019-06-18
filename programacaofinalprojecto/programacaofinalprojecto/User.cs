using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace programacaofinalprojecto
{
    class User
    {
        public int pontos { get; set; }
        public string Username { get; internal set; }


        public User(string username, int pontos)
        {
            Username = username;
            this.pontos = pontos;
        }

        public void atualizarpontosbd()
        {

            DB db = null;
            try { 
            db = new DB();
                db.connect();

            db.openConnection();
                
                string Queryselect = ("UPDATE utilizador SET pontos=@pontos WHERE Nome = @Username");
            SqlCommand Commandselect = new SqlCommand(Queryselect, db.getConnection());

            Commandselect.Parameters.AddWithValue("@username", Username);
            Commandselect.Parameters.AddWithValue("@pontos", pontos);
            Commandselect.ExecuteNonQuery();
                
            }


            catch (Exception x)
            {
                MessageBox.Show("Error no update" + x.ToString());
            }

            finally
            {
                db.closeConnection();
            }


            
        }
        public void atualizardados(string password, string username)
        {
            DB db = null;
            try
            {
                db = new DB();
                db.connect();

                db.openConnection();

                string Queryselect = "";
                if (!password.Equals("") && username.Equals(""))
                {
                    Queryselect = "UPDATE utilizador SET pass=@password WHERE Nome = @Username";
                }



                else if (password.Equals("") && !username.Equals(""))
                {
                    Queryselect = "UPDATE utilizador SET Nome=@user WHERE Nome = @Username";
                  
                }

                else if (!password.Equals("") && !username.Equals(""))
                {
                    Queryselect = "UPDATE utilizador SET Nome=@user,pass=@password WHERE Nome = @Username";
                }

                SqlCommand Commandselect = new SqlCommand(Queryselect, db.getConnection());

                Commandselect.Parameters.AddWithValue("@username", Username);
                Commandselect.Parameters.AddWithValue("@user", username);
                Commandselect.Parameters.AddWithValue("@password", password);
                Commandselect.ExecuteNonQuery();

            }


            catch (Exception x)
            {
                MessageBox.Show("Error no update" + x.ToString());
            }

            finally
            {
                if (!Username.Equals(username))
                    Username = username;
                db.closeConnection();
            }

        }
    }
}
