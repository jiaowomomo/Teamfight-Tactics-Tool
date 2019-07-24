using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace YunDingCombination
{
    class 暮光之眼:IHero
    {
        public CombinationType ct
        {
            get { return CombinationType.忍者 | CombinationType.剑士; }
        }

        public string name
        {
            get { return "暮光之眼"; }
        }

        public System.Drawing.Bitmap image
        {
            get { return Properties.Resources.慎; }
        }
    }
}
