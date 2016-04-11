using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Forest.Interfaces;

namespace Forest
{
     enum Shape { Slender, Normal }
     enum Color { DarkGreen, Green }
     enum Season { Autumn, Winter, Spring, Summer }

    class Tree:ITree
    {
        readonly Random rand = new Random();        
        private Season season;
        private  Color color;
        private  Shape shape;
        private int height = 0;
        private int width = 0;
        private int countOfDays = 0;
        private int interval = 300;
        private int growDays = 600;
        private DateTime endDate = new DateTime(2015, 01, 11);
        public int CountOfDays
        {
            get { return countOfDays; }
            set { countOfDays = value; }
        }
        public Color Colour { get { return color; } }
        public Shape TreeShape { get { return shape; } }
        public Tree(Season season)
        {
            countOfDays = Counting();
            this.season = season;
            var msMessanger = new Messanger(this);
            Options();
        }

        public void Appear()
        {
            if (Born != null)
                Born(this, EventArgs.Empty);
        }

        public int Counting()
        {
            DateTime time = RandomDay();
            TimeSpan elSpan = endDate.Subtract(time);
            Console.WriteLine("Time of Born: {0}", time);
            int mytime = elSpan.Days;
            return mytime;
        }
        public DateTime RandomDay()
        {
            DateTime start = new DateTime(1995, 1, 1);
            int range = (DateTime.Today - start).Days;
            return start.AddDays(rand.Next(range));
        }
        bool CheckSeason()
        {
            if (season == Season.Winter || season == Season.Summer)
            {
                return true;
            }
            return false;
        }

        public void Options()
        {
            if (CheckSeason())
            {
                color = Color.Green;
                shape = Shape.Slender;
            }
            else
            {
                color = Color.DarkGreen;
                shape = Shape.Normal;
            }
        }
        public void Grow()
        {
            int count = 300;
            if (countOfDays > 0)
            {
                height += rand.Next(5);
                width += rand.Next(5);
                while (countOfDays >= 0)
                {
                    countOfDays -= interval;
                    if (count == growDays && countOfDays > 0)
                    {
                        if (Grown != null)
                            Grown(this, EventArgs.Empty);
                        break;
                    }
                    count += interval;
                }
            }
            if (countOfDays < 0 || countOfDays == 0)
            {
                if (Die != null)
                    Die(this, EventArgs.Empty);
            }
        }
        public void DisplayTree()
        {
            Console.WriteLine("|Season: {0} | Shape: {1} | Color: {2}|", season, shape, color);
            Console.WriteLine("Left Days: {0}", countOfDays);
        }
        public event EventHandler Born;
        public event EventHandler Grown;
        public event EventHandler Die;
    }
}
