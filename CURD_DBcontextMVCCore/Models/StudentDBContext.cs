﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CURD_DBcontextMVCCore.Models
{
    public class StudentDBContext:DbContext
    {
        public StudentDBContext(DbContextOptions<StudentDBContext> options) : base(options)
        {

        }
        public DbSet<Student> students { get; set; }
        public DbSet<Teacher> teachers { get; set; }
    }
}
