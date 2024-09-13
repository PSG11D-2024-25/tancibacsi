using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projektmunka
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("\t\tKészítette: Mizere Robin Roland v0.1");
            Console.ForegroundColor = ConsoleColor.White;


            bool menu = true; // Menü aktív?

            while (menu)
            {
                Console.Write("\n\n" +
                    " 1 - Bejelentkezés" + "\n" +
                    " 2 - Regisztráció" + "\n" +
                    " 3 - Beállítások" + "\n" +
                    " 4 - Kilépés" +"\n\n" +
                    
                    
                        " Választás: ");

                string menuinput = Console.ReadLine();

                if (menuinput=="1")
                {
                    menu = false;
                    Console.WriteLine("bejelentkezés lesz majd...");
                    Console.Read();
                }
                else if (menuinput== "2")
                {
                    menu = false;
                    Console.WriteLine("reg lesz majd...");
                    Console.Read();
                }
                else if (menuinput == "3")
                {
                    menu = false;
                    Console.WriteLine("opcio lesz majd...");
                    Console.Read();
                }
                else if (menuinput == "4")
                {
                    menu = false;
                    break;
                    //ez csak kilép
                }
                else
                {
                    Console.WriteLine("nincs ilyen opció");
                }
            }

        }
    }
}
