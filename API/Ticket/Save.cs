using System;
using Microsoft.AspNetCore.Mvc;

namespace SuportAPI.API.Ticket
{
    partial class TicketController
    {
        [HttpPost("add")]
        public ActionResult<bool> Save(/*SuportAPI.Data.Ticket ticket*/)
        {
            try
            {
                var content = "Test";//context.Tickets.Add(ticket);
                return OkResponse(true);
            }
            catch(Exception ex) { return BadRequestResponse(ex); }
        }
    }
}
