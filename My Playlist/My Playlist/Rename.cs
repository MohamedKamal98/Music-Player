using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;
using System.Windows.Forms;

namespace My_Playlist
{
    class Rename
    {
        /*
         * note: most of the variables are paths
         * if the file in the project directory (.\project\bin\Debug) complete paths are not necessary
         */
        public void rename_name_tag(string mp3_file_name, string new_name_tag)
        {
            //this function takes the file name or path and the new tag which will replace the old one

            try
            {
                //opening the stream object
                using (Stream stream = File.Open(mp3_file_name, FileMode.Open))
                {
                    //seek the tag position in the file
                    stream.Position = stream.Seek(-125, SeekOrigin.End);

                    //init of the data byte array   
                    byte[] data = new byte[30];
                    int i = 0;

                    //converting the caracters to byte array
                    foreach (char c in new_name_tag)
                    {
                        data[i] = (byte)c;
                        i++;
                    }

                    //converting the rest of the 30 byte array with empty bytes
                    while (i < 30)
                    {
                        //data[i] = (byte)' '; //empty bytes
                        data[i] = 0;           //null bytes
                        i++;
                    }

                    //finally write the byte array to the file in the required place
                    stream.Write(data, 0, data.Length);
                }
            }
            catch (FileNotFoundException e)
            {
                MessageBox.Show( e.ToString(), "Error in name tag renaming", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        public void rename_xml_name(string xml_path, string old_name, string new_name)
        {
            //this function takes the xml file path and the song name to be renamed and the new name
            try
            {
                XmlDocument xDoc = new XmlDocument();
                xDoc.Load(xml_path);
                string byte_old_name = old_name;   //this string variable is made because some songs has fixed 30 characters
                for (int i = old_name.Length; i < 30; i++)
                    byte_old_name += ' ';

                foreach (XmlNode node in xDoc.SelectNodes("AllPlayListsSongs/playlistSong"))
                {
                    if (node.SelectSingleNode("Name").InnerText == old_name || node.SelectSingleNode("Name").InnerText == byte_old_name)
                    {
                        node.SelectSingleNode("Name").InnerText = new_name;
                        xDoc.Save(xml_path);
                        break;
                    }
                }
            }
            catch (XmlException e)
            {
                MessageBox.Show(e.ToString(), "Xml Renaming Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        public void rename_file(string old_name, string new_name)
        {
            try
            {
                File.Move(old_name, new_name);
            }
            catch (FileNotFoundException e)
            {
                MessageBox.Show(e.ToString(), "Rename Directory Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}