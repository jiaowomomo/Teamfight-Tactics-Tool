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


        public int consumption
        {
            get { return 1; }
        }

        public string skill
        {
            get { return "主动：伊莉丝召唤出小蜘蛛、变形并获得生命吸取，小蜘蛛会获得恶魔种族的特质"; }
        }
    }
}
