using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Lucaci_Andreea_Lab2.Models;

namespace Lucaci_Andreea_Lab2.Data
{
    public class Lucaci_Andreea_Lab2Context : DbContext
    {
        public Lucaci_Andreea_Lab2Context (DbContextOptions<Lucaci_Andreea_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Lucaci_Andreea_Lab2.Models.Book> Book { get; set; } = default!;

        public DbSet<Lucaci_Andreea_Lab2.Models.Publisher> Publisher { get; set; }

        public DbSet<Lucaci_Andreea_Lab2.Models.Category> Category { get; set; }
    }
}
