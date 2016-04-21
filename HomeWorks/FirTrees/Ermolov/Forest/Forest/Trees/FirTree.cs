/*
 * Created by Mad Nomad
 * User: Sergey Ermolov
 * Date: 15.03.2016
 * Time: 17:53
 */
using System;
using Forest.Enums;

namespace Forest
{
    public class FirTree : Tree
    {
        public FirTree()
        {
            Type = TypeOfTree.Fir;
            Height = 1;
            Form = Shape.Shapely;
            Color = "Green";
        }
    }
}
