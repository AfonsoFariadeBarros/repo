using System.Data.SqlClient;
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



    public partial class Form1 : Form
    {
         
        private Panel pnl_lateral;
        private Button button8;
        private Button button7;
        private PictureBox pictureBox5;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Button button10;
        private Button button4;
        private Button button2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private Button button3;

        public Form1()
        {
            InitializeComponent();
            
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Form2 Login = new Form2();
            this.Hide();
            Login.ShowDialog();
            this.Dispose();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Form3 Registo = new Form3();
            this.Hide();
            Registo.ShowDialog();
            this.Dispose();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pnl_lateral = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button10 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.button7 = new System.Windows.Forms.Button();
            this.pnl_lateral.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_lateral
            // 
            this.pnl_lateral.BackColor = System.Drawing.Color.PowderBlue;
            this.pnl_lateral.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnl_lateral.Controls.Add(this.panel1);
            this.pnl_lateral.Controls.Add(this.button3);
            this.pnl_lateral.Controls.Add(this.button8);
            this.pnl_lateral.Controls.Add(this.pictureBox5);
            this.pnl_lateral.Controls.Add(this.button7);
            this.pnl_lateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_lateral.Location = new System.Drawing.Point(0, 0);
            this.pnl_lateral.Name = "pnl_lateral";
            this.pnl_lateral.Size = new System.Drawing.Size(72, 297);
            this.pnl_lateral.TabIndex = 21;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightCyan;
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.button10);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Location = new System.Drawing.Point(72, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(313, 304);
            this.panel1.TabIndex = 49;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(221, 18);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(50, 50);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 54;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(30, 18);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(50, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 53;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(104, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(93, 57);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 52;
            this.pictureBox1.TabStop = false;
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.DarkRed;
            this.button10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button10.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.ForeColor = System.Drawing.Color.White;
            this.button10.Location = new System.Drawing.Point(7, 222);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(294, 68);
            this.button10.TabIndex = 51;
            this.button10.Text = "SAIR";
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.Button10_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(7, 156);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(294, 60);
            this.button4.TabIndex = 50;
            this.button4.Text = "Criar uma conta";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.Button4_Click_2);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(7, 90);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(294, 60);
            this.button2.TabIndex = 49;
            this.button2.Text = "Iniciar sessão";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.Button2_Click_4);
            // 
            // button3
            // 
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.Location = new System.Drawing.Point(6, 222);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(60, 68);
            this.button3.TabIndex = 31;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click_2);
            // 
            // button8
            // 
            this.button8.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button8.BackgroundImage")));
            this.button8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button8.Location = new System.Drawing.Point(6, 156);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(60, 60);
            this.button8.TabIndex = 29;
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.Button8_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(10, 16);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(54, 52);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 22;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.PictureBox5_Click);
            // 
            // button7
            // 
            this.button7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button7.BackgroundImage")));
            this.button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button7.Location = new System.Drawing.Point(6, 90);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(60, 60);
            this.button7.TabIndex = 28;
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.Button7_Click);
            // 
            // Form1
            // 
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(379, 297);
            this.Controls.Add(this.pnl_lateral);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cuidad...BOOM!";
            this.pnl_lateral.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);

        }

        private void Button3_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

       

        private void Button2_Click_1(object sender, EventArgs e)
        {
            Form2 Login = new Form2();
            this.Hide();
            Login.ShowDialog();
            this.Dispose();
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            Form3 Registo = new Form3();
            this.Hide();
            Registo.ShowDialog();
            this.Dispose();

        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            Form2 Loginface = new Form2();
            this.Hide();
            Loginface.ShowDialog();
            this.Dispose();


        }

        private void PictureBox3_Click(object sender, EventArgs e)
        {
            Form3 Registo = new Form3();
            this.Hide();
            Registo.ShowDialog();
            this.Dispose();
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            Form2 Login = new Form2();
            this.Hide();
            Login.ShowDialog();
            this.Dispose();
        }

        private void PictureBox5_Click(object sender, EventArgs e)
        {
            /*Comando que faz com que o botão altere o tamanho do painel- menu*/
            if (pnl_lateral.Width == 72)
            {
                pnl_lateral.Width = 379
                    ;
            }
            else
            {
                pnl_lateral.Width = 72;
            }
        }

        private void Button1_Click_2(object sender, EventArgs e)
        {
            /*Comando que faz com que o botão altere a página*/
            Form2 Loginface = new Form2();
            this.Hide();
            Loginface.ShowDialog();
            this.Dispose();

        }

        private void Button4_Click(object sender, EventArgs e)
        {
            /*Comando que faz com que o botão altere a página*/
            Form2 Login = new Form2();
            this.Hide();
            Login.ShowDialog();
            this.Dispose();
        }

        private void Button2_Click_2(object sender, EventArgs e)
        {
            /*Comando que faz com que o botão altere a página*/
            Form3 Registo = new Form3();
            this.Hide();
            Registo.ShowDialog();
            this.Dispose();
        }

       

        private void Button9_Click(object sender, EventArgs e)
        {
            /*Comando que faz com que o botão altere a página*/
            Form4 Jogo = new Form4();
            this.Hide();
            Jogo.ShowDialog();
            this.Dispose();
        }

        

        private void Button7_Click(object sender, EventArgs e)
        {
            /*Comando que faz com que o botão altere a página*/
            Form2 Login = new Form2();
            this.Hide();
            Login.ShowDialog();
            this.Dispose();
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            /*Comando que faz com que o botão altere a página*/
            Form3 Registo = new Form3();
            this.Hide();
            Registo.ShowDialog();
            this.Dispose();
        }

        private void Button3_Click_2(object sender, EventArgs e)
        {
            this.Close();
        }

        

        private void Button6_Click(object sender, EventArgs e)
        {
            /*Comando que faz com que o botão altere a página*/
            Form2 Login = new Form2();
            this.Hide();
            Login.ShowDialog();
            this.Dispose();
        }

        private void Button1_Click_3(object sender, EventArgs e)
        {
            /*Comando que faz com que o botão altere a página*/
            Form2 Login = new Form2();
            this.Hide();
            Login.ShowDialog();
            this.Dispose();
        }

        private void Button2_Click_3(object sender, EventArgs e)
        {
            /*Comando que faz com que o botão altere a página*/
            Form2 Login = new Form2();
            this.Hide();
            Login.ShowDialog();
            this.Dispose();
        }

        private void Button4_Click_1(object sender, EventArgs e)
        {
            /*Comando que faz com que o botão altere a página*/
            Form3 Registo = new Form3();
            this.Hide();
            Registo.ShowDialog();
            this.Dispose();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            /*Comando que faz com que o botão altere a página*/
            Form4 Jogo = new Form4();
            this.Hide();
            Jogo.ShowDialog();
            this.Dispose();
        }

        private void Button2_Click_4(object sender, EventArgs e)
        {
            /*Comando que faz com que o botão altere a página*/
            Form2 Login = new Form2();
            this.Hide();
            Login.ShowDialog();
            this.Dispose();
        }

        private void Button4_Click_2(object sender, EventArgs e)
        {
            /*Comando que faz com que o botão altere a página*/
            Form3 Registo= new Form3();
            this.Hide();
            Registo.ShowDialog();
            this.Dispose();
        }

        private void Button10_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
