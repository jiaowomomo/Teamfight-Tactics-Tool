using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace YunDingCombination
{
    class 虚空遁地兽:IHero
    {
        public CombinationType ct
        {
            get { return CombinationType.虚空 | CombinationType.斗士; }
        }

        public string name
        {
            get { return "虚空遁地兽"; }
        }

        public System.Drawing.Bitmap image
        {
            get { return Properties.Resources.挖掘机; }
        }


        public int consumption
        {
            get { return 2; }
        }

        public string skill
        {
            get { return "主动：雷克塞遁入地底一小段时间，来变得无法被选取并治疗自身。当雷克塞破土而出时，她会造成伤害并击飞距离最近的敌人"; }
        }
    }
}
