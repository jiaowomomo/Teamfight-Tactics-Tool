using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace YunDingCombination
{
    class 虚空遁地兽:IHero
    {
        public CombinationType ct
        {
            get { return CombinationType.虚空 | CombinationType.斗士; }
        }

        public string name
        {
            get { return "虚空遁地兽"; }
        }

        public System.Drawing.Bitmap image
        {
            get { return Properties.Resources.挖掘机; }
        }
    }
}
