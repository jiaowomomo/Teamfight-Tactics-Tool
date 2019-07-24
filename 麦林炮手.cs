using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace YunDingCombination
{
    class 麦林炮手:IHero
    {
        public CombinationType ct
        {
            get { return CombinationType.约德尔人 | CombinationType.枪手; }
        }

        public string name
        {
            get { return "麦林炮手"; }
        }

        public System.Drawing.Bitmap image
        {
            get { return Properties.Resources.小炮; }
        }
    }
}
