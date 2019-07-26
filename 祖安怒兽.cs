using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace YunDingCombination
{
    class 祖安怒兽:IHero
    {
        public CombinationType ct
        {
            get { return CombinationType.狂野 | CombinationType.斗士; }
        }

        public string name
        {
            get { return "祖安怒兽"; }
        }

        public System.Drawing.Bitmap image
        {
            get { return Properties.Resources.狼人; }
        }


        public int consumption
        {
            get { return 1; }
        }

        public string skill
        {
            get { return "主动：沃里克扑向生命值最低的敌人，造成伤害和晕眩效果。技能附带普攻特效"; }
        }
    }
}
