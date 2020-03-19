using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BadgerToSnake
{
    class Program
    {
        static void Main(string[] args)
        {
            string word1 = "badger", word2 = "mushroom",ready;

            Console.Title = "Badger Badger Reimagined - by HLH";

            DisplayTitleImage();
            do
            {
                Console.WriteLine($"\n\n{"",50}PRESS ENTER WHEN YOU ARE READY");
                ready = Console.ReadLine().Trim();
            } while (ready.Length < 0);
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();
            for (int i = 1; i < 4; i++)
            {
                DisplayBadgerStanza(word1);
                DisplayMushroomStanza(word2);
                Console.WriteLine();
            }

            DisplayBadgerStanza(word1);
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("\n\n");
                // for (int two = 0; two < 50; two++)
                for (int two = 0; two < 25; two++)
                {
                    switch (two % 2)
                    {
                        case 0:
                            {
                                Console.ForegroundColor = ConsoleColor.Black;
                                Console.BackgroundColor = ConsoleColor.Cyan;
                            }
                            break;
                        default:
                            {
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.BackgroundColor = ConsoleColor.Black;
                            }
                            break;
                    }
                    Console.Clear();

                    DisplaySnake();
                    Thread.Sleep(100);
                }
            }

            Console.ResetColor();
            Console.WriteLine("Press enter to quit");
            Console.ReadLine();

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="firstWord"></param>
        static void DisplayBadgerStanza(string firstWord)
        {
            for (int line = 1; line <= 4; line++)
            {
                for (int word = 1; word <= 3; word++)
                {
                    Console.Write($"{firstWord}");
                    Thread.Sleep(300);
                    if (word != 3)
                    {
                        Console.Write(", ");
                    }
                }
                Console.WriteLine();
            }
        }//End of DisplayBadgerStanza(string)

        /// <summary>
        /// 
        /// </summary>
        /// <param name="secondWord"></param>
        static void DisplayMushroomStanza(string secondWord)
        {
            for (int i = 1; i <= 2; i++)
            {
                Console.Write($"{secondWord}");
                Thread.Sleep(500);
                if (i != 2)
                {
                    Console.Write(", ");
                }
            }
            Console.WriteLine();
        }//End of DisplayMushroomStanza(string)

        /// <summary>
        /// 
        /// </summary>
        static void DisplaySnake()
        {
            Console.WriteLine("SNAKE!!!!!!\tSNAKE!!!!!!\nAAAAAAAAAAHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHH\nIts a   SSSNNNAAAAKKKEEE!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!");
            Console.WriteLine("\n\n ------------------------------------------------------------------");
            Console.WriteLine("|.........................................____.....................|");
            Console.WriteLine(@"|................________________________/ O  \___/................|");
            Console.WriteLine(@"|...............<_/_\_/_\_/_\_/_\_/_\_/_______/...\................|");
            Console.WriteLine(" ------------------------------------------------------------------");
        }//End of DisplaySnake()

        /// <summary>
        /// 
        /// </summary>
        static void DisplayTitleImage()
        {
            Console.WriteLine(@"                                                                                
                                       .     (@&%.                         |     
                **             *@@@&&&.   /&&&&&&&%                        |     
               (  .%&&&&@&,      &&&&(    &&&&&&( &                        |     
                *@&%&&&&&&&&&&@@@#&&&     @&&&#   &                        |     
                   ,@&&&&&&&&&&@& &&&.    &&&&.  ,,      .,/%@&%#@*        |     
                      ,@&&&&&&&&&@#&&%   .&&&#  @@@&&&&&&&&&&&,  .@.       |    ___          __  
                          *&&&&&&&&%&,   .&&( #&&&&&&&&&&&&&&&&(@          |   / _ )___ ____/ /__ ____ ____  
                            .@&&&&&&,%(((#  &&&&&&&&&&&&&&&@@@,            |  / _  / _ `/ _  / _ `/ -_) __/      
                             %&&&%  ,&(##@(  .&&&&&&&&@@@(.                | /____/\_,_/\_,_/\_, /\__/_/    
                             #&&&             *&&&&&@.                     |       ___      /___/_    
                             &&&&,            /&&&&@&                      |      / _ )___ ____/ /__ ____ ____    
                             @&&&             *&&&&@/                      |     / _  / _ `/ _  / _ `/ -_) __/    
                             @&&(             #&&&&@/                      |    /____/\_,_/\_,_/\_, /\__/_/       
                             @&&&(           ,&&&&&&@                      |                   /___/            
                             @&&&&&&&#.(*/&#&&&&&&&&&                      |     
                             @&&&@&&&&&&&&&&&&&&&&&&&                      |     
                             @&&&&&&&&&&@&&&&&&&&&&&@                      |     
                            #@&&&&&&&&@(.@@&&&&&&&&&&                      |     
                           &@&&&&&&&&@@    @&&&&&&&&&@                     |     
                          *&&&&&&&&&&@%%%%%%@&&&&&&&&&&                    |     
                      #%%%%%&@&&&&&&&%%%%%%%%@&&&&&&@%%%%%%                |     
                       .(%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%#,                 |     
                                       ...                              ");



        }//End of DisplayTitleImage()
    }
}
