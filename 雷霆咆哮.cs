using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace YunDingCombination
{
    class 雷霆咆哮:IHero
    {
        public CombinationType ct
        {
            get { return CombinationType.极地 | CombinationType.斗士; }
        }

        public string name
        {
            get { return "雷霆咆哮"; }
        }

        public System.Drawing.Bitmap image
        {
            get { return Properties.Resources.狗熊; }
        }
    }
}
