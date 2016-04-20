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
        protected double growingSpeed;
        protected TreeColor color;
        protected TreeType type;
        protected TreeShape shape;


        public double Height
        {
            get
            {
                return height;
            }
        }
        public double GrowingSpeed
        {
            get
            {
                return growingSpeed;
            }
            set
            {
                growingSpeed = value;
            }
        }
        public TreeColor Color
        {
            get
            {
                return color;
            }
        }
        public TreeType Type
        {
            get
            {
                return type;
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
            height += growingSpeed;
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
                        break;
                    }
            }
        }
    }
}
