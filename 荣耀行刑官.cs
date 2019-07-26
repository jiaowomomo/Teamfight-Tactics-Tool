using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace YunDingCombination
{
    class 荣耀行刑官:IHero
    {
        public CombinationType ct
        {
            get { return CombinationType.帝国 | CombinationType.剑士; }
        }

        public string name
        {
            get { return "荣耀行刑官"; }
        }

        public System.Drawing.Bitmap image
        {
            get { return Properties.Resources.德莱文; }
        }


        public int consumption
        {
            get { return 4; }
        }

        public string skill
        {
            get { return "主动：德莱文获得额外攻击特效伤害和攻击速度。至多可叠加2次"; }
        }
    }
}
