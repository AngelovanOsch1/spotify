using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotify
{
    internal class Album : SongCollection
    {
        private List <Artist> artists = new List<Artist>();

        public Album(string abc, List<Artist> artists) : base(abc)
        {
            
        }

        public Artist ShowArtists()
        {
            return artists[0];
        }

        public override String ToString()
        {
            return "";
        }
    }
}
