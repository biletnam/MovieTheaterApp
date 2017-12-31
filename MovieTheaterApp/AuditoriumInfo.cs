using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieTheaterApp
{
    public class AuditoriumInfo
    {

        public MovieInfo Screen1;
        public MovieInfo Screen2;
        public List<MovieInfo> screens = new List<MovieInfo>();

        public AuditoriumInfo()
        {
            Screen1 = new MovieInfo("Coco", "Enlish", "****", 1.30);
            screens.Add(Screen1);
            Screen2 = new MovieInfo("adc", "sdf", "3333", 0);
            screens.Add(Screen2);

        }
      

    }
}
