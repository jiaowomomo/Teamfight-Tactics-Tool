using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace YunDingCombination
{
    class 永猎双子:IHero
    {
        public CombinationType ct
        {
            get { return CombinationType.暗影 | CombinationType.游侠; }
        }

        public string name
        {
            get { return "永猎双子"; }
        }

        public System.Drawing.Bitmap image
        {
            get { return Properties.Resources.千珏; }
        }
    }
}
