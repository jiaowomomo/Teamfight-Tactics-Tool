using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace YunDingCombination
{
    class 无双剑姬:IHero
    {
        public CombinationType ct
        {
            get { return CombinationType.贵族 | CombinationType.剑士; }
        }

        public string name
        {
            get { return "无双剑姬"; }
        }

        public System.Drawing.Bitmap image
        {
            get { return Properties.Resources.剑姬; }
        }


        public int consumption
        {
            get { return 1; }
        }

        public string skill
        {
            get { return "主动：菲奥娜变得免疫伤害和技能。在短暂的延迟后，她会对距离最近的敌人造成伤害和晕眩效果"; }
        }
    }
}
