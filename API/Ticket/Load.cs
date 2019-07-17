using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace SuportAPI.API.Ticket
{
    partial class TicketController
    {
        [HttpGet("getTickets")]
        public async Task<ActionResult<Object>> GetTickets()
        {
            try
            {
                var content = await context.Tickets.FirstOrDefaultAsync();
                return OkResponse(content);
            }
            catch(Exception ex) { return BadRequestResponse(ex); }
        }
    }
}
