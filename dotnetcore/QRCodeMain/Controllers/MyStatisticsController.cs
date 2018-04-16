using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using QRCodeMain.Models;
using QRCodeMain.Models.MyStatisticsViewModels;
using VocabularyAnalyser.Model;

namespace QRCodeMain.Controllers
{
    [Authorize]
    public class MyStatisticsController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly MvcQrCodeContext _context;

        public MyStatisticsController(
            UserManager<ApplicationUser> userManager,
            MvcQrCodeContext context)
        {
            _userManager = userManager;
            _context = context;
        }

        // GET: New Test
        public async Task<IActionResult> Index()
        {
            var user = await _userManager.GetUserAsync(User);
            if (user == null)
            {
                throw new ApplicationException($"Unable to load user with ID '{_userManager.GetUserId(User)}'.");
            }
            var vm = new MyStatisticsViewModel
            {
                MyVocabulary = await _context.MyVocabularyStatisticses.Include(p => p.Language).SingleOrDefaultAsync(p => p.UserName == user.UserName),
                MyTestsLatest = _context.MyVocabularyTests.OrderByDescending(p => p.TestTime).Take(10).ToList()
            };
            if(vm.MyVocabulary == null)
            {
                vm.MyVocabulary = new MyVocabularyStatistics
                {
                    Language = await _context.Languages.FirstOrDefaultAsync(p => p.LanguageCode == "zh_CN")
                };
                vm.MyVocabulary.LanguageId = vm.MyVocabulary.Language.LanguageId;
                vm.MyVocabulary.UserName = user.UserName;
                vm.MyVocabulary.CurrentScore = 0;
                _context.Add(vm.MyVocabulary);
                try
                {
                    await _context.SaveChangesAsync();
                }
                catch (Exception)
                {
                    throw;
                }
            }
            return View(vm);
        }

        // GET: New Test
        public async Task<IActionResult> NewTest()
        {
            var user = await _userManager.GetUserAsync(User);
            if (user == null)
            {
                throw new ApplicationException($"Unable to load user with ID '{_userManager.GetUserId(User)}'.");
            }
            var language = await _context.Languages.SingleOrDefaultAsync(p => p.LanguageCode == "zh_CN");
            var vm = new NewTestViewModel
            {
                Test = new VocabularyAnalyser.Model.MyVocabularyTest
                {
                    UserName = user.UserName,
                    TestWordCount = 20,
                    TestTime = DateTime.UtcNow,
                    Language = language,
                    LanguageId = language.LanguageId
                }
            };
            vm.Test.VocabularyTestDetails = await GenerateTestDetailsAsync(vm.Test, new List<(int, int, int)> { (0, 3000, 15), (3001, 5000, 5), (5001, 10000, 5) });
            return View(vm);
        }

        private async Task<List<VocabularyTestDetail>> GenerateTestDetailsAsync(MyVocabularyTest test, List<(int, int, int)> items)
        {
            // todo: 使用智能算法为每个用户量身定做？或许只需要规则：从哪几个级别各自取出多少字。
            // 或者其实可以由用户自己选择考试范围和各自需要多少字。
            var lst = new List<VocabularyTestDetail>();
            // todo: 如何快速的选择考试词汇？ 解决方案之一是人工预先定义好几套试卷！
            var data = await _context.WordStatisticses.OrderByDescending(p => p.TotalOccur).ToListAsync();
            var rand = new Random();
            for (int n = 0; n < items.Count; ++n)
            {
                var item = items[n];
                for (int i = 0; i < item.Item3; ++i)
                {
                    var word = data[rand.Next(Math.Min(item.Item1, data.Count), Math.Min(item.Item2, data.Count))];  //random的区间是：左闭右开[）
                    char correctanswer = (char)rand.Next('A', 'E');
                    lst.Add(new VocabularyTestDetail
                    {
                        VocabularyTest = test,
                        WordUnicode = word.WordUnicode,
                        AnswerContentA = 'A' == correctanswer? word.WordDescription: data[rand.Next(Math.Min(item.Item1, data.Count - 1), Math.Min(item.Item2, data.Count - 1))].WordDescription,
                        AnswerContentB = 'B' == correctanswer ? word.WordDescription : data[rand.Next(Math.Min(item.Item1, data.Count - 1), Math.Min(item.Item2, data.Count - 1))].WordDescription,
                        AnswerContentC = 'C' == correctanswer ? word.WordDescription : data[rand.Next(Math.Min(item.Item1, data.Count - 1), Math.Min(item.Item2, data.Count - 1))].WordDescription,
                        AnswerContentD = 'D' == correctanswer ? word.WordDescription : data[rand.Next(Math.Min(item.Item1, data.Count - 1), Math.Min(item.Item2, data.Count - 1))].WordDescription,
                        CorrectAnswer = correctanswer
                    });   
                }
            }
            return lst;
        }

        // POST: WordStatistics/SubmitTest
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult SubmitTest(NewTestViewModel model)
        {
            if (ModelState.IsValid)
            {
                var testvm = new TestResultViewModel
                {
                    Test = Judge(model.Test)
                };
                return View(testvm);
            }
            return NotFound();
        }

        private MyVocabularyTest Judge(MyVocabularyTest test)
        {
            return test;
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
