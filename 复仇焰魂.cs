using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace YunDingCombination
{
    class 复仇焰魂:IHero
    {
        public CombinationType ct
        {
            get { return CombinationType.恶魔 | CombinationType.元素使; }
        }

        public string name
        {
            get { return "复仇焰魂"; }
        }

        public System.Drawing.Bitmap image
        {
            get { return Properties.Resources.火男; }
        }


        public int consumption
        {
            get { return 4; }
        }

        public string skill
        {
            get { return "主动：布兰德发射一团会弹射的火球，对命中的所有敌人造成伤害"; }
        }
    }
}
