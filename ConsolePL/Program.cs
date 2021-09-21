using System;
using Persistence;
using BL;

namespace ConsolePL
{
    class Program
    {
        static void Main(string[] args)
        {
            Ui ui = new Ui();
            Login login = new Login();
            
            bool resume = true;
            var account = login.LoginMenu();
            if (account != null)
            {
                do
                {
                    resume = ui.MainMenu(account);
                } while (resume);
            }
        }
    }
}
