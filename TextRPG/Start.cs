using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRPG
{
    public class Start
    {

        

        public void TitleRender()
        {

            da:
            Console.Clear();
            Console.WriteLine("--------------------------");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("          TextRPG");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("--------------------------");
            Console.WriteLine("");
            Console.WriteLine("     시작하려면 'a'");
            Console.WriteLine("");

            /*Thread titlethread = new Thread(() => this.Run());
            titlethread.Start();
            titlethread.Interrupt();*/

            
                
                ConsoleKeyInfo result = Console.ReadKey();
                switch (result.KeyChar.ToString())
                {
                    case "a":
                    case "A":
                            
                        break;
                    default:
                        goto da;
                }
                
            



        }

    }
}
