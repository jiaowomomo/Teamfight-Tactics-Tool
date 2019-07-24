using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace YunDingCombination
{
    class 复仇焰魂:IHero
    {
        public CombinationType ct
        {
            get { return CombinationType.恶魔 | CombinationType.元素使; }
        }

        public string name
        {
            get { return "复仇焰魂"; }
        }

        public System.Drawing.Bitmap image
        {
            get { return Properties.Resources.火男; }
        }
    }
}
