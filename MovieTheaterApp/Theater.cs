using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieTheaterApp
{ 
    enum ScrrenIds
    {
        Screen1 =1, Screeen2, Screen3, Screen5
    }
    class Theater
    {
        #region Properties

        public ScrrenIds ScreenId { get; private set; }

        #endregion
    }
}
