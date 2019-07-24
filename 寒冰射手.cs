using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace YunDingCombination
{
    class 寒冰射手:IHero
    {
        public CombinationType ct
        {
            get { return CombinationType.极地 | CombinationType.游侠; }
        }

        public string name
        {
            get { return "寒冰射手"; }
        }

        public System.Drawing.Bitmap image
        {
            get { return Properties.Resources.寒冰; }
        }
    }
}
