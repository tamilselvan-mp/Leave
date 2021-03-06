﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Leave.Models
{
    public class AdminModelContext: DbContext
    {
        public DbSet<AdminModel> AdminModel { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=Leaves.db");
        }
    }
}
