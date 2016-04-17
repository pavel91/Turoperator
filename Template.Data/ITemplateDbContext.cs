namespace Template.Data
{
    using System.Data.Entity;

    using Template.Models;

    public interface ITemplateDbContext
    {
        IDbSet<Comment> Comments { get; set; }
        IDbSet<Destination> Destinations { get; set; }
        IDbSet<Event> Events { get; set; }
        IDbSet<Extra> Extras { get; set; }
        IDbSet<Like> Likes { get; set; }
        IDbSet<Location> Locations { get; set; }
        IDbSet<Message> Messages { get; set; }
        IDbSet<Order> Orders { get; set; }
        IDbSet<Package> Packages { get; set; }
        IDbSet<Photo> Photos { get; set; }
        IDbSet<TourGuide> TourGuides { get; set; }
        IDbSet<Video> Videos { get; set; }

        int SaveChanges();
    }
}