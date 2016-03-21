/*
 * Created by Mad Nomad
 * User: Sergey Ermolov
 * Date: 16.03.2016
 * Time: 12:29
 */
using System;

namespace Forest
{
    /// <summary>
    /// Description of TreeCreator.
    /// </summary>
    public class TreeCreator
    {
        public Tree Born(TypeOfTree type)
        {
            switch (type)
            {
                case TypeOfTree.Fir:
                    return new FirTree();
                case TypeOfTree.Oak:
                    return new SomeAbstractTree();
                case TypeOfTree.Birch:
                    return new SomeAbstractTree();
                default:
                    return new SomeAbstractTree();
            }
            
        }
    }
}
