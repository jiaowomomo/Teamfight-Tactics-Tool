using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace YunDingCombination
{
    class 法外狂徒:IHero
    {
        public CombinationType ct
        {
            get { return CombinationType.海盗 | CombinationType.枪手; }
        }

        public string name
        {
            get { return "法外狂徒"; }
        }

        public System.Drawing.Bitmap image
        {
            get { return Properties.Resources.男枪; }
        }
    }
}
