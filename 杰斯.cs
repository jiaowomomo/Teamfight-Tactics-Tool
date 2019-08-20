using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace YunDingCombination
{
    class 杰斯 : IHero
    {
        public CombinationType ct => CombinationType.换形师 | CombinationType.海克斯;

        public string name => "杰斯";

        public Bitmap image => Properties.Resources.杰斯;

        public int consumption => 2;

        public string skill => "主动：击退一名敌方单位来扰乱敌人的前排。他随后会切换到他的【墨丘利之炮】来提升攻击速度和攻击距离";
    }
}
