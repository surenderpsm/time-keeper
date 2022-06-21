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

    public class DisplayTask
    {
        public string ?Category { get; set; }
        public string ?Description { get; set; }
        public string Date { get; set; }
        public string Start { get; set; }
        public string End { get; set; }
        public string Elapsed{ get; set; }

        public DisplayTask(Task task)
        {
            Category = task.Category;
            Description = task.Description;
            Date = task.Start.ToShortDateString();
            Start = task.Start.ToShortTimeString();
            End = task.End.ToShortTimeString();
            Elapsed = Utility.DisplayFormat(task.Elapsed);
        }
        
    }

}
