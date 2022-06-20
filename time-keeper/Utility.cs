using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace time_keeper
{
    public class Utility
    {
        public static string DisplayFormat(TimeSpan Elapsed)
        {
            string hrs = (Elapsed.Hours < 10) ? "0" + Elapsed.Hours.ToString() : Elapsed.Hours.ToString();
            string mins = (Elapsed.Minutes < 10) ? "0" + Elapsed.Minutes.ToString() : Elapsed.Minutes.ToString();
            string seconds = (Elapsed.Seconds < 10) ? "0" + Elapsed.Seconds.ToString() : Elapsed.Seconds.ToString();
            return hrs + ":" + mins + ":" + seconds;
        }
    }
}
