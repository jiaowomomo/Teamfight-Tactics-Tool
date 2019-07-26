using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace YunDingCombination
{
    class 麦林炮手:IHero
    {
        public CombinationType ct
        {
            get { return CombinationType.约德尔人 | CombinationType.枪手; }
        }

        public string name
        {
            get { return "麦林炮手"; }
        }

        public System.Drawing.Bitmap image
        {
            get { return Properties.Resources.小炮; }
        }


        public int consumption
        {
            get { return 1; }
        }

        public string skill
        {
            get { return "主动：崔丝塔娜将一颗炸弹放置到她的当前目标的身上，并在3次攻击后引爆该炸弹，来伤害附近的敌人"; }
        }
    }
}
