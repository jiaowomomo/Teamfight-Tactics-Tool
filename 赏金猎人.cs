using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace YunDingCombination
{
    class 赏金猎人:IHero
    {
        public CombinationType ct
        {
            get { return CombinationType.海盗 | CombinationType.枪手; }
        }

        public string name
        {
            get { return "赏金猎人"; }
        }

        public System.Drawing.Bitmap image
        {
            get { return Properties.Resources.女枪; }
        }
    }
}
