using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enums
{
    public enum Color
    {
        [Description("неизвестен")]  Unknown,
        [Description("зеленый")] Green }

    public enum TreeType
    {
        [Description("ёлка")] FirTree,
        [Description("другое дерево")] SomeTree,

    }

    public enum Shape
    {
        [Description("неизвестна")] Unknown,
        [Description("стройная")] Shapely }

    public enum PartOfYear
    {
        [Description("Весна")] Spring,
        [Description("Лето")] Summer,
        [Description("Осень")] Autumn,
        [Description("Зима")] Winter
    }
    
}
