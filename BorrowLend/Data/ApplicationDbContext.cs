using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BorrowLend.Models;

namespace BorrowLend.Data
{
    public class ApplicationDbContext:DbContext
    {
        public DbSet<Item> Items1 { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
        {

        }
    }
}
