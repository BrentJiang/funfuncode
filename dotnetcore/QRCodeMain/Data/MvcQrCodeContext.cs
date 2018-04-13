using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace QRCodeMain.Models
{
    public class MvcQrCodeContext : DbContext
    {
        public DbSet<QrCode> QrCodes { get; set; }
        public DbSet<Article> Articles { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<UserTag> UserTags { get; set; }

        public MvcQrCodeContext (DbContextOptions<MvcQrCodeContext> options)
            : base(options)
        {
        }
    }
}
