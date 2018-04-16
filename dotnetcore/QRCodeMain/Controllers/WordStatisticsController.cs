using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using QRCodeMain.Models;
using QRCodeMain.Models.WordStatisticsViewModels;

namespace QRCodeMain.Controllers
{
    public class WordStatisticsController : Controller
    {
        private readonly MvcQrCodeContext _context;

        public WordStatisticsController(MvcQrCodeContext context)
        {
            _context = context;
        }

        // GET: New Test
        public IActionResult NewTest()
        {
            var vm = new NewTestViewModel
            {
                TestScopeWordCount = 3000,
                TestWordCount = 20
            };
            return View(vm);
        }
        // POST: WordStatistics/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> NewTest([Bind("TestScopeWordCount, TestWordCount")] NewTestViewModel testPaperViewModel)
        {
            if (ModelState.IsValid)
            {
                return View(testvm);
            }
            return NotFound();
        }
        // GET: WordStatistics
        public async Task<IActionResult> List()
        {
            return View(await _context.WordStatisticses.ToListAsync());
        }

        // GET: WordStatistics/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var wordStatistics = await _context.WordStatisticses
                .SingleOrDefaultAsync(m => m.WordStatisticsId == id);
            if (wordStatistics == null)
            {
                return NotFound();
            }

            return View(wordStatistics);
        }

        // GET: WordStatistics/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: WordStatistics/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("WordStatisticsId,WordUnicode,TotalBook,TotalWords,TotalOccur,MaxWords,MaxOccur,MaxRatio")] WordStatistics wordStatistics)
        {
            if (ModelState.IsValid)
            {
                _context.Add(wordStatistics);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(wordStatistics);
        }

        // GET: WordStatistics/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var wordStatistics = await _context.WordStatisticses.SingleOrDefaultAsync(m => m.WordStatisticsId == id);
            if (wordStatistics == null)
            {
                return NotFound();
            }
            return View(wordStatistics);
        }

        // POST: WordStatistics/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("WordStatisticsId,WordUnicode,TotalBook,TotalWords,TotalOccur,MaxWords,MaxOccur,MaxRatio")] WordStatistics wordStatistics)
        {
            if (id != wordStatistics.WordStatisticsId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(wordStatistics);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!WordStatisticsExists(wordStatistics.WordStatisticsId))
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
            return View(wordStatistics);
        }

        // GET: WordStatistics/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var wordStatistics = await _context.WordStatisticses
                .SingleOrDefaultAsync(m => m.WordStatisticsId == id);
            if (wordStatistics == null)
            {
                return NotFound();
            }

            return View(wordStatistics);
        }

        // POST: WordStatistics/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var wordStatistics = await _context.WordStatisticses.SingleOrDefaultAsync(m => m.WordStatisticsId == id);
            _context.WordStatisticses.Remove(wordStatistics);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool WordStatisticsExists(int id)
        {
            return _context.WordStatisticses.Any(e => e.WordStatisticsId == id);
        }
    }
}
