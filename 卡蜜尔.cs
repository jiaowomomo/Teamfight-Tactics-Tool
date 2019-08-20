using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace YunDingCombination
{
    class 卡蜜尔 : IHero
    {
        public CombinationType ct
        {
            get
            {
                return CombinationType.剑士 | CombinationType.海克斯;
            }
        }

        public string name
        {
            get
            {
                return "卡蜜尔";
            }
        }

        public Bitmap image
        {
            get
            {
                return Properties.Resources.卡蜜尔;
            }
        }

        public int consumption
        {
            get
            {
                return 1;
            }
        }

        public string skill
        {
            get
            {
                return "主动：会禁锢一名敌人并迫使她范围内的队友优先攻击她的当前目标";
            }
        }
    }
}
