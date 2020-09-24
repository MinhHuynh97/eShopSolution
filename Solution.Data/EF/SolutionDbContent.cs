using Microsoft.EntityFrameworkCore;
using Solution.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Solution.Data.EF
{
    public class SolutionDbContent : DbContext
    {
        public SolutionDbContent(DbContextOptions options) : base(options)
        {
            
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Catelogy> Catelogies { get; set; }
    }

}
   
