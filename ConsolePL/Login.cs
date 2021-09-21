using System;
using Persistence;
using BL;

namespace ConsolePL
{
    public class Login
    {
        public Account LoginMenu(){
            Console.Write("User Name: ");
            string userName = Console.ReadLine();
            Console.Write("Password: ");
            string pass = GetPassword();
            Console.WriteLine();
            //valid username & password here...

            Account account = new Account(){UserName=userName, Password=pass};
            AccountBl bl = new AccountBl();
            int login = bl.Login(account);

            if(login<=0){
                Console.WriteLine("Can't login to system...");
            }else if(login == Account.CASHIER_ROLE){
                return account;
            }
            return null;
        }
        static string GetPassword(){
            var pass = string.Empty;
            ConsoleKey key;
            do
            {
                var keyInfo = Console.ReadKey(intercept: true);
                key = keyInfo.Key;

                if (key == ConsoleKey.Backspace && pass.Length > 0)
                {
                    Console.Write("\b \b");
                    pass = pass[0..^1];
                }
                else if (!char.IsControl(keyInfo.KeyChar))
                {
                    Console.Write("*");
                    pass += keyInfo.KeyChar;
                }
            } while (key != ConsoleKey.Enter);
            return pass;
        }

    }
}
