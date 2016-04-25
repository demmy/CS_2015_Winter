/*
 * Created by Mad Nomad
 * User: Sergey Ermolov
 * Date: 21.04.2016
 * Time: 17:46
 */
using System;
using Forest.Enums;

namespace Forest.Interfaces
{
    /// <summary>
    /// Description of ITree.
    /// </summary>
    public interface ITree
    {
        void Grow();
        TypeOfTree Type { get; set; }
        int Height { get; set; }
        string Color { get; set; }
        Shape Form { get; set; }
    }
}
