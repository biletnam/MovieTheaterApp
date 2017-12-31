using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieTheaterApp
{
    public enum Showtimings
    {
        MorningShow_10am,
        AfterNoonshow_1pm,
        EveningShow_4pm,
        NightShow_7pm,
        Midnightshow_9pm
    }
    public class MovieInfo
    {
        
        #region Properites
        public string MovieName { get; set; }
        public string MovieLanguage { get;private set; }
        public string Rating { get; private set; }
        public double RunningLength{ get; set; }
        #endregion
        public MovieInfo()
        {

        }
        public MovieInfo(string name,string language,string rating,double runninglength)
        {
            MovieName = name;
            MovieLanguage = language;
            Rating = rating;
            RunningLength = runninglength;
        }

        public decimal BuyingTickets(int tickets)
        {
            decimal amount = 11.25M;
            amount = amount * tickets;
            return amount;
        }
    }
}
