using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace YunDingCombination
{
    class 邪恶小法师:IHero
    {
        public CombinationType ct
        {
            get { return CombinationType.约德尔人 | CombinationType.法师; }
        }

        public string name
        {
            get { return "邪恶小法师"; }
        }

        public System.Drawing.Bitmap image
        {
            get { return Properties.Resources.小法; }
        }


        public int consumption
        {
            get { return 3; }
        }

        public string skill
        {
            get { return "主动：维迦用魔法能量来轰击一名敌人。如果敌人的星级低于维迦，那么这个技能会将其立刻击杀"; }
        }
    }
}
