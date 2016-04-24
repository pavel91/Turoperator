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
        ApplicationUser Sender { get; set; }

        [Required]
        ApplicationUser Recipient { get; set; }

        [Required]
        DateTime SentTime { get; set; }

        [Required]
        MessageStatus Status { get; set; }
    }
}
