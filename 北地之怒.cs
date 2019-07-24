using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace YunDingCombination
{
    class 北地之怒:IHero
    {
        public CombinationType ct
        {
            get { return CombinationType.极地 | CombinationType.骑士; }
        }

        public string name
        {
            get { return "北地之怒"; }
        }

        public System.Drawing.Bitmap image
        {
            get { return Properties.Resources.猪女; }
        }
    }
}
