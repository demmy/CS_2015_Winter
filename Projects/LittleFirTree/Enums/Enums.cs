using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enums
{
    public enum Colour
    {[Description("неизвестен")]  Unknown, [Description("зеленый")] Green }

    public enum Shape
    {[Description("неизвестна")] Unknown, [Description("стройная")] Shapely }

    public enum PartOfYear
    {
        [Description("Весна")]
        Spring,
        [Description("Лето")]
        Summer,
        [Description("Осень")]
        Autumn,
        [Description("Зима")]
        Winter
    }
}
