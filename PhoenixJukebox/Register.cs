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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        string connectionString = "server = localhost; user id = root; password = prAc7ice2018!; database = jukebox";

        private void Register_Load(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection con = new MySqlConnection(connectionString);

                MySqlCommand insertCommand = new MySqlCommand("insert into users(userName, userPassword) values('" + this.txtUsername.Text + "', '" + this.txtPassword.Text + "') ;", con);
                MySqlDataReader myReader;

                try
                {
                    con.Open();
                    myReader = insertCommand.ExecuteReader();
                        MessageBox.Show("Registered successfully.", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtUsername.Text = txtPassword.Text = string.Empty;
                    while (myReader.Read())
                    {

                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                con.Close();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtUsername.Text = txtPassword.Text = string.Empty;
        }
    }
}
