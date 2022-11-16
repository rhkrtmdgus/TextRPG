using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace TextRPG.Monster
{
    public class Gobulin : Monster
    {
        public Gobulin(string monName, int a, int b, int c, int d, int e, int f, int g) {

            this.monName = monName;
            this.lv = a;
            this.at = b;
            this.br = c;
            this.exp = d;
            this.hp = e;
            this.mp = f;
            this.gold = g;

        }

    }
}
