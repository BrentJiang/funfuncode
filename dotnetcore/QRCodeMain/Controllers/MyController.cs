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
using QRCodeMain.Models.MyViewModels;

namespace QRCodeMain.Controllers
{
    [Authorize]
    public class MyController : Controller
    {
        private readonly MvcQrCodeContext _context;
        private readonly UserManager<ApplicationUser> _userManager;

        public MyController(MvcQrCodeContext context,
            UserManager<ApplicationUser> userManager
        )
        {
            _context = context;
            _userManager = userManager;
        }

        // GET: My
        public async Task<IActionResult> Index()
        {
            var user = await _userManager.GetUserAsync(User);
            if (user == null)
            {
                throw new ApplicationException($"Unable to load user with ID '{_userManager.GetUserId(User)}'.");
            }
            var vm = new MyHomeViewModel()
            {
                Articles = await _context.Articles.Where(p => p.UserName == user.UserName).ToListAsync()
            };
            return View(vm);
        }

        // GET: My/Details/5
        public async Task<IActionResult> Details(Int64? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var article = await _context.Articles.Include(p => p.QrCode)
                .SingleOrDefaultAsync(m => m.ArticleId == id);
            if (article == null)
            {
                return NotFound();
            }

            if (article.Categories == null)
            {
                article.Categories = new List<Category>();
            }
            var vm = new ArticleViewModel()
            {
                Article = article,
                SystemCategories = await _context.Categories.ToListAsync()
            };

            return View(vm);
        }

        // GET: My/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: My/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ArticleId,Title,Content")] Article article)
        {
            if (ModelState.IsValid)
            {
                var user = await _userManager.GetUserAsync(User);
                if (user == null)
                {
                    throw new ApplicationException($"Unable to load user with ID '{_userManager.GetUserId(User)}'.");
                }
                article.UserName = user.UserName;
                QrCode newcode = new QrCode()
                {
                    Article = article
                };
                _context.Add(newcode);
                _context.Add(article);
                await _context.SaveChangesAsync();
                // see How can I get Id of inserted entity in Entity framework?https://stackoverflow.com/questions/5212751
                Int64 lastArticleId =
                    article.ArticleId; // yes, it's here! another way is: _context.Articles.Max(item => item.ArticleId);
                await _context.SaveChangesAsync();
                newcode.QrCodeRelativePath = $"My/Detail/{newcode.QrCodeId}";
                _context.Update(newcode);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(article);
        }

        // GET: My/Edit/5
        public async Task<IActionResult> Edit(Int64? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            // dev skill: 在Article中定义“virtual QrCode”对象，并且在这里使用Include()。
            var article = await _context.Articles.Include(x => x.QrCode).SingleOrDefaultAsync(m => m.ArticleId == id);
            if (article == null)
            {
                return NotFound();
            }
            return View(article);
        }

        // POST: My/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Int64 id, [Bind("ArticleId,Title,Content")] Article article)
        {
            if (id != article.ArticleId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(article);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ArticleExists(article.ArticleId))
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
            return View(article);
        }

        // GET: My/Delete/5
        public async Task<IActionResult> Delete(Int64? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var article = await _context.Articles.Include(p => p.QrCode)
                .SingleOrDefaultAsync(m => m.ArticleId == id);
            if (article == null)
            {
                return NotFound();
            }

            return View(article);
        }

        // POST: My/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Int64 id)
        {
            var article = await _context.Articles.SingleOrDefaultAsync(m => m.ArticleId == id);
            _context.Articles.Remove(article);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ArticleExists(Int64 id)
        {
            return _context.Articles.Any(e => e.ArticleId == id);
        }

        // GET: My/Delete/5
        public async Task<IActionResult> AttachCategory(Int64? categoryId, Int64? articleId)
        {
            if (categoryId == null || articleId == null)
            {
                return NotFound();
            }

            return View(new UpdateCategoryViewModel()
            {
                Category = await _context.Categories.SingleOrDefaultAsync(m => m.CategoryId == categoryId),
                Article = await _context.Articles.SingleOrDefaultAsync(m => m.ArticleId == articleId)
            });
        }

        // GET: My/Delete/5
        public async Task<IActionResult> DetachCategory(Int64? categoryId, Int64? articleId)
        {
            if (categoryId == null || articleId == null)
            {
                return NotFound();
            }

            return View(new UpdateCategoryViewModel()
            {
                Category = await _context.Categories.SingleOrDefaultAsync(m => m.CategoryId == categoryId),
                Article = await _context.Articles.SingleOrDefaultAsync(m => m.ArticleId == articleId)
            });
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AttachCategory(UpdateCategoryViewModel model, string returnUrl = null)
        {
            ViewData["ReturnUrl"] = returnUrl;
            if (model?.Category == null || model.Article == null)
            {
                return NotFound();
            }
            var category = await _context.Categories.SingleOrDefaultAsync(m => m.CategoryId == model.Category.CategoryId);
            var article = await _context.Articles.SingleOrDefaultAsync(m => m.ArticleId == model.Article.ArticleId);
            if (article.Categories == null)
            {
                article.Categories = new List<Category>();
            }
            if (!article.Categories.Exists(p => p.CategoryId == category.CategoryId))
            {
                // add
                article.Categories.Add(category);
                _context.Articles.Update(article);
                await _context.SaveChangesAsync();
            }
            return RedirectToAction(nameof(Details), new { id = article.ArticleId });
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DetachCategory(UpdateCategoryViewModel model, string returnUrl = null)
        {
            ViewData["ReturnUrl"] = returnUrl;
            if (model?.Category == null || model.Article == null)
            {
                return NotFound();
            }
            var category = await _context.Categories.SingleOrDefaultAsync(m => m.CategoryId == model.Category.CategoryId);
            var article = await _context.Articles.SingleOrDefaultAsync(m => m.ArticleId == model.Article.ArticleId);
            if (article.Categories == null)
            {
                return RedirectToLocal(returnUrl);
            }
            if (article.Categories.Exists(p => p.CategoryId == category.CategoryId))
            {
                // remove
                article.Categories.RemoveAll(p => p.CategoryId == category.CategoryId);
                _context.Articles.Update(article);
                await _context.SaveChangesAsync();
            }
            return RedirectToAction(nameof(Details), new { id = article.ArticleId});
        }

        private IActionResult RedirectToLocal(string returnUrl)
        {
            if (Url.IsLocalUrl(returnUrl))
            {
                return Redirect(returnUrl);
            }
            else
            {
                return RedirectToAction(nameof(HomeController.Index), "Home");
            }
        }

    }
}
