using HomeInbox_EngleanAPI.Database.DatabaseModel;
using Microsoft.EntityFrameworkCore;

namespace HomeInbox_EngleanAPI.Database
{
    public class DbDatacontext : DbContext
    {
        public DbDatacontext(DbContextOptions<DbDatacontext> options) : base(options) { }

        public DbSet<Vocabulary> vocabularies { get; set; }
        public DbSet<userlogin> userlogins { get; set; }
    }
}
