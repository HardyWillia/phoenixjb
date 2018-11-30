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
        }

        string connectionString = "server = localhost; user id = root; password = prAc7ice2018!; database = jukebox";

        void FillGenreCombo()
        {
            try
            {
                MySqlConnection con = new MySqlConnection(connectionString);

                MySqlCommand selectCommand = new MySqlCommand("select distinct AlbGenre from jukebox.album;", con);
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
                    myReader 
= deleteCommand.ExecuteReader();
                    MessageBox.Show("Deletion Successful");

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

    }
}





