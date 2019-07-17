using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace SuportAPI.API.Ticket
{
    partial class TicketController
    {
        [HttpGet("getTickets")]
        public async Task<ActionResult<List<Data.Ticket>>> GetTickets()
        {
            try
            {
                // QUERY
                var ticketList = await context.Tickets
                    .Where(x => x.RowStatus == Data.enRowStatus.Active)
                    .ToListAsync();                               

                // RESULT
                List<Data.Ticket> result = ticketList.ToList();           
                return OkResponse(result);
            }
            catch(Exception ex) { return BadRequestResponse(ex); }
        }
    }
}
