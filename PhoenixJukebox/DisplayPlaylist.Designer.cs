namespace PhoenixJukebox
{
    partial class DisplayPlaylist
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
            this.viewPlaylist = new System.Windows.Forms.DataGridView();
            this.jukeboxDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.jukeboxDataSet = new PhoenixJukebox.jukeboxDataSet();
            this.txtSong = new System.Windows.Forms.TextBox();
            this.txtArtist = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnPlay = new System.Windows.Forms.Button();
            this.txtAudio = new System.Windows.Forms.TextBox();
            this.txtAlbum = new System.Windows.Forms.TextBox();
            this.pictAlbArt = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.viewPlaylist)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jukeboxDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jukeboxDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictAlbArt)).BeginInit();
            this.SuspendLayout();
            // 
            // viewPlaylist
            // 
            this.viewPlaylist.AllowUserToAddRows = false;
            this.viewPlaylist.AutoGenerateColumns = false;
            this.viewPlaylist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.viewPlaylist.DataSource = this.jukeboxDataSetBindingSource;
            this.viewPlaylist.Location = new System.Drawing.Point(25, 333);
            this.viewPlaylist.Name = "viewPlaylist";
            this.viewPlaylist.RowTemplate.Height = 28;
            this.viewPlaylist.Size = new System.Drawing.Size(775, 583);
            this.viewPlaylist.TabIndex = 0;
            this.viewPlaylist.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.viewPlaylist_CellContentClick);
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
            // txtSong
            // 
            this.txtSong.Location = new System.Drawing.Point(345, 64);
            this.txtSong.Name = "txtSong";
            this.txtSong.Size = new System.Drawing.Size(235, 26);
            this.txtSong.TabIndex = 2;
            // 
            // txtArtist
            // 
            this.txtArtist.Location = new System.Drawing.Point(345, 124);
            this.txtArtist.Name = "txtArtist";
            this.txtArtist.Size = new System.Drawing.Size(235, 26);
            this.txtArtist.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnPlay);
            this.groupBox1.Controls.Add(this.txtAudio);
            this.groupBox1.Controls.Add(this.txtAlbum);
            this.groupBox1.Controls.Add(this.pictAlbArt);
            this.groupBox1.Controls.Add(this.txtArtist);
            this.groupBox1.Controls.Add(this.txtSong);
            this.groupBox1.Location = new System.Drawing.Point(25, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(793, 314);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Now Playing";
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(677, 248);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(110, 38);
            this.btnPlay.TabIndex = 6;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // txtAudio
            // 
            this.txtAudio.Location = new System.Drawing.Point(313, 248);
            this.txtAudio.Name = "txtAudio";
            this.txtAudio.Size = new System.Drawing.Size(341, 26);
            this.txtAudio.TabIndex = 5;
            // 
            // txtAlbum
            // 
            this.txtAlbum.Location = new System.Drawing.Point(345, 183);
            this.txtAlbum.Name = "txtAlbum";
            this.txtAlbum.Size = new System.Drawing.Size(235, 26);
            this.txtAlbum.TabIndex = 4;
            // 
            // pictAlbArt
            // 
            this.pictAlbArt.Location = new System.Drawing.Point(31, 49);
            this.pictAlbArt.Name = "pictAlbArt";
            this.pictAlbArt.Size = new System.Drawing.Size(249, 211);
            this.pictAlbArt.TabIndex = 1;
            this.pictAlbArt.TabStop = false;
            // 
            // DisplayPlaylist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 1011);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.viewPlaylist);
            this.Name = "DisplayPlaylist";
            this.Text = "DisplayPlaylist";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DisplayPlaylist_FormClosing);
            this.Load += new System.EventHandler(this.DisplayPlaylist_Load);
            ((System.ComponentModel.ISupportInitialize)(this.viewPlaylist)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jukeboxDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jukeboxDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictAlbArt)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView viewPlaylist;
        private System.Windows.Forms.TextBox txtSong;
        private System.Windows.Forms.TextBox txtArtist;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.BindingSource jukeboxDataSetBindingSource;
        private jukeboxDataSet jukeboxDataSet;
        private System.Windows.Forms.PictureBox pictAlbArt;
        private System.Windows.Forms.TextBox txtAlbum;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.TextBox txtAudio;
    }
}