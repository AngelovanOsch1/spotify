using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotify
{
    internal class SuperUser : Person
    {
        public SuperUser(string person) : base(person)
        {

        }

        void AddFriend(Person person)
        {
           Friends.Add(person);
        }

        void RemoveFriend(Person person)
        {
            Friends.Remove(person);
        }

        Playlist CreatePlaylist(string createPlaylist)
        {
            return CreatePlaylist(createPlaylist);
        }

        void RemovePlaylist(int playlist)
        {

        }
        void AddToPlayList(iPlayable addToPlaylist)
        {

        }

        void RemoveFromPlaylist(iPlayable removeFromPlaylist)
        {

        }
    }
}
