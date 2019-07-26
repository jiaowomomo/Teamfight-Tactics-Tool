using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace YunDingCombination
{
    class 暮光之眼:IHero
    {
        public CombinationType ct
        {
            get { return CombinationType.忍者 | CombinationType.剑士; }
        }

        public string name
        {
            get { return "暮光之眼"; }
        }

        public System.Drawing.Bitmap image
        {
            get { return Properties.Resources.慎; }
        }


        public int consumption
        {
            get { return 2; }
        }

        public string skill
        {
            get { return "主动：慎创造一个领域来环绕自身，允许友军闪避所有攻击"; }
        }
    }
}
