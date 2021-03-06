﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace YunDingCombination
{
    class 虚空掠夺者:IHero
    {
        public CombinationType ct
        {
            get { return CombinationType.虚空 | CombinationType.刺客; }
        }

        public string name
        {
            get { return "虚空掠夺者"; }
        }

        public System.Drawing.Bitmap image
        {
            get { return Properties.Resources.螳螂; }
        }


        public int consumption
        {
            get { return 1; }
        }

        public string skill
        {
            get { return "主动：卡兹克斩击距离最近的敌人，并可对孤立无援的敌人造成额外伤害"; }
        }
    }
}
