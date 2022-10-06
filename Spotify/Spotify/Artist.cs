using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotify
{
    internal class Artist
    {
        private string name;
        public string Name { get { return name; } }

        private List<Album> albums = new List<Album>();

        private List<Song> Songs = new List<Song>();

        public Artist(string name, List<Album> albums)
        {
            this.name = name;
            this.albums = albums;
        }

        public void AddSong(Song song)
        {

        }

        public void AddAlbum(Album album)
        {

        }

        public override String ToString()
        {
            return "";
        }
    }
}
