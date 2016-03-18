/*
 * Created by Mad Nomad
 * User: Sergey Ermolov
 * Date: 14.03.2016
 * Time: 13:02
 */
using System;
using Forest;

namespace Forest
{
    /// <summary>
    /// Description of Tree.
    /// </summary>
    public abstract class Tree
    {
        public abstract void Grow();
        public abstract TypeOfTree Type { get; set; }
        public abstract int Lenght { get; set; }
        public abstract string Color { get; set; }
        public abstract bool Shapely { get; set; }
    }
    
    public enum TypeOfTree {
        Unknown,
        Fir,
        Oak,
        Birch
    }
}
