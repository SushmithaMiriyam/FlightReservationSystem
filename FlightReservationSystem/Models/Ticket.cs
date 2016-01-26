using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;


namespace FlightReservationSystem.Models
{
    [Table("Ticket")]
    public class Ticket
    {
        [Required]
        [Key]
        public int ticketId { get; set; }
        // [ForeignKey("UserId")]
         public string UserId { get; set; }  
        //[ForeignKey("UserId")]
        //public virtual ApplicationUser User { get; set; }
        [ForeignKey("Flight")]
        public int flightId { get; set; }
        [ForeignKey("Schedule")]
        public int scheduleId { get; set; }
        [ForeignKey("Payment")]
        public int paymentId { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime dateOfJourney { get; set; }
        public int seatNo { get; set; }
        public string passengerName { get; set; }
        public char gender { get; set; }
        [Phone]
        public string phoneNumber { get; set; }
        public string address { get; set; }
        public string emergencyContact { get; set; }
        public string travelclass { get; set; }

        public virtual Flight Flight { get; set; }
        public virtual Schedule Schedule { get; set; }
        public virtual Payment Payment { get; set; }
        //public virtual ApplicationUser ApplicationUser{ get; set; }
    }
}
