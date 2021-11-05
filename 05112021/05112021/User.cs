using System;
using System.Collections.Generic;
using System.Text;

namespace _05112021
{
    class User
    {
        static User()
        {
            StaticTotalCount = 100;
        }
        public User()
        {
            StaticTotalCount += 1;
            TotalCount += 1;
            Order = StaticTotalCount;
        }
        public int Order { get; }
        public static int StaticTotalCount;
        public int TotalCount;
        public string UserName;
        private string _password;

        public string Password
        {
            set
            {
                if (CheckPass(value)) _password = value;
            }
        }

        public static bool CheckPass(string pass)
        {
            if (!string.IsNullOrWhiteSpace(pass) && pass.Length > 7 && pass.Length < 26) return true;
            return false;
        }

    }
}
