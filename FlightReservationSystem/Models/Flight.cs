using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace FlightReservationSystem.Models
{
    [Table("Flight")]
    public class Flight
    {
        [Required]
        [Key]
        public int flightId { get; set; }
        [Required]
        public string flightName { get; set; }
        [Required]
        public int seatFirstclass { get; set; }
        [Required]
        public int seatBusinessclass { get; set; }
        [Required]
        public int seatEconomyclass { get; set; }

        public virtual ICollection<Ticket> Ticket { get; set; }
        public virtual ICollection<Schedule> Schedule { get; set; }
    }
}