using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CrusadeServices.Data;
using CrusadeServices.Models;

namespace CrusadeServices.Controllers
{
    public class TransactionsController : Controller
    {
        private readonly CrusadeServicesContext _context;

        public TransactionsController(CrusadeServicesContext context)
        {
            _context = context;
        }

        // GET: Transactions
        public async Task<IActionResult> Index()
        {
              return View(await _context.Transaction.ToListAsync());
        }

        // GET: Transactions/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Transaction == null)
            {
                return NotFound();
            }

            var transaction = await _context.Transaction
                .FirstOrDefaultAsync(m => m.TransactionID == id);
            if (transaction == null)
            {
                return NotFound();
            }

            return View(transaction);
        }

        // GET: Transactions/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Transactions/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("TransactionID,CustomerID,DateOfJob,WorkOrderNo,InvoiceNo,Description,PriceNoGST,ModeOfPayment,Remark,Technicians,CreatedBy,CreatedDate,LastUpdateBy,LastUpdateDate,OtherAddress,ContactPerson,ContactNo,FirstName,LastName,HomeNo,OfficeNo,MobileNo,Salutation,PostalCode,Address1,Address2,B_Salutation,B_FirstName,B_LastName,B_Address1,B_Address2,B_PostalCode,B_HomeNo,B_MobileNo,B_OfficeNo,SalesPersonID,B_ContactPerson,B_ContactNo,EmployeeID,ContractDesc,TimeOfJob,TermsAndCondition,ReferenceNo,EmailID,UnitNo,B_EmailID,B_UnitNo,IsQuotation,PrizeSpecial,TranStatus,UnitNo2,B_UnitNo2,OperationRemarks,OperationStatus,JobTitle,DescRug,DescCarpet,DescMattress,DescUpholstery,DescGeneral,DescOthers,DateOfDelivery,DateOfQuotation,Discount,JobType,TimeArrived,TimeCompletion,SpecialInstructions,CustomerTypeID,CompanyName,IsBlacklisted")] Transaction transaction)
        {
            if (ModelState.IsValid)
            {
                _context.Add(transaction);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(transaction);
        }

        // GET: Transactions/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Transaction == null)
            {
                return NotFound();
            }

            var transaction = await _context.Transaction.FindAsync(id);
            if (transaction == null)
            {
                return NotFound();
            }
            return View(transaction);
        }

        // POST: Transactions/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("TransactionID,CustomerID,DateOfJob,WorkOrderNo,InvoiceNo,Description,PriceNoGST,ModeOfPayment,Remark,Technicians,CreatedBy,CreatedDate,LastUpdateBy,LastUpdateDate,OtherAddress,ContactPerson,ContactNo,FirstName,LastName,HomeNo,OfficeNo,MobileNo,Salutation,PostalCode,Address1,Address2,B_Salutation,B_FirstName,B_LastName,B_Address1,B_Address2,B_PostalCode,B_HomeNo,B_MobileNo,B_OfficeNo,SalesPersonID,B_ContactPerson,B_ContactNo,EmployeeID,ContractDesc,TimeOfJob,TermsAndCondition,ReferenceNo,EmailID,UnitNo,B_EmailID,B_UnitNo,IsQuotation,PrizeSpecial,TranStatus,UnitNo2,B_UnitNo2,OperationRemarks,OperationStatus,JobTitle,DescRug,DescCarpet,DescMattress,DescUpholstery,DescGeneral,DescOthers,DateOfDelivery,DateOfQuotation,Discount,JobType,TimeArrived,TimeCompletion,SpecialInstructions,CustomerTypeID,CompanyName,IsBlacklisted")] Transaction transaction)
        {
            if (id != transaction.TransactionID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(transaction);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TransactionExists(transaction.TransactionID))
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
            return View(transaction);
        }

        // GET: Transactions/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Transaction == null)
            {
                return NotFound();
            }

            var transaction = await _context.Transaction
                .FirstOrDefaultAsync(m => m.TransactionID == id);
            if (transaction == null)
            {
                return NotFound();
            }

            return View(transaction);
        }

        // POST: Transactions/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Transaction == null)
            {
                return Problem("Entity set 'CrusadeServicesContext.Transaction'  is null.");
            }
            var transaction = await _context.Transaction.FindAsync(id);
            if (transaction != null)
            {
                _context.Transaction.Remove(transaction);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TransactionExists(int id)
        {
          return _context.Transaction.Any(e => e.TransactionID == id);
        }
    }
}
