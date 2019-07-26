using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace YunDingCombination
{
    class 死亡歌颂者:IHero
    {
        public CombinationType ct
        {
            get { return CombinationType.暗影 | CombinationType.法师; }
        }

        public string name
        {
            get { return "死亡歌颂者"; }
        }

        public System.Drawing.Bitmap image
        {
            get { return Properties.Resources.死歌; }
        }


        public int consumption
        {
            get { return 5; }
        }

        public string skill
        {
            get { return "主动：卡尔萨斯在一段长时间的引导后对随机数量的敌人造成伤害"; }
        }
    }
}
