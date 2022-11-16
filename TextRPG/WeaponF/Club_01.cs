using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRPG.WeaponF
{
    public class Club_01 : Weapon
    {
        public Club_01(int a, string b, int c, int d) {

            this.num = a;
            this.wapName = b;
            this.at = c;
            this.gold = d;
        }

        public override void SpecialSkill()
        {
            Console.WriteLine("☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆☆★☆★☆★☆★☆★☆");
            Console.WriteLine("☆  특수 스킬 : 적을 기절시킨다.                확률 10%      ☆");
            Console.WriteLine("☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆☆★☆★☆★☆★☆★☆");
            Thread.Sleep(2000);
        }

    }
}
