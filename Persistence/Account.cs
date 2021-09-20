using System;

namespace Persistence
{
    public class Account
    {
        public int AcccountId {set;get;}
        public string UserName {set;get;}
        public string Password {set;get;}
        public int Role {set;get;}

        public static int CASHIER_ROLE = 1;
    }
}