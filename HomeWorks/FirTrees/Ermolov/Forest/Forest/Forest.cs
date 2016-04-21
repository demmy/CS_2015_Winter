/*
 * Created by Mad Nomad
 * User: Sergey Ermolov
 * Date: 14.03.2016
 * Time: 12:47
 */
using System;
using System.Collections.Generic;
using Forest.Enums;
using Forest.Interfaces;

namespace Forest
{
    public class Forest : IForest
    {
        public Season CurrentSeason {get;set;}
        public List<ITree> TreesInForest {get;set;}
        
        public Forest()
        {
            TreesInForest = new List<ITree>();
            changeCurrentSeason(DateTime.Now);
        }

        
        protected void changeCurrentSeason(DateTime date)
        {
            CurrentSeason = GetSeason(date);
        }

        public void Add(TypeOfTree tree)
        {
            TreesInForest.Add(new TreeCreator().Born(tree));
        }


        internal Season GetSeason(DateTime time)
        {
            DateTime t = time;
            switch (t.Month)
            {
                case 1:
                case 2:
                case 12:
                    return Season.Winter;
                case 3:
                case 4:
                case 5:
                    return Season.Spring;
                case 6:
                case 7:
                case 8:
                    return Season.Summer;
                case 9:
                case 10:
                case 11:
                    return Season.Autumn;
                default:
                    return Season.Winter;
            }
        }
        
        internal Season GetSeason2(DateTime time)
        {
            int month = time.Month;
            
            if (month == 12 || month < 3)
                return Season.Winter;
            
            if (month >= 3 && month < 6)
                return Season.Spring;
            
            if (month >= 6 && month < 9)
                return Season.Summer;
            
            return Season.Autumn;
        }
        

    }
}