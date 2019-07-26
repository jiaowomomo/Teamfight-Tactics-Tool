using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace YunDingCombination
{
    class 赏金猎人:IHero
    {
        public CombinationType ct
        {
            get { return CombinationType.海盗 | CombinationType.枪手; }
        }

        public string name
        {
            get { return "赏金猎人"; }
        }

        public System.Drawing.Bitmap image
        {
            get { return Properties.Resources.女枪; }
        }


        public int consumption
        {
            get { return 5; }
        }

        public string skill
        {
            get { return "主动： 厄运小姐呈锥形引导并发射若干波子弹"; }
        }
    }
}
