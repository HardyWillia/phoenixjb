using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhoenixJukebox
{
    public partial class AdminPage : Form
    {
        public AdminPage()
        {
            InitializeComponent();
        }

        string connectionString = "server = localhost; user id = root; password = prAc7ice2018!; database = jukebox";

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection con = new MySqlConnection(connectionString);
                MySqlCommand selectCommand = new MySqlCommand("delete from songs where songName = " +textDelArt+ " and artistName = " +textDelSong+ "; ", con);

            }
            catch(Exception ex)
            {
                ();
            }

        }

        private void textDelArt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}





