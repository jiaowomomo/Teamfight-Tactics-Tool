using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace YunDingCombination
{
    class 正义天使:IHero
    {
        public CombinationType ct
        {
            get { return CombinationType.贵族 | CombinationType.骑士; }
        }

        public string name
        {
            get { return "正义天使"; }
        }

        public System.Drawing.Bitmap image
        {
            get { return Properties.Resources.天使; }
        }
    }
}
