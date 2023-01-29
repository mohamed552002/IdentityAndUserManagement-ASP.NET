using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace IdentityAndUserManagement.Models
{
    public class ApplicationUser : IdentityUser
    {
        [Required,MaxLength(100)]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Required, MaxLength(100)]
        [Display(Name = "Last Name")]

        public string LastName { get; set; }
        [Display(Name = "profile picture")]
        public byte[]? ProfilePic { get; set; }


    }
}
