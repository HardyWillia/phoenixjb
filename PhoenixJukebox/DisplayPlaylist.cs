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
            MySqlCommand searchQuery = new MySqlCommand("select * from jukebox.playlist Order by songQue;", con);

            try
                {   
                    con.Open();
                    using (MySqlDataReader reader = searchQuery.ExecuteReader())
                    {
                        DataTable dt = new DataTable();
                        dt.Load(reader);
                        dataGridView1.AutoGenerateColumns = true;
                        dataGridView1.DataSource = dt;
                        dataGridView1.Refresh();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            
        }
    }
}
