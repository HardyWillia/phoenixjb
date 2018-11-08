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
    public partial class FirstPage : Form
    {
        public FirstPage()
        {
            InitializeComponent();
        }

        string connectionString = "server = localhost; user id = root; password = prAc7ice2018!;";
        private void FirstPage_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try{
                using (MySqlConnection con = new MySqlConnection(connectionString))
                {
                    if (con.State == System.Data.ConnectionState.Closed)
                        con.Open();
                    MessageBox.Show("Connection opened successfully.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
          
        }
    }
}
