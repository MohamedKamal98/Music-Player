namespace My_Playlist
{
    partial class playlists
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(playlists));
            this.button1 = new System.Windows.Forms.Button();
            this.playcombo = new System.Windows.Forms.ComboBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.axplaylists = new AxWMPLib.AxWindowsMediaPlayer();
            this.addsongbtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.addplaybtn = new System.Windows.Forms.Button();
            this.playnametxt = new System.Windows.Forms.TextBox();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.donebtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.axplaylists)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(32, 24);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 28);
            this.button1.TabIndex = 0;
            this.button1.Text = "Create a new playlist";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // playcombo
            // 
            this.playcombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playcombo.FormattingEnabled = true;
            this.playcombo.Location = new System.Drawing.Point(32, 67);
            this.playcombo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.playcombo.Name = "playcombo";
            this.playcombo.Size = new System.Drawing.Size(128, 23);
            this.playcombo.TabIndex = 1;
            this.playcombo.Text = "your playlists";
            this.playcombo.SelectedIndexChanged += new System.EventHandler(this.Playcombo_SelectedIndexChanged);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(440, 132);
            this.listBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(159, 368);
            this.listBox1.TabIndex = 2;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.ListBox1_SelectedIndexChanged);
            // 
            // axplaylists
            // 
            this.axplaylists.Enabled = true;
            this.axplaylists.Location = new System.Drawing.Point(3, 128);
            this.axplaylists.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.axplaylists.Name = "axplaylists";
            this.axplaylists.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axplaylists.OcxState")));
            this.axplaylists.Size = new System.Drawing.Size(438, 354);
            this.axplaylists.TabIndex = 3;
            // 
            // addsongbtn
            // 
            this.addsongbtn.Location = new System.Drawing.Point(451, 81);
            this.addsongbtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.addsongbtn.Name = "addsongbtn";
            this.addsongbtn.Size = new System.Drawing.Size(140, 28);
            this.addsongbtn.TabIndex = 4;
            this.addsongbtn.Text = "Add songs to this playlist";
            this.addsongbtn.UseVisualStyleBackColor = true;
            this.addsongbtn.Click += new System.EventHandler(this.Button2_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.addplaybtn);
            this.panel1.Controls.Add(this.playnametxt);
            this.panel1.Location = new System.Drawing.Point(192, 10);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(150, 81);
            this.panel1.TabIndex = 5;
            // 
            // addplaybtn
            // 
            this.addplaybtn.Location = new System.Drawing.Point(46, 50);
            this.addplaybtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.addplaybtn.Name = "addplaybtn";
            this.addplaybtn.Size = new System.Drawing.Size(56, 19);
            this.addplaybtn.TabIndex = 1;
            this.addplaybtn.Text = "Add";
            this.addplaybtn.UseVisualStyleBackColor = true;
            this.addplaybtn.Click += new System.EventHandler(this.Addplaybtn_Click);
            // 
            // playnametxt
            // 
            this.playnametxt.Location = new System.Drawing.Point(2, 15);
            this.playnametxt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.playnametxt.Name = "playnametxt";
            this.playnametxt.Size = new System.Drawing.Size(146, 20);
            this.playnametxt.TabIndex = 0;
            this.playnametxt.Text = "Enter the playlist name";
            this.playnametxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.playnametxt.Click += new System.EventHandler(this.Playnametxt_Click);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(440, 132);
            this.checkedListBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(159, 349);
            this.checkedListBox1.TabIndex = 6;
            // 
            // donebtn
            // 
            this.donebtn.Location = new System.Drawing.Point(471, 49);
            this.donebtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.donebtn.Name = "donebtn";
            this.donebtn.Size = new System.Drawing.Size(68, 28);
            this.donebtn.TabIndex = 7;
            this.donebtn.Text = "Done";
            this.donebtn.UseVisualStyleBackColor = true;
            this.donebtn.Click += new System.EventHandler(this.Donebtn_Click);
            // 
            // playlists
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 491);
            this.Controls.Add(this.donebtn);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.addsongbtn);
            this.Controls.Add(this.axplaylists);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.playcombo);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "playlists";
            this.Text = "playlists";
            this.Load += new System.EventHandler(this.Playlists_Load);
            ((System.ComponentModel.ISupportInitialize)(this.axplaylists)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox playcombo;
        private System.Windows.Forms.ListBox listBox1;
        private AxWMPLib.AxWindowsMediaPlayer axplaylists;
        private System.Windows.Forms.Button addsongbtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button addplaybtn;
        private System.Windows.Forms.TextBox playnametxt;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Button donebtn;
    }
}