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

            void Reset()
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.BackgroundColor = ConsoleColor.Black;
            }
            void Aktiv()
            {
                Console.ForegroundColor = ConsoleColor.Black;
                Console.BackgroundColor = ConsoleColor.Gray;
            }

            byte aktualis = 1;
            bool loginaktiv = true;
            bool regaktiv = false;
            bool settactive = false;
            bool exitactive = false;
            

            while (menu)
            {
                switch (aktualis)
                {
                    case 1:
                        loginaktiv = true;
                        regaktiv = false;
                        settactive = false;
                        exitactive = false;
                        break;
                    case 2:
                        loginaktiv = false;
                        regaktiv   = true;
                        settactive = false;
                        exitactive = false;
                        break;
                    case 3:
                        loginaktiv = false;
                        regaktiv = false;
                        settactive = true;
                        exitactive = false;
                        break;
                    case 4:
                        loginaktiv = false;
                        regaktiv = false;
                        settactive = false;
                        exitactive = true;
                        break;
                    default:
                        break;
                }

                if (loginaktiv) {Aktiv();}
                else { Reset(); }
                Console.WriteLine("Bejelentkezés");

                if (loginaktiv) { Aktiv(); }
                else { Reset(); }
                Console.WriteLine("Regisztráció");

                if (loginaktiv) { Aktiv(); }
                else { Reset(); }
                Console.WriteLine("Beállítások");

                if (loginaktiv) { Aktiv(); }
                else { Reset(); }
                Console.WriteLine("Bezárás");

                ConsoleKey gomb = Console.ReadKey().Key;

                if (gomb == ConsoleKey.UpArrow)
                {
                    if (aktualis > 1)
                    {
                        aktualis--;
                    }
                }
                else if (gomb == ConsoleKey.DownArrow)
                {
                    if (aktualis<4)
                    {
                        aktualis++;
                    }
                }
                else if (gomb == ConsoleKey.Enter)
                {

                }
            }

        }
    }
}
