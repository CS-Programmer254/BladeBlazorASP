using System.ComponentModel.DataAnnotations;

namespace BladeBlazorASP.Models
{
    public class EmailSubscribers
    {
        [Key]
        public Guid SubscriberID { get; set; }
        [Required]
        public string EmailAddress { get; set; }
        public bool IsSubscriber{ get; set; }=true;
        public EmailSubscribers()
        {
            
        }

        public EmailSubscribers( string emailAddress)
        {
            SubscriberID = Guid.NewGuid(); 
            EmailAddress = emailAddress;
            IsSubscriber = true;                    
        }

    }
}
