using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace YunDingCombination
{
    class 冰霜女巫:IHero
    {
        public CombinationType ct
        {
            get { return CombinationType.极地 | CombinationType.元素使; }
        }

        public string name
        {
            get { return "冰霜女巫"; }
        }

        public System.Drawing.Bitmap image
        {
            get { return Properties.Resources.冰女; }
        }
    }
}
