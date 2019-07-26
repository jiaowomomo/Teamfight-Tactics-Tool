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


        public int consumption
        {
            get { return 5; }
        }

        public string skill
        {
            get { return "主动：艾尼维亚引导一次大型冰风暴，对其中的敌人造成伤害"; }
        }
    }
}
