using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace YunDingCombination
{
    public interface IHero
    {
        CombinationType ct { get; }
        string name { get; }
        Bitmap image { get; }
        int consumption { get; }
        string skill { get; }
    }
}
