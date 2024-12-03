using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_data_structures_sprint.Playlist
{
    internal record Song(string Title, double Duration)
    {
       public override string ToString()
        {
            return $"{Title}:{Duration}";
        }
    }
}
