using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace YunDingCombination
{
    class 虚空行者:IHero
    {
        public CombinationType ct
        {
            get { return CombinationType.虚空 | CombinationType.法师; }
        }

        public string name
        {
            get { return "虚空行者"; }
        }

        public System.Drawing.Bitmap image
        {
            get { return Properties.Resources.卡萨丁; }
        }


        public int consumption
        {
            get { return 1; }
        }

        public string skill
        {
            get { return "被动：卡萨丁的攻击可从敌人那里偷取法力值，并将其转化成一层护盾"; }
        }
    }
}
