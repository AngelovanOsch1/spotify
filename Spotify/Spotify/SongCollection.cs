using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotify
{
    internal class SongCollection
    {
        private string Title;
        public List<iPlayable> playables = new List<iPlayable>();

        public SongCollection(string abc)
        {

        }

        public override String ToString()
        {
            return "";
        }

        public iPlayable ShowPlayables()
        {
            return playables[0];
        }
    }
}
