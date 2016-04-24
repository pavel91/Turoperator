using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Template.Models
{
    public class ApplicationUser : IdentityUser
    {
        private ICollection<ApplicationUser> friends;
        //do we need it
        private ICollection<Package> packages;
        private ICollection<Comment> comments;
        //private ICollection<Destination> destinations;

        public ApplicationUser()
        {
            this.friends = new List<ApplicationUser>();
            this.packages = new List<Package>();
            this.comments = new List<Comment>();
            //this.destinations = new List<Destination>();
        }

        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            return userIdentity;
        }

        public Photo ProfilePic { get; set; }

        public virtual ICollection<ApplicationUser> Friends
        {
            get { return this.friends; }
            set { this.friends = value; }
        }

        public virtual ICollection<Package> Packages
        {
            get { return this.packages; }
            set { this.packages = value; }
        }

        public virtual ICollection<Comment> Comments
        {
            get { return this.comments; }
            set { this.comments = value; }
        }

        //public virtual ICollection<Destination> Destinations
        //{
        //    get { return this.destinations; }
        //    set { this.destinations = value; }
        //}
    }
}
