
using System.ComponentModel.DataAnnotations;

namespace IdentityAndUserManagement.ViewModel
{
    public class RoleFormViewModel
    {
        [Required, StringLength(256)]
        public string Name { get; set; }
    }
}
