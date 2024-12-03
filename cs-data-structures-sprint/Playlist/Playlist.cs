using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_data_structures_sprint.Playlist
{
    internal class Playlist
    {
        public LinkedList<Song> Songs = new();


        public void AddSong(Song song)
        {
            Songs.AddLast(song);
        }

        public void PlaySong(Song song) 
        {
            Console.WriteLine($"Playing {song.Title} for {song.Duration}");
        }

        public List<Song> GetSongList()
        {
            return Songs.ToList();
        }
    }
}
