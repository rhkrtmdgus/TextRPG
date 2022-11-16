using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextRPG.bettle;
using TextRPG.Monster;
using TextRPG.Town;

namespace TextRPG
{
    public class Home
    {
        
        public void PlayerStatus(Player play, IceTown town, BattleField bf)
        {

            
            bool rs = true;

            while(rs) { 
            res:
            Console.Clear();
            Console.WriteLine("------플레이어 정보------\n");
            Console.WriteLine("  레  벨 : " + play.Lv);
            Console.WriteLine("  공격력 : " + play.At + $" ({play.WapAt})");
            Console.WriteLine("  방어력 : " + play.Br + $" ({play.GabBr})");
            Console.WriteLine("  체  력 : " + play.Hp);
            Console.WriteLine("  마  나 : " + play.Mp);
            Console.WriteLine("  경험치 : " + play.Exp +"/"+play.MaxExp+"\n");
            
            Console.WriteLine("  무  기 : " + play.Wap);
            Console.WriteLine("  방어구 : " + play.Gab);
            Console.WriteLine("    펫   : " + play.Pet+"\n");

            Console.WriteLine("  소지금 : " + play.Gold);

            Console.WriteLine("-------------------------\n");

            Console.WriteLine("1. 마을로 가기");

            Console.WriteLine("2. 사냥하러 가기 (자동)");

            Console.WriteLine("3. 저장하기");
            
            ConsoleKeyInfo check = Console.ReadKey();
            string che = check.KeyChar.ToString();
                
                switch (che)
                {
                    case "1":

                        town.TownIn(play);

                        break;
                    case "2": // lv, at, br, exp, hp, mp.gold
                        Thread thread = new Thread(new ThreadStart(bf.Run));
                        bf.Battle(play, bf, thread);
                            break;

                    case "3":
                        Console.Clear();
                        Console.WriteLine("저장하시려면 'Y' 를 눌러 주세요.");
                        ConsoleKeyInfo check2 = Console.ReadKey();
                        string che2 = check2.KeyChar.ToString();
                        if (che2.ToUpper() == "Y")
                        {
                            play.save();
                            
                        }
                        
                        break;
                    default:
                        goto res;
                }

            
            
                
            }
        }
    }
}
