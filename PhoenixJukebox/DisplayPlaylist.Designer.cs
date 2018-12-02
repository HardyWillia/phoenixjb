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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.viewPlaylist)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jukeboxDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jukeboxDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
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
            this.viewPlaylist.Size = new System.Drawing.Size(637, 402);
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
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(31, 49);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(249, 211);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(345, 64);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(235, 26);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(345, 124);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(235, 26);
            this.textBox2.TabIndex = 3;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(345, 184);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(235, 26);
            this.textBox3.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Location = new System.Drawing.Point(25, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(649, 290);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Now Playing";
            // 
            // DisplayPlaylist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 765);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.viewPlaylist);
            this.Name = "DisplayPlaylist";
            this.Text = "DisplayPlaylist";
            this.Load += new System.EventHandler(this.DisplayPlaylist_Load);
            ((System.ComponentModel.ISupportInitialize)(this.viewPlaylist)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jukeboxDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jukeboxDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView viewPlaylist;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.BindingSource jukeboxDataSetBindingSource;
        private jukeboxDataSet jukeboxDataSet;
    }
}