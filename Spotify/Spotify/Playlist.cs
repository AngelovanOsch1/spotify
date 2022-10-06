using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotify
{
    internal class Playlist : SongCollection
    {
        public Person Owner;

        public Playlist(Person owner, string playlist) : base(playlist)
        {

        }

        public void Add(iPlayable addSong)
        {
            playables.Add(addSong);
        }

        public void Remove(iPlayable removeSong) 
        {
            playables.Remove(removeSong);
        }

        public override String ToString()
        {
            return "";
        }
    }
}
