using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace YunDingCombination
{
    class 蜘蛛女皇:IHero
    {
        public CombinationType ct
        {
            get { return CombinationType.恶魔 | CombinationType.换形师; }
        }

        public string name
        {
            get { return "蜘蛛女皇"; }
        }

        public System.Drawing.Bitmap image
        {
            get { return Properties.Resources.蜘蛛; }
        }
    }
}
