using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace YunDingCombination
{
    class 傲之追猎者:IHero
    {
        public CombinationType ct
        {
            get { return CombinationType.狂野 | CombinationType.刺客; }
        }

        public string name
        {
            get { return "傲之追猎者"; }
        }

        public System.Drawing.Bitmap image
        {
            get { return Properties.Resources.狮子狗; }
        }
    }
}
