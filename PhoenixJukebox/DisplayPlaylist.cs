using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO;
using System.Text;
using System.Drawing;
using System.Drawing.Imaging;
using System.Media;

namespace PhoenixJukebox
{
    public partial class DisplayPlaylist : Form
    {
        public DisplayPlaylist()
        {
            InitializeComponent();
            loadPlaylist(viewPlaylist);
        }

        string connectionString = "server = localhost; user id = root; password = prAc7ice2018!; database = jukebox";
        private void DisplayPlaylist_Load(object sender, EventArgs e)
        {

        }

        public void loadPlaylist(DataGridView dataGridView1)
        {
            MySqlConnection con = new MySqlConnection(connectionString);        
            MySqlCommand searchQuery = 
                new MySqlCommand("select distinct p.songQue, p.Songs_songName AS Song, p.Songs_artistName AS Artist, s.audioFile, a.AlbName AS Album, a.Albart AS Artwork from jukebox.playlist p, jukebox.songs s join jukebox.album a ON a.idAlbum = s.Album_idAlbum where p.Songs_songName = s.songName Order by songQue; ", con);

            try
                {   
                    con.Open();
                    using (MySqlDataReader reader = searchQuery.ExecuteReader())
                    {
                        DataTable dt = new DataTable();
                        dt.Load(reader);
                        reader.Close();

                        dataGridView1.AutoGenerateColumns = true;
                        dataGridView1.DataSource = dt;
                        dataGridView1.Refresh();
                    }
                con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            
        }

        //Byte[] ImageByte;
        private void viewPlaylist_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                DataGridViewRow row = this.viewPlaylist.Rows[e.RowIndex];

                txtSong.Text = row.Cells["Song"].Value.ToString();
                txtArtist.Text = row.Cells["Artist"].Value.ToString();
                txtAlbum.Text = row.Cells["Album"].Value.ToString();
                txtAudio.Text = row.Cells["audioFile"].Value.ToString();

                //TODO: Maybe another way to get it to work?
                //int bufferSize = 1000;
                //DataSet ds = new DataSet();
                //int c = ds.Tables["Artwork"].Rows.Count;
                //Byte[] byteBLOBData = new Byte[bufferSize];
                //byteBLOBData = (Byte[])(ds.Tables["Artwork"].Rows[c - 1]["Artwork"]);
                //MemoryStream stmBLOBData = new MemoryStream(byteBLOBData);
                //pictAlbArt.Image = Image.FromStream(stmBLOBData);

                //TODO: Get the artwork to appear in the Picture Box
                //byte[] img = (byte[])viewPlaylist.CurrentRow.Cells["Albart"].Value;
                //if (img == null)
                //    pictAlbArt.Image = null;
                //else
                //{
                //    MemoryStream ms = new MemoryStream(img);
                //    pictAlbArt.Image = Image.FromStream(ms);
                //}


            }
        }

        private void DisplayPlaylist_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Do you really want to exit this application?", "Exit", MessageBoxButtons.YesNo);

            if(dialog == DialogResult.Yes)
            {
                Application.Exit();
            } else if(dialog == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            try
            {
                SoundPlayer player = new SoundPlayer();
                player.SoundLocation = txtAudio.Text;

                player.Load();
                player.PlaySync();



            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
