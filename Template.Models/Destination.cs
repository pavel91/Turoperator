using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Template.Models.Enums;

namespace Template.Models
{
    public class Destination
    {
        private ICollection<ApplicationUser> participants;
        private ICollection<Photo> photos;
        private ICollection<Video> videos;
        private ICollection<Event> events;

        public Destination()
        {
            this.participants = new List<ApplicationUser>();
            this.photos = new List<Photo>();
            this.videos = new List<Video>();
            this.events = new List<Event>();
        }

        [Key]
        public int Id { get; set; }

        public Status Status { get; set; }

        public int LimitPlaces { get; set; }

        public DateTime startDate { get; set; }
        
        public DateTime endDate { get; set; }

        public decimal Price { get; set; }

        public virtual Location Location { get; set; }

        public virtual TourGuide TourGuide { get; set; }

        public virtual Package Package { get; set; }

        public virtual ICollection<Event> Events
        {
            get { return this.events; }
            set { this.events = value; }
        }

        public virtual ICollection<Video> Videos
        {
            get { return this.videos; }
            set { this.videos = value; }
        }

        public virtual ICollection<ApplicationUser> Participants
        {
            get { return this.participants; }
            set { this.participants = value; }
        }

        public virtual ICollection<Photo> Photos
        {
            get { return this.photos; }
            set { this.photos = value; }
        }

    }
}
