using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Template.Models;
using System.Data.Entity;
using Template.Data.Migrations;
using System.Data.Entity.ModelConfiguration.Conventions;

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

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Package>()
                .HasMany(p => p.Participants)
                .WithMany(u => u.Packages)
                .Map(m =>
                {
                    m.ToTable("PackageUsers");
                    m.MapLeftKey("PackageId");
                    m.MapRightKey("ParticipantId");
                });

            modelBuilder.Entity<ApplicationUser>()
                .HasMany(au => au.Friends)
                .WithMany()
                .Map(m =>
                {
                    m.ToTable("UserFriends");
                    m.MapLeftKey("UserId");
                    m.MapRightKey("FriendId");
                });

            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            base.OnModelCreating(modelBuilder);
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
