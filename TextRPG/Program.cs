

using TextRPG.bettle;
using TextRPG.Town;

namespace TextRPG
{
    public class Program
    {
        

        static void Main(string[] args)
        {
            string path = @"d:\save\test.txt";
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
            }
            Player play = new Player(textInt[0], textInt[1], textInt[2], textInt[3],
                textInt[4], textInt[5], textInt[6], textInt[7], textInt[8], textResult[9], textResult[10], textResult[11],
                textInt[12], textInt[13]);
            play.WapSet();
            play.GabSet();
            Start st = new Start();
            Home home = new Home();
            IceTown town = new IceTown();
            BtnThread btn = new BtnThread();
            BattleField bf = new BattleField();
            
            st.TitleRender();
            while (true)
            {
                home.PlayerStatus(play, town, bf);
                
            }
            
        }

    }
}