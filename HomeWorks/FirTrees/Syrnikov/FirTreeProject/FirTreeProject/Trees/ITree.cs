using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirTreeProject
{
    public interface ITree
    {
        double Height { get; }
        double GrowthSpeed { get; set; }
        TreeColor Color { get; }
        TreeShape Shape { get; }

        void GrowUp();
        void GrowUp(double delta);
        void ChangeColor(Season season);
    }
}
