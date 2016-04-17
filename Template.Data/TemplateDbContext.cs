using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Template.Models;
using System.Data.Entity;
using Template.Data.Migrations;

namespace Template.Data
{
    public class TemplateDbContext : IdentityDbContext<ApplicationUser> , ITemplateDbContext
    {
        public TemplateDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<TemplateDbContext, Configuration>());
        }

        public static TemplateDbContext Create()
        {
            return new TemplateDbContext();
        }

        public IDbSet<Comment> Comments { get; set; }
        public IDbSet<Destination> Destinations { get; set; }
        public IDbSet<Event> Events { get; set; }
        public IDbSet<Extra> Extras { get; set; }
        public IDbSet<Like> Likes { get; set; }
        public IDbSet<Location> Locations { get; set; }
        public IDbSet<Message> Messages { get; set; }
        public IDbSet<Order> Orders { get; set; }
        public IDbSet<Package> Packages { get; set; }
        public IDbSet<Photo> Photos { get; set; }
        public IDbSet<TourGuide> TourGuides { get; set; }
        public IDbSet<Video> Videos { get; set; }
    }
}
