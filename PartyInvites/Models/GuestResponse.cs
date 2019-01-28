using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PartyInvites.Models
{
    public class GuestResponse
    {
        public string Name { get; set; }
        [Required(ErrorMessage = "Podaj email")]
        [RegularExpression(".+\\@.+\\..+", ErrorMessage = "Podaj prawidłowy email")]
        public string Email { get; set; }
        public string Phone { get; set; }
        public bool? WillAttend { get; set; }
    }
}
