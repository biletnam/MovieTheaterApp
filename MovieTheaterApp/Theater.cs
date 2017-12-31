using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieTheaterApp
{ 
    public static class Theater
    {
        private static List<Account> accounts = new List<Account>();
      //  private static List<Showtimings> showtimings = new List<Showtimings>();
      public static Account createAccount(string username,string emailaddress)
        {
            var account = new Account
            {
                UserName = username,
                EmailAddress = emailaddress
                
            };
            accounts.Add(account);
            return account;
        }
        private static List<AuditoriumInfo> movies = new List<AuditoriumInfo>();
        public static AuditoriumInfo GetMovieInfo()
        {
            var MI = new AuditoriumInfo();
            movies.Add(MI);
            return MI;
           
        }

        public static decimal BuyTickets(int tickets)
        {
            var movie = new MovieInfo();
            decimal result=movie.BuyingTickets(tickets);
            return result;
        }
       
    }

}
