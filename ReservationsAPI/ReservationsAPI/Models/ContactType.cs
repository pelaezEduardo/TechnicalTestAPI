using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ReservationsAPI.Models
{
    public class ContactType
    {
        public ContactType()
        {
            Contacts = new HashSet<Contact>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        public string Description { get; set; }
        
        public ICollection<Contact> Contacts { get; set; }
    }
}
