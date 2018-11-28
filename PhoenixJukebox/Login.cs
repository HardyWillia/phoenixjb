using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace PhoenixJukebox
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        private void Login_Load(object sender, EventArgs e)
        {

        }

        string connectionString = "server = localhost; user id = root; password = prAc7ice2018!; database = jukebox";
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection con = new MySqlConnection(connectionString);

                MySqlCommand selectCommand = new MySqlCommand("select * from jukebox.users where userName= '" + this.txtUser.Text + "' and userPassword='" + this.txtPassword.Text + "' ;", con);

                MySqlDataReader myReader;
                con.Open();
                myReader = selectCommand.ExecuteReader();

                int count = 0;
                while (myReader.Read())
                {
                    count = count + 1;
                }

                if (count == 1)
                {
                    if (this.txtUser.Text == "ADMIN")
                    {
                        MessageBox.Show("Welcome Administrator");
                        this.Hide();
                        AdminPage a1 = new AdminPage();
                        a1.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Username and password is correct");
                        this.Hide();
                        FirstPage p1 = new FirstPage();
                        p1.ShowDialog();
                    }
                }
                else if(count > 1)
                {
                    MessageBox.Show("Duplicate credentials...Access denied.");
                }
                else
                {
                    MessageBox.Show("Username and password is incorrect, please try again");
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Register reg = new Register();
            reg.ShowDialog();
        }

        private void btnForgot_Click(object sender, EventArgs e)
        {
            ResetLogin rl1 = new ResetLogin();
            rl1.ShowDialog();
        }
    }
}
