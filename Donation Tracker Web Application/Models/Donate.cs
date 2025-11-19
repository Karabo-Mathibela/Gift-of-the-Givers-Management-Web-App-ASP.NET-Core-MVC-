using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace LoginAndRegistration.Models
{
    public class Donate
    {
        [DisplayName("Name:")]
        public string Names { get; set; }

        [DisplayName("Email Address:")]
        public string EmailAddress { get; set; }

        [DisplayName("Description: ")]
        public string Description { get; set; }

        [DisplayName("Amount: ")]
        public int Amount { get; set; }

        //THE DEFAULT CONSTRUCTOR:
        public Donate() 
        {

        }
    }
}
