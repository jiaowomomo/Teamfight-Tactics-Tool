using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace YunDingCombination
{
    class 龙血武姬:IHero
    {
        public CombinationType ct
        {
            get { return CombinationType.龙 | CombinationType.换形师; }
        }

        public string name
        {
            get { return "龙血武姬"; }
        }

        public System.Drawing.Bitmap image
        {
            get { return Properties.Resources.龙女; }
        }
    }
}
