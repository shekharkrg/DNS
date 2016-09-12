namespace DNS.DataBase
{
    using Entities;
    using System.Data.Entity;
    public class DatabaseContext : DbContext
    {
        public DbSet<UserRole> Userroles { get; set; }

    }
}
