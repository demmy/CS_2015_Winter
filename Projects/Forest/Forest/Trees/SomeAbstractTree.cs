/*
 * Created by Mad Nomad
 * User: Sergey Ermolov
 * Date: 16.03.2016
 * Time: 12:40
 */
using System;

namespace Forest
{
    /// <summary>
    /// Description of SomeAbstractTree.
    /// </summary>
    public class SomeAbstractTree : Tree
    {
        TypeOfTree type;
        int lenght;
        string color;
        bool shapely;
        
        public SomeAbstractTree()
        {
            Type = TypeOfTree.Unknown;
            Lenght = 0;
            Shapely = false;
            Color = "Invisible";
        }
         #region implemented abstract members of Tree

        public override void Grow()
        {
            // Growing?
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
