using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCore.Data
{
    public class ComicContext : DbContext
    {
        public ComicContext() : base("ComicCoreDB")
        {
            Database.SetInitializer<ComicContext>(new CreateDatabaseIfNotExists<ComicContext>());

            //Database.SetInitializer<SchoolDBContext>(new DropCreateDatabaseIfModelChanges<SchoolDBContext>());
            //Database.SetInitializer<SchoolDBContext>(new DropCreateDatabaseAlways<SchoolDBContext>());
            //Database.SetInitializer<SchoolDBContext>(new SchoolDBInitializer());
        }

        public DbSet<ComicPublisher> Publishers { get; set; }
        public DbSet<ComicSeries> Series { get; set; }
        public DbSet<ComicArtist> Artists { get; set; }
        public DbSet<ComicIssue> Comics { get; set; }
    }
}
