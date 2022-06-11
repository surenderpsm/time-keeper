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
        private string? category { get; set; }
        private string? description { get; set; }
        private DateTime start;
        private DateTime end;        
        
        public Task()
        {
            start = DateTime.Now;
        }
        
        
    }
}
