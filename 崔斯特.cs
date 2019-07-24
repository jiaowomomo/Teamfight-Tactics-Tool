using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace YunDingCombination
{
    class 崔斯特:IHero
    {
        public CombinationType ct
        {
            get { return CombinationType.海盗 | CombinationType.法师; }
        }

        public string name
        {
            get { return "崔斯特"; }
        }

        public System.Drawing.Bitmap image
        {
            get { return Properties.Resources.卡牌; }
        }
    }
}
