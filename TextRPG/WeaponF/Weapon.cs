using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRPG.WeaponF
{
    public class Weapon
    {
        protected int num;
        protected string wapName;
        protected int at;
        protected int gold;



        public int Num
        {
            get { return num; }
            set { num = value; }
        }

        public string WapName
        {
            get { return wapName; }
            set { wapName = value; }

        }

        public int At
        {
            get { return at; }
            set { at = value; }

        }

        public int Gold
        {
            get { return gold; }
            set
            {
                gold = value;
            }

        }

        public virtual void SpecialSkill()
        {

        }

    }
}
