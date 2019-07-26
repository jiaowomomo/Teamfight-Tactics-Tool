using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace YunDingCombination
{
    class 堕落天使:IHero
    {
        public CombinationType ct
        {
            get { return CombinationType.恶魔 | CombinationType.法师; }
        }

        public string name
        {
            get { return "堕落天使"; }
        }

        public System.Drawing.Bitmap image
        {
            get { return Properties.Resources.莫甘娜; }
        }


        public int consumption
        {
            get { return 3; }
        }

        public string skill
        {
            get { return "主动：莫甘娜对附近的敌人放置于枷锁，在短暂的延迟后，如果敌人仍在附近，则莫甘娜会对他们造成伤害和晕眩效果"; }
        }
    }
}
