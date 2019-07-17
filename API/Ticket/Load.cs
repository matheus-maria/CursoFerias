using Microsoft.AspNetCore.Mvc;

namespace SuportAPI.API.Ticket
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
