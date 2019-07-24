using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace YunDingCombination
{
    class 祖安怒兽:IHero
    {
        public CombinationType ct
        {
            get { return CombinationType.狂野 | CombinationType.斗士; }
        }

        public string name
        {
            get { return "祖安怒兽"; }
        }

        public System.Drawing.Bitmap image
        {
            get { return Properties.Resources.狼人; }
        }
    }
}
