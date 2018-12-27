using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Exam3.Models
{
    public class Exam3Context : DbContext
    {
        public Exam3Context (DbContextOptions<Exam3Context> options)
            : base(options)
        {
        }

        public DbSet<Exam3.Models.Employee> Employee { get; set; }
    }
}
