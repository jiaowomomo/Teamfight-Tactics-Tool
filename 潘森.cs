using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace YunDingCombination
{
    class 潘森 : IHero
    {
        public CombinationType ct => CombinationType.龙 | CombinationType.护卫;

        public string name => "潘森";

        public Bitmap image => Properties.Resources.潘森;

        public int consumption => 5;

        public string skill => "主动：潘森跃至空中，冲向最远的敌人并眩晕;沿途所有敌人还会受到最大生命值百分比伤害";
    }
}
