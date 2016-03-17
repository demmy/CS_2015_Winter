using Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirTree
{
    class Program
    {
        static void Main(string[] args)
        {
            Forest Sherwood = new Forest(PartOfYear.Spring); 
            Sherwood.NextSeason(); 

            Sherwood.FirTreeBorn();

            Sherwood.NextSeason(); 
            Sherwood.NextSeason(); 

            Sherwood.ShowFirTreesInfo(); // зима стройность (+) зеленость (+) рост (+)

            Sherwood.NextSeason(); 

            Sherwood.ShowFirTreesInfo(); // весна - - +
            Sherwood.NextSeason(); 

            Sherwood.ShowFirTreesInfo(); // лето + + + 

            Sherwood.NextSeason(); 

            Sherwood.ShowFirTreesInfo(); // осень - - +



        }
    }
}
