using Microsoft.EntityFrameworkCore.Sqlite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace time_keeper
{
    public class Task
    {
        public string? Category { get; set; }
        public string? Description { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public TimeSpan Elapsed { get; set; }

        public Task()
        {
            Start = DateTime.Now;
            End = new DateTime();
        }
        public void setDetails(string Category, string Description)
        {
            this.Category = Category;
            this.Description = Description;
        }
        public void EndTask()
        {
            End = DateTime.Now;
            Elapsed = End - Start;
        }
        public TimeSpan getElapsed()
        {
            return Elapsed;
        }
        public string getTime()
        {
           return Utility.DisplayFormat(Elapsed);
        }

    }

    
}
