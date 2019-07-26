using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace YunDingCombination
{
    class 迷失之牙:IHero
    {
        public CombinationType ct
        {
            get { return CombinationType.约德尔人 | CombinationType.狂野 | CombinationType.换形师; }
        }

        public string name
        {
            get { return "迷失之牙"; }
        }

        public System.Drawing.Bitmap image
        {
            get { return Properties.Resources.纳尔; }
        }


        public int consumption
        {
            get { return 4; }
        }

        public string skill
        {
            get { return "主动：纳尔变形并跳到距离最远的敌人身后，同时伤害并将敌人向后猛推"; }
        }
    }
}
