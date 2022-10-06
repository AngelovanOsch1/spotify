using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotify
{
    internal class Person
    {
        public string name;
        private List <Person> Friends = new List<Person>();
        private List<Playlist> playlists = new List<Playlist>();


        public Person(string person)
        {

        }

        public List <Person> ShowFriends()
        {
            return Friends;
        }

        public List <Playlist> ShowPlayLists()
        {
            return playlists;
        }

        public Playlist SelectPlaylist(int abc)
        {
             return playlists[abc];
        }

        public override String ToString()
        {
            return "";
        }
    }
}
