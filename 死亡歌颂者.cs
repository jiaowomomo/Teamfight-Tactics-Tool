using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace YunDingCombination
{
    class 死亡歌颂者:IHero
    {
        public CombinationType ct
        {
            get { return CombinationType.暗影 | CombinationType.法师; }
        }

        public string name
        {
            get { return "死亡歌颂者"; }
        }

        public System.Drawing.Bitmap image
        {
            get { return Properties.Resources.死歌; }
        }
    }
}
