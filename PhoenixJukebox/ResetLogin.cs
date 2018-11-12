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
    public partial class ResetLogin : Form
    {
        public ResetLogin()
        {
            InitializeComponent();
        }

        string connectionString = "server = localhost; user id = root; password = prAc7ice2018!; database = jukebox";

        private void ResetLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection con = new MySqlConnection(connectionString);

                MySqlCommand selectCommand = new MySqlCommand("select * from jukebox.users where userName= '" + this.txtUserUpdate.Text + "' and userPassword='" + this.txtOldPass.Text + "' ;", con);

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
                    con.Close();

                    MySqlConnection conUpdate = new MySqlConnection(connectionString);
                    MySqlCommand updateCommand = new MySqlCommand("update jukebox.users set userPassword='" + this.txtNewPass.Text + "' where userName='" + this.txtUserUpdate.Text + "' ;", conUpdate);
                    conUpdate.Open();
                    updateCommand.ExecuteNonQuery();

                    MessageBox.Show("Password has been updated!");
                    this.Hide();
                    Login l1 = new Login();
                    l1.ShowDialog();
                }
                else if (count > 1)
                {
                    MessageBox.Show("Duplicate credentials...Access denied.");
                }
                else
                {
                    MessageBox.Show("Username and password is does not match, please try again.");
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
