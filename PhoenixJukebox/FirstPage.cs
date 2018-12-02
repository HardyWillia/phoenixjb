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
        public FirstPage(string UserName)
        {
            InitializeComponent();
            lblUser.Text = UserName;
            FillArtistCombo();

        }

        string connectionString = "server = localhost; user id = root; password = prAc7ice2018!; database = jukebox";
        void FillArtistCombo ()
        {
            try
            {
                MySqlConnection con = new MySqlConnection(connectionString);

                MySqlCommand selectCommand = new MySqlCommand("select distinct artistName from jukebox.songs;", con);
                MySqlDataReader myReader;
                
                try
                {
                    con.Open();
                    myReader = selectCommand.ExecuteReader();
                   
                    while (myReader.Read())
                    {
                        string sName = myReader.GetString("artistName");
                        boxArtist.Items.Add(sName);
                    }
                }
                catch (Exception ex)
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



        private void FirstPage_Load(object sender, EventArgs e)
        {
            boxArtist.Select();
            DomainUpDown.DomainUpDownItemCollection collection = this.priorityPicker.Items;
            collection.Add("0");
            collection.Add("1");
            collection.Add("2");
            collection.Add("3");
            collection.Add("4");
            collection.Add("5");

            //Set the default number in the Priority Picker
            this.priorityPicker.Text = "5";

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

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(connectionString))
                {
                    if (con.State == System.Data.ConnectionState.Closed)
                        con.Open();
                    using (MySqlCommand cmd = new MySqlCommand("insert into jukebox.playlist(songQue, Songs_songName, Songs_artistName) values ('"+priorityPicker.Text+"', '"+boxSong.Text+ "', '" + boxArtist.Text + "')", con))
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Record Inserted successfully.", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        priorityPicker.Text = string.Empty;
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
            textGenre.Text = boxSong.Text = boxArtist.Text = string.Empty;
        }

        private void boxGenre_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnPlayshow_Click(object sender, EventArgs e)
        {
            DisplayPlaylist dp1 = new DisplayPlaylist();
            dp1.ShowDialog();
        }

        private void boxSong_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection con = new MySqlConnection(connectionString);

                MySqlCommand filterCommand = new MySqlCommand("select s.*, AlbGenre from jukebox.songs s join jukebox.album a ON a.idAlbum = s.Album_idAlbum where s.artistName='" + boxArtist.Text + "' group by s.Album_idAlbum;", con);
                MySqlDataReader myReader;

                con.Open();
                myReader = filterCommand.ExecuteReader();

                while (myReader.Read())
                {
                    //Automatically put the matching artist for the song selected into the box
                    string aName = myReader.GetString("songName");
                    boxSong.Text = aName;
                    string gName = myReader.GetString("AlbGenre");
                    textGenre.Text = gName;

                }

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            UserRequest us1 = new UserRequest();
            us1.ShowDialog();
        }
    }
}
