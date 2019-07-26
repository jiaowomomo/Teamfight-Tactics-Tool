using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace YunDingCombination
{
    class 虚空恐惧:IHero
    {
        public CombinationType ct
        {
            get { return CombinationType.虚空 | CombinationType.斗士; }
        }

        public string name
        {
            get { return "虚空恐惧"; }
        }

        public System.Drawing.Bitmap image
        {
            get { return Properties.Resources.大虫; }
        }


        public int consumption
        {
            get { return 4; }
        }

        public string skill
        {
            get { return "主动：科加斯碎裂一片区域，对区域内的敌人造成伤害和晕眩效果"; }
        }
    }
}
