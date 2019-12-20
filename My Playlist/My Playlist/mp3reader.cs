using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace My_Playlist
{
    class mp3reader
    {
        string filename;
        FileStream stream;
        const int size = 128;
        byte[] tagdata;
        public bool check = false;
        public mp3reader(string name)
        {
            try
            {
                tagdata = new byte[size];
                this.filename = name;
                this.stream = new FileStream(this.filename, FileMode.Open);
                check = false;
            }
            catch (Exception){
                check = true; 
            }
        }
        public Song GetTag()
        {
                Song tag = new Song();
            try
            {
                check = false;
                stream.Seek(-128, SeekOrigin.End);
                stream.Read(tagdata, 0, size);
                stream.Close();
            }
            catch (Exception) { }
         
            byte b1 = tagdata[0];
            byte b2 = tagdata[1];
            byte b3 = tagdata[2];
            
            if ((char)b1 != 'T' || (char)b2 != 'A' || (char)b3 != 'G')
            {
                check = false;
            }
            else
            {
                for (int i = 3; i < 33; i++)
                {
                    if (tagdata[i] != 0)
                    {
                        tag.name += (char)tagdata[i];
                    }
                }
               
                for (int i = 33; i < 63; i++)
                {
                    if (tagdata[i] != 0)
                    {
                        tag.Artist += (char)tagdata[i];
                    }
                }
                for (int i = 63; i < 93; i++)
                {
                    if (tagdata[i] != 0)
                    {
                        tag.Album += (char)tagdata[i];
                    }
                }
                for (int i = 97; i < 127; i++)
                {
                    if (tagdata[i] != 0)
                    {
                        tag.Tune += (char)tagdata[i];
                    }
                }
                //if (tag.name == "")
                //    tag.name = filename;
                
            }
            return tag;
        }
    }
}
