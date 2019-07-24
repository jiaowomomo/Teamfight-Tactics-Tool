using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace YunDingCombination
{
    class 圣枪游侠:IHero
    {
        public CombinationType ct
        {
            get { return CombinationType.贵族 | CombinationType.枪手; }
        }

        public string name
        {
            get { return "圣枪游侠"; }
        }

        public System.Drawing.Bitmap image
        {
            get { return Properties.Resources.奥巴马; }
        }
    }
}
