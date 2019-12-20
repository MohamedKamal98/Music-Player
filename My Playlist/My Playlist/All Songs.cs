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
    public partial class All_Songs : Form
    {
        public All_Songs()
        {
            InitializeComponent();
            flowLayoutPanel1.Hide();
            backbtn.Hide();
        }
        Song s = new Song();
        public static string songname;
        public string searchname;
        int index = 0;
        private void Addbtn_Click(object sender, EventArgs e)
        {

            OpenFileDialog dia = new OpenFileDialog();
            if (dia.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                String strfilename = dia.FileName;
                string sourceFile = strfilename;
                songname = Path.GetFileName(sourceFile);
                string destinationFile = @"C:\Users\Mido\Desktop\My Playlist\My Playlist\Resources\AllSongs\" + songname;
                try
                {
                    File.Copy(sourceFile, Path.Combine(destinationFile), true);
                }
                catch (Exception)
                {
                    MessageBox.Show("We are very sorry , try to add another song");
                }
                mp3reader m = new mp3reader(destinationFile);
                Song c = m.GetTag();
                if (!File.Exists("AllSongs.xml"))
                {
                    XmlWriter writer = XmlWriter.Create("AllSongs.xml");
                    writer.WriteStartDocument();
                    writer.WriteStartElement("AllSongs");
                    writer.WriteStartElement("Song");
                    writer.WriteStartElement("Title");
                    writer.WriteString(c.name);
                    writer.WriteEndElement();

                    writer.WriteStartElement("Artist");
                    writer.WriteString(c.Artist);
                    writer.WriteEndElement();

                    writer.WriteStartElement("Album");
                    writer.WriteString(c.Album);
                    writer.WriteEndElement();

                    writer.WriteStartElement("Path");
                    writer.WriteString(destinationFile);
                    writer.WriteEndElement();

                    writer.WriteEndElement();
                    writer.WriteEndElement();
                    writer.WriteEndDocument();
                    writer.Close();


                }
                else
                {
                    XmlDocument doc2 = new XmlDocument();
                    XmlElement son= doc2.CreateElement("Song");
                    XmlElement node = doc2.CreateElement("Title");
                    node.InnerText = c.name;
                    son.AppendChild(node);

                    node = doc2.CreateElement("Artist");
                    node.InnerText =c.Artist ;
                    son.AppendChild(node);

                    node = doc2.CreateElement("Album");
                    node.InnerText = c.Album;
                    son.AppendChild(node);

                    node = doc2.CreateElement("Path");
                    node.InnerText = destinationFile;
                    son.AppendChild(node);

                    doc2.Load("AllSongs.xml");
                    XmlElement root = doc2.DocumentElement;
                    root.AppendChild(son);
                    doc2.Save("AllSongs.xml");
                }
                listBox1.Items.Clear();
                flowLayoutPanel1.Controls.Clear();
                XmlDocument doc = new XmlDocument();
                doc.Load("AllSongs.xml");
                XmlNodeList list = doc.GetElementsByTagName("Song");
                names = new string[list.Count];
                paths = new string[list.Count];
                for (int i = 0; i < list.Count; i++)
                {

                    XmlNodeList child = list[i].ChildNodes;
                    string titleval = child[0].InnerText;
                    string artistval = child[1].InnerText;
                    string albumval = child[2].InnerText;
                    string pathval = child[3].InnerText;
                    sname = titleval;
                    path = pathval;
                    paths[i] = pathval;
                    names[i] = titleval;
                    User_controllers.Songaya s = new User_controllers.Songaya();
                    flowLayoutPanel1.Controls.Add(s);
                listBox1.Items.Add(sname);
                }
                axWindowsMediaPlayer1.URL = destinationFile;
                
            }
        }
       
        private void FlowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        public static string sname, path;

        private void FlowLayoutPanel1_Click(object sender, EventArgs e)
        {
        }
       public string []names ,paths;

        private void Button1_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Show();
            backbtn.Show();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Hide();
        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                axWindowsMediaPlayer1.URL = paths[listBox1.SelectedIndex];
            }
            catch(Exception)
            { }
        }

        private void All_Songs_Load(object sender, EventArgs e)
        {
            if (File.Exists("AllSongs.xml"))
            {
                flowLayoutPanel1.Controls.Clear();
                XmlDocument doc = new XmlDocument();
                doc.Load("AllSongs.xml");
                XmlNodeList list = doc.GetElementsByTagName("Song");
                names = new string[list.Count];
                paths = new string[list.Count];

                for (int i = 0; i < list.Count; i++)
                {
                    XmlNodeList child = list[i].ChildNodes;
                    string titleval = child[0].InnerText;
                    string artistval = child[1].InnerText;
                    string albumval = child[2].InnerText;
                    string pathval = child[3].InnerText;
                    sname = titleval;
                    path = pathval;
                    paths[i] = pathval;
                    names[i] = titleval;
                    listBox1.Items.Add(sname);
                    User_controllers.Songaya s = new User_controllers.Songaya();                   
                    flowLayoutPanel1.Controls.Add(s);
                }
                index = Array.IndexOf(names, searchname);
                mark:
                try
                {

                    axWindowsMediaPlayer1.URL = paths[index];
                    listBox1.SetSelected(index, true);

                }
                catch (IndexOutOfRangeException)
                {
                    index = 0;
                    goto mark;
                }
            }


        }
    }
}
