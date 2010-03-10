namespace TERSApplication.Web
{
     
    using System.ComponentModel.DataAnnotations;
       
    public class EventReadOnly
    {
        [Key]
        public int EventID { get; set; }
        public string EventName { get; set; }
        public string Status { get; set; }
        public string CreatedBy { get; set; }
    }
}