using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextRPG.Monster;
using System.Threading;
using System.Runtime.InteropServices;
using TextRPG.WeaponF;

namespace TextRPG.bettle
{
    public class BattleField
    {
        private int status = 1;
        private int threadStatus = 1;
        public string EndMae = "사냥 종료 : 'p' 또는 'P'";
        public string EndAto = "종료 예약 중...";
        public string EndResult = "";

        public int Status { get { return status; } set { this.status = value; } }
        public int ThreadStatus { get { return threadStatus; } set { this.threadStatus = value; } }

        public void Run()
        {
            res:
            ConsoleKeyInfo inf = Console.ReadKey();
            string tt = inf.KeyChar.ToString();

            switch (tt)
            {
                case "p":
                case "P":
                    
                    try
                    {
                        Thread.Sleep(1000);
                    }
                    catch (ThreadInterruptedException e)
                    {
                        Console.WriteLine(e.Message);
                        Console.Clear();
                        this.EndResult = this.EndAto;
                        this.status = 0;
                        this.threadStatus = 0;

                    }
                    break;
                default:
                    goto res;
            }
        }

        public void Battle(Player play, BattleField bf, Thread thread)
        {
            this.EndResult = this.EndMae;
            Random random = new Random();
            Console.Clear();

            Console.WriteLine("---------------------------");
            Console.WriteLine("†       사냥터 입장     †");
            Console.WriteLine("---------------------------\n");

            Thread.Sleep(3000);
            Console.Clear();
            Console.WriteLine("---------------------------");
            Console.WriteLine("†       고블린 초원     †");
            Console.WriteLine("---------------------------\n");
            Thread.Sleep(1000);
            Gobulin gobulin = new Gobulin("고블린", 1, 2, 3, 3, 130, 0, 30);


            int checkBF = 1;
            this.threadStatus = 1;  //스레드 동작 초기화 
            while (true)
            {

                if(thread.ThreadState.ToString() == "Unstarted")
                {
                    thread.Start();
                    thread.Interrupt();
                }
                Console.Clear();
                Console.WriteLine("---------------------------");
                Console.WriteLine("†       고블린 초원     †");
                Console.WriteLine($"---------------------------                   {this.EndResult}\n");
                

                if(checkBF == 1)
                {
                    Thread.Sleep(3000);
                    gobulin.MonsterReset(random);
                    Thread.Sleep(random.Next(3000) + 2000);
                    if(this.threadStatus == 0) //스레드 종료 확인용
                    {

                        break;
                    }
                    checkBF = bf.Damage(play, gobulin);
                    if (checkBF == 0)
                    {
                        bf.Status = 1;
                        break;
                    }
                }

            }
            
        }

        public int Damage(Player play, Gobulin monster)
        {
            this.status = 1;
            Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine("---------------------------");
            Console.WriteLine("†       고블린 초원     †");
            Console.WriteLine($"---------------------------                   {this.EndResult}\n");
            Console.WriteLine("몬스터 출현!!!!");
            Thread.Sleep(2000);
            while (true)
            {
                
                Console.Clear();
                if(this.status == 0)
                {
                    Console.WriteLine("잠시 후 마을로 귀환합니다. ");
                    break;
                }
                    Console.WriteLine("---------------------------");
                    Console.WriteLine("†       고블린 초원     †");
                    Console.WriteLine($"---------------------------                   {this.EndResult}\n");
                    Console.WriteLine($"몬스터 레벨 : {monster.lv} 체력 : {monster.hp} \n");
                    Console.WriteLine($"플레이어 레벨 : {play.Lv} 체력 : {play.Hp} \n");
                    Console.WriteLine("----------------------배틀 시작-------------------------\n");

                

                Random random = new Random();
                int result = random.Next(2);
                if (result == 0)
                {
                    result = monster.br - play.At;
                    result = result <= 0 ? -result : result;
                    monster.hp -= result;
                    Console.Clear();
                    Console.WriteLine("---------------------------");
                    Console.WriteLine("†       고블린 초원     †");
                    Console.WriteLine($"---------------------------                   {this.EndResult}\n");
                    Console.WriteLine($"몬스터 레벨 : {monster.lv} 체력 : {monster.hp} \n");
                    Console.WriteLine($"플레이어 레벨 : {play.Lv} 체력 : {play.Hp} \n");
                    Console.WriteLine("----------------------배틀 시작-------------------------\n");
                    Console.WriteLine($"플레이어 가 {monster.monName} 에게 {result} 만큼의 데미지를 주었습니다.\n");
                    Thread.Sleep(500);
                    result = random.Next(10)+1;
                    if(result == 1)
                    {
                        // 특수스킬 넣을 예정
                    }
                    Thread.Sleep(random.Next(1000)+1000);
                }
                else
                {
                    result = play.Br - monster.at;
                    result = result <= 0 ? -result : result;
                    play.Hp -= result;
                    Console.Clear();
                    Console.WriteLine("---------------------------");
                    Console.WriteLine("†       고블린 초원     †");
                    Console.WriteLine($"---------------------------                   {this.EndResult}\n");
                    Console.WriteLine($"몬스터 레벨 : {monster.lv} 체력 : {monster.hp} \n");
                    Console.WriteLine($"플레이어 레벨 : {play.Lv} 체력 : {play.Hp} \n");
                    Console.WriteLine("----------------------배틀 시작-------------------------\n");
                    Console.WriteLine($"{monster.monName} 이(가) 플레이어 에게 {result} 만큼의 데미지를 주었습니다.\n");
                    Thread.Sleep(500);

                    Thread.Sleep(random.Next(1000) + 1000);
                }

                if (play.Hp <= 20)
                {
                    Console.WriteLine("------- 시스템 -------\n");
                    Console.WriteLine("플레이어 체력이 부족합니다.");
                    Console.WriteLine("곧 마을로 복귀합니다...");
                    Thread.Sleep(3000);
                }



                if (monster.hp <= 0)
                {
                    monster.hp = 0;
                    Console.Clear();
                    Console.WriteLine("---------------------------");
                    Console.WriteLine("†       고블린 초원     †");
                    Console.WriteLine($"---------------------------                   {this.EndResult}\n");
                    Console.WriteLine($"몬스터 레벨 : {monster.lv} 체력 : {monster.hp} \n");
                    Console.WriteLine($"플레이어 레벨 : {play.Lv} 체력 : {play.Hp} \n");
                    Console.WriteLine("----------------------배틀 종료-------------------------\n");

                    Console.WriteLine($"{monster.monName} 을(를) 처치했습니다. 경험치 +{monster.exp} 골드 +{monster.gold}\n");
                    Thread.Sleep(3000);
                    Console.Clear();
                    Console.WriteLine("---------------------------");
                    Console.WriteLine("†       고블린 초원     †");
                    Console.WriteLine($"---------------------------                   {this.EndResult}\n");
                    play.Exp += monster.exp;
                    play.Gold += monster.gold;
                    if(play.Exp >= play.MaxExp)
                    {
                        play.LevelUp(play.Lv);
                        
                    }
                    break;
                }

            }
            return this.status;
            
        }
        
    }
}
