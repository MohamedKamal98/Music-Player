using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace My_Playlist.User_controllers
{
    public partial class Songaya : UserControl
    {
        public Songaya()
        {
            InitializeComponent();
            songnamelbl.Text = All_Songs.sname;
        }
        public static string NAME;
        public static string path,name,playlistName;
        public Delete d = new Delete();

        private void Song_Load(object sender, EventArgs e)
        {
           
            
        }
        private void Button2_Click(object sender, EventArgs e)
        {

        }
        public string[] get_songData()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("AllSongs.xml");
            XmlNodeList list = doc.GetElementsByTagName("Song");
            for (int i = 0; i < list.Count; i++)
            {

                XmlNodeList child = list[i].ChildNodes;
                string titleval = child[0].InnerText;
                string pathval = child[3].InnerText;
                if (titleval == songnamelbl.Text)
                {
                    path = pathval;
                    name = titleval;
                    break;
                }

            }
            string[] str = new string[]{ path, name };
            return str;
        }
            private void Songnamelbl_Click(object sender, EventArgs e)
        {
            

        }
        private void PictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void DeleteBT_Click(object sender, EventArgs e)
        {
            d.delete_all(get_songData()[1]);
            this.Hide();
        }

        private void RenameBT_Click(object sender, EventArgs e)
        {

        }

        private void AddToPlaylistBT_Click(object sender, EventArgs e)
        {
            AddSongToPlaylistForm addSongToPlaylistForm = new AddSongToPlaylistForm();
            addSongToPlaylistForm.Show();
            NAME = get_songData()[1];
        }

        private void AddToPlaylistBT_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(this.AddToPlaylistBT, "Add to playlist");
        }

        private void RenameBT_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(this.RenameBT, "Rename");

        }

        private void DeleteBT_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(this.DeleteBT, "Delete");

        }

        private void PlayBT_Click(object sender, EventArgs e)
        {
            if (Form1.clicks == 1)
                Form1.Player_Slider.Value = 0;

            Form1.axWindowsMediaPlayer1.URL = get_songData()[0];
            Form1.SongName_lbl.Text = get_songData()[1];
            Form1.timer1.Start();
            Form1.clicks = 1;
            Form1.pictureBox5.Enabled = true;
        }
    }
}
