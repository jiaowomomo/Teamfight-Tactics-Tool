using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace YunDingCombination
{
    class 铁铠冥魂:IHero
    {
        public CombinationType ct
        {
            get { return CombinationType.暗影 | CombinationType.骑士; }
        }

        public string name
        {
            get { return "铁铠冥魂"; }
        }

        public System.Drawing.Bitmap image
        {
            get { return Properties.Resources.铁男; }
        }


        public int consumption
        {
            get { return 1; }
        }

        public string skill
        {
            get { return "主动：莫德凯撒朝他前方挥舞他的权杖，沿直线造成伤害"; }
        }
    }
}
