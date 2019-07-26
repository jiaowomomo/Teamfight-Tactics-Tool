using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace YunDingCombination
{
    class 暗影猎手:IHero
    {
        public CombinationType ct
        {
            get { return CombinationType.贵族 | CombinationType.游侠; }
        }

        public string name
        {
            get { return "暗影猎手"; }
        }

        public System.Drawing.Bitmap image
        {
            get { return Properties.Resources.薇恩; }
        }


        public int consumption
        {
            get { return 1; }
        }

        public string skill
        {
            get { return "被动：薇恩每第三次攻击造成基于目标最大生命值的额外真实伤害"; }
        }
    }
}
