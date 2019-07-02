using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryKeeper.DaraBaseTablesClassses
{
    public class Context : DbContext
    {
        /// <summary>
        /// You can change sql connection string in this constructor method
        /// </summary>
        public Context() : base("Server=.;Database=MemoryKeeperDB;User Id=sa;Password=123")
        {

        }
        public DbSet<User> Users { get; set; }
        public DbSet<Memory> Memories { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //User's Table Propperties Settings
            modelBuilder.Entity<User>().Property(x => x.Email).IsRequired();
            modelBuilder.Entity<User>().Property(x => x.Password).IsRequired();


            //Memory's Table Propperties Settings
            modelBuilder.Entity<Memory>().Property(x => x.Description).IsRequired();
            modelBuilder.Entity<Memory>().Property(x => x.Rate).IsOptional();
            modelBuilder.Entity<Memory>().Property(x => x.ImagePath).IsOptional();

            base.OnModelCreating(modelBuilder);
        }
    }
}
