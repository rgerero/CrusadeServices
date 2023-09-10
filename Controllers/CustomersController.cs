using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CrusadeServices.Data;
using CrusadeServices.Models;
using CrusadeServices.Utilities;

namespace CrusadeServices.Controllers
{
    public class CustomersController : Controller
    {
        private readonly CrusadeServicesContext _context;

        public CustomersController(CrusadeServicesContext context)
        {
            _context = context;
        }

        // GET: Customers
        public async Task<IActionResult> Index(string searchText = "", int pg=1,int pageSize=10)//
		{
            var query = _context.Customer.AsQueryable();

            if (pg < 1) pg = 1;

            //if (!string.IsNullOrEmpty(searchText))
            //{
            //    query = _context.Customer.Where(p => p.FirstName.Contains(searchText)).AsQueryable();
            //}

            int recCount = query.Count();
			Pager searchPager = new Pager(recCount, pg, pageSize);
			int recSkip = (pg - 1) * pageSize;
            List<Customer> lstCustomer = query.Skip(recSkip).Take(pageSize).ToList();

            //var data=lstCustomer.Skip(recSkip).Take(searchPager.PageSize).ToList();

            this.ViewBag.Pager = searchPager;
            
            return View(lstCustomer);


            //int pageSize = 10;
            //return View(PaginatedList<Customer>.Create(_context.Customer.ToList(), pageNumber ?? 1, pageSize));
            //return View(await _context.Customer.ToListAsync());

            //return _context.Customer != null ?
            //    View("Index", await _context.Customer.Where(e => e.CompanyName != null && e.CompanyName.Length > 0).ToListAsync()) :
            //    Problem("Entity set customer is null.");
        }

        // GET: Customers/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Customer == null)
            {
                return NotFound();
            }

            var customer = await _context.Customer
                .FirstOrDefaultAsync(m => m.CustomerID == id);
            if (customer == null)
            {
                return NotFound();
            }

            return View(customer);
        }

        // GET: Customers/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Customers/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CustomerID,CustomerTypeID,SalesPersonID,CompanyName,Salutation,FirstName,LastName,HomeNo,OfficeNo,MobileNo,Address1,Address2,PostalCode,B_Salutation,B_FirstName,B_LastName,B_Address1,B_Address2,B_PostalCode,B_HomeNo,B_MobileNo,B_OfficeNo,CreatedDate,CreatedBy,LastUpdateDate,LastUpdateBy,ContactPerson,ContactNo,B_ContactNo,IsBlacklisted,EmployeeID")] Customer customer)
        {
            if (ModelState.IsValid)
            {
                _context.Add(customer);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(customer);
        }

        // GET: Customers/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Customer == null)
            {
                return NotFound();
            }

            var customer = await _context.Customer.FindAsync(id);
            if (customer == null)
            {
                return NotFound();
            }
            return View(customer);
        }

        // POST: Customers/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("CustomerID,CustomerTypeID,SalesPersonID,CompanyName,Salutation,FirstName,LastName,HomeNo,OfficeNo,MobileNo,Address1,Address2,PostalCode,B_Salutation,B_FirstName,B_LastName,B_Address1,B_Address2,B_PostalCode,B_HomeNo,B_MobileNo,B_OfficeNo,CreatedDate,CreatedBy,LastUpdateDate,LastUpdateBy,ContactPerson,ContactNo,B_ContactNo,IsBlacklisted,EmployeeID")] Customer customer)
        {
            if (id != customer.CustomerID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(customer);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CustomerExists(customer.CustomerID))
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
            return View(customer);
        }

        // GET: Customers/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Customer == null)
            {
                return NotFound();
            }

            var customer = await _context.Customer
                .FirstOrDefaultAsync(m => m.CustomerID == id);
            if (customer == null)
            {
                return NotFound();
            }

            return View(customer);
        }

        // POST: Customers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Customer == null)
            {
                return Problem("Entity set 'CrusadeServicesContext.Customer'  is null.");
            }
            var customer = await _context.Customer.FindAsync(id);
            if (customer != null)
            {
                _context.Customer.Remove(customer);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CustomerExists(int id)
        {
          return _context.Customer.Any(e => e.CustomerID == id);
        }
    }
}
