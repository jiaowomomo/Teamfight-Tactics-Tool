using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace YunDingCombination
{
    class 痛苦之拥:IHero
    {
        public CombinationType ct
        {
            get { return CombinationType.恶魔 | CombinationType.刺客; }
        }

        public string name
        {
            get { return "痛苦之拥"; }
        }

        public System.Drawing.Bitmap image
        {
            get { return Properties.Resources.寡妇; }
        }
    }
}
