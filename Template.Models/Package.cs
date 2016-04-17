using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Template.Models.Enums;

namespace Template.Models
{
    public class Package
    {
        private ICollection<Destination> destinations;
        private ICollection<ApplicationUser> participants;

        public Package()
        {
            this.destinations = new List<Destination>();
            this.participants = new List<ApplicationUser>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public string Description { get; set; }

        public Status Status { get; set; }

        public virtual ICollection<Destination> Destinations
        {
            get { return this.destinations; }
            set { this.destinations = value; }
        }

        public virtual ICollection<ApplicationUser> Participants
        {
            get { return this.participants; }
            set { this.participants = value; }
        }
    }
}
