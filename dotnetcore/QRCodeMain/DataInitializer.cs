using Microsoft.EntityFrameworkCore;
using QRCodeMain.Models;
using System;
using System.Linq;
using System.Threading.Tasks;
using VocabularyAnalyser.Model;

namespace QRCodeMain
{
    public class DataInitializer
    {
        private readonly MvcQrCodeContext _context;
        public DataInitializer(MvcQrCodeContext context)
        {
            _context = context;
        }

        public async Task InitializeDataAsync(IServiceProvider serviceProvider)
        {
            var lang = await _context.Languages.SingleOrDefaultAsync(p => p.LanguageCode == "zh_CN");
            if (lang == null)
            {
                lang = new Language
                {
                    LanguageName = "简体中文",
                    LanguageCode = "zh_CN",
                    LanguageType = _context.Languages.Max(p => p.LanguageType) + 1
                };
                _context.Add(lang);
                await _context.SaveChangesAsync();
            }
            lang = await _context.Languages.SingleOrDefaultAsync(p => p.LanguageCode == "en_US");
            if (lang == null)
            {
                lang = new Language
                {
                    LanguageName = "美国英语",
                    LanguageCode = "en_US",
                    LanguageType = _context.Languages.Max(p => p.LanguageType) + 1
                };
                _context.Add(lang);
                await _context.SaveChangesAsync();
            }
        }
    }
}