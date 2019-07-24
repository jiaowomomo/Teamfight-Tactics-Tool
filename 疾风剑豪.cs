using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace YunDingCombination
{
    class 疾风剑豪:IHero
    {
        public CombinationType ct
        {
            get { return CombinationType.浪人 | CombinationType.剑士; }
        }

        public string name
        {
            get { return "疾风剑豪"; }
        }

        public System.Drawing.Bitmap image
        {
            get { return Properties.Resources.亚索; }
        }
    }
}
