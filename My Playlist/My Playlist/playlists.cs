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
    public partial class playlists : Form
    {
        public playlists()
        {
            InitializeComponent();
            panel1.Hide();
            donebtn.Hide();
        }

        private void Playlists_Load(object sender, EventArgs e)
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

        private void Button1_Click(object sender, EventArgs e)
        {
            panel1.Show();
        }
        public void Add_NewPlayList()
        {
            if (!File.Exists("Playlists.xml"))
            {
                XmlWriter writer = XmlWriter.Create("Playlists.xml");
                writer.WriteStartDocument();
                writer.WriteStartElement("PlayLists");
                writer.WriteStartElement("playlist");
                writer.WriteStartElement("Name");
                writer.WriteString(playnametxt.Text);
                writer.WriteEndElement();

                writer.WriteEndElement();
                writer.WriteEndElement();
                writer.WriteEndDocument();
                writer.Close();


            }
            else
            {
                XmlDocument doc2 = new XmlDocument();
                XmlElement son = doc2.CreateElement("playlist");
                XmlElement node = doc2.CreateElement("Name");
                node.InnerText = playnametxt.Text;
                son.AppendChild(node);

                doc2.Load("Playlists.xml");
                XmlElement root = doc2.DocumentElement;
                root.AppendChild(son);
                doc2.Save("Playlists.xml");
            }
        }
        private void Addplaybtn_Click(object sender, EventArgs e)
        {
            playcombo.Items.Add(playnametxt.Text);
            Add_NewPlayList();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            listBox1.Hide();
            addsongbtn.Hide();
            panel1.Hide();
            donebtn.Show();
            checkedListBox1.Show();
            if (File.Exists("AllSongs.xml"))
            {
                XmlDocument doc = new XmlDocument();
                doc.Load("AllSongs.xml");
                XmlNodeList list = doc.GetElementsByTagName("Song");
               
                for (int i = 0; i < list.Count; i++)
                {
                    XmlNodeList child = list[i].ChildNodes;
                    bool getcheck = ExistsOrNot(child[0].InnerText, playcombo.SelectedItem.ToString());
                    if (getcheck == false)
                        checkedListBox1.Items.Add(child[0].InnerText);
                }
            }
           
            }
        public bool ExistsOrNot(string song_name,string playlist_name)
        {
            bool c = true;
            if (File.Exists("PlaylistsSongs.xml"))
            {

                XmlDocument doc = new XmlDocument();
                doc.Load("PlaylistsSongs.xml");
                XmlNodeList list = doc.GetElementsByTagName("playlistSong");
                for (int k = 0; k < list.Count; k++)
                {
                    XmlNodeList child = list[k].ChildNodes;
                    if (child[0].InnerText == song_name&&child[4].InnerText==playlist_name)
                    {
                       
                        return true;
                        
                    }
                    else
                        c= false;

                }
            }
            return false;
        }
        public string itemname, titleval, artistval, albumval, pathval;

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
               axplaylists.URL = paths[listBox1.SelectedIndex];
            }
            catch (Exception)
            { }
        }

        private void Playnametxt_Click(object sender, EventArgs e)
        {
            playnametxt.Text = "";
        }

        public string[] paths;
      
        private void Playcombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            int x = 0;
            axplaylists.Ctlcontrols.stop();
            checkedListBox1.Items.Clear();
            checkedListBox1.Hide();
            listBox1.Show();
            listBox1.Items.Clear();
            donebtn.Hide();
            addsongbtn.Show();
            if (File.Exists("PlaylistsSongs.xml"))
            {
              
                XmlDocument doc = new XmlDocument();
                doc.Load("PlaylistsSongs.xml");
                XmlNodeList list = doc.GetElementsByTagName("playlistSong");
                paths = new string[list.Count];
                for (int i = 0; i < list.Count; i++)
                {
                    XmlNodeList child = list[i].ChildNodes;
                   if(child[4].InnerText==playcombo.SelectedItem.ToString())
                    {
                        listBox1.Items.Add(child[0].InnerText);   
                        paths[x] = child[3].InnerText;
                        x++;
                    }
                    
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
        private void Donebtn_Click(object sender, EventArgs e)
        {

            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                check = false;
                if(checkedListBox1.GetItemChecked(i))
                {
                    itemname = checkedListBox1.Items[i].ToString();
                    if (File.Exists("AllSongs.xml"))
                    {
                        
                        XmlDocument doc = new XmlDocument();
                        doc.Load("AllSongs.xml");
                        XmlNodeList list = doc.GetElementsByTagName("Song");
                     

                        for (int j= 0; j < list.Count; j++)
                        {
                            XmlNodeList child = list[j].ChildNodes;
                            if (child[0].InnerText == itemname)
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
            }
                if (check == true)
                {
                    addSongToPlayList();
                }
            
        }
            checkedListBox1.Hide();
            listBox1.Show();
            donebtn.Hide();
            addsongbtn.Show();
    }
    }
}
