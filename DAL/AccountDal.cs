using System;
using Persistence;
using MySql.Data.MySqlClient;

namespace DAL
{
    public class AccountDal
    {
        public int Login(Account account){
            int login = 0;
            try{
                MySqlConnection connection = DbHelper.GetConnection();
                connection.Open();
                MySqlCommand command = connection.CreateCommand();
                command.CommandText = "select * from Accounts where user_name='"+
                    account.UserName +"' and user_password='"+
                    Md5Algorithms.CreateMD5(account.Password) +"'";
                MySqlDataReader reader = command.ExecuteReader();
                if(reader.Read()){
                    login = reader.GetInt32("role");
                }
                reader.Close();
                //close
                connection.Close();
            }catch(Exception e){
                Console.WriteLine(e.Message);
                login = -1;
            }
            return login;
        }
    }
}
