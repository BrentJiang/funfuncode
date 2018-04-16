using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using VocabularyAnalyser.Model;

namespace QRCodeMain.Models
{
    public class MvcQrCodeContext : DbContext
    {
        public DbSet<QrCode> QrCodes { get; set; }
        public DbSet<Article> Articles { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<UserTag> UserTags { get; set; }
        public DbSet<WordStatistics> WordStatisticses { get; set; }
        public DbSet<Language> Languages { get; set; }
        public DbSet<MyVocabularyStatistics> MyVocabularyStatisticses { get; set; }
        public DbSet<UserVocabulary> UserVocabularies { get; set; }
        public DbSet<MyVocabularyTest> MyVocabularyTests { get; set; }
        public DbSet<VocabularyTestDetail> VocabularyTestDetails { get; set; }

        public MvcQrCodeContext (DbContextOptions<MvcQrCodeContext> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Language>()
                .HasIndex(b => b.LanguageCode).IsUnique(true);
            modelBuilder.Entity<WordStatistics>()
                .HasIndex(b => b.WordUnicode).IsUnique(true);
            modelBuilder.Entity<MyVocabularyStatistics>()
                .HasIndex(b => b.UserName).IsUnique(true);
        }
    }
}
