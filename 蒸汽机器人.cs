using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace YunDingCombination
{
    class 蒸汽机器人:IHero
    {
        public CombinationType ct
        {
            get { return CombinationType.机器人 | CombinationType.斗士; }
        }

        public string name
        {
            get { return "蒸汽机器人"; }
        }

        public System.Drawing.Bitmap image
        {
            get { return Properties.Resources.机器人; }
        }
    }
}
