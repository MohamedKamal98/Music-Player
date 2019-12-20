using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml;

namespace My_Playlist
{
    public partial class AddSongToPlaylistForm : Form
    {
        public AddSongToPlaylistForm()
        {
            InitializeComponent();
        }

        public string itemname, titleval, artistval, albumval, pathval;
        public string[] paths;


        private void AddSongToPlaylistForm_Load(object sender, EventArgs e)
        {
            playcombo.Items.Clear();
            if (File.Exists("Playlists.xml"))
            {

                XmlDocument doc = new XmlDocument();
                doc.Load("Playlists.xml");
                XmlNodeList list = doc.GetElementsByTagName("playlist");

                for (int i = 0; i < list.Count; i++)
                {
                    XmlNodeList child = list[i].ChildNodes;
                    string playname = child[0].InnerText;
                    playcombo.Items.Add(playname);
                }
            }
        }

        
        bool check = false;
        public void addSongToPlayList()
        {
            if (!File.Exists("PlaylistsSongs.xml"))
            {
                XmlWriter writer = XmlWriter.Create("PlaylistsSongs.xml");
                writer.WriteStartDocument();
                writer.WriteStartElement("AllPlayListsSongs");
                writer.WriteStartElement("playlistSong");
                writer.WriteStartElement("Name");
                writer.WriteString(titleval);
                writer.WriteEndElement();
                writer.WriteStartElement("Artist");
                writer.WriteString(artistval);
                writer.WriteEndElement();
                writer.WriteStartElement("Album");
                writer.WriteString(albumval);
                writer.WriteEndElement();
                writer.WriteStartElement("Path");
                writer.WriteString(pathval);
                writer.WriteEndElement();
                writer.WriteStartElement("PLayList_Name");
                writer.WriteString(playcombo.SelectedItem.ToString());
                writer.WriteEndElement();
                writer.WriteEndElement();
                writer.WriteEndElement();
                writer.WriteEndDocument();
                writer.Close();


            }
            else
            {
                XmlDocument doc2 = new XmlDocument();
                XmlElement son = doc2.CreateElement("playlistSong");

                XmlElement node = doc2.CreateElement("Name");
                node.InnerText = titleval;
                son.AppendChild(node);
                node = doc2.CreateElement("Artist");
                node.InnerText = artistval;
                son.AppendChild(node);
                node = doc2.CreateElement("Album");
                node.InnerText = albumval;
                son.AppendChild(node);
                node = doc2.CreateElement("Path");
                node.InnerText = pathval;
                son.AppendChild(node);
                node = doc2.CreateElement("PLayList_Name");
                node.InnerText = playcombo.SelectedItem.ToString();
                son.AppendChild(node);


                doc2.Load("PlaylistsSongs.xml");
                XmlElement root = doc2.DocumentElement;
                root.AppendChild(son);
                doc2.Save("PlaylistsSongs.xml");
            }
        }

        
        private void Addplaybtn_Click(object sender, EventArgs e)
        {
            
                check = false;

                if (File.Exists("AllSongs.xml"))
                {

                    XmlDocument doc = new XmlDocument();
                    doc.Load("AllSongs.xml");
                    XmlNodeList list = doc.GetElementsByTagName("Song");


                    for (int j = 0; j < list.Count; j++)
                    {
                        XmlNodeList child = list[j].ChildNodes;
                        if (child[0].InnerText == User_controllers.Songaya.NAME)
                        {
                            titleval = child[0].InnerText;
                            artistval = child[1].InnerText;
                            albumval = child[2].InnerText;
                            pathval = child[3].InnerText;
                            check = true;
                            break;

                        }
                    }

                }

                if (check == true)
                {
                    addSongToPlayList();
                }

            this.Close();
        }
    }
}
