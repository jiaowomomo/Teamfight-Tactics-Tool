using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace YunDingCombination
{
    class 寒冰射手:IHero
    {
        public CombinationType ct
        {
            get { return CombinationType.极地 | CombinationType.游侠; }
        }

        public string name
        {
            get { return "寒冰射手"; }
        }

        public System.Drawing.Bitmap image
        {
            get { return Properties.Resources.寒冰; }
        }


        public int consumption
        {
            get { return 3; }
        }

        public string skill
        {
            get { return "主动：艾希发射一支箭来横穿地图。在一段长久的延迟后，它会对一名随机敌人造成伤害和晕眩效果"; }
        }
    }
}
