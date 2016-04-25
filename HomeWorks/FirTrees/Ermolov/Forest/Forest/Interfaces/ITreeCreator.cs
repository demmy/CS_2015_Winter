/*
 * Created by Mad Nomad
 * User: Sergey Ermolov
 * Date: 21.04.2016
 * Time: 17:45
 */
using System;
using Forest.Enums;

namespace Forest.Interfaces
{
    /// <summary>
    /// Description of ITreeCreator.
    /// </summary>
    public interface ITreeCreator
    {
        ITree Born(TypeOfTree type);
    }
}
