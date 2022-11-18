using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRPG
{
    public class login
    {
        public void connect()
        {
            string port = "1433";

            string dbcon = "Server=127.0.0.1; Uid=kwak;Pwd =1234; database=ShopDB;";
            try
            {
                SqlConnection conn = new SqlConnection(dbcon);
                conn.Open();
                Console.WriteLine("\n접속성공!\n");
                conn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("오류입니다.");
            }
        }

        public void select()
        {
            string dbcon = "Server=127.0.0.1; Uid=kwak;Pwd =1234; database=ShopDB;";
            using (SqlConnection conn = new SqlConnection(dbcon))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "select * from test";
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    int s = Convert.ToInt32(rdr["memberid"]);
                    string name = rdr["membername"].ToString();

                    Console.WriteLine(s + name);
                }
            }
        }
        public bool select(string id, string pw, Player play)
        {
            bool w;
            string dbcon = "Server=127.0.0.1; Uid=kwak;Pwd =1234; database=ShopDB;";
            using (SqlConnection conn = new SqlConnection(dbcon))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = $"select * from player where id = '{id}' and pw = '{pw}'";
                SqlDataReader rdr = cmd.ExecuteReader();
                w = rdr.Read();
                if (w)
                {
                    play.Id = rdr["id"].ToString();
                    play.Pw = rdr["pw"].ToString();
                    play.Lv = Convert.ToInt32(rdr["lv"]);
                    play.At = Convert.ToInt32(rdr["mem_str"]);
                    play.Br = Convert.ToInt32(rdr["mem_def"]);
                    play.Hp = Convert.ToInt32(rdr["hp"]);
                    play.MaxHp = Convert.ToInt32(rdr["maxhp"]);
                    play.Mp = Convert.ToInt32(rdr["mp"]);
                    play.MaxMp = Convert.ToInt32(rdr["maxmp"]);
                    play.Dex = Convert.ToInt32(rdr["dex"]);
                    play.Exp = Convert.ToInt32(rdr["mem_exp"]);
                    play.MaxExp = Convert.ToInt32(rdr["max_mem_exp"]);
                    play.Gold = Convert.ToInt32(rdr["gold"]);
                    play.WapAt = Convert.ToInt32(rdr["wapStr"]);
                    play.GabBr = Convert.ToInt32(rdr["gabDef"]);
                    play.Wap = rdr["wap"].ToString();
                    play.Gab = rdr["gab"].ToString();
                    play.Pet = rdr["pet"].ToString();
                    play.Job = rdr["memberjob"].ToString();
                
                }
               
            }
            return w;
        }
        public void sabinsert(Player play)
        {
            string dbcon = "Server=127.0.0.1; Uid=kwak;Pwd =1234; database=ShopDB;";
            try
            {
                SqlConnection conn = new SqlConnection(dbcon);
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "insert into player values(@id, @pw, @lv, @mem_str, " +
                    "@mem_def, @hp, @maxhp, @mp, @maxmp, @dex, @mem_exp, @max_mem_exp, " +
                    "@gold, @wap, @gab, @pet, @wapStr, @gabDef, @memberjob )";
                cmd.Parameters.AddWithValue("@id", play.Id);
                cmd.Parameters.AddWithValue("@pw", play.Pw);
                cmd.Parameters.AddWithValue("@lv", play.Lv);
                cmd.Parameters.AddWithValue("@mem_str", play.At);
                cmd.Parameters.AddWithValue("@mem_def", play.Br);
                cmd.Parameters.AddWithValue("@hp", play.Hp);
                cmd.Parameters.AddWithValue("@maxhp", play.MaxHp);
                cmd.Parameters.AddWithValue("@mp", play.Mp);
                cmd.Parameters.AddWithValue("@maxmp", play.MaxMp);
                cmd.Parameters.AddWithValue("@dex", play.Dex);
                cmd.Parameters.AddWithValue("@mem_exp", play.Exp);
                cmd.Parameters.AddWithValue("@max_mem_exp", play.MaxExp);
                cmd.Parameters.AddWithValue("@gold", play.Gold);
                cmd.Parameters.AddWithValue("@wap", play.Wap);
                cmd.Parameters.AddWithValue("@gab", play.Gab);
                cmd.Parameters.AddWithValue("@pet", play.Pet);
                cmd.Parameters.AddWithValue("@wapStr", play.WapAt);
                cmd.Parameters.AddWithValue("@gabDef", play.GabBr);
                cmd.Parameters.AddWithValue("@memberjob", play.Job);
                conn.Open();
                cmd.ExecuteNonQuery();
                Console.WriteLine("인설트 성공");
                conn.Close();


            }
            catch (Exception)
            {
                Console.Clear();
                Console.WriteLine("인설트 실패");
                Thread.Sleep(2000);
            }

        }

        public void sabUpdate(Player play)
        {
            string dbcon = "Server=127.0.0.1; Uid=kwak;Pwd =1234; database=ShopDB;";
            try
            {
                SqlConnection conn = new SqlConnection(dbcon);
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = $"update player set lv = {play.Lv}, mem_str = {play.At}, " +
                    $"mem_def = {play.Br}, hp = {play.Hp}, maxhp = {play.MaxHp}, mp = {play.Mp}, " +
                    $"maxmp = {play.MaxMp}, dex = {play.Dex}, mem_exp = {play.Exp}, " +
                    $"max_mem_exp = {play.MaxExp}, gold = {play.Gold}, wap = '{play.Wap}', " +
                    $"gab = '{play.Gab}', pet = '{play.Pet}', wapStr = {play.WapAt}, " +
                    $"gabDef = {play.GabBr}, memberjob = '{play.Job}' where id = '{play.Id}'";
                conn.Open();
                cmd.ExecuteNonQuery();
                Console.WriteLine("저장 성공");
                Thread.Sleep(2000);
                conn.Close();


            }
            catch (Exception)
            {
                Console.Clear();
                Console.WriteLine("저장 실패");
                Thread.Sleep(2000);
            }

        }

        public void loginRender(Player play) 
        {
            back:
            Console.WriteLine("\n\n Text RPG\n\n\n1.새로 하기\n2.이어하기");
            ConsoleKeyInfo info = Console.ReadKey();
            string ss = info.KeyChar.ToString();
            switch (ss)
            {
                case "1":
                    
                    break;
                case "2":
                
                    Console.Clear();
                    Console.WriteLine("\n\n Text RPG\n\n\n로그인을 해 주세요.\n");

                    Console.Write("아이디 :");
                    string id = Console.ReadLine();
                    if (id == "" || id == null)
                    {
                        Console.Clear();
                        goto back;
                    }
                    Console.Write("비밀번호 : ");
                    string pw = Console.ReadLine();
                    bool che = select(id, pw, play);

                    if (!che)
                    {
                        Console.WriteLine("플레이어 정보가 없습니다.");
                        Thread.Sleep(2000);
                        Console.Clear();
                        goto back;
                    }
                    break;
            }

            
        }

        public void loading()
        {
            Console.Clear();
            Console.WriteLine("\n로딩 중 ○○○");
            Thread.Sleep(500);
            Console.Clear();
            Console.WriteLine("\n로딩 중 ◐○○");
            Thread.Sleep(500);
            Console.Clear();
            Console.WriteLine("\n로딩 중 ●○○");
            Thread.Sleep(500);
            Console.Clear();
            Console.WriteLine("\n로딩 중 ●◐○");
            Thread.Sleep(500);
            Console.Clear();
            Console.WriteLine("\n로딩 중 ●●○");
            Thread.Sleep(500);
            Console.Clear();
            Console.WriteLine("\n로딩 중 ●●◐");
            Thread.Sleep(500);
            Console.Clear();
            Console.WriteLine("\n로딩 중 ●●●");
            Thread.Sleep(2000);
            Console.Clear();
        }
    }
}
