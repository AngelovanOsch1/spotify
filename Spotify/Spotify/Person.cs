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
        protected List <Person> Friends = new List<Person>();
        private List<Playlist> playlists = new List<Playlist>();


        public Person(string person)
        {
            this.name = person;
        }

        public List <Person> ShowFriends()
        {
            return Friends;
        }

        public List <Playlist> ShowPlayLists()
        {
            return playlists;
        }

        public Playlist SelectPlaylist(int playlist)
        {
             return playlists[playlist];
        }

        public override String ToString()
        {
            return "";
        }
    }
}
