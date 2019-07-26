using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace YunDingCombination
{
    class 狂野女猎手:IHero
    {
        public CombinationType ct
        {
            get { return CombinationType.狂野 | CombinationType.换形师; }
        }

        public string name
        {
            get { return "狂野女猎手"; }
        }

        public System.Drawing.Bitmap image
        {
            get { return Properties.Resources.豹女; }
        }


        public int consumption
        {
            get { return 1; }
        }

        public string skill
        {
            get { return "主动：奈德丽治疗自身和伤势最重的友军，然后变形"; }
        }
    }
}
