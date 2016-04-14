using System.Data.Entity.ModelConfiguration.Conventions;
using Core;
namespace Core.Entity
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class EntityData : DbContext
    {
        public EntityData() : base("name=EntityData")
        {
            this.Configuration.LazyLoadingEnabled = false;
            this.Configuration.ProxyCreationEnabled = false;
        }

        public DbSet<Movie> Movies { get; set; }
        public DbSet<Screen> Screens { get; set; }
        public DbSet<Show> Shows { get; set; }
    }

}