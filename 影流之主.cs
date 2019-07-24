using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace YunDingCombination
{
    class 影流之主:IHero
    {
        public CombinationType ct
        {
            get { return CombinationType.忍者 | CombinationType.刺客; }
        }

        public string name
        {
            get { return "影流之主"; }
        }

        public System.Drawing.Bitmap image
        {
            get { return Properties.Resources.劫; }
        }
    }
}
