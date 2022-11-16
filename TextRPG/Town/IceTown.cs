using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextRPG.Shop;

namespace TextRPG.Town
{
    public class IceTown
    {
        public void TownIn(Player play)
        {
            bool rs = true;
            while (rs)
            {

            res:
            Console.Clear();

            Console.WriteLine("---------------------------");
            Console.WriteLine("†       마을 입장       †");
            Console.WriteLine("---------------------------\n\n");

            
            Console.WriteLine("1. 캐릭터 장비 보기");

            Console.WriteLine("2. 상점으로 가기");

            Console.WriteLine("\n\n3. 뒤로가기");

            ConsoleKeyInfo check = Console.ReadKey();
            string che = check.KeyChar.ToString();
            if (che == "1" || che == "2" || che == "3")
            {

                switch (che)
                {
                    case "1":
                        play.GetStatus();
                        break;
                    case "2":
                            ShopMain shop = new ShopMain();
                            shop.ShopIn(play);
                        break;
                    case "3":
                        rs = false;
                        break;
                }
            }
            else
            {
                goto res;
            }

            }

        }
    }
}
