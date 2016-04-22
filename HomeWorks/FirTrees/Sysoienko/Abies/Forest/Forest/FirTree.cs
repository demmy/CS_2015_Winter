using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Forest.Enums;
using Forest.Interfaces;

namespace Forest
{
     class FirTree : IFirTree
    {
        private const int Interval = 50;
        private const int GrowDays = 300;  
        private  Color _color;
        private  Shape _shape;
        private int _height = 0;
        private int _width = 0;
        public Color Colour { get { return _color; } }
        public Shape Shape { get { return _shape; } }

        public int Height { get { return _height; } }
        public int Width { get { return _width; } }
        public FirTree()
        {
            var msMessanger = new Messanger(this);
        }
        public void Appear()
        {
            if (Born != null)
                Born(this, EventArgs.Empty);
        }
        public void TreeOption(Season season)
        {
            if (season == Season.Summer ||  season == Season.Winter)
            {
                _color = Color.Green;
                _shape = Shape.Slender;
            }
            else
            {
                _color = Color.DarkGreen;
                _shape = Shape.Normal;
            }
        }
        public void Grow()
        {
                var count = 0;
                _height += 10;
                _width += 10;
                while ( GrowDays > count)
                {
                    if (count == GrowDays)
                    {
                        if (Grown != null)
                            Grown(this, EventArgs.Empty);
                              return;
                    }
                    count += Interval;
                } 
        }
        public event EventHandler Born;
        public event EventHandler Grown;
    }
}
