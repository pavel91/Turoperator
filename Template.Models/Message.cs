namespace Template.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Template.Models.Enums;

    public class Message
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public ApplicationUser Sender { get; set; }

        [Required]
        public ApplicationUser Recipient { get; set; }

        [Required]
        public DateTime SentTime { get; set; }

        [Required]
        public MessageStatus Status { get; set; }
    }
}
