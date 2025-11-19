using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace LoginAndRegistration.Models
{
    public class IncidentR
    {
        [DisplayName("Incident:")]
        public string incident { get; set; }

        [DisplayName("Location:")]
        public string location { get; set; }

        [DisplayName("Items required:")]
        public string itemsRequired { get; set; }

        public IncidentR() 
        { 
        
        }

    }
}
