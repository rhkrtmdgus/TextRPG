using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRPG.Armor
{
    public class ArmorMom
    {
        protected int num;
        protected string gabName;
        protected int br;
        protected int gold;


        public int Num
        {
            get { return num; }
            set { num = value; }
        }

        public string GabName
        {
            get { return gabName; }
            set { gabName = value; }
        }

        public int Br
        {
            get { return br; }
            set { br = value; }
        }

        public int Gold
        {
            get { return gold; }
            set
            {
                gold = value;
            }
        }


    }
}
