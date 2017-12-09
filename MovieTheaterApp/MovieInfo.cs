using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieTheaterApp
{
    class MovieInfo
    {
        #region Properites
        public int ScreenId { get; private set; }
        public string MovieName { get; private set; }
        public float showTimings { get;private set; }
        public int Tickets { get; set; }
        #endregion

        public decimal BuyingTickets(int tickets)
        {
            decimal amount = 11.25M;
            amount = amount * tickets;
            return amount;
        }
    }
}
