using System;
using Persistence;

namespace ConsolePL
{
    public class Ui
    {
        Account account = new Account();
        Login login = new Login();
        string choice;
        public void delete()
        {
            Console.Clear();
        }
        bool resume = true;

        public bool MainMenu(Account account)
        {
            Console.WriteLine("Hello" + " " + account.UserName);
            Console.WriteLine("======================================");
            Console.WriteLine("--- PHONE STORE ---");
            Console.WriteLine("======================================");
            Console.WriteLine("1. Phone Manager");
            Console.WriteLine("2. Invoice");
            Console.WriteLine("3. Exit");
            Console.WriteLine("======================================");
            Console.WriteLine("#YOUR CHOICE: ");
            choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    delete();
                    MenuPhoneManager();
                    break;
                case "2":
                    delete();
                    InvoiceManager();
                    break;
                case "3":
                    return false;
                default:
                    delete();
                    break;
            }
            return true;
        }
        public void MenuPhoneManager()
        {
            Console.WriteLine("======================================");
            Console.WriteLine("--- PHONE MANAGER ---");
            Console.WriteLine("======================================");
            Console.WriteLine("1. Search Phone");
            Console.WriteLine("2. Add Phone");
            Console.WriteLine("3. Back To Main Menu");
            Console.WriteLine("======================================");
            Console.WriteLine("#YOUR CHOICE: ");
            choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    delete();
                    SerachPhone();
                    break;
                case "2":
                    delete();
                    AddPhone();
                    break;
                case "3":
                    delete();
                    break;
                default:
                    delete();
                    break;
            }
        }
        public void InvoiceManager()
        {
            Console.WriteLine("======================================");
            Console.WriteLine("--- INVOICE MANAGER ---");
            Console.WriteLine("======================================");
            Console.WriteLine("1. Create Invoice");
            Console.WriteLine("2. Export Invoice");
            Console.WriteLine("3. Back To Main Menu");
            Console.WriteLine("======================================");
            Console.WriteLine("#YOUR CHOICE: ");
            choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    delete();
                    CreateInvoice();
                    break;
                case "2":

                    delete();
                    ExportInvoice();
                    break;
                case "3":
                    delete();
                    break;
                default:
                    delete();
                    break;
            }
        }
        public void SerachPhone()
        {
            Console.WriteLine("======================================");
            Console.WriteLine("--- SEARCH PHONE ---");
            Console.WriteLine("======================================");
            Console.WriteLine("1. Search By ID");
            Console.WriteLine("2. Search By Name");
            Console.WriteLine("3. Back To Main Menu");
            Console.WriteLine("======================================");
            Console.WriteLine("#YOUR CHOICE: ");
            choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    delete();
                    SearchByID();
                    break;
                case "2":
                    delete();
                    SearchByName();
                    break;
                case "3":
                    delete();
                    break;
                default:
                    delete();
                    break;
            }
        }
        public void AddPhone()
        {
            Console.Write("Add Phone");
            Console.ReadLine();
        }
        public void CreateInvoice()
        {
            Console.Write("Create invoice");
            Console.ReadLine();
        }
        public void ExportInvoice()
        {
            Console.Write("Export invoice");
            Console.Read();
        }
        public void SearchByID()
        {
            Console.Write("Search Phone By ID");
            Console.Read();
        }
        public void SearchByName()
        {
            Console.Write("Search Phone By Name");
            Console.Read();
        }
    }
}