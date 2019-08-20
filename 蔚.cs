using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace YunDingCombination
{
    class 蔚 : IHero
    {
        public CombinationType ct => CombinationType.斗士 | CombinationType.海克斯;

        public string name => "蔚";

        public Bitmap image => Properties.Resources.蔚;

        public int consumption => 3;

        public string skill => "主动：选择距离最远的敌人并向其冲锋，震开并伤害沿途的每个敌人。一旦她到达目标敌人那里，她就会将其击飞并造成伤害";
    }
}
