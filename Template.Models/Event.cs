using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Template.Models.Enums;

namespace Template.Models
{
    public class Event
    {
        [Key]
        public int Id { get; set; }

        public EventType Type { get; set; }
    }
}
