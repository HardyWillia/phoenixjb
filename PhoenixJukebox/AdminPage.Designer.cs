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
            this.components = new System.ComponentModel.Container();
            this.textDelArt = new System.Windows.Forms.TextBox();
            this.textDelSong = new System.Windows.Forms.TextBox();
            this.labelDeleteArtist = new System.Windows.Forms.Label();
            this.labelDelSong = new System.Windows.Forms.Label();
            this.txtAlbName = new System.Windows.Forms.TextBox();
            this.labelGenre = new System.Windows.Forms.Label();
            this.labelAlbName = new System.Windows.Forms.Label();
            this.boxAlbm = new System.Windows.Forms.ComboBox();
            this.txtSongTitle = new System.Windows.Forms.TextBox();
            this.txtSongArt = new System.Windows.Forms.TextBox();
            this.labelAlb = new System.Windows.Forms.Label();
            this.labelSongArtist = new System.Windows.Forms.Label();
            this.labelSongTitle = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAddSong = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnPlaylist = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.addPic = new System.Windows.Forms.Button();
            this.btnAddAlb = new System.Windows.Forms.Button();
            this.txtSongLink = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.boxAddGenre = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.usrRequestData = new System.Windows.Forms.DataGridView();
            this.jukeboxDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.jukeboxDataSet = new PhoenixJukebox.jukeboxDataSet();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usrRequestData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jukeboxDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jukeboxDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // textDelArt
            // 
            this.textDelArt.Location = new System.Drawing.Point(21, 34);
            this.textDelArt.Name = "textDelArt";
            this.textDelArt.Size = new System.Drawing.Size(203, 26);
            this.textDelArt.TabIndex = 1;
            // 
            // textDelSong
            // 
            this.textDelSong.Location = new System.Drawing.Point(256, 34);
            this.textDelSong.Name = "textDelSong";
            this.textDelSong.Size = new System.Drawing.Size(175, 26);
            this.textDelSong.TabIndex = 2;
            // 
            // labelDeleteArtist
            // 
            this.labelDeleteArtist.AutoSize = true;
            this.labelDeleteArtist.Location = new System.Drawing.Point(17, 68);
            this.labelDeleteArtist.Name = "labelDeleteArtist";
            this.labelDeleteArtist.Size = new System.Drawing.Size(46, 20);
            this.labelDeleteArtist.TabIndex = 3;
            this.labelDeleteArtist.Text = "Artist";
            // 
            // labelDelSong
            // 
            this.labelDelSong.AutoSize = true;
            this.labelDelSong.Location = new System.Drawing.Point(252, 68);
            this.labelDelSong.Name = "labelDelSong";
            this.labelDelSong.Size = new System.Drawing.Size(80, 20);
            this.labelDelSong.TabIndex = 4;
            this.labelDelSong.Text = "Song Title";
            // 
            // txtAlbName
            // 
            this.txtAlbName.Location = new System.Drawing.Point(173, 45);
            this.txtAlbName.Name = "txtAlbName";
            this.txtAlbName.Size = new System.Drawing.Size(154, 26);
            this.txtAlbName.TabIndex = 7;
            // 
            // labelGenre
            // 
            this.labelGenre.AutoSize = true;
            this.labelGenre.Location = new System.Drawing.Point(17, 79);
            this.labelGenre.Name = "labelGenre";
            this.labelGenre.Size = new System.Drawing.Size(54, 20);
            this.labelGenre.TabIndex = 9;
            this.labelGenre.Text = "Genre";
            // 
            // labelAlbName
            // 
            this.labelAlbName.AutoSize = true;
            this.labelAlbName.Location = new System.Drawing.Point(169, 77);
            this.labelAlbName.Name = "labelAlbName";
            this.labelAlbName.Size = new System.Drawing.Size(100, 20);
            this.labelAlbName.TabIndex = 10;
            this.labelAlbName.Text = "Album Name";
            // 
            // boxAlbm
            // 
            this.boxAlbm.FormattingEnabled = true;
            this.boxAlbm.Location = new System.Drawing.Point(21, 41);
            this.boxAlbm.Name = "boxAlbm";
            this.boxAlbm.Size = new System.Drawing.Size(121, 28);
            this.boxAlbm.TabIndex = 13;
            // 
            // txtSongTitle
            // 
            this.txtSongTitle.Location = new System.Drawing.Point(359, 41);
            this.txtSongTitle.Name = "txtSongTitle";
            this.txtSongTitle.Size = new System.Drawing.Size(194, 26);
            this.txtSongTitle.TabIndex = 14;
            // 
            // txtSongArt
            // 
            this.txtSongArt.Location = new System.Drawing.Point(159, 41);
            this.txtSongArt.Name = "txtSongArt";
            this.txtSongArt.Size = new System.Drawing.Size(187, 26);
            this.txtSongArt.TabIndex = 15;
            // 
            // labelAlb
            // 
            this.labelAlb.AutoSize = true;
            this.labelAlb.Location = new System.Drawing.Point(17, 86);
            this.labelAlb.Name = "labelAlb";
            this.labelAlb.Size = new System.Drawing.Size(54, 20);
            this.labelAlb.TabIndex = 16;
            this.labelAlb.Text = "Album";
            // 
            // labelSongArtist
            // 
            this.labelSongArtist.AutoSize = true;
            this.labelSongArtist.Location = new System.Drawing.Point(155, 86);
            this.labelSongArtist.Name = "labelSongArtist";
            this.labelSongArtist.Size = new System.Drawing.Size(88, 20);
            this.labelSongArtist.TabIndex = 17;
            this.labelSongArtist.Text = "Song Artist";
            // 
            // labelSongTitle
            // 
            this.labelSongTitle.AutoSize = true;
            this.labelSongTitle.Location = new System.Drawing.Point(348, 86);
            this.labelSongTitle.Name = "labelSongTitle";
            this.labelSongTitle.Size = new System.Drawing.Size(83, 20);
            this.labelSongTitle.TabIndex = 18;
            this.labelSongTitle.Text = "Song Titile";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(640, 25);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(110, 35);
            this.btnDelete.TabIndex = 19;
            this.btnDelete.Text = "Delete Song";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAddSong
            // 
            this.btnAddSong.Location = new System.Drawing.Point(640, 41);
            this.btnAddSong.Name = "btnAddSong";
            this.btnAddSong.Size = new System.Drawing.Size(110, 35);
            this.btnAddSong.TabIndex = 21;
            this.btnAddSong.Text = "Add Song";
            this.btnAddSong.UseVisualStyleBackColor = true;
            this.btnAddSong.Click += new System.EventHandler(this.btnAddSong_Click);
            // 
            // btnHome
            // 
            this.btnHome.Location = new System.Drawing.Point(284, 592);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(110, 35);
            this.btnHome.TabIndex = 22;
            this.btnHome.Text = "Go to Log-in";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnPlaylist
            // 
            this.btnPlaylist.Location = new System.Drawing.Point(417, 592);
            this.btnPlaylist.Name = "btnPlaylist";
            this.btnPlaylist.Size = new System.Drawing.Size(110, 35);
            this.btnPlaylist.TabIndex = 23;
            this.btnPlaylist.Text = "Go to Playlist";
            this.btnPlaylist.UseVisualStyleBackColor = true;
            this.btnPlaylist.Click += new System.EventHandler(this.btnPlaylist_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(352, 79);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(201, 176);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // addPic
            // 
            this.addPic.Location = new System.Drawing.Point(352, 45);
            this.addPic.Name = "addPic";
            this.addPic.Size = new System.Drawing.Size(201, 29);
            this.addPic.TabIndex = 25;
            this.addPic.Text = "Insert Album Art";
            this.addPic.UseVisualStyleBackColor = true;
            this.addPic.Click += new System.EventHandler(this.addPic_Click);
            // 
            // btnAddAlb
            // 
            this.btnAddAlb.Location = new System.Drawing.Point(640, 45);
            this.btnAddAlb.Name = "btnAddAlb";
            this.btnAddAlb.Size = new System.Drawing.Size(110, 35);
            this.btnAddAlb.TabIndex = 26;
            this.btnAddAlb.Text = "Add Album";
            this.btnAddAlb.UseVisualStyleBackColor = true;
            this.btnAddAlb.Click += new System.EventHandler(this.btnAddAlb_Click);
            // 
            // txtSongLink
            // 
            this.txtSongLink.Location = new System.Drawing.Point(21, 126);
            this.txtSongLink.Name = "txtSongLink";
            this.txtSongLink.Size = new System.Drawing.Size(433, 26);
            this.txtSongLink.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 20);
            this.label1.TabIndex = 28;
            this.label1.Text = "Song link";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.boxAlbm);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtSongLink);
            this.groupBox1.Controls.Add(this.labelAlb);
            this.groupBox1.Controls.Add(this.txtSongArt);
            this.groupBox1.Controls.Add(this.labelSongArtist);
            this.groupBox1.Controls.Add(this.btnAddSong);
            this.groupBox1.Controls.Add(this.txtSongTitle);
            this.groupBox1.Controls.Add(this.labelSongTitle);
            this.groupBox1.Location = new System.Drawing.Point(16, 443);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(796, 198);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add New Song";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.boxAddGenre);
            this.groupBox2.Controls.Add(this.txtAlbName);
            this.groupBox2.Controls.Add(this.btnAddAlb);
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Controls.Add(this.addPic);
            this.groupBox2.Controls.Add(this.labelAlbName);
            this.groupBox2.Controls.Add(this.labelGenre);
            this.groupBox2.Location = new System.Drawing.Point(16, 143);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(936, 273);
            this.groupBox2.TabIndex = 30;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Add Album";
            // 
            // boxAddGenre
            // 
            this.boxAddGenre.FormattingEnabled = true;
            this.boxAddGenre.Location = new System.Drawing.Point(6, 43);
            this.boxAddGenre.Name = "boxAddGenre";
            this.boxAddGenre.Size = new System.Drawing.Size(121, 28);
            this.boxAddGenre.TabIndex = 27;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textDelArt);
            this.groupBox3.Controls.Add(this.textDelSong);
            this.groupBox3.Controls.Add(this.labelDelSong);
            this.groupBox3.Controls.Add(this.labelDeleteArtist);
            this.groupBox3.Controls.Add(this.btnDelete);
            this.groupBox3.Location = new System.Drawing.Point(16, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(787, 106);
            this.groupBox3.TabIndex = 31;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Delete Song";
            // 
            // usrRequestData
            // 
            this.usrRequestData.AllowUserToOrderColumns = true;
            this.usrRequestData.AutoGenerateColumns = false;
            this.usrRequestData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.usrRequestData.DataSource = this.jukeboxDataSetBindingSource;
            this.usrRequestData.Location = new System.Drawing.Point(16, 686);
            this.usrRequestData.Name = "usrRequestData";
            this.usrRequestData.RowTemplate.Height = 28;
            this.usrRequestData.Size = new System.Drawing.Size(955, 594);
            this.usrRequestData.TabIndex = 32;
            // 
            // jukeboxDataSetBindingSource
            // 
            this.jukeboxDataSetBindingSource.DataSource = this.jukeboxDataSet;
            this.jukeboxDataSetBindingSource.Position = 0;
            // 
            // jukeboxDataSet
            // 
            this.jukeboxDataSet.DataSetName = "jukeboxDataSet";
            this.jukeboxDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // AdminPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1426, 1324);
            this.Controls.Add(this.usrRequestData);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnPlaylist);
            this.Controls.Add(this.btnHome);
            this.Name = "AdminPage";
            this.Text = "AdminPage";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usrRequestData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jukeboxDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jukeboxDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox textDelArt;
        private System.Windows.Forms.TextBox textDelSong;
        private System.Windows.Forms.Label labelDeleteArtist;
        private System.Windows.Forms.Label labelDelSong;
        private System.Windows.Forms.TextBox txtAlbName;
        private System.Windows.Forms.Label labelGenre;
        private System.Windows.Forms.Label labelAlbName;
        private System.Windows.Forms.ComboBox boxAlbm;
        private System.Windows.Forms.TextBox txtSongTitle;
        private System.Windows.Forms.TextBox txtSongArt;
        private System.Windows.Forms.Label labelAlb;
        private System.Windows.Forms.Label labelSongArtist;
        private System.Windows.Forms.Label labelSongTitle;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAddSong;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnPlaylist;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button addPic;
        private System.Windows.Forms.Button btnAddAlb;
        private System.Windows.Forms.TextBox txtSongLink;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox boxAddGenre;
        private System.Windows.Forms.DataGridView usrRequestData;
        private System.Windows.Forms.BindingSource jukeboxDataSetBindingSource;
        private jukeboxDataSet jukeboxDataSet;
    }
}
