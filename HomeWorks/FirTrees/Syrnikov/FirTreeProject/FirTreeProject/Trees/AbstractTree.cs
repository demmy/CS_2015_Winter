using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirTreeProject
{
    public abstract class AbstractTree : ITree
    {
        protected double height;
        protected double growthSpeed = 10;
        protected TreeColor color;
        protected TreeShape shape;


        public double Height
        {
            get
            {
                return height;
            }
        }
        public double GrowthSpeed
        {
            get
            {
                return growthSpeed;
            }
            set
            {
                if (value > 0)
                {
                    growthSpeed = value;
                }
                else
                {
                    growthSpeed = 0;
                }
            }
        }
        public TreeColor Color
        {
            get
            {
                return color;
            }
        }
        public TreeShape Shape
        {
            get
            {
                return shape;
            }
        }

        public virtual void GrowUp(double delta)
        {
            height += delta;
        }

        public virtual void GrowUp()
        {
            GrowUp(growthSpeed);
        }

        public virtual void ChangeColor(Season season)
        {
            switch (season)
            {
                case Season.Winter:
                    {
                        color = TreeColor.Brown;
                        break;
                    }
                case Season.Spring:
                    {
                        color = TreeColor.LightGreen;
                        break;
                    }
                case Season.Summer:
                    {
                        color = TreeColor.Green;
                        break;
                    }
                case Season.Autumn:
                    {
                        color = TreeColor.Yellow;
                        break;
                    }
                default:
                    {
                        throw new Exception();
                    }
            }
        }
    }
}
