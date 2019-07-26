using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace YunDingCombination
{
    class 暗裔剑魔 : IHero
    {
        public CombinationType ct
        {
            get { return CombinationType.恶魔 | CombinationType.剑士; }
        }

        public string name
        {
            get { return "暗裔剑魔"; }
        }

        public System.Drawing.Bitmap image
        {
            get { return Properties.Resources.剑魔; }
        }


        public int consumption
        {
            get { return 3; }
        }

        public string skill
        {
            get { return "主动：亚托克斯顺劈他面前的区域，对区域内的敌人造成伤害"; }
        }
    }
}
