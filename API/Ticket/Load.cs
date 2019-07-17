using Microsoft.AspNetCore.Mvc;

namespace SuporteAPI.API.Ticket
{
    partial class TicketController
    {
        [HttpGet("getTickets")]
        public IActionResult GetTickets()
        {
            return Ok("Tickets");
        }
    }
}
