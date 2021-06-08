using System.ComponentModel.DataAnnotations;

namespace PartyInvites.Models
{
    public class GuestResponse
    {
        [Required(ErrorMessage = "Please enter your name")]
        public string Name { get; set; }
        
        [Required(ErrorMessage = "Please rnter your email address")]
        public string Email { get; set; }
        
        [Required(ErrorMessage = "Please enter your phone")]
        public string Phone { get; set; }
        
        [Required(ErrorMessage = "Please specify whether you will attend")]
        public bool? WillAttend { get; set; }
    }
}