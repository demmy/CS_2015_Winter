using System.Collections.Generic;
using Forest.Enums;

namespace Forest.Interfaces
{
     interface IForest
    {
        void SetSeason(Season season);
        void Add(ITree tree);
    }
}