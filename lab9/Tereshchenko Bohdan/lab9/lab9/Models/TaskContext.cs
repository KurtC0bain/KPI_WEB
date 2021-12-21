using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace lab9.Models
{
    public class TaskContext : DbContext
    {
        public DbSet<Task> Tasks { get; set; }
    }

    public class TaskDbInitializer : DropCreateDatabaseAlways<TaskContext>
    {
        protected override void Seed(TaskContext db)
        {
            db.Tasks.Add(new Task { Name = "Купив холодильник", Date = "21.12.2021" });
            db.Tasks.Add(new Task { Name = "Полагодив телевізор", Date = "21.12.2021" });
            db.Tasks.Add(new Task { Name = "Повчив уроки", Date = "21.12.2021" });
            db.Tasks.Add(new Task { Name = "Зробив лабу по пмс", Date = "21.12.2021" });
            db.Tasks.Add(new Task { Name = "Повечеряв", Date = "21.12.2021" });

            base.Seed(db);
        }
    }

}