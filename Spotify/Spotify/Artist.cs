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
            this.albums = new List<Album>(albums);
        }

        public void AddSong(Song song)
        {
            // Song wordt toegevoegd aan welke list?
        }

        public void AddAlbum(Album album)
        {
            albums.Add(album);
        }

        public override String ToString()
        {
            return "";
        }
    }
}
