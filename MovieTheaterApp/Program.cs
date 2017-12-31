using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieTheaterApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Movie Theter");
            Console.WriteLine("************************");
            while(true)
            {
                Console.WriteLine("0.Exit");
                Console.WriteLine("1: Create Account");
                Console.WriteLine("2. Show Movies playing");
                Console.WriteLine("3.Buy tickets");
                Console.WriteLine("4.Print account information ");//or ticket confirmation
                Console.WriteLine("Please choose an option");
                var choice = Console.ReadLine();

                switch (choice)
                {
                    case "0":
                        Console.WriteLine("Thank you for visiting");
                        return;
                    case "1":
                        Console.Write("Enter user name:");
                        var name = Console.ReadLine();
                        Console.Write("Enter emaila address:");
                        var emailadd = Console.ReadLine();
                        var account = Theater.createAccount(name, emailadd);
                        Console.WriteLine($"UserID:{account.UserId},User Name:{account.UserName},EmailAddress:{account.EmailAddress}");
                        break;
                    case "2":
                        Console.WriteLine("Movies now playing");
                        var movie = Theater.GetMovieInfo();
                        Console.WriteLine($"Movie Name:{movie.Screen1.MovieName},Language:{movie.Screen1.MovieLanguage},Rating:{movie.Screen1.Rating},Running Time{movie.Screen1.RunningLength}");
                        Console.WriteLine($"Movie Name:{movie.Screen2.MovieName},Language:{movie.Screen2.MovieLanguage},Rating:{movie.Screen2.Rating},Running Time{movie.Screen2.RunningLength}");
                                                    
                        break;
                        
                    case "3":
                        Console.WriteLine("Select Movie");
                        
                        var screen = Theater.GetMovieInfo();
                        var scr = screen.screens;
                        int j = 0;
                        foreach (var s in scr)
                        { 
                            Console.WriteLine($"{j+1}.{s.MovieName}");
                            j++;
                        }
                        
                        var choice2 = Console.ReadLine();
                        var showTimings = Enum.GetNames(typeof(Showtimings));
                        for(var i =0; i<showTimings.Length;i++)
                        {
                            Console.WriteLine($"{i + 1}.{showTimings[i]}");
                        }
                        var screenTime = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Tickets to purchase:");
                        int numberoftickets = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Total amount for purchasing tickets:{0}", Theater.BuyTickets(numberoftickets));
                        if (choice2 == "1")
                        {
                            Console.WriteLine($"Movie Timings:{(Showtimings)screenTime - 1},Movie Name:{screen.Screen1.MovieName } ");
                        }
                        else
                        {
                            Console.WriteLine($"Movie Timings:{(Showtimings)screenTime - 1},Movie Name:{screen.Screen2.MovieName } ");

                        }
                        break;
                    case "4":

                    default:
                        Console.WriteLine("Invalid Choice");
                        break;
                }
               
            }
        }
    }
}
