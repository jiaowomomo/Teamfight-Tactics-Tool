using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace YunDingCombination
{
    class 不详之刃:IHero
    {
        public CombinationType ct
        {
            get { return CombinationType.帝国 | CombinationType.刺客; }
        }

        public string name
        {
            get { return "不详之刃"; }
        }

        public System.Drawing.Bitmap image
        {
            get { return Properties.Resources.不详; }
        }


        public int consumption
        {
            get { return 3; }
        }

        public string skill
        {
            get { return "主动：卡塔琳娜引导并朝附近的若干敌人投掷匕首，对他们造成伤害并减少治疗效果"; }
        }
    }
}
