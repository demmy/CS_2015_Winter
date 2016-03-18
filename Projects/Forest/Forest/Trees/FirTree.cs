/*
 * Created by Mad Nomad
 * User: Sergey Ermolov
 * Date: 15.03.2016
 * Time: 17:53
 */
using System;

namespace Forest
{
    /// <summary>
    /// Description of FirTree.
    /// </summary>
    public class FirTree : Tree
    {
        TypeOfTree type;
        int lenght;
        string color;
        bool shapely;
        
        public FirTree()
        {
            Type = TypeOfTree.Fir;
            Lenght = 1;
            Shapely = true;
            Color = "Green";
        }

        #region implemented abstract members of Tree

        public override void Grow()
        {
            Lenght++;
        }

        public override TypeOfTree Type
        {
            get
            {
                return type;
            }
            set
            {
                type = value; 
            }
        }

        public override int Lenght
        {
            get
            {
                return lenght;
            }
            set
            {
                lenght = value; 
            }
        }

        public override string Color
        {
            get
            {
                return color;
              }
            set
            {
                color = value;
            }
        }

        public override bool Shapely
        {
            get
            {
                return shapely;
            }
            set
            {
                shapely = value;
            }
        }

        #endregion
    }
}
