using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace YunDingCombination
{
    class 堕落天使:IHero
    {
        public CombinationType ct
        {
            get { return CombinationType.恶魔 | CombinationType.法师; }
        }

        public string name
        {
            get { return "堕落天使"; }
        }

        public System.Drawing.Bitmap image
        {
            get { return Properties.Resources.莫甘娜; }
        }
    }
}
