using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KATSU.Foundation.Enumeration.Models
{
    public interface ISitecoreVersion : ISitecoreVersionGlassBase
    {
        string  Version { get; set; }
    }
}
