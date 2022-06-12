using Microsoft.EntityFrameworkCore.Sqlite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace time_keeper
{
    internal class Task
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

        public void EndTask(string Description, string Category)
        {
            this.Description = Description;
            this.Category = Category;
            End = DateTime.Now;
            Elapsed = End - Start;
            Console.WriteLine(Elapsed.ToString());
        }
    }
}
