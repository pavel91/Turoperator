using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template.Models
{
    public class Location
    {
        private ICollection<Destination> destinations;
        private ICollection<Photo> photos;
        private ICollection<Video> videos;

        public Location()
        {
            this.destinations = new List<Destination>();
            this.photos = new List<Photo>();
            this.videos = new List<Video>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string DestinationInfo { get; set; }

        [Required]
        public string Description { get; set; }

        public string Coordinates { get; set; }

        public virtual ICollection<Video> Videos
        {
            get { return this.videos; }
            set { this.videos = value; }
        }

        public virtual ICollection<Destination> Destinations
        {
            get { return this.destinations; }
            set { this.destinations = value; }
        }

        public virtual ICollection<Photo> Photos
        {
            get { return this.photos; }
            set { this.photos = value; }
        }
    }
}
