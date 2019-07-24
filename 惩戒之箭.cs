using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace YunDingCombination
{
    class 惩戒之箭:IHero
    {
        public CombinationType ct
        {
            get { return CombinationType.恶魔 | CombinationType.游侠; }
        }

        public string name
        {
            get { return "惩戒之箭"; }
        }

        public System.Drawing.Bitmap image
        {
            get { return Properties.Resources.维鲁斯; }
        }
    }
}
