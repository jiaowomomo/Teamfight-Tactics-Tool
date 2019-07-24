using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace YunDingCombination
{
    class 诺克萨斯统领:IHero
    {
        public CombinationType ct
        {
            get { return CombinationType.帝国 | CombinationType.恶魔 | CombinationType.换形师; }
        }

        public string name
        {
            get { return "诺克萨斯统领"; }
        }

        public System.Drawing.Bitmap image
        {
            get { return Properties.Resources.乌鸦; }
        }
    }
}
