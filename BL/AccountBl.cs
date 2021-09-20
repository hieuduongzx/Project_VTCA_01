using System;
using Persistence;
using DAL;

namespace BL
{
    public class AccountBl
    {
        private AccountDal dal = new AccountDal();

        public int Login(Account account){
            return dal.Login(account);
        }
    }
}
