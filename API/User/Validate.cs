using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using SuportAPI.Data;

namespace SuportAPI.API.User
{
    partial class UserController
    {
        [HttpGet("validate")]
        public async Task<ActionResult<bool>> ValidadeUser(string login, string password)
        {
            try
            {
                // VERIFY
                var isUser = await context.Users
                    .Where(x => x.Login == login && x.Password == password)
                    .AnyAsync();                

                // RESULT
                return OkResponse(isUser);
            }
            catch(Exception ex) { return BadRequestResponse(ex); }
        }      
        
    }
}
