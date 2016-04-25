using FirTreeApp.Interfaces;
using FirTreeApp.Season;
using FirTreeApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirTreeApp.Trees
{
    public abstract class AbstractTree : ITree
    {
        public AbstractTree()
        {
            Height = 0;
            Age = 0;
        }
        protected int increase = 5;
        public abstract string Kind { get; protected set; }
        public abstract string Color { get; protected set; }
        public virtual int Height { get; protected set; }        
        public virtual int Age { get; protected set; }
        public abstract void ChangeColor(ISeason season);
        public virtual void Grow(ISeason season)
        {
            if (season.NameOfSeason == SeasonOfYear.Summer.ToString())
            {
                Height += increase;
            }
        }
    }
}
