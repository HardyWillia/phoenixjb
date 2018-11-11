namespace PhoenixJukebox
{
    partial class FirstPage
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
            this.btnConnect = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.genre = new System.Windows.Forms.Label();
            this.boxGenre = new System.Windows.Forms.ComboBox();
            this.btnPlayshow = new System.Windows.Forms.Button();
            this.priorityPicker = new System.Windows.Forms.DomainUpDown();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.boxSong = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnConnect
            // 
            this.btnConnect.AutoSize = true;
            this.btnConnect.Location = new System.Drawing.Point(399, 738);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(189, 30);
            this.btnConnect.TabIndex = 0;
            this.btnConnect.Text = "Reconnect to Database";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.boxSong);
            this.groupBox1.Controls.Add(this.genre);
            this.groupBox1.Controls.Add(this.boxGenre);
            this.groupBox1.Controls.Add(this.btnPlayshow);
            this.groupBox1.Controls.Add(this.priorityPicker);
            this.groupBox1.Controls.Add(this.btnCancel);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(30, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(530, 316);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Song to Playlist";
            // 
            // genre
            // 
            this.genre.AutoSize = true;
            this.genre.Location = new System.Drawing.Point(21, 150);
            this.genre.Name = "genre";
            this.genre.Size = new System.Drawing.Size(58, 20);
            this.genre.TabIndex = 10;
            this.genre.Text = "Genre:";
            // 
            // boxGenre
            // 
            this.boxGenre.FormattingEnabled = true;
            this.boxGenre.Location = new System.Drawing.Point(125, 146);
            this.boxGenre.Name = "boxGenre";
            this.boxGenre.Size = new System.Drawing.Size(189, 28);
            this.boxGenre.TabIndex = 9;
            this.boxGenre.SelectedIndexChanged += new System.EventHandler(this.boxGenre_SelectedIndexChanged);
            // 
            // btnPlayshow
            // 
            this.btnPlayshow.AutoSize = true;
            this.btnPlayshow.Location = new System.Drawing.Point(21, 214);
            this.btnPlayshow.Name = "btnPlayshow";
            this.btnPlayshow.Size = new System.Drawing.Size(154, 45);
            this.btnPlayshow.TabIndex = 8;
            this.btnPlayshow.Text = "Show Playlist";
            this.btnPlayshow.UseVisualStyleBackColor = true;
            this.btnPlayshow.Click += new System.EventHandler(this.btnPlayshow_Click);
            // 
            // priorityPicker
            // 
            this.priorityPicker.Location = new System.Drawing.Point(125, 102);
            this.priorityPicker.Name = "priorityPicker";
            this.priorityPicker.Size = new System.Drawing.Size(120, 26);
            this.priorityPicker.TabIndex = 5;
            // 
            // btnCancel
            // 
            this.btnCancel.AutoSize = true;
            this.btnCancel.Location = new System.Drawing.Point(419, 214);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(97, 45);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.AutoSize = true;
            this.btnSave.Location = new System.Drawing.Point(300, 214);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(97, 45);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Song Title:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Priority:";
            // 
            // boxSong
            // 
            this.boxSong.FormattingEnabled = true;
            this.boxSong.Location = new System.Drawing.Point(125, 62);
            this.boxSong.Name = "boxSong";
            this.boxSong.Size = new System.Drawing.Size(354, 28);
            this.boxSong.TabIndex = 12;
            // 
            // FirstPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 780);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnConnect);
            this.Name = "FirstPage";
            this.ShowIcon = false;
            this.Text = "Jukebox Addition";
            this.Load += new System.EventHandler(this.FirstPage_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DomainUpDown priorityPicker;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnPlayshow;
        private System.Windows.Forms.Label genre;
        private System.Windows.Forms.ComboBox boxGenre;
        private System.Windows.Forms.ComboBox boxSong;
    }
}

