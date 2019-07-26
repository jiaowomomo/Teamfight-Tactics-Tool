using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace YunDingCombination
{
    class 曙光女神:IHero
    {
        public CombinationType ct
        {
            get { return CombinationType.贵族 | CombinationType.护卫; }
        }

        public string name
        {
            get { return "曙光女神"; }
        }

        public System.Drawing.Bitmap image
        {
            get { return Properties.Resources.日女; }
        }


        public int consumption
        {
            get { return 4; }
        }

        public string skill
        {
            get { return "主动：蕾欧娜召唤一道天降的太阳光束，对其中心的敌人造成晕眩效果并对其内的敌人造成伤害"; }
        }
    }
}
