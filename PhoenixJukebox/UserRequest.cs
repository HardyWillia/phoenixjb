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
    public partial class UserRequest : Form
    {
        public UserRequest()
        {
            InitializeComponent();
            FillGenreCombo();
        }

        string connectionString = "server = localhost; user id = root; password = prAc7ice2018!; database = jukebox";

        void FillGenreCombo()
        {
            boxAddGenre.Items.Add("Alternative");
            boxAddGenre.Items.Add("Blues");
            boxAddGenre.Items.Add("Classic");
            boxAddGenre.Items.Add("Country");
            boxAddGenre.Items.Add("Electronic Dance Music");
            boxAddGenre.Items.Add("Folk");
            boxAddGenre.Items.Add("Gospel");
            boxAddGenre.Items.Add("Heavy Metal");
            boxAddGenre.Items.Add("Hip Hop");
            boxAddGenre.Items.Add("Jazz");
            boxAddGenre.Items.Add("Pop");
            boxAddGenre.Items.Add("R&B");
            boxAddGenre.Items.Add("Rap");
            boxAddGenre.Items.Add("Reggae");
            boxAddGenre.Items.Add("Rock");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(connectionString))
                {
                    if (con.State == System.Data.ConnectionState.Closed)
                        con.Open();
                    using (MySqlCommand cmd = new MySqlCommand("insert into jukebox.usrrequest(artist, songTitle, albName) values ('" + textArtist.Text + "', '" + textSong.Text + "', '" + textAlbum.Text + "')", con))
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Record Inserted successfully.", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            textArtist.Text = textAlbum.Text = textSong.Text = string.Empty;
            boxAddGenre.Items.Clear(); 
        }

        private void lblUser_Click(object sender, EventArgs e)
        {

        }
    }
}
