using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace YunDingCombination
{
    class 不详之刃:IHero
    {
        public CombinationType ct
        {
            get { return CombinationType.帝国 | CombinationType.刺客; }
        }

        public string name
        {
            get { return "不详之刃"; }
        }

        public System.Drawing.Bitmap image
        {
            get { return Properties.Resources.不详; }
        }
    }
}
