using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace My_Playlist.User_controllers
{
    public partial class SongayaInPlaylist : Songaya
    {
        public SongayaInPlaylist()
        {
            InitializeComponent();
        }

        private void SongayaInPlaylist_Load(object sender, EventArgs e)
        {
            label1.Text = songnamelbl.Text;
        }

        private void RemoveBT_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(this.RemoveBT, "Remove from playlist");

        }

        private void RemoveBT_Click(object sender, EventArgs e)
        {
            d.delete_Song_From_playlist(get_songData()[1],Form1.playcombo.Text);
            this.Hide();
        }
    }
}
