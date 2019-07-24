using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace YunDingCombination
{
    class 无双剑姬:IHero
    {
        public CombinationType ct
        {
            get { return CombinationType.贵族 | CombinationType.剑士; }
        }

        public string name
        {
            get { return "无双剑姬"; }
        }

        public System.Drawing.Bitmap image
        {
            get { return Properties.Resources.剑姬; }
        }
    }
}
