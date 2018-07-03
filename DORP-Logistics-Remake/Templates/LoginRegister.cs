using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace DORP_Logistics_Remake.Templates
{
    class LoginRegister
    {
        public static void LoginScreen()
        {
            string username;
            string password;

            Console.Clear();
            Console.WriteLine("Please enter your Username:");
            username = Console.ReadLine();

            Console.Clear();
            Console.WriteLine("Please enter your Password:");
            GetPassword();
            password = Console.ReadLine();

        }
        public static void RegisterScreen()
        {

        }

        private static SecureString GetPassword()
        {
            var pwd = new SecureString();
            while (true)
            {
                ConsoleKeyInfo i = Console.ReadKey(true);
                if (i.Key == ConsoleKey.Enter)
                {
                    break;
                }
                else if (i.Key == ConsoleKey.Backspace)
                {
                    if (pwd.Length > 0)
                    {
                        pwd.RemoveAt(pwd.Length - 1);
                        Console.Write("\b \b");
                    }
                }
                else
                {
                    pwd.AppendChar(i.KeyChar);
                    Console.Write("*");
                }
            }
            return pwd;
        }
    }
}
