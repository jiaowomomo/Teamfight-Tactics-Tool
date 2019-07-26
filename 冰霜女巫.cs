using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace YunDingCombination
{
    class 冰霜女巫:IHero
    {
        public CombinationType ct
        {
            get { return CombinationType.极地 | CombinationType.元素使; }
        }

        public string name
        {
            get { return "冰霜女巫"; }
        }

        public System.Drawing.Bitmap image
        {
            get { return Properties.Resources.冰女; }
        }


        public int consumption
        {
            get { return 2; }
        }

        public string skill
        {
            get { return "主动：丽桑卓将目标封入冰块，并对附近的敌人造成伤害。在半血以下时，丽桑卓会将自己封入冰块，并变得无法被选取"; }
        }
    }
}
