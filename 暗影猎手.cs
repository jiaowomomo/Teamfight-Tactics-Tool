using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace YunDingCombination
{
    class 暗影猎手:IHero
    {
        public CombinationType ct
        {
            get { return CombinationType.贵族 | CombinationType.游侠; }
        }

        public string name
        {
            get { return "暗影猎手"; }
        }

        public System.Drawing.Bitmap image
        {
            get { return Properties.Resources.薇恩; }
        }
    }
}
