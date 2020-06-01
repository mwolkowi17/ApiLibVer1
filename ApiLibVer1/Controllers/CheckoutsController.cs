﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ApiLibVer1.Models;

namespace ApiLibVer1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CheckoutsController : ControllerBase
    {
        private readonly AppLibVer1Context _context;

        public CheckoutsController(AppLibVer1Context context)
        {
            _context = context;
        }

        // GET: api/Checkouts
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Checkout>>> GetCheckouts()
        {
            return await _context.Checkouts.ToListAsync();
        }

        // GET: api/Checkouts/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Checkout>> GetCheckout(int id)
        {
            var checkout = await _context.Checkouts.FindAsync(id);

            if (checkout == null)
            {
                return NotFound();
            }

            return checkout;
        }

        // PUT: api/Checkouts/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCheckout(int id, Checkout checkout)
        {
            if (id != checkout.CheckoutID)
            {
                return BadRequest();
            }

            _context.Entry(checkout).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CheckoutExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Checkouts
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Checkout>> PostCheckout(Checkout checkout)
        {
            _context.Checkouts.Add(checkout);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCheckout", new { id = checkout.CheckoutID }, checkout);
        }

        // DELETE: api/Checkouts/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Checkout>> DeleteCheckout(int id)
        {
            var checkout = await _context.Checkouts.FindAsync(id);
            if (checkout == null)
            {
                return NotFound();
            }

            _context.Checkouts.Remove(checkout);
            await _context.SaveChangesAsync();

            return checkout;
        }

        private bool CheckoutExists(int id)
        {
            return _context.Checkouts.Any(e => e.CheckoutID == id);
        }
    }
}
