using Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirTree
{
    public  static class Nature
    {
        public static PartOfYear actualSeason = PartOfYear.Spring;
        public static event EventHandler changeSeason;

        public static void NextSeason()
        {
            ChooseSeason();
            if (changeSeason != null) { changeSeason(actualSeason, EventArgs.Empty);  }
        }

        private static void ChooseSeason()
        {
            switch (actualSeason)
            {
                case PartOfYear.Spring:
                    actualSeason = PartOfYear.Summer;
                    break;

                case PartOfYear.Summer:
                    actualSeason = PartOfYear.Autumn;
                    break;

                case PartOfYear.Autumn:
                    actualSeason = PartOfYear.Winter;
                    break;

                case PartOfYear.Winter:
                    actualSeason = PartOfYear.Spring;
                    break;
                default:
                    break;
            }
        }
    }
}
