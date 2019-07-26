using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace YunDingCombination
{
    class 弗雷尔卓德之心:IHero
    {
        public CombinationType ct
        {
            get { return CombinationType.极地 | CombinationType.护卫; }
        }

        public string name
        {
            get { return "弗雷尔卓德之心"; }
        }

        public System.Drawing.Bitmap image
        {
            get { return Properties.Resources.布隆; }
        }


        public int consumption
        {
            get { return 2; }
        }

        public string skill
        {
            get { return "主动：布隆创造一道屏障来格挡所有即将到来的伤害"; }
        }
    }
}
