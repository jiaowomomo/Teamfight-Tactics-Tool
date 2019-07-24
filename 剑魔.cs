using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace YunDingCombination
{
    class 剑魔 : IHero
    {
        public CombinationType ct
        {
            get { return CombinationType.恶魔 | CombinationType.剑士; }
        }

        public string name
        {
            get { return "剑魔"; }
        }

        public System.Drawing.Bitmap image
        {
            get { return Properties.Resources.剑魔; }
        }
    }
}
