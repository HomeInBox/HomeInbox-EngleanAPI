using HomeInbox_EngleanAPI.Database.DatabaseModel;
using Microsoft.EntityFrameworkCore;

namespace HomeInbox_EngleanAPI.Database
{
    public class DbDatacontext : DbContext
    {
        public DbDatacontext(DbContextOptions<DbDatacontext> options) : base(options) { }

        public DbSet<VOCABULARY> VOCABULARYs { get; set; }
        public DbSet<USER_LOGIN> USER_LOGINs { get; set; }
        public DbSet<USER_PROFILE> USER_PROFILEs { get; set; }
        public DbSet<TESTSCORE> TESTSCOREs { get; set; }
    }
}
