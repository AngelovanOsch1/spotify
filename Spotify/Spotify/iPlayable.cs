using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotify
{
    internal interface iPlayable
    {
        void Play();
        void Pause();
        void Next();
        void Stop();
        int Length();
    }
}
