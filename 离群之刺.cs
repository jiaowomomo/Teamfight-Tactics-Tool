using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace YunDingCombination
{
    class 离群之刺:IHero
    {
        public CombinationType ct
        {
            get { return CombinationType.忍者 | CombinationType.刺客; }
        }

        public string name
        {
            get { return "离群之刺"; }
        }

        public System.Drawing.Bitmap image
        {
            get { return Properties.Resources.阿卡丽; }
        }
    }
}
