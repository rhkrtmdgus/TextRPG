using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextRPG.WeaponF;

namespace TextRPG.Shop
{
    public class WapShop
    {
        public void WapList(Player play) {
            bool rs = true;
            Club_01 club = new Club_01(1, "몽둥이", 10, 300);
            
            while (rs)
            {

            res:
                Console.Clear();

                Console.WriteLine("---------------------------");
                Console.WriteLine("†    무기 코너 입장     †");
                Console.WriteLine("---------------------------\n");


                Console.WriteLine("1. 몽둥이(일반)            Gold : 300");
                Console.WriteLine("2. 미구현단검(일반)        Gold : 500");
                Console.WriteLine("3. 미구현소드(일반)        Gold : 700");

                Console.WriteLine("\n5. 홈으로");


                ConsoleKeyInfo check = Console.ReadKey();
                string che = check.KeyChar.ToString();

                switch (che)
                {
                    case "1":
                        if (play.Gold >= 300)
                        {
                            play.Gold -= 300;
                            play.WapSet(club.WapName, club.At);
                            Console.WriteLine($"무기 장착 성공!!     현재 공격력 : {play.At} 골드 : {play.Gold}");
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
