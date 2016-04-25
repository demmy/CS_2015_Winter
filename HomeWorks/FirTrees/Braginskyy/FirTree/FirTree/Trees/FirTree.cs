using FirTreeApp.Interfaces;
using FirTreeApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirTreeApp.Trees
{
    public class FirTree : AbstractTree, IFirTree
    {
        public FirTree()
        {
            Kind = TypeOfTree.FirTree.ToString();
            Color = ColorOfTree.Green.ToString();
            this.increase = 7;
        }
        public override string Kind { get; protected set; }
        public override int Height { get; protected set; }
        public override string Color { get; protected set; }
        public override int Age 
        {
            get
            {
                return Height / increase;
            }
        }
        public bool Cones
        {
            get
            {
                if (Age >= 5)
                {
                    return true;
                }
                else return false;
            }
        }
        public override void ChangeColor(ISeason season)
        {
            if (season.NameOfSeason == SeasonOfYear.Summer.ToString())
            {
                Color = ColorOfTree.Green.ToString();
            }
            if (season.NameOfSeason == SeasonOfYear.Winter.ToString())
            {
                Color = ColorOfTree.Green.ToString();
            }
        }
        public override void Grow(ISeason season)
        {
            if (season.NameOfSeason == SeasonOfYear.Summer.ToString())
            {
                Height += increase;                
            }
        }
    }
}
