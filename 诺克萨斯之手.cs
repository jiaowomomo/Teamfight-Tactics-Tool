using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace YunDingCombination
{
    class 诺克萨斯之手:IHero
    {
        public CombinationType ct
        {
            get { return CombinationType.帝国 | CombinationType.骑士; }
        }

        public string name
        {
            get { return "诺克萨斯之手"; }
        }

        public System.Drawing.Bitmap image
        {
            get { return Properties.Resources.诺手; }
        }


        public int consumption
        {
            get { return 1; }
        }

        public string skill
        {
            get { return "主动：德莱厄斯挥舞他的斧头，对附近的敌人造成伤害并基于他的已损失生命值来治疗自身"; }
        }
    }
}
