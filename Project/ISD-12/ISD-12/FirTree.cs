using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISD_12
{
    public class FirTree : IFirTree
    {
        private int hight = 0;
        private string form = "Slim";
        private string color = "Green";
        public int GrowFirTree(int increase)
        {            
            return hight+= increase;            
        }
        public int Hight
        {
            get { return hight; }
        }
        public string Form
        {
            get { return form; }
        }
        public string Color
        {
            get { return color; }
        }
    }
}
