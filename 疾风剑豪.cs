using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace YunDingCombination
{
    class 疾风剑豪:IHero
    {
        public CombinationType ct
        {
            get { return CombinationType.浪人 | CombinationType.剑士; }
        }

        public string name
        {
            get { return "疾风剑豪"; }
        }

        public System.Drawing.Bitmap image
        {
            get { return Properties.Resources.亚索; }
        }


        public int consumption
        {
            get { return 5; }
        }

        public string skill
        {
            get { return "主动：亚索向前戳刺来造成伤害。在第三次施放时，亚索会吹出一道龙卷风，来对一条直线上的敌人造成伤害和击飞效果"; }
        }
    }
}
