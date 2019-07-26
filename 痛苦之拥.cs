using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace YunDingCombination
{
    class 痛苦之拥:IHero
    {
        public CombinationType ct
        {
            get { return CombinationType.恶魔 | CombinationType.刺客; }
        }

        public string name
        {
            get { return "痛苦之拥"; }
        }

        public System.Drawing.Bitmap image
        {
            get { return Properties.Resources.寡妇; }
        }


        public int consumption
        {
            get { return 3; }
        }

        public string skill
        {
            get { return "主动：伊芙琳对距离最近的3名敌人造成伤害，同时自身传送到远处"; }
        }
    }
}
