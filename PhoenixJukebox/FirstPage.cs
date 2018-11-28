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
            FillSongCombo();
            FillGenreCombo();
            FillArtistCombo();

        }

        string connectionString = "server = localhost; user id = root; password = prAc7ice2018!; database = jukebox";
        void FillSongCombo ()
        {
            try
            {
                MySqlConnection con = new MySqlConnection(connectionString);

                MySqlCommand selectCommand = new MySqlCommand("select * from jukebox.songs;", con);
                MySqlDataReader myReader;
                
                try
                {
                    con.Open();
                    myReader = selectCommand.ExecuteReader();
                   
                    while (myReader.Read())
                    {
                        string sName = myReader.GetString("songName");
                        boxSong.Items.Add(sName);
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
        void FillGenreCombo()
        {
            try
            {
                MySqlConnection con = new MySqlConnection(connectionString);

                MySqlCommand selectCommand = new MySqlCommand("select * from jukebox.album;", con);
                MySqlDataReader myReader;

                try
                {
                    con.Open();
                    myReader = selectCommand.ExecuteReader();

                    while (myReader.Read())
                    {
                        string sName = myReader.GetString("AlbGenre");
                        boxGenre.Items.Add(sName);
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

        void FillArtistCombo()
        {
            try
            {
                MySqlConnection con = new MySqlConnection(connectionString);

                MySqlCommand selectCommand = new MySqlCommand("select * from jukebox.songs;", con);
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
            boxSong.Select();
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
            boxGenre.Text = boxSong.Text = boxArtist.Text = priorityPicker.Text = string.Empty;
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
    }
}
