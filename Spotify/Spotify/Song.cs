using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotify
{
    enum Genre
    {
        ROCK,
        METAL,
        POP,
        HIPHOP,
        DUBSTEP,

    }
    internal class Song
    {
        private string title;
        public string Title { get { return title; } }
        private List <Artist> artists  = new List<Artist>();

        private Genre songGenre;
        public Genre SongGenre { get { return songGenre; } }
        private int duration;

        public Song(string song, List<Artist> artists, int duration, Genre genre)
        {
            songGenre = Genre.METAL;
        }

        public override String ToString()
        {
            return "";
        }
    }
}
