using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace YunDingCombination
{
    class 卡莎 : IHero
    {
        public CombinationType ct => CombinationType.刺客 | CombinationType.游侠 | CombinationType.虚空;

        public string name => "卡莎";

        public Bitmap image => Properties.Resources.卡莎;

        public int consumption => 5;

        public string skill => "主动：卡莎冲到距离最远的敌方单位旁边，自身获得基于生命值的护盾并获得攻击速度，持续3秒。";
    }
}
