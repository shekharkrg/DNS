using System.Data.Entity;

namespace DataBase
{
    public class DatabaseContext : DbContext
    {
        public DbSet<UserRole> Userroles { get; set; }

    }
}
