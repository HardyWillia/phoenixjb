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
            FillGenreCombo();
            FillAlbumCombo();
            loadPlaylist(usrRequestData);
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
            boxAddGenre.Items.Add("Reggae");
            boxAddGenre.Items.Add("Rock");
        }
        void FillAlbumCombo()
        {
            try
            {
                MySqlConnection con = new MySqlConnection(connectionString);

                MySqlCommand selectCommand = new MySqlCommand("select distinct AlbName from jukebox.album;", con);
                MySqlDataReader myReader;

                try
                {
                    con.Open();
                    myReader = selectCommand.ExecuteReader();

                    while (myReader.Read())
                    {
                        string sName = myReader.GetString("AlbName");
                        boxAlbm.Items.Add(sName);
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection con = new MySqlConnection(connectionString);
                MySqlCommand selectCommand = new MySqlCommand("select * from jukebox.songs where songName= '" + this.textDelSong.Text + "' and artistName ='" + this.textDelArt.Text + "' ;", con);
                MySqlCommand deleteCommand = new MySqlCommand("delete from jukebox.songs where songName = '" + this.textDelSong.Text + "' and artistName = '" + this.textDelArt.Text + "'; ", con);
                MySqlDataReader myReader;
                con.Open();
                myReader = selectCommand.ExecuteReader();


                int count = 0;
                while (myReader.Read())
                {
                    count = count + 1;
                }

                myReader.Close();

                if (count == 1)
                {
                    myReader = deleteCommand.ExecuteReader();
                    MessageBox.Show("Deletion Successful");
                    this.Hide();
                    AdminPage a1 = new AdminPage();
                    a1.ShowDialog();                    
                }
                else
                {
                    MessageBox.Show("Delete Unsuccessful");
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void addPic_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog1.ShowDialog();
                pictureBox1.ImageLocation = openFileDialog1.FileName;
                this.Text = openFileDialog1.FileName;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAddAlb_Click(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(connectionString))
                {
                    if (con.State == System.Data.ConnectionState.Closed)
                        con.Open();
                    using (MySqlCommand cmd = new MySqlCommand("insert into jukebox.album(AlbName, AlbGenre, Albart) values ('" + txtAlbName.Text + "', '" + boxAddGenre.Text + "', '" +pictureBox1.ImageLocation+"')", con))
                        
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Record Inserted successfully.", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    AdminPage a1 = new AdminPage();
                    a1.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAddSong_Click(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(connectionString))
                {
                    if (con.State == System.Data.ConnectionState.Closed)
                        con.Open();
                    using (MySqlCommand cmd = new MySqlCommand("insert into jukebox.songs(songName, artistName, audioFile, Album_idAlbum) values" +
                        " ('" + txtSongTitle.Text + "', '" + txtSongArt.Text + "', '" + txtSongLink.Text + "' ,  (select idAlbum from jukebox.album where albName = '" +boxAlbm.Text+ "'))", con))
                        cmd.ExecuteNonQuery();
                    MessageBox.Show("Record Inserted successfully.", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    AdminPage a1 = new AdminPage();
                    a1.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login l1 = new Login();
            l1.ShowDialog();
        }

        private void btnPlaylist_Click(object sender, EventArgs e)
        {
            this.Hide();
            DisplayPlaylist p1 = new DisplayPlaylist();
            p1.ShowDialog();
        }

        public void loadPlaylist(DataGridView usrRequestData)
        {
            MySqlConnection con = new MySqlConnection(connectionString);
            MySqlCommand searchQuery = new MySqlCommand("select * from jukebox.usrrequest Order by idReqNum;", con);

            try
            {
                con.Open();
                using (MySqlDataReader reader = searchQuery.ExecuteReader())
                {
                    DataTable dt = new DataTable();
                    dt.Load(reader);
                    usrRequestData.AutoGenerateColumns = true;
                    usrRequestData.DataSource = dt;
                    usrRequestData.Refresh();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void AdminPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}





