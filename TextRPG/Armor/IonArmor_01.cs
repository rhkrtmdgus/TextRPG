using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRPG.Armor
{
    public class IonArmor_01 : ArmorMom
    {
        public IonArmor_01(int a, String b, int c, int d) 
        { 
            this.num = a;
            this.gabName = b;
            this.br = c;
            this.gold= d;
        }
    }
}
