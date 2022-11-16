using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextRPG;

namespace TextRPG.Shop
{
    public class ShopMain
    {
        public void ShopIn(Player play)
        {
            bool rs = true;
            while (rs)
            {

            res:
                Console.Clear();

                Console.WriteLine("---------------------------");
                Console.WriteLine("†       상점가 입장     †");
                Console.WriteLine("---------------------------\n");


                Console.WriteLine("1. 무기 코너 보기");
                Console.WriteLine("2. 방어구 코너 보기");
                Console.WriteLine("3. 펫 코너 보기");
                Console.WriteLine("4. 소모품 코너 보기");
                Console.WriteLine("\n\n5. 홈으로");


                ConsoleKeyInfo check = Console.ReadKey();
                string che = check.KeyChar.ToString();

                switch (che)
                {
                    case "1":
                        WapShop wapShop = new WapShop();
                        wapShop.WapList(play);
                        break;
                    case "2":
                        GabShop gabShop = new GabShop();
                        gabShop.GabList(play);
                        break;
                    case "4":
                        Consumables consu = new Consumables();
                        consu.ConsuShopIn(play);
                        break;
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
