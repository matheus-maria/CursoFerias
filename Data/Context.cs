using Microsoft.EntityFrameworkCore;
using System;

namespace SuportAPI.Data
{
    public partial class BaseContext : DbContext
    {
        
    }

    public class TicketContext : BaseContext
    {
        public DbSet<Ticket> Tickets { get; set; }
        
    }
}
