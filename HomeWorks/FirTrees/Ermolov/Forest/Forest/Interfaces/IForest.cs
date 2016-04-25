/*
 * Created by Mad Nomad
 * User: Sergey Ermolov
 * Date: 21.04.2016
 * Time: 17:44
 */
using System;
using System.Collections.Generic;
using Forest.Enums;
using Forest.Interfaces;

namespace Forest.Interfaces
{
    /// <summary>
    /// Description of IForest.
    /// </summary>
    public interface IForest
    {
        void Add(TypeOfTree tree);
        List<ITree> TreesInForest { get; set; }
        Season CurrentSeason { get; set; }
    }
}
