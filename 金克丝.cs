using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace YunDingCombination
{
    class 金克丝 : IHero
    {
        public CombinationType ct => CombinationType.枪手 | CombinationType.海克斯;

        public string name => "金克丝";

        public Bitmap image => Properties.Resources.金克丝;

        public int consumption => 4;

        public string skill => "被动：在她首次参与击杀后获得【罪恶快感】，提供攻击速度加成。在她第二次参与击杀后，她会抽出她的火箭发射器【鱼骨头】，来使她的攻击造成范围伤害";
    }
}
