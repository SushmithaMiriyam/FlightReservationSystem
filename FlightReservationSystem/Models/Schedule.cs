using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;


namespace FlightReservationSystem.Models
{
    [Table("Schedule")]
    public class Schedule
    {
        [Key]
        public int scheduleId { get; set; }
        [ForeignKey("Flight")]
        public int flightId { get; set; }
        [Required]
        public string source { get; set; }
        [Required]
        public int sourceId { get; set; }
        [Required]
        public string dest { get; set; }
        [Required]
        public int destId { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:MM-dd-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime scheduleDate { get; set; }
        [Required]
        public TimeSpan depatureTime { get; set; }
        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime arrivalDate { get; set; }
        [Required]
        public TimeSpan arrivalTime { get; set; }
        [Required]
        public string status { get; set; }
        [Required]
        public int FCseats { get; set; } //remaining seats in First class
        [Required]
        public int BCseats { get; set; } //remaining seats in Business class
        [Required]
        public int ECseats { get; set; } //remaining seats in Economy class
        [Required]
        public double costFirst { get; set; }
        [Required]
        public double costBusiness { get; set; }
        [Required]
        public double costEconomy { get; set; }
        [Required]
        public string traveltype { get; set; }
        

        public virtual Flight Flight { get; set; }
        public virtual ICollection<Ticket> Ticket { get; set; }


    }
}