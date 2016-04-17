namespace Template.Data
{
    using System.Text.RegularExpressions;

    using Template.Data.Repositories;
    using Template.Models;

    public interface ITemplateData
    {
        IRepository<ApplicationUser> Users { get; }

        IRepository<Comment> Comments { get; }
        IRepository<Destination> Destinations { get; }
        IRepository<Event> Events { get; }
        IRepository<Extra> Extras { get; }
        IRepository<Like> Likes { get; }
        IRepository<Location> Locations { get; }
        IRepository<Message> Messages { get; }
        IRepository<Order> Orders { get; }
        IRepository<Package> Packages { get; }
        IRepository<Photo> Photos { get; }
        IRepository<TourGuide> TourGuides { get; }
        IRepository<Video> Videos { get; }

        int SaveChanges();
    }
}
