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
            return View(await _context.QrCode.ToListAsync());
        }

        // GET: QrCode/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var qrCode = await _context.QrCode
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
                return RedirectToAction(nameof(Index));
            }
            return View(qrCode);
        }

        // GET: QrCode/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var qrCode = await _context.QrCode.SingleOrDefaultAsync(m => m.QrCodeId == id);
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
        public async Task<IActionResult> Edit(int id, [Bind("QrCodeId")] QrCode qrCode)
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
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var qrCode = await _context.QrCode
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
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var qrCode = await _context.QrCode.SingleOrDefaultAsync(m => m.QrCodeId == id);
            _context.QrCode.Remove(qrCode);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool QrCodeExists(int id)
        {
            return _context.QrCode.Any(e => e.QrCodeId == id);
        }
    }
}
