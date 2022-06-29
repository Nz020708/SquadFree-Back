using Microsoft.EntityFrameworkCore;
using SquadFree_Back.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SquadFree_Back.DAL
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {
        }
        public DbSet<Testimonial> Testimonials { get; set; }
    }
}
