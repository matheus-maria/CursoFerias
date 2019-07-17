using Microsoft.EntityFrameworkCore;
using System;

namespace SuportAPI.Data
{
    public class BaseContext : DbContext
    {
        public BaseContext(DbContextOptions<BaseContext> options) : base(options) { }

        public DbSet<Ticket> Tickets { get; set; }
    }    
}
