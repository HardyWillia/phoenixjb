namespace PhoenixJukebox
{
    partial class UserRequest
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
            this.label1 = new System.Windows.Forms.Label();
            this.genre = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.submitBtn = new System.Windows.Forms.Button();
            this.boxAddGenre = new System.Windows.Forms.ComboBox();
            this.textAlbum = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textSong = new System.Windows.Forms.TextBox();
            this.textArtist = new System.Windows.Forms.TextBox();
            this.lblUser = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 20);
            this.label1.TabIndex = 20;
            this.label1.Text = "Artist";
            // 
            // genre
            // 
            this.genre.AutoSize = true;
            this.genre.Location = new System.Drawing.Point(28, 212);
            this.genre.Name = "genre";
            this.genre.Size = new System.Drawing.Size(58, 20);
            this.genre.TabIndex = 19;
            this.genre.Text = "Genre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 20);
            this.label3.TabIndex = 18;
            this.label3.Text = "Song Title:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCancel);
            this.groupBox1.Controls.Add(this.submitBtn);
            this.groupBox1.Controls.Add(this.boxAddGenre);
            this.groupBox1.Controls.Add(this.textAlbum);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textSong);
            this.groupBox1.Controls.Add(this.textArtist);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.genre);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(33, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(711, 583);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Song to Database";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(373, 507);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(133, 56);
            this.btnCancel.TabIndex = 30;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // submitBtn
            // 
            this.submitBtn.Location = new System.Drawing.Point(536, 507);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(150, 56);
            this.submitBtn.TabIndex = 29;
            this.submitBtn.Text = "Submit Request";
            this.submitBtn.UseVisualStyleBackColor = true;
            this.submitBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // boxAddGenre
            // 
            this.boxAddGenre.FormattingEnabled = true;
            this.boxAddGenre.Location = new System.Drawing.Point(132, 212);
            this.boxAddGenre.Name = "boxAddGenre";
            this.boxAddGenre.Size = new System.Drawing.Size(198, 28);
            this.boxAddGenre.TabIndex = 28;
            this.boxAddGenre.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // textAlbum
            // 
            this.textAlbum.Location = new System.Drawing.Point(132, 154);
            this.textAlbum.Name = "textAlbum";
            this.textAlbum.Size = new System.Drawing.Size(253, 26);
            this.textAlbum.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 20);
            this.label2.TabIndex = 26;
            this.label2.Text = "Album Name:";
            // 
            // textSong
            // 
            this.textSong.Location = new System.Drawing.Point(132, 103);
            this.textSong.Name = "textSong";
            this.textSong.Size = new System.Drawing.Size(253, 26);
            this.textSong.TabIndex = 25;
            // 
            // textArtist
            // 
            this.textArtist.Location = new System.Drawing.Point(132, 54);
            this.textArtist.Name = "textArtist";
            this.textArtist.Size = new System.Drawing.Size(253, 26);
            this.textArtist.TabIndex = 24;
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(52, 9);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(51, 20);
            this.lblUser.TabIndex = 25;
            this.lblUser.Text = "label4";
            this.lblUser.Click += new System.EventHandler(this.lblUser_Click);
            // 
            // UserRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 659);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.groupBox1);
            this.Name = "UserRequest";
            this.Text = "UserRequest";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label genre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox boxAddGenre;
        private System.Windows.Forms.TextBox textAlbum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textSong;
        private System.Windows.Forms.TextBox textArtist;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button submitBtn;
        private System.Windows.Forms.Label lblUser;
    }
}