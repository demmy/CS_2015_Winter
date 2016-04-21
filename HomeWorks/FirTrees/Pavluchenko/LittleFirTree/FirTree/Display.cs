using Enums;
using FirTree.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirTree
{
    public static class Display
    {
        
        public static void ShowActualSeason()
        {
            string actualSeason = DiscriptionHelper.GetDescription(Nature.actualSeason);
            Console.WriteLine(actualSeason);
        }

        public static void ShowFirTree(FirTree ft)
        {
            Console.WriteLine("Елочка");
            Console.WriteLine("Длина иголок: {0}", ft.NeedleLength);
            Console.WriteLine("Количество шишек: {0}", ft.NumberOfCones);
            ShowTree(ft);
        }

        public static void ShowSomeTree(SomeTree st)
        {
            Console.WriteLine("Другое дерево");
            ShowTree(st);
        }
        
        public static void ShowFirTrees(Forest forest)
        {
            foreach (var firTree in forest.FirTrees)
            {
                ShowFirTree(firTree);
            }
        }

        public static void ShowSomeTrees(Forest forest)
        {
            foreach (var SomeTree in forest.SomeTrees)
            {
                ShowSomeTree(SomeTree);
            }
        }

        public static void ShowForest(Forest forest)
        {
            foreach (var tree in forest.AllTrees)
            {
                if (tree is FirTree)
                {
                    ShowFirTree((FirTree)tree);
                }
                else if(tree is SomeTree)
                {
                    ShowSomeTree((SomeTree)tree);
                }
            }
        }

        public static void FirTreePrick(int number)
        {
            Console.WriteLine("Вас уколола ёлочка №{0}", number);
        }

        private static void  ShowTree(BaseTree ft)
        {
            Console.WriteLine("Номер: {0}", ft.Number);
            Console.WriteLine("Форма: {0}", DiscriptionHelper.GetDescription(ft.Form));
            Console.WriteLine("Цвет: {0}", DiscriptionHelper.GetDescription(ft.State));
            Console.WriteLine("Высота: {0} м", ft.Height);
            Console.WriteLine("Возраст: {0} года", ft.Age);
            Console.WriteLine();
        }
    }
}
