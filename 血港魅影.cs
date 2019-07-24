using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace YunDingCombination
{
    class 血港魅影:IHero
    {
        public CombinationType ct
        {
            get { return CombinationType.海盗 | CombinationType.刺客; }
        }

        public string name
        {
            get { return "血港魅影"; }
        }

        public System.Drawing.Bitmap image
        {
            get { return Properties.Resources.派克; }
        }
    }
}
