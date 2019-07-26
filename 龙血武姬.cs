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


        public int consumption
        {
            get { return 3; }
        }

        public string skill
        {
            get { return "主动：希瓦娜突进到远处并变形。在变形状态下，希瓦娜的攻击变为远程并且会使地面燃烧"; }
        }
    }
}
