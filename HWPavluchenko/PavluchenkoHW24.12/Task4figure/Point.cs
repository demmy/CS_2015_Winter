﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4figure
{
    public class Point
    {
        int x;

        public int X
        {
            get { return x; }
        }
        int y;

        public int Y
        {
            get { return y; }
        }
        string name;

        public string Name
        {
            get { return name; }
        }

        public Point(int x, int y, string name)
        {
            this.x = x;
            this.y = y;
            this.name = name;
        }
    }

   
    
}
