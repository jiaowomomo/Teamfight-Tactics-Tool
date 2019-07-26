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


        public int consumption
        {
            get { return 5; }
        }

        public string skill
        {
            get { return "主动：斯维因变形，可从附近的所有敌人那里吸取生命值"; }
        }
    }
}
