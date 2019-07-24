using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace YunDingCombination
{
    class 曙光女神:IHero
    {
        public CombinationType ct
        {
            get { return CombinationType.贵族 | CombinationType.护卫; }
        }

        public string name
        {
            get { return "曙光女神"; }
        }

        public System.Drawing.Bitmap image
        {
            get { return Properties.Resources.日女; }
        }
    }
}
