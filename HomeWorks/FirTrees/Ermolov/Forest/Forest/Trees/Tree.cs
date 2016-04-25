/*
 * Created by Mad Nomad
 * User: Sergey Ermolov
 * Date: 14.03.2016
 * Time: 13:02
 */
using System;
using Forest;
using Forest.Enums;
using Forest.Interfaces;

namespace Forest
{
    /// <summary>
    /// Description of Tree.
    /// </summary>
    public abstract class Tree : ITree
    {
        public TypeOfTree Type { get; set; }
        public int Height { get; set; }
        public string Color{ get; set; }
        public Shape Form { get; set; }

        public void Grow()
        {
            Height++;
        }
    }
}
