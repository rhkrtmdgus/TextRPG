using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace TextRPG.Monster
{
    public class Monster
    {
        public string monName;
        public int lv;
        public int at;
        public int br;
        public int exp;
        public int hp;
        public int mp;
        public int gold;

        public virtual void MonsterReset(Random random)
        {
            this.lv = random.Next(3)+1;
            this.at = random.Next(5)+1;
            this.br = random.Next(7)+1;
            this.exp = random.Next(5)+5;
            this.hp = random.Next(100)+100;
            this.mp = random.Next(0);
            this.gold = random.Next(15)+15;
        }
    }
}
