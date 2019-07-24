using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace YunDingCombination
{
    class 九尾妖狐:IHero
    {
        public CombinationType ct
        {
            get { return CombinationType.狂野 | CombinationType.法师; }
        }

        public string name
        {
            get { return "九尾妖狐"; }
        }

        public System.Drawing.Bitmap image
        {
            get { return Properties.Resources.狐狸; }
        }
    }
}
