using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace YunDingCombination
{
    class 铸星龙王:IHero
    {
        public CombinationType ct
        {
            get { return CombinationType.龙 | CombinationType.法师; }
        }

        public string name
        {
            get { return "铸星龙王"; }
        }

        public System.Drawing.Bitmap image
        {
            get { return Properties.Resources.龙王; }
        }


        public int consumption
        {
            get { return 4; }
        }

        public string skill
        {
            get { return "主动：奥瑞利安 · 索尔沿直线喷出一道龙息，来对敌人造成伤害"; }
        }
    }
}
