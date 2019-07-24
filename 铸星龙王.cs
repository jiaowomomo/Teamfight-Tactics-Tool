using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace YunDingCombination
{
    class 铸星龙王:IHero
    {
        public CombinationType ct
        {
            get { return CombinationType.龙 | CombinationType.法师; }
        }

        public string name
        {
            get { return "铸星龙王"; }
        }

        public System.Drawing.Bitmap image
        {
            get { return Properties.Resources.龙王; }
        }
    }
}
