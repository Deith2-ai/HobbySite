using System.Data.Entity;
using System.Data.Entity.Infrastructure;

namespace Hobby.Data
{
    public class HobbyDbContext : DbContext
    {
        public HobbyDbContext()
            : base("HobbyDev")
        {
            SetContext();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Configurations.AddFromAssembly(typeof(HobbyDbContext).Assembly);
        }

        private void SetContext()
        {
            Database.SetInitializer<HobbyDbContext>(new DropCreateDatabaseAlways<HobbyDbContext>());

            ((IObjectContextAdapter)this).ObjectContext.CommandTimeout = 120;
            this.Configuration.LazyLoadingEnabled = true;
            this.Configuration.ProxyCreationEnabled = false;
        }
    }
}
