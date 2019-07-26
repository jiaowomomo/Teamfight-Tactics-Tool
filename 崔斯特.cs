using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace YunDingCombination
{
    class 崔斯特:IHero
    {
        public CombinationType ct
        {
            get { return CombinationType.海盗 | CombinationType.法师; }
        }

        public string name
        {
            get { return "崔斯特"; }
        }

        public System.Drawing.Bitmap image
        {
            get { return Properties.Resources.卡牌; }
        }


        public int consumption
        {
            get { return 2; }
        }

        public string skill
        {
            get { return "主动：卡牌大师丢出一张卡牌，可以随机造成眩晕(金色)，目标周围的范围伤害(红色)或者是为自己和附近友军回复法力值(蓝色)的效果"; }
        }
    }
}
