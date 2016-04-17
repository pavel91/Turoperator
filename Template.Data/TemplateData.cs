namespace Template.Data
{
    using System;
    using System.Collections.Generic;

    using Template.Data.Repositories;
    using Template.Models;

    public class TemplateData : ITemplateData
    {
        private ITemplateDbContext context;
        private IDictionary<Type, object> repositories;

        public TemplateData(ITemplateDbContext context)
        {
            this.context = context;
            this.repositories = new Dictionary<Type, object>();
        }

        public IRepository<ApplicationUser> Users
        {
            get { return this.GetRepository<ApplicationUser>(); }
        }

        public IRepository<Comment> Comments
        {
            get { return this.GetRepository<Comment>(); }
        }

        public IRepository<Destination> Destinations
        {
            get { return this.GetRepository<Destination>(); }
        }

        public IRepository<Event> Events
        {
            get { return this.GetRepository<Event>(); }
        }

        public IRepository<Extra> Extras
        {
            get { return this.GetRepository<Extra>(); }
        }

        public IRepository<Like> Likes
        {
            get { return this.GetRepository<Like>(); }
        }

        public IRepository<Location> Locations
        {
            get { return this.GetRepository<Location>(); }
        }

        public IRepository<Message> Messages
        {
            get { return this.GetRepository<Message>(); }
        }

        public IRepository<Order> Orders
        {
            get { return this.GetRepository<Order>(); }
        }

        public IRepository<Package> Packages
        {
            get { return this.GetRepository<Package>(); }
        }

        public IRepository<Photo> Photos
        {
            get { return this.GetRepository<Photo>(); }
        }

        public IRepository<TourGuide> TourGuides
        {
            get { return this.GetRepository<TourGuide>(); }
        }

        public IRepository<Video> Videos
        {
            get { return this.GetRepository<Video>(); }
        }
        

        public int SaveChanges()
        {
            return this.context.SaveChanges();
        }

        private IRepository<T> GetRepository<T>() where T : class
        {
            var type = typeof(T);
            if (!this.repositories.ContainsKey(type))
            {
                var typeOfRepository = typeof(GenericRepository<T>);

                var repository = Activator.CreateInstance(typeOfRepository, this.context);
                this.repositories.Add(type, repository);
            }

            return (IRepository<T>)this.repositories[type];
        }
    }
}
