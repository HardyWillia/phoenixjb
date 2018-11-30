namespace PhoenixJukebox
{
    partial class AdminPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelDelete = new System.Windows.Forms.Label();
            this.textDelArt = new System.Windows.Forms.TextBox();
            this.textDelSong = new System.Windows.Forms.TextBox();
            this.labelDeleteArtist = new System.Windows.Forms.Label();
            this.labelDelSong = new System.Windows.Forms.Label();
            this.labelAlbum = new System.Windows.Forms.Label();
            this.boxGenre = new System.Windows.Forms.ComboBox();
            this.txtAlbName = new System.Windows.Forms.TextBox();
            this.labelGenre = new System.Windows.Forms.Label();
            this.labelAlbName = new System.Windows.Forms.Label();
            this.labelAlbArt = new System.Windows.Forms.Label();
            this.labelSong = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.labelAlb = new System.Windows.Forms.Label();
            this.labelSongArtist = new System.Windows.Forms.Label();
            this.labelSongTitle = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAddSong = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnPlaylist = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.addPic = new System.Windows.Forms.Button();
            this.btnAddAlb = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelDelete
            // 
            this.labelDelete.AutoSize = true;
            this.labelDelete.Location = new System.Drawing.Point(12, 9);
            this.labelDelete.Name = "labelDelete";
            this.labelDelete.Size = new System.Drawing.Size(98, 20);
            this.labelDelete.TabIndex = 0;
            this.labelDelete.Text = "Delete Song";
            // 
            // textDelArt
            // 
            this.textDelArt.Location = new System.Drawing.Point(12, 32);
            this.textDelArt.Name = "textDelArt";
            this.textDelArt.Size = new System.Drawing.Size(174, 26);
            this.textDelArt.TabIndex = 1;
            // 
            // textDelSong
            // 
            this.textDelSong.Location = new System.Drawing.Point(209, 32);
            this.textDelSong.Name = "textDelSong";
            this.textDelSong.Size = new System.Drawing.Size(175, 26);
            this.textDelSong.TabIndex = 2;
            // 
            // labelDeleteArtist
            // 
            this.labelDeleteArtist.AutoSize = true;
            this.labelDeleteArtist.Location = new System.Drawing.Point(12, 61);
            this.labelDeleteArtist.Name = "labelDeleteArtist";
            this.labelDeleteArtist.Size = new System.Drawing.Size(46, 20);
            this.labelDeleteArtist.TabIndex = 3;
            this.labelDeleteArtist.Text = "Artist";
            // 
            // labelDelSong
            // 
            this.labelDelSong.AutoSize = true;
            this.labelDelSong.Location = new System.Drawing.Point(205, 61);
            this.labelDelSong.Name = "labelDelSong";
            this.labelDelSong.Size = new System.Drawing.Size(80, 20);
            this.labelDelSong.TabIndex = 4;
            this.labelDelSong.Text = "Song Title";
            // 
            // labelAlbum
            // 
            this.labelAlbum.AutoSize = true;
            this.labelAlbum.Location = new System.Drawing.Point(12, 101);
            this.labelAlbum.Name = "labelAlbum";
            this.labelAlbum.Size = new System.Drawing.Size(87, 20);
            this.labelAlbum.TabIndex = 5;
            this.labelAlbum.Text = "Add Album";
            // 
            // boxGenre
            // 
            this.boxGenre.FormattingEnabled = true;
            this.boxGenre.Location = new System.Drawing.Point(16, 124);
            this.boxGenre.Name = "boxGenre";
            this.boxGenre.Size = new System.Drawing.Size(121, 28);
            this.boxGenre.TabIndex = 6;
            // 
            // txtAlbName
            // 
            this.txtAlbName.Location = new System.Drawing.Point(10, 188);
            this.txtAlbName.Name = "txtAlbName";
            this.txtAlbName.Size = new System.Drawing.Size(100, 26);
            this.txtAlbName.TabIndex = 7;
            // 
            // labelGenre
            // 
            this.labelGenre.AutoSize = true;
            this.labelGenre.Location = new System.Drawing.Point(15, 164);
            this.labelGenre.Name = "labelGenre";
            this.labelGenre.Size = new System.Drawing.Size(54, 20);
            this.labelGenre.TabIndex = 9;
            this.labelGenre.Text = "Genre";
            // 
            // labelAlbName
            // 
            this.labelAlbName.AutoSize = true;
            this.labelAlbName.Location = new System.Drawing.Point(8, 217);
            this.labelAlbName.Name = "labelAlbName";
            this.labelAlbName.Size = new System.Drawing.Size(100, 20);
            this.labelAlbName.TabIndex = 10;
            this.labelAlbName.Text = "Album Name";
            // 
            // labelAlbArt
            // 
            this.labelAlbArt.AutoSize = true;
            this.labelAlbArt.Location = new System.Drawing.Point(280, 242);
            this.labelAlbArt.Name = "labelAlbArt";
            this.labelAlbArt.Size = new System.Drawing.Size(109, 20);
            this.labelAlbArt.TabIndex = 11;
            this.labelAlbArt.Text = "Upload Image";
            // 
            // labelSong
            // 
            this.labelSong.AutoSize = true;
            this.labelSong.Location = new System.Drawing.Point(12, 267);
            this.labelSong.Name = "labelSong";
            this.labelSong.Size = new System.Drawing.Size(115, 20);
            this.labelSong.TabIndex = 12;
            this.labelSong.Text = "Add New Song";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(12, 290);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 28);
            this.comboBox2.TabIndex = 13;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(301, 292);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(158, 26);
            this.textBox4.TabIndex = 14;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(156, 290);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(129, 26);
            this.textBox5.TabIndex = 15;
            // 
            // labelAlb
            // 
            this.labelAlb.AutoSize = true;
            this.labelAlb.Location = new System.Drawing.Point(15, 321);
            this.labelAlb.Name = "labelAlb";
            this.labelAlb.Size = new System.Drawing.Size(54, 20);
            this.labelAlb.TabIndex = 16;
            this.labelAlb.Text = "Album";
            // 
            // labelSongArtist
            // 
            this.labelSongArtist.AutoSize = true;
            this.labelSongArtist.Location = new System.Drawing.Point(152, 321);
            this.labelSongArtist.Name = "labelSongArtist";
            this.labelSongArtist.Size = new System.Drawing.Size(88, 20);
            this.labelSongArtist.TabIndex = 17;
            this.labelSongArtist.Text = "Song Artist";
            // 
            // labelSongTitle
            // 
            this.labelSongTitle.AutoSize = true;
            this.labelSongTitle.Location = new System.Drawing.Point(297, 321);
            this.labelSongTitle.Name = "labelSongTitle";
            this.labelSongTitle.Size = new System.Drawing.Size(83, 20);
            this.labelSongTitle.TabIndex = 18;
            this.labelSongTitle.Text = "Song Titile";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(669, 23);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(110, 35);
            this.btnDelete.TabIndex = 19;
            this.btnDelete.Text = "Delete Song";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAddSong
            // 
            this.btnAddSong.Location = new System.Drawing.Point(465, 314);
            this.btnAddSong.Name = "btnAddSong";
            this.btnAddSong.Size = new System.Drawing.Size(110, 35);
            this.btnAddSong.TabIndex = 21;
            this.btnAddSong.Text = "Add Song";
            this.btnAddSong.UseVisualStyleBackColor = true;
            // 
            // btnHome
            // 
            this.btnHome.Location = new System.Drawing.Point(233, 377);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(110, 35);
            this.btnHome.TabIndex = 22;
            this.btnHome.Text = "Go to Log-in";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnPlaylist
            // 
            this.btnPlaylist.Location = new System.Drawing.Point(349, 377);
            this.btnPlaylist.Name = "btnPlaylist";
            this.btnPlaylist.Size = new System.Drawing.Size(110, 35);
            this.btnPlaylist.TabIndex = 23;
            this.btnPlaylist.Text = "Playlist";
            this.btnPlaylist.UseVisualStyleBackColor = true;
            this.btnPlaylist.Click += new System.EventHandler(this.btnPlaylist_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(156, 101);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(201, 141);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            // 
            // addPic
            // 
            this.addPic.Location = new System.Drawing.Point(363, 196);
            this.addPic.Name = "addPic";
            this.addPic.Size = new System.Drawing.Size(137, 29);
            this.addPic.TabIndex = 25;
            this.addPic.Text = "Insert Pic";
            this.addPic.UseVisualStyleBackColor = true;
            this.addPic.Click += new System.EventHandler(this.addPic_Click);
            // 
            // btnAddAlb
            // 
            this.btnAddAlb.Location = new System.Drawing.Point(669, 101);
            this.btnAddAlb.Name = "btnAddAlb";
            this.btnAddAlb.Size = new System.Drawing.Size(110, 35);
            this.btnAddAlb.TabIndex = 26;
            this.btnAddAlb.Text = "Add Album";
            this.btnAddAlb.UseVisualStyleBackColor = true;
            this.btnAddAlb.Click += new System.EventHandler(this.btnAddAlb_Click);
            // 
            // AdminPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 529);
            this.Controls.Add(this.btnAddAlb);
            this.Controls.Add(this.addPic);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnPlaylist);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.btnAddSong);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.labelSongTitle);
            this.Controls.Add(this.labelSongArtist);
            this.Controls.Add(this.labelAlb);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.labelSong);
            this.Controls.Add(this.labelAlbArt);
            this.Controls.Add(this.labelAlbName);
            this.Controls.Add(this.labelGenre);
            this.Controls.Add(this.txtAlbName);
            this.Controls.Add(this.boxGenre);
            this.Controls.Add(this.labelAlbum);
            this.Controls.Add(this.labelDelSong);
            this.Controls.Add(this.labelDeleteArtist);
            this.Controls.Add(this.textDelSong);
            this.Controls.Add(this.textDelArt);
            this.Controls.Add(this.labelDelete);
            this.Name = "AdminPage";
            this.Text = "AdminPage";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelDelete;
        private System.Windows.Forms.TextBox textDelArt;
        private System.Windows.Forms.TextBox textDelSong;
        private System.Windows.Forms.Label labelDeleteArtist;
        private System.Windows.Forms.Label labelDelSong;
        private System.Windows.Forms.Label labelAlbum;
        private System.Windows.Forms.ComboBox boxGenre;
        private System.Windows.Forms.TextBox txtAlbName;
        private System.Windows.Forms.Label labelGenre;
        private System.Windows.Forms.Label labelAlbName;
        private System.Windows.Forms.Label labelAlbArt;
        private System.Windows.Forms.Label labelSong;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label labelAlb;
        private System.Windows.Forms.Label labelSongArtist;
        private System.Windows.Forms.Label labelSongTitle;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAddSong;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnPlaylist;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.Button addPic;
        private System.Windows.Forms.Button btnAddAlb;
    }
}
