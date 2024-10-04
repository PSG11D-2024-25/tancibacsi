using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projektmunka
{
    internal class User
    {
        public static int lastID;
        private static List<User> users;
        private string name;
        private string password;
        private int id;

        public string Name
        {
            get { return name; }
            set
            {
                if (value is null)
                {
                    throw new Exception("Username cannot be null!");
                }
                name = value;
            }
        }
        public string PassWord
        {
            
            get { return password; }
            protected set
            {
                string characters = "0123456789öüóqwertzuiopőúasdfghjkléáűíyxcvbnmÖÜÓQWERTZUIOPŐÚASDFGHJKLÉÁŰÍYXCVBNM";
                if (value is null)
                {
                    throw new Exception("Password cannot be null!");
                }
                foreach (char word in value)
                {
                    if (!characters.Contains(word))
                    {
                        throw new Exception("Password characters bust be letters of the ABC or numbers");
                    }
                }
                password = value;
            }
        }

        public int Id {
            get { return id; }
        }

        public static List<User> Users { get { return users; } }


        public User(string name, string pass)
        {
            this.Name = name;
            this.PassWord = pass;
            this.id = lastID++;
        }
        public User(string name, string pass, int id)
        {
            this.Name = name;
            this.PassWord = pass;
            this.id = id;
        }
        public static void AddNewUser(string uname, string upass)
        {
            User user = new User(uname, upass);
            users.Add(user);
        }
        public static void AddExistingUser(string uname, string upass, int id)
        {
            User user = new User(uname, upass, id);
            users.Add(user);
        }
    }
    internal class Program
    {
        void Beolvas()
        {
            StreamReader sr = null;
            try
            {
                sr = new StreamReader("info.txt");
                User.lastID = int.Parse(sr.ReadLine());

                while (!sr.EndOfStream)
                {
                    string[] line = sr.ReadLine().Split(';');
                    User.AddExistingUser(line[0], line[1], int.Parse(line[2]));
                }
            }
            catch { Console.Error.WriteLine("Error during read file"); }
            finally { if (sr!= null ) sr.Close(); }
        }



        static void Main(string[] args)
        {
            #region Fejléc
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("\t\tKészítette: Mizere Robin Roland v0.1");
            Console.ForegroundColor = ConsoleColor.White;
            #endregion

            #region Menü 
            bool menu = true; // Menü aktív?
            void Menu() { 
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
                            regaktiv = true;
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

                    if (loginaktiv) { Aktiv(); }
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
                        if (aktualis < 4)
                        {
                            aktualis++;
                        }
                    }
                    else if (gomb == ConsoleKey.Enter)
                    {

                    }
                    
                }
            }
            #endregion

            Menu();

            void Login()
            {
                string ReadPassword()
                {
                    string rpassword = "";
                    ConsoleKeyInfo keyInfo;

                    do
                    {
                        keyInfo = Console.ReadKey(true); // true: ne jelenítse meg a konzolon a beírt karaktereket

                        if (keyInfo.Key != ConsoleKey.Enter)
                        {
                            rpassword += keyInfo.KeyChar; // Tároljuk a beírt karaktereket
                        }
                    } while (keyInfo.Key != ConsoleKey.Enter); // Amíg az Enter nincs lenyomva

                    return rpassword;
                }

                Console.WriteLine("Kérlek add meg a Felhasználóneved!");
                string fnev = Console.ReadLine();

                Console.WriteLine("Kérlek add meg a Jelszavadat!");
                    
                string password = ReadPassword();
            }

        }
    }
}
