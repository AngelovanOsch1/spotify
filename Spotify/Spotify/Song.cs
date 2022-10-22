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
        private int duration;
        private List <Artist> artists  = new List<Artist>();
        private Genre songGenre;
        public Genre SongGenre { get { return songGenre; } }

        public Song(string title, List<Artist> artists, int duration, Genre genre)
        {
            this.title = title;
            this.artists = new List<Artist>(artists);
            this.duration = duration;
            songGenre = Genre.METAL;
        }

        public override String ToString()
        {
            return "";
        }
    }
}
