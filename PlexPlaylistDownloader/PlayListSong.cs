using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlexPlaylistDownloader
{
    public class PlayListSong: INotifyPropertyChanged
    {
        public string Id { get; set; }
        public string ListId { get; set; }
        public string LibraryUUID { get; }
        public string ExtInf { get;  }
        public string Artist { get; }
        public string Title { get;  }
        public string Path { get;  }

        public string Extension { get; }

        public event PropertyChangedEventHandler PropertyChanged;


    public PlayListSong(List<string> m3u8Lines)
        {
            if (m3u8Lines.First<string>().StartsWith("#{\"Id\":"))
            {
                string songListInfo = (m3u8Lines.First<string>());
                string songInfo = m3u8Lines[1];
                string songPath = m3u8Lines[2];

                string[] line1 = songListInfo.Split(',');
                Id = line1[0].Split(':')[1];
                ListId = line1[2].Split(':')[1];


                // line 2
                string[] line2 = songInfo.Split(',');
                ExtInf = line2[0].Split(':')[1];

                Artist = string.Empty;
                int artistIndex = 1;
                string thisArtist = line2[artistIndex];
                while (thisArtist != line2.Last())
                {
                    Artist += thisArtist + ", ";
                    artistIndex++;
                    thisArtist = line2[artistIndex];
                }

                string[] song = songInfo.Split('-');
                Artist += song[0].Split(',').Last().Trim();
                Title = song[1].Trim();

                // line 3
                Path = songPath;
                Extension = System.IO.Path.GetExtension(Path);
            }
        }


    }
}
