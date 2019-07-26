using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace YunDingCombination
{
    class 海洋之灾:IHero
    {
        public CombinationType ct
        {
            get { return CombinationType.海盗 | CombinationType.枪手 | CombinationType.剑士; }
        }

        public string name
        {
            get { return "海洋之灾"; }
        }

        public System.Drawing.Bitmap image
        {
            get { return Properties.Resources.船长; }
        }


        public int consumption
        {
            get { return 3; }
        }

        public string skill
        {
            get { return "主动：普朗克周期性地制造火药桶。在施放时，普朗克会引爆火药桶来伤害附近的敌人"; }
        }
    }
}
