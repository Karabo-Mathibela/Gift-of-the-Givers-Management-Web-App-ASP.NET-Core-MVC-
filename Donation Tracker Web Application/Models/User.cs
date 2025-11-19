using System.ComponentModel.DataAnnotations;

namespace LoginAndRegistration.Models
{
    //THIS CLASS WILL REPRESENT THE USERS IN THE DATABASE:
    public class User
    {
        //THE CLASS PROPERTIES:
        [Required]
        public String Name { get; set; }

        [Required]
        [EmailAddress]
        public String Email { get; set; }

        [Required]
        public String Password { get; set; }
    }
}
