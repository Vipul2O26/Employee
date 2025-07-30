﻿using Employee.Models;
using Microsoft.EntityFrameworkCore;


namespace Employee.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<TodoTask> TodoTasks { get; set; }
    }
}
