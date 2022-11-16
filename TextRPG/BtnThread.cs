using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextRPG.bettle;

namespace TextRPG
{
    public class BtnThread
    {

        public static void Run()
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

                    }
                    catch
                    {

                    }
                    

                    break;
                default:
                    goto res;
            }
        }

        
    }
}
