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
        private string id = "";
        private string pw = "";
        private int lv = 1;
        private int at = 5;
        private int br = 8;
        private int hp = 200;
        private int maxHp = 200;
        private int mp = 10;
        private int maxMp = 30;
        private int exp = 0;
        private int maxExp = 10;
        private int dex = 1;
        private int gold = 1000;

        private string wap = "없 음";
        private string gab = "없 음";
        private string pet = "없 음";
        private string job = "무 직";

        private int wapAt = 0;
        private int gabBr = 0;


        public string Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Pw
        {
            get { return pw; }
            set { pw = value; }

        }
        public string Job
        {
            get { return job; }
            set { job = value; }
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

        public int MaxHp
        {
            get { return maxHp; }
            set { maxHp = value; }
        }

        public int MaxMp
        {
            get { return maxMp; }
            set { maxMp = value; }
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

        /*public void save()
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
        }*/

        public void saveInsert()
        {
            
                
                back:
                Console.Clear();
                Console.WriteLine("\n아이디와 패스워드 정보가 없습니다.");

                Console.Write("저장할 아이디 입력 : ");
                this.Id = Console.ReadLine();
                if(id.Length < 6 || id.Length > 10)
                {
                    Console.WriteLine("\n아이디는 6 ~ 10 자이내로 가능합니다. ");
                    Thread.Sleep(2000);
                    goto back;
                }
                Console.Write("비밀번호 : ");
                this.Pw = Console.ReadLine();
      
            
            login login = new login();
            login.loading();
            login.sabinsert(this);
            
        }

        public void saveUpdate()
        {
            login login = new login();
            login.loading();
            login.sabUpdate(this);
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
            Console.WriteLine("★☆★☆★☆★☆\n" +
                "레벨 업!!\n" +
                "★☆★☆★☆★☆");
            Thread.Sleep(2000);
        }

        public void WapSet(String wapName, int at)
        {
            this.Wap = wapName;
            this.WapAt = at;
        }

        public void WapSet()
        {
            this.at += this.wapAt;
        }

        public void GabSet(String name, int br)
        {
            this.Gab = name;  //미완성
            this.gabBr = br;
        }

        public void GabSet()
        {
            this.br += this.gabBr;
        }
    }
}
