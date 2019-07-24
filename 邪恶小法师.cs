using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace YunDingCombination
{
    class 邪恶小法师:IHero
    {
        public CombinationType ct
        {
            get { return CombinationType.约德尔人 | CombinationType.法师; }
        }

        public string name
        {
            get { return "邪恶小法师"; }
        }

        public System.Drawing.Bitmap image
        {
            get { return Properties.Resources.小法; }
        }
    }
}
