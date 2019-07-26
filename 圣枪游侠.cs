using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace YunDingCombination
{
    class 圣枪游侠:IHero
    {
        public CombinationType ct
        {
            get { return CombinationType.贵族 | CombinationType.枪手; }
        }

        public string name
        {
            get { return "圣枪游侠"; }
        }

        public System.Drawing.Bitmap image
        {
            get { return Properties.Resources.奥巴马; }
        }


        public int consumption
        {
            get { return 2; }
        }

        public string skill
        {
            get { return "主动：卢锡安突进到安全处，并攻击一名敌人两次，一次造成攻击伤害，另一次造成技能伤害"; }
        }
    }
}
