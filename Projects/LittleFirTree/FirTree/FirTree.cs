using Enums;
using FirTree.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirTree
{
    public class FirTree: IFirTree
    {
        IForest forest;
        Colour condition;
        Shape form; 
        double height;
        double age;
        const double DeltaHeight = 0.5;
        const double DeltaAge = 0.25;
        
        public FirTree(IForest forest)
        {
            this.forest = forest;
            height = 0;
            age = 0;
            ConditionAndFormChange();
        }

        #region Properties

        public Colour Condition
        { get { return condition; } }

        public Shape Form
        { get { return form; } }

        public double Height
        { get { return height; } }

        public double Age
        { get { return age; } }
        
        #endregion

        public void Growth()
        {
            height += DeltaHeight; 
            age += DeltaAge;
            ConditionAndFormChange();
        }

            void ConditionAndFormChange()
        {
            if (forest.ActualSeason == PartOfYear.Autumn || forest.ActualSeason == PartOfYear.Spring)
            {
                condition = Colour.Unknown;
                form = Shape.Unknown;
            }
            else
            {
                condition = Colour.Green;
                form = Shape.Shapely;
            }
        }
    }
}
