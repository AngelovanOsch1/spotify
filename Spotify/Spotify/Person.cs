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
        protected List <Person> friends = new List<Person>();
        private List <Playlist> playlists = new List<Playlist>();


        public Person(string person)
        {
            this.name = person;
            friends.Add(new List <Person>());
        }

        public List <Person> ShowFriends()
        {
            return friends;
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
            return "Friends " + friends + "Name " + name;
        }
    }
}
