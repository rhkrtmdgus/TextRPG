

using TextRPG.bettle;
using TextRPG.Town;

namespace TextRPG
{
    public class Program
    {
        

        static void Main(string[] args)
        {
            Player play = new Player();
            login log = new login();
            log.loginRender(play);
            log.loading();
            /*string path = @"d:\save\test.txt";
            string textvalue = System.IO.File.ReadAllText(path);
            string[] textResult = textvalue.Split('!');
            int[] textInt = new int[20];
            for (int i = 0; i < 9; i++)
            {
                textInt[i] = int.Parse(textResult[i]);
            }
            for (int y = 12; y < 14; y++)
            {
                textInt[y] = int.Parse(textResult[y]);
            }*/ //텍스트 파일이용
            
            Home home = new Home();
            IceTown town = new IceTown();
            BtnThread btn = new BtnThread();
            BattleField bf = new BattleField();
            
            while (true)
            {
                home.PlayerStatus(play, town, bf);
                
            }
            
        }

    }
}