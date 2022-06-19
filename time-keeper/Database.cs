using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Sqlite;
using Microsoft.EntityFrameworkCore;
using System.IO;

namespace time_keeper
{
    internal class Database : DbContext
    {
        public DbSet<Task>? Tasks { get; set; }
        public string DbPath;

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            var folder = Environment.SpecialFolder.LocalApplicationData;
            var path = Environment.GetFolderPath(folder);
            DbPath = System.IO.Path.Join(path, "localDB.db");
            options.UseSqlite($"Data Source={DbPath}");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Task>()
                .HasKey(obj => obj.Start);
        }

        public static void addtoDB(Task task)
        {
            using (var db = new Database())
            {
                db.Add(task);
                db.SaveChanges();
            }
        }

        public static List<Task> getAllTasks()
        {
            using(var db = new Database())
            {
                return db.Tasks.ToList();
            }
        }
    }

}
