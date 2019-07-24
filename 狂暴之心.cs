using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace YunDingCombination
{
    class 狂暴之心:IHero
    {
        public CombinationType ct
        {
            get { return CombinationType.忍者 | CombinationType.约德尔人 | CombinationType.元素使; }
        }

        public string name
        {
            get { return "狂暴之心"; }
        }

        public System.Drawing.Bitmap image
        {
            get { return Properties.Resources.凯南; }
        }
    }
}
