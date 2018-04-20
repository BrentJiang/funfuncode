using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using QRCodeMain.Models;

namespace QRCodeMain.Controllers
{
    public class QrCodeController : Controller
    {
        private readonly MvcQrCodeContext _context;

        public QrCodeController(MvcQrCodeContext context)
        {
            _context = context;
        }

        // GET: QrCode
        public async Task<IActionResult> Index()
        {
            return View(await _context.QrCodes.ToListAsync());
        }

        // GET: QrCode/Details/5
        public async Task<IActionResult> Details(Int64? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var qrCode = await _context.QrCodes
                .SingleOrDefaultAsync(m => m.QrCodeId == id);
            if (qrCode == null)
            {
                return NotFound();
            }

            return View(qrCode);
        }

        // GET: QrCode/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: QrCode/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("QrCodeId")] QrCode qrCode)
        {
            if (ModelState.IsValid)
            {
                _context.Add(qrCode);
                await _context.SaveChangesAsync();
                qrCode.QrCodeRelativePath = $"My/Detail/{qrCode.QrCodeId}";
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(qrCode);
        }

        // GET: QrCode/Edit/5
        public async Task<IActionResult> Edit(Int64? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var qrCode = await _context.QrCodes.SingleOrDefaultAsync(m => m.QrCodeId == id);
            if (qrCode == null)
            {
                return NotFound();
            }
            return View(qrCode);
        }

        // POST: QrCode/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Int64 id, [Bind("QrCodeId")] QrCode qrCode)
        {
            if (id != qrCode.QrCodeId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(qrCode);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!QrCodeExists(qrCode.QrCodeId))
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
            return View(qrCode);
        }

        // GET: QrCode/Delete/5
        public async Task<IActionResult> Delete(Int64? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var qrCode = await _context.QrCodes
                .SingleOrDefaultAsync(m => m.QrCodeId == id);
            if (qrCode == null)
            {
                return NotFound();
            }

            return View(qrCode);
        }

        // POST: QrCode/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Int64 id)
        {
            var qrCode = await _context.QrCodes.SingleOrDefaultAsync(m => m.QrCodeId == id);
            _context.QrCodes.Remove(qrCode);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool QrCodeExists(Int64 id)
        {
            return _context.QrCodes.Any(e => e.QrCodeId == id);
        }
    }
}
