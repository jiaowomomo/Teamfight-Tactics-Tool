using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace YunDingCombination
{
    class 仙灵女巫:IHero
    {
        public CombinationType ct
        {
            get { return CombinationType.约德尔人 | CombinationType.法师; }
        }

        public string name
        {
            get { return "仙灵女巫"; }
        }

        public System.Drawing.Bitmap image
        {
            get { return Properties.Resources.璐璐; }
        }


        public int consumption
        {
            get { return 2; }
        }

        public string skill
        {
            get { return "主动：璐璐为一名友军提供额外生命值，并击飞该友军附近的敌人"; }
        }
    }
}
