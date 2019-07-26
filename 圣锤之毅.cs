using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace YunDingCombination
{
    class 圣锤之毅:IHero
    {
        public CombinationType ct
        {
            get { return CombinationType.约德尔人 | CombinationType.骑士; }
        }

        public string name
        {
            get { return "圣锤之毅"; }
        }

        public System.Drawing.Bitmap image
        {
            get { return Properties.Resources.波比; }
        }


        public int consumption
        {
            get { return 3; }
        }

        public string skill
        {
            get { return "主动：波比砸下她的铁锤，来震开附近的敌人"; }
        }
    }
}
