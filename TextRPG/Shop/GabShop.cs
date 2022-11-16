using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextRPG.Armor;
using TextRPG.WeaponF;

namespace TextRPG.Shop
{
    public class GabShop
    {
        public void GabList(Player play)
        {
            bool rs = true;
            IonArmor_01 ion = new IonArmor_01(1, "철갑옷", 10, 500);
            while (rs)
            {

            res:
                Console.Clear();

                Console.WriteLine("---------------------------");
                Console.WriteLine("†   방어구 코너 입장    †");
                Console.WriteLine("---------------------------\n");


                Console.WriteLine("1. 철갑옷(일반)            Gold : 500");
                Console.WriteLine("2. 미스릴갑옷(일반)        Gold : 700");
                Console.WriteLine("3. 다이아갑옷(일반)        Gold : 1000");

                Console.WriteLine("\n5. 홈으로");


                ConsoleKeyInfo check = Console.ReadKey();
                string che = check.KeyChar.ToString();

                switch (che)
                {
                    case "1":
                        if (play.Gold >= 500)
                        {
                            play.Gold -= 500;
                            play.GabSet(ion.GabName, ion.Br);
                            Console.WriteLine($"방어구 장착 성공!!     현재 방어력 : {play.Br} 골드 : {play.Gold}");
                            Thread.Sleep(2000);
                            break;
                        }
                        else
                        {
                            Console.WriteLine($"골드가 부족합니다.       골드 : {play.Gold}");
                            Thread.Sleep(2000);
                            break;
                        }

                    case "2":
                    case "3":
                    case "5":
                        rs = false;
                        break;
                    default:
                        goto res;
                }


            }
        }
    }
}
