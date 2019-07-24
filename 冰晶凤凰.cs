using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace YunDingCombination
{
    class 冰晶凤凰:IHero
    {
        public CombinationType ct
        {
            get { return CombinationType.极地 | CombinationType.元素使; }
        }


        public string name
        {
            get { return "冰晶凤凰"; }
        }

        public System.Drawing.Bitmap image
        {
            get { return Properties.Resources.凤凰; }
        }
    }
}
