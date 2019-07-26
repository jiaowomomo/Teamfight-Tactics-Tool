using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace YunDingCombination
{
    class 傲之追猎者:IHero
    {
        public CombinationType ct
        {
            get { return CombinationType.狂野 | CombinationType.刺客; }
        }

        public string name
        {
            get { return "傲之追猎者"; }
        }

        public System.Drawing.Bitmap image
        {
            get { return Properties.Resources.狮子狗; }
        }


        public int consumption
        {
            get { return 3; }
        }

        public string skill
        {
            get { return "主动：雷恩加尔跃向最弱的敌人，并对其造成额外伤害。造成伤害后雷恩加尔会获得攻击速度和暴击几率"; }
        }
    }
}
