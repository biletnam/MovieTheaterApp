using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieTheaterApp
{
    class Account
    {
        private static int LastUserId = 0;
       
        public Account()
        {
            UserId = ++LastUserId;
        }
        #region properties
        //creating account for user
        public int UserId { get; private set; }
        public string UserName { get; set; }
        public string EmailAddress { get; set; }
#endregion

    }
}
