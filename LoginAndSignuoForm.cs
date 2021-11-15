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

namespace In_Body_Scale
{

    public partial class LoginAndSignuoForm : Form
    {




        public LoginAndSignuoForm()
        {
            InitializeComponent();

        }





        private void textBox2_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
            textBox2.PasswordChar = '*';
        }



        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
        }

        private void textBox3_Click(object sender, EventArgs e)
        {
            txtpass.Clear();
            txtpass.PasswordChar = '*';
        }


        private void textBox4_Click(object sender, EventArgs e)
        {
            txtname.Clear();
        }

        private void textBox5_Click(object sender, EventArgs e)
        {
            txtmail.Clear();
        }

        private void textBox6_Click(object sender, EventArgs e)
        {
            txtconf.Clear();
            txtconf.PasswordChar = '*';
        }

        Color Select_Color = Color.FromArgb(46, 49, 49);
        private void button_Login_Click(object sender, EventArgs e)
        {
            panel_Login.BringToFront();
            panel_l.BackColor = Color.Yellow;
            panel_s.BackColor = Select_Color;
            panel_Login.BackColor = Select_Color;
            button_Login.BackColor = Select_Color;
            button_SignUp.BackColor = Color.Black;
        }

        private void button_SignUp_Click(object sender, EventArgs e)
        {
            panel_SignUp.BringToFront();
            panel_s.BackColor = Color.Yellow;
            panel_l.BackColor = Select_Color;
            panel_SignUp.BackColor = Select_Color;
            button_Login.BackColor = Color.Black;
            button_SignUp.BackColor = Select_Color;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Projects'Codes\C#\In Body\In Body Scale\db1.mdf;Integrated Security=True");
            con.Open();

            SqlCommand command = new SqlCommand("SELECT * FROM [register] WHERE username = @username AND password = @password", con);
            command.Parameters.AddWithValue("@username", (textBox1.Text));
            command.Parameters.AddWithValue("@password", (textBox2.Text));

            SqlDataReader user = command.ExecuteReader();
            if (user.Read())
            {

                this.Hide();
                Form1 frm = new Form1();
                frm.ShowDialog();
                this.Close(); ;

            }
            else
            {
                MessageBox.Show("Data is wrong", "Faild", MessageBoxButtons.OK);
            }
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if ((txtname.Text != "username" && txtname.Text != "") && 
                (txtmail.Text != "email" && txtmail.Text != "") &&
                (txtpass.Text != "password" && txtpass.Text != "") &&
                (txtconf.Text != "confirm" && txtconf.Text != ""))
            {
                if (txtpass.Text == txtconf.Text)
                {
                    SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Projects'Codes\C#\In Body\In Body Scale\db1.mdf;Integrated Security=True");
                    con.Open();
                    SqlCommand command = new SqlCommand("INSERT INTO register(username, email, password, confirm) VALUES(@username,@email,@password,@confirm)", con);
                    command.CommandType = CommandType.Text;
                    command.Parameters.AddWithValue("@username", (txtname.Text));
                    command.Parameters.AddWithValue("@email", (txtmail.Text));
                    command.Parameters.AddWithValue("@password", (txtpass.Text));
                    command.Parameters.AddWithValue("@confirm", (txtconf.Text));

                    command.ExecuteNonQuery();
                    con.Close();

                    this.Hide();
                    Form1 frm = new Form1();
                    frm.ShowDialog();
                    this.Close();
                }
                else { MessageBox.Show("passward must equal confirm passward"); }
            }
            else MessageBox.Show("field cannot be empty ");

        }

        private void iconPictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
