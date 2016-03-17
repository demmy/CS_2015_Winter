using System;
using Forest.Interfaces;

namespace Forest
{
     class Messanger
    {
        public Messanger(ITree tree)
        {
            tree.Born += tree_Born;
            tree.Grown += tree_Grown;
            tree.Die += tree_Die;
        }

        void tree_Die(object sender, EventArgs e)
        {
            if (sender is ITree)
                Console.WriteLine("Abies died in Forest!");
        }
        void tree_Grown(object sender, EventArgs e)
        {
            if (sender is ITree)
                Console.WriteLine("Abies grew in Forest!");
        }
        void tree_Born(object sender, EventArgs e)
        {
            if (sender is ITree)
                Console.WriteLine("Abies was born in Forest!");
        } 
    }
}