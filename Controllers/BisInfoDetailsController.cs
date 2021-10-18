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
    public class BisInfoDetailsController : ControllerBase
    {
        private readonly BankLoanContext _context;
        public BisInfoDetailsController(BankLoanContext context)
        {
            _context = context;
        }

        [HttpGet("{RefID}")]
        public async Task<ActionResult<BisInfoDetail>> GetBisInfoDetail(string RefID)
        {
            var bisInfoDetail = await _context.bisInfoDetails.FindAsync(RefID);
            if (bisInfoDetail != null)
            {
                var Authorizers = _context.Authorizers.Where(d => d.RefID == RefID).ToList();
                if (Authorizers == null)
                {
                    return NotFound();
                }
                else
                {
                    return bisInfoDetail;
                }
            }
            return NotFound();

        }

        [ProducesResponseType(200)]
        [HttpPost]
        public async Task<ActionResult<BisInfoDetail>> PostBisInfoDetail(BisInfoDetail bisInfoDetail)
        {
            _context.bisInfoDetails.Add(bisInfoDetail);
            try
            {
                await _context.SaveChangesAsync();
                return bisInfoDetail;
            }
            catch (DbUpdateException)
            {
                if (BisInfoDetailExists(bisInfoDetail.RefID))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }
        }

        private bool BisInfoDetailExists(string id)
        {
            return _context.bisInfoDetails.Any(e => e.RefID == id);
        }
    }

}
