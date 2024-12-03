using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace cs_data_structures_sprint.Playlist
{
    internal class Album(string name, string artist)
    {
        public string Name = name;
        public string Artist = artist;
        public List<Song> Songs = new();


        public void AddSong(Song song)
        {
            Songs.Add(song);
        }

        public void AddSong(string title, double duration)
        {
            AddSong(new Song(title, duration));
        }

        public Song? FindSong(string title)
        {
            return Songs.Find(s => s.Title == title);//.Where(x => x.Title == title)
        }
        
    }
}
