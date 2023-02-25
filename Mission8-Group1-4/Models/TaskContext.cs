using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission8_Group1_4.Models
{
    public class TaskContext : DbContext
    {
        public TaskContext(DbContextOptions<TaskContext> options) : base(options)
        {
            // blank for now
        }

        public DbSet<TaskList> tasks { get; set; }
        public DbSet<Category> categories { get; set; }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<TaskList>().HasData(
                new TaskList
                {
                    TaskId = 1,
                    Title = "Complete Mission 8",
                    DueDate = new DateTime(2023, 2, 24, 23, 59, 0), // March 15th, 2023 at 11:59 PM
                    Quadrant = 3,
                    CategoryId = 1,
                    Completed = false
                }
            );

            mb.Entity<Category>().HasData(
                new Category
                {
                    CategoryId = 1,
                    Title = "Home",
                },
                new Category
                {
                    CategoryId = 2,
                    Title = "School",
                },
                new Category
                {
                    CategoryId = 3,
                    Title = "Work",
                },
                new Category
                {
                    CategoryId = 4,
                    Title = "Church",
                }
            );
        }
    }
}
