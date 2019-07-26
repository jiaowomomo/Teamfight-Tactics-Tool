using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace YunDingCombination
{
    class 德玛西亚之力:IHero
    {
        public CombinationType ct
        {
            get { return CombinationType.贵族 | CombinationType.骑士; }
        }

        public string name
        {
            get { return "德玛西亚之力"; }
        }

        public System.Drawing.Bitmap image
        {
            get { return Properties.Resources.盖伦; }
        }


        public int consumption
        {
            get { return 1; }
        }

        public string skill
        {
            get { return "主动：盖伦快速地围绕自身旋转他的剑刃，变得免疫魔法伤害，同时会对附近的敌人造成伤害"; }
        }
    }
}
