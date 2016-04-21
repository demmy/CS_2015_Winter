using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirTreeProject
{
    public delegate void EnvironmentEvent(Season currentSeason);
    public static class NatureEnvironment
    {       
        private static Season currentSeason;
        public static event EnvironmentEvent SeasonChanged;

        public static Season CurrentSeason
        {
            get
            {
                return currentSeason;
            }
        }

        static NatureEnvironment()
        {
            currentSeason = Season.Winter;
        }

        public static void ChangeSeason()
        {
            if (currentSeason == Season.Autumn)
            {
                currentSeason = Season.Winter;
            }
            else
            {
                currentSeason++;
            }
            SeasonChanged.Invoke(currentSeason);
        }
    }
}
