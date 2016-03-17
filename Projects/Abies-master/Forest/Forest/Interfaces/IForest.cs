using System.Collections.Generic;

namespace Forest.Interfaces
{
     interface IForest
    {
         Season TreeSeason { get; set; }
         Color TreeColor { get; }
         Shape TreeShape { get; }
    }
}