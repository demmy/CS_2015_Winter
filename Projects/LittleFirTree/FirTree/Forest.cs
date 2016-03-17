using FirTree.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Enums;

namespace FirTree
{
    public class Forest: IForest
    {
        FirTree firTree; 
        PartOfYear actualSeason;
        double age;
        const double DeltaAge = 0.25;
        
        public Forest (PartOfYear season)
        {
            age = 0;
            actualSeason = season;
        }

        public PartOfYear ActualSeason
        { get { return actualSeason; } }

        public double Age
        { get { return age; } }

        public void FirTreeBorn()
        {
            firTree = new FirTree(this); ;
        }
        
        public void NextSeason()
        {
            age += DeltaAge;
            ChooseSeason();
            IfExistGrowth();
        }

        private void ChooseSeason()
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

        private void IfExistGrowth()
        {
            if (firTree != null)
            {
                firTree.Growth();
            }
        }

        public Shape GetFormFirTree()
        {
            return firTree.Form;
        }

        public Colour GetConditionFirTree()
        {
            return firTree.Condition;
        }

        public double GetAgeFirTree()
        {
            return firTree.Age;
        }

        public double GetHeightFirTree()
        {
            return firTree.Height;
        }

        public void ShowFirTreesInfo()
        {
            Console.WriteLine("Сезон: {0}", GetDescription(actualSeason));
            Console.WriteLine("Информация о ёлочке:");
            Console.WriteLine("Форма: {0}.", GetDescription(firTree.Form));
            Console.WriteLine("Цвет: {0}.", GetDescription(firTree.Condition));
            Console.WriteLine("Высота: {0} м.", firTree.Height);
            Console.WriteLine("Возраст: {0} года.", firTree.Age);
            Console.WriteLine();
            
            Console.ReadLine();
        }
        
        static string GetDescription(Enum value)
        {
            FieldInfo fi = value.GetType().GetField(value.ToString());
            DescriptionAttribute[] attributes =
                  (DescriptionAttribute[])fi.GetCustomAttributes(
                  typeof(DescriptionAttribute), false);
            return (attributes.Length > 0) ? attributes[0].Description : value.ToString();
        }


    }
}
