using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace YunDingCombination
{
    class 北地之怒:IHero
    {
        public CombinationType ct
        {
            get { return CombinationType.极地 | CombinationType.骑士; }
        }

        public string name
        {
            get { return "北地之怒"; }
        }

        public System.Drawing.Bitmap image
        {
            get { return Properties.Resources.猪女; }
        }


        public int consumption
        {
            get { return 4; }
        }

        public string skill
        {
            get { return "主动：瑟庄妮创造一团大型的冰川风暴，在短暂的延迟后，对其内的敌人造成晕眩效果"; }
        }
    }
}
