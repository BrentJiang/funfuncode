using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using WordAnalyser.Model;

namespace BookReader
{
    public class BookContext : DbContext
    {
        public DbSet<Language> Languages { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<BookResult> BookResults { get; set; }
        public DbSet<Word> Words { get; set; }
        public DbSet<WordResult> WordResults { get; set; }
        public DbSet<WordResultHistory> WordResultHistories { get; set; }

        public BookContext(DbContextOptions<BookContext> options)
            : base(options)
        {
        }

    }


    /// <summary>
    /// A factory to create an instance of the StudentsContext 
    /// </summary>
    public static class BookContextFactory
    {
        public static BookContext Create(string connectionString)
        {
            var optionsBuilder = new DbContextOptionsBuilder<BookContext>();
            optionsBuilder.UseSqlite(connectionString);

            // Ensure that the SQLite database and sechema is created!
            var context = new BookContext(optionsBuilder.Options);
            context.Database.EnsureCreated();

            return context;
        }
    }
}
