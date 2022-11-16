using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextRPG.WeaponF;

namespace TextRPG
{
    public class Player
    {
        private int lv;
        private int at;
        private int br;
        private int gold;
        private int exp;
        private int maxExp;
        private int hp;
        private int mp;
        private int dex;

        private string wap = "   없 음";
        private string gab = "   없 음";
        private string pet = "   없 음";

        private int wapAt;
        private int gabBr;

        public Player(int lv, int at, int br, int gold, int exp, int maxExp, int hp, int mp, int dex, string wap, string gab, string pet, 
            int wapAt, int gabBr) {
            this.lv = lv;
            this.at = at;
            this.br = br;
            this.gold = gold;
            this.exp = exp;
            this.maxExp = maxExp;
            this.hp = hp;
            this.mp = mp;
            this.dex = dex;

            this.wap = wap;
            this.gab = gab;
            this.pet = pet;

            this.wapAt = wapAt;
            this.gabBr = gabBr;
        }


        public int Lv
        {


            get { return lv; }
            set { lv = value; }
        }

        public int At
        {


            get { return at; }
            set { at = value; }
        }

        public int Br
        {


            get { return br; }
            set { br = value; }
        }

        public int Exp
        {


            get { return exp; }
            set { exp = value; }
        }
        public int MaxExp
        {


            get { return maxExp; }
            set { maxExp = value; }
        }

        public int Hp
        {


            get { return hp; }
            set { hp = value; }
        }
        public int Mp
        {


            get { return mp; }
            set { mp = value; }
        }
        public int Dex
        {


            get { return dex; }
            set { dex = value; }
        }

        public int Gold
        {


            get { return gold; }
            set { gold = value; }
        }

        public string Wap
        {


            get { return wap; }
            set { wap = value; }
        }
        public string Gab
        {


            get { return gab; }
            set { gab = value; }
        }
        public string Pet
        {


            get { return pet; }
            set { pet = value; }
        }

        public int WapAt
        {
            get { return wapAt; }
            set { wapAt = value; }
        }

        public int GabBr
        {
            get { return gabBr; }
            set { gabBr = value; }
        }

        



        public void GetStatus()
        {
            bool rs = true;
            while (rs)
            {
                res:
                Console.Clear();
                Console.WriteLine("------플레이어 장비------\n");
                Console.WriteLine("  무  기 : " + wap);
                Console.WriteLine("  갑  옷 : " + gab);
                Console.WriteLine("    펫   : " + pet);

                Console.WriteLine("-------------------------\n");

                Console.WriteLine("1. 돌아가기");

                ConsoleKeyInfo check = Console.ReadKey();
                string che = check.KeyChar.ToString();
                switch (che)
                {
                    case "1":
                        rs = false;
                        break;
                    default:
                        goto res;
                    
                }

                

            }
        }

        public void save()
        {
            string savePath = @"d:\save\test.txt";
            //무기 공격력 빼기 방어구도 추가예정
            this.at -= this.wapAt;
            this.br -= this.gabBr;
            string textValue = $"{this.lv}!{this.at}!{this.br}!{this.gold}!{this.exp}!{this.maxExp}!{this.hp}!{this.mp}!{this.dex}!{this.wap}!{this.gab}!{this.pet}!{this.WapAt}!{this.GabBr}";
        
            System.IO.File.WriteAllText(savePath, textValue, Encoding.UTF8);
            Console.Clear();
            Console.WriteLine("저장되었습니다.");
            Thread.Sleep(1500);
            //무기 공격력 다시 증가
            this.at += this.wapAt;
            this.br += this.gabBr;
        }

        public void LevelUp(int lv)
        {
            Random random = new Random();
            this.lv += 1;
            this.at += random.Next(2)+1;
            this.br += random.Next(2)+1;
            this.hp += random.Next(100)+30;
            this.mp += random.Next(3)+1;
            this.dex += random.Next(1);
            int overExp = this.exp - this.maxExp;
            this.maxExp += 30 + (lv * 5);
            this.exp = overExp;
            Console.WriteLine("레벨 업!!");

        }

        public void WapSet(String wapName, int at)
        {
            this.Wap = wapName;
            this.WapAt = at;
            this.at += at;
        }

        public void WapSet()
        {
            this.at += this.wapAt;
        }

        public void GabSet(String name, int br)
        {
            this.Gab = name;  //미완성
            this.gabBr = br;
            this.br += br;
        }

        public void GabSet()
        {
            this.br += this.gabBr;
        }
    }
}
