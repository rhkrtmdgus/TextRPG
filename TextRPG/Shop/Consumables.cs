using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRPG.Shop
{
    public class Consumables
    {
        public void ConsuShopIn(Player play)
        {
            int freepo = 0;
            if (play.Hp <= 20)
            {
                freepo = 2;
            }
            
            bool rs = true;
            while (rs)
            {

            res:
                Console.Clear();

                Console.WriteLine("---------------------------");
                Console.WriteLine("†   소모품 상점 입장    †");
                Console.WriteLine("---------------------------\n");


                Console.WriteLine("1. 체력 포션 (HP : 100)       Gold : 100");
                Console.WriteLine("2. 마나 포션 (MP : 30)        Gold :  50");
                Console.WriteLine("3. 무료 체력 포션 (최대 2EA)  Gold :   -");
                
                Console.WriteLine("\n\n5. 홈으로");


                ConsoleKeyInfo check = Console.ReadKey();
                string che = check.KeyChar.ToString();

                switch (che)
                {
                    case "1":
                        if (play.Gold >= 100)
                        {
                            play.Gold -= 100;
                            play.Hp += 100;
                            Console.WriteLine($"\n 체력 포션 구매 성공      골드 : {play.Gold}");
                            Console.WriteLine($"현재 체력 : {play.Hp}  현재 마나 : {play.Mp}");
                            Thread.Sleep(1500);
                        }
                        else
                        {
                            Console.WriteLine($"골드가 부족합니다.        골드 : {play.Gold}");
                            Thread.Sleep(1500);
                        }
                        
                        break;
                    case "2":
                        break;
                    case "3":
                        if(freepo <= 2 && freepo != 0)
                        {
                            play.Hp += 100;
                            freepo -= 1;
                            Console.WriteLine($"무료 체력 포션 구매     현재 포인트 : {freepo}");
                            Thread.Sleep(1500);

                        }
                        else
                        {
                            Console.WriteLine("무료 포인트가 부족합니다.");
                            Thread.Sleep(1500);

                        }
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
