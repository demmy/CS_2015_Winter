using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirTreeProject
{
    public enum TreeColor
    {
        Green,
        Yellow,
        Red,
        Brown,
        LightGreen,
        DarkGreen
    }
    public enum TreeType
    {
        FirTree,
        Oak
    }
    public enum TreeShape
    {
        Shapely,
        Wide
    }
    public interface ITree
    {
        double Height { get; }
        double GrowingSpeed { get; set; }
        TreeColor Color { get; }
        TreeType Type { get; }
        TreeShape Shape { get; }

        void GrowUp();
        void GrowUp(double delta);
        void ChangeColor(Season season);
    }
}
