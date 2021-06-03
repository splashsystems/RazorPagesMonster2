using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RazorPagesMonster2.Models;

namespace RazorPagesMonster2.Data
{
    public class RazorPagesMonster2Context : DbContext
    {
        public RazorPagesMonster2Context (DbContextOptions<RazorPagesMonster2Context> options)
            : base(options)
        {
        }

        public DbSet<RazorPagesMonster2.Models.Monster> Monster { get; set; }
    }
}
