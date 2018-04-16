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
        public DbSet<VocabularyTest> VocabularyTests { get; set; }
        public DbSet<VocabularyTestDetail> VocabularyTestDetails { get; set; }
        public DbSet<WordStatistics> WordStatisticses { get; set; }

        public MvcQrCodeContext (DbContextOptions<MvcQrCodeContext> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<WordStatistics>()
                .HasIndex(b => b.WordUnicode).IsUnique(true);
        }
    }
}
