using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace YunDingCombination
{
    class 德玛西亚之力:IHero
    {
        public CombinationType ct
        {
            get { return CombinationType.贵族 | CombinationType.骑士; }
        }

        public string name
        {
            get { return "德玛西亚之力"; }
        }

        public System.Drawing.Bitmap image
        {
            get { return Properties.Resources.盖伦; }
        }
    }
}
