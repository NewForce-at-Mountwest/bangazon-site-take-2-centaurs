using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Bangazon.Data;
using Bangazon.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authorization;

namespace Bangazon.Controllers
{
    public class PaymentTypesController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;

        public PaymentTypesController(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }
        private Task<ApplicationUser> GetCurrentUserAsync() => _userManager.GetUserAsync(HttpContext.User);
        
        
        // GET: PaymentTypes
        public async Task<IActionResult> Index()
        {
            var currentUser = await GetCurrentUserAsync();
            var applicationDbContext = _context.PaymentType
                .Include(pt => pt.User)
                .Where(pt => pt.UserId == currentUser.Id)
                .Where(p => p.Inactive == false);
            return View(await applicationDbContext.ToListAsync());
        }


        // GET: PaymentTypes/Details/
        [Authorize]
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var currentUser = await GetCurrentUserAsync();
            var paymentType = await _context.PaymentType
                .Include(pt => pt.User)
                .Where(pt => pt.UserId == currentUser.Id)
                .FirstOrDefaultAsync(u => u.PaymentTypeId == id);
            if (paymentType == null)
            {
                return NotFound();
            }

            return View(paymentType);
        }


        // GET: PaymentTypes/Create
        [Authorize]
        public IActionResult Create()
        {

            ViewData["UserId"] = new SelectList(_context.ApplicationUsers, "Id", "Id");
            return View();
        }


        // POST: PaymentTypes/Create
        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PaymentTypeId,DateCreated,Description,AccountNumber,UserId")] PaymentType paymentType)
        {
            ModelState.Remove("UserId");
            ModelState.Remove("User");
            if (ModelState.IsValid)
            {
                var currentUser = await GetCurrentUserAsync();
                paymentType.UserId = currentUser.Id;
                _context.Add(paymentType);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["UserId"] = new SelectList(_context.ApplicationUsers, "Id", "Id", paymentType.UserId);
            return View(paymentType);
        }


        // GET: PaymentTypes/Edit/
        [Authorize]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var paymentType = await _context.PaymentType.FindAsync(id);
            if (paymentType == null)
            {
                return NotFound();
            }
            ViewData["UserId"] = new SelectList(_context.ApplicationUsers, "Id", "Id", paymentType.UserId);
            return View(paymentType);
        }

        // POST: PaymentTypes/Edit/
        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("PaymentTypeId, DateCreated, Description, AccountNumber, UserId")] PaymentType paymentType)
        {
            var currentUser = await GetCurrentUserAsync();
            if (id != paymentType.PaymentTypeId)
            {
                return NotFound();
            }

            ModelState.Remove("User");
            ModelState.Remove("DateCreated");
            ModelState.Remove("UserId");
            paymentType.UserId = currentUser.Id;

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(paymentType);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PaymentTypeExists(paymentType.PaymentTypeId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["UserId"] = new SelectList(_context.ApplicationUsers, "Id", "Id", paymentType.UserId);
            return View(paymentType);
        }


        // GET: PaymentTypes/Delete/
        [Authorize]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var currentUser = await GetCurrentUserAsync();
            var paymentType = await _context.PaymentType
                .Include(pt => pt.User)
                .Where(pt => pt.UserId == currentUser.Id)
                .FirstOrDefaultAsync(u => u.PaymentTypeId == id);
            if (paymentType == null)
            {
                return NotFound();
            }

            return View(paymentType);
        }


        // POST: PaymentTypes/Delete/
        [Authorize]
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var paymentType = await _context.PaymentType.FindAsync(id);
            var orderHistory = (_context.Order
                .Include(o => o.PaymentTypeId)
                .Where(o => o.PaymentTypeId == id)).Count();
            if (orderHistory > 0)
            {
                paymentType.Inactive = true;
            }
            else
            {
                _context.PaymentType.Remove(paymentType);
             }
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PaymentTypeExists(int id)
        {
            return _context.PaymentType.Any(u => u.PaymentTypeId == id);
        }
    }
}