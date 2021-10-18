using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using APIBankLoan.Models;
using Microsoft.AspNetCore.Mvc.Abstractions;
using System.ComponentModel;

namespace APIBankLoan.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegistrationController : ControllerBase
    {
        private readonly BankLoanContext _context;
        public RegistrationController(BankLoanContext context)
        {
            _context = context;
        }

        // GET: api/GeneralMessage
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Registration>>> GetGeneralMessages()
        {
            return await _context.Registrations.ToListAsync();
        }

        [HttpGet("{Email}")]
        public async Task<ActionResult<Registration>> GetRegistration(string Email)
        {
            var Registration = await _context.Registrations.FindAsync(Email);
            if (Registration != null)
            {
                return Registration;
            }
            return NotFound();
        }

        [ProducesResponseType(200)]
        [HttpPost]
        public async Task<ActionResult<Registration>> PostRegistration(Registration Registration)
        {
            var RegistrationEmail = await _context.Registrations.FindAsync(Registration.Email.ToString());
            if (RegistrationEmail != null){
                _context.Registrations.Add(Registration);
                try
                {
                    await _context.SaveChangesAsync();
                    return Registration;
                }
                catch (DbUpdateException)
                {
                    if (RegistrationExists(Registration.Email))
                    {
                        return Conflict();
                    }
                    else
                    {
                        throw;
                    }
                }
            }

            return NotFound();
            
        }

        private bool RegistrationExists(string email)
        {
            return _context.Registrations.Any(e => e.Email == email);
        }
    }
}
