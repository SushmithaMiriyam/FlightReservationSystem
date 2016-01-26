using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FlightReservationSystem.Models
{
    public class DbInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<FlightReservationSystemContext>
    {
        protected override void Seed(FlightReservationSystemContext context)
        {
            var flight = new List<Flight>
            {
                new Flight {flightId = 1, flightName = "British Airways", seatFirstclass = 20 ,seatBusinessclass = 30, seatEconomyclass = 50 },
                new Flight {flightId = 2, flightName = "British Airways1", seatFirstclass = 20 ,seatBusinessclass = 30, seatEconomyclass = 50 },
                new Flight {flightId = 3, flightName = "British Airways2", seatFirstclass = 20 ,seatBusinessclass = 30, seatEconomyclass = 50 },
                new Flight {flightId = 4, flightName = "AirAsia", seatFirstclass = 20 ,seatBusinessclass = 30, seatEconomyclass = 50 },
                new Flight {flightId = 5, flightName = "Eithihad", seatFirstclass = 20 ,seatBusinessclass = 30, seatEconomyclass = 50 },
                new Flight {flightId = 6, flightName = "Eithihad", seatFirstclass = 20 ,seatBusinessclass = 30, seatEconomyclass = 50 },
                new Flight {flightId = 7, flightName = "Eithihad", seatFirstclass = 20 ,seatBusinessclass = 30, seatEconomyclass = 50 },
                new Flight {flightId = 8, flightName = "Eithihad", seatFirstclass = 20 ,seatBusinessclass = 30, seatEconomyclass = 50 },
                new Flight {flightId = 9, flightName = "Eithihad", seatFirstclass = 20 ,seatBusinessclass = 30, seatEconomyclass = 50 },
                new Flight {flightId = 10, flightName = "British Airways4", seatFirstclass = 20 ,seatBusinessclass = 30, seatEconomyclass = 50 },
                new Flight {flightId = 11, flightName = "British Airways3", seatFirstclass = 20 ,seatBusinessclass = 30, seatEconomyclass = 50 }
            };

            flight.ForEach(s => context.Flight.Add(s));
            context.SaveChanges();

            var schedule = new List<Schedule>
            {
                new Schedule { scheduleId = 1,  flightId =1, source = "Chicago", sourceId = 12, dest = "Kansas", destId = 13, scheduleDate = new DateTime(2015,11, 17) , depatureTime = new TimeSpan(2,14, 18) ,arrivalDate = new DateTime(2015,11, 17) ,arrivalTime = new TimeSpan(4, 34, 50), status = "onschedule", FCseats = 20, BCseats = 28, ECseats = 50, costFirst = 500.00, costBusiness = 300.00, costEconomy = 160.00, traveltype = "domestic" },
                new Schedule { scheduleId = 2,  flightId =1, source = "Chicago", sourceId = 12, dest = "Kansas", destId = 13, scheduleDate = new DateTime(2015,11, 18), depatureTime = new TimeSpan(2,14, 18) ,arrivalDate = new DateTime(2015,11, 18) ,arrivalTime = new TimeSpan(4,34,50), status = "onschedule", FCseats = 20, BCseats = 30, ECseats = 50, costFirst = 500.00, costBusiness = 300.00, costEconomy = 160.00, traveltype = "domestic" },
                new Schedule { scheduleId = 3,  flightId =1, source = "Chicago", sourceId = 12, dest = "Kansas", destId = 13, scheduleDate = new DateTime(2015,11, 20), depatureTime = new TimeSpan(2,14, 18) ,arrivalDate = new DateTime(2015,11, 20) ,arrivalTime = new TimeSpan(4,34,50), status = "onschedule", FCseats = 20, BCseats = 30, ECseats = 50, costFirst = 500.00, costBusiness = 300.00, costEconomy = 160.00, traveltype = "domestic" },
                new Schedule { scheduleId = 4,  flightId =1, source = "Chicago", sourceId = 12, dest = "Kansas", destId = 13, scheduleDate = new DateTime(2016,01, 01), depatureTime = new TimeSpan(2,14, 18) ,arrivalDate = new DateTime(2016,01,01) ,arrivalTime = new TimeSpan(4,34,50), status = "onschedule", FCseats = 20, BCseats = 30, ECseats = 50, costFirst = 500.00, costBusiness = 300.00, costEconomy = 160.00, traveltype = "domestic" },
                new Schedule { scheduleId = 5,  flightId =1, source = "Chicago", sourceId = 12, dest = "Kansas", destId = 13, scheduleDate = new DateTime(2016,01, 14), depatureTime = new TimeSpan(2,14, 18) ,arrivalDate = new DateTime(2016,01, 14) ,arrivalTime = new TimeSpan(4,34,50), status = "onschedule", FCseats = 20, BCseats = 30, ECseats = 50, costFirst = 500.00, costBusiness = 300.00, costEconomy = 160.00, traveltype = "domestic" },
                new Schedule { scheduleId = 6,  flightId =2, source = "New York", sourceId = 10, dest = "Illinois", destId = 15, scheduleDate = new DateTime(2015,12, 07), depatureTime = new TimeSpan(2,14, 18) ,arrivalDate = new DateTime(2015,12, 07) ,arrivalTime = new TimeSpan(4,34,50), status = "onschedule", FCseats = 20, BCseats = 30, ECseats = 50, costFirst = 500.00, costBusiness = 300.00, costEconomy = 160.00, traveltype = "domestic" },
                new Schedule { scheduleId = 6,  flightId =2, source = "New York", sourceId = 10, dest = "Illinois", destId = 15, scheduleDate = new DateTime(2015,12, 08), depatureTime = new TimeSpan(2,14, 18) ,arrivalDate = new DateTime(2015,12, 08) ,arrivalTime = new TimeSpan(4,34,50), status = "onschedule", FCseats = 20, BCseats = 30, ECseats = 50, costFirst = 500.00, costBusiness = 300.00, costEconomy = 160.00, traveltype = "domestic" },
                new Schedule { scheduleId = 7,  flightId =2, source = "New York", sourceId = 10, dest = "Illinois", destId = 15, scheduleDate = new DateTime(2015,12, 13), depatureTime = new TimeSpan(2,14, 18) ,arrivalDate = new DateTime(2015,12, 13) ,arrivalTime = new TimeSpan(4,34,50), status = "onschedule", FCseats = 20, BCseats = 30, ECseats = 50, costFirst = 500.00, costBusiness = 300.00, costEconomy = 160.00, traveltype = "domestic" },
                new Schedule { scheduleId = 8,  flightId =2, source = "New York", sourceId = 10, dest = "Illinois", destId = 15, scheduleDate = new DateTime(2016,1, 04), depatureTime = new TimeSpan(2,14, 18) ,arrivalDate = new DateTime(2016,1, 04) ,arrivalTime = new TimeSpan(4,34,50), status = "onschedule", FCseats = 20, BCseats = 30, ECseats = 50, costFirst = 500.00, costBusiness = 300.00, costEconomy = 160.00, traveltype = "domestic" },
                new Schedule { scheduleId = 9,  flightId =2, source = "New York", sourceId = 10, dest = "Illinois", destId = 15, scheduleDate = new DateTime(2016,2, 01), depatureTime = new TimeSpan(2,14, 18) ,arrivalDate = new DateTime(2016,2, 01) ,arrivalTime = new TimeSpan(4,34,50), status = "onschedule", FCseats = 20, BCseats = 30, ECseats = 50, costFirst = 500.00, costBusiness = 300.00, costEconomy = 160.00, traveltype = "domestic" },
                new Schedule { scheduleId = 10,  flightId =3, source = "Chicago", sourceId = 12, dest = "California", destId = 9, scheduleDate = new DateTime(2015,11, 21), depatureTime = new TimeSpan(8,14, 18) ,arrivalDate = new DateTime(2015,11, 21) ,arrivalTime = new TimeSpan(14,34,50), status = "onschedule", FCseats = 20, BCseats = 30, ECseats = 49, costFirst = 300.00, costBusiness = 200.00, costEconomy = 120.00, traveltype = "domestic" },
                new Schedule { scheduleId = 11,  flightId =3, source = "Chicago", sourceId = 12, dest = "California", destId = 9, scheduleDate = new DateTime(2015,11, 25), depatureTime = new TimeSpan(8,14, 18) ,arrivalDate = new DateTime(2015,11, 25) ,arrivalTime = new TimeSpan(14,34,50), status = "onschedule", FCseats = 20, BCseats = 30, ECseats = 50, costFirst = 300.00, costBusiness = 200.00, costEconomy = 120.00, traveltype = "domestic" },
                new Schedule { scheduleId = 12,  flightId =3, source = "Chicago", sourceId = 12, dest = "California", destId = 9, scheduleDate = new DateTime(2015,12, 01), depatureTime = new TimeSpan(8,14, 18) ,arrivalDate = new DateTime(2015,12, 01) ,arrivalTime = new TimeSpan(14,34,50), status = "onschedule", FCseats = 20, BCseats = 30, ECseats = 50, costFirst = 300.00, costBusiness = 200.00, costEconomy = 120.00, traveltype = "domestic" },
                new Schedule { scheduleId = 13,  flightId =3, source = "Chicago", sourceId = 12, dest = "California", destId = 9, scheduleDate = new DateTime(2015,12, 04), depatureTime = new TimeSpan(8,14, 18) ,arrivalDate = new DateTime(2015,12, 04) ,arrivalTime = new TimeSpan(14,34,50), status = "onschedule", FCseats = 20, BCseats = 30, ECseats = 50, costFirst = 300.00, costBusiness = 200.00, costEconomy = 120.00, traveltype = "domestic" },
                new Schedule { scheduleId = 14,  flightId =3, source = "Chicago", sourceId = 12, dest = "California", destId = 9, scheduleDate = new DateTime(2015,12, 25), depatureTime = new TimeSpan(8,14, 18) ,arrivalDate = new DateTime(2015,12, 25) ,arrivalTime = new TimeSpan(14,34,50), status = "onschedule", FCseats = 20, BCseats = 29, ECseats = 50, costFirst = 300.00, costBusiness = 200.00, costEconomy = 120.00, traveltype = "domestic" },
                new Schedule { scheduleId = 15,  flightId =4, source = "Kansas", sourceId = 13, dest = "Chicago", destId = 12, scheduleDate = new DateTime(2015,11, 21), depatureTime = new TimeSpan(5,24, 30) ,arrivalDate = new DateTime(2015,11, 21) ,arrivalTime = new TimeSpan(7,40,20), status = "onschedule", FCseats = 20, BCseats = 30, ECseats = 50, costFirst = 500.00, costBusiness = 300.00, costEconomy = 160.00, traveltype = "domestic" },
                new Schedule { scheduleId = 16,  flightId =4, source = "Kansas", sourceId = 13, dest = "Chicago", destId = 12, scheduleDate = new DateTime(2015,11, 24), depatureTime = new TimeSpan(5,24, 30) ,arrivalDate = new DateTime(2015,11, 24) ,arrivalTime = new TimeSpan(7,40,20), status = "onschedule", FCseats = 20, BCseats = 30, ECseats = 50, costFirst = 500.00, costBusiness = 300.00, costEconomy = 160.00, traveltype = "domestic" },
                new Schedule { scheduleId = 17,  flightId =4, source = "Kansas", sourceId = 13, dest = "Chicago", destId = 12, scheduleDate = new DateTime(2015,12, 4), depatureTime = new TimeSpan(5,24, 30) ,arrivalDate = new DateTime(2015,12, 4) ,arrivalTime = new TimeSpan(7,40,20), status = "onschedule", FCseats = 20, BCseats = 30, ECseats = 50, costFirst = 500.00, costBusiness = 300.00, costEconomy = 160.00, traveltype = "domestic" },
                new Schedule { scheduleId = 18,  flightId =4, source = "Kansas", sourceId = 13, dest = "Chicago", destId = 12, scheduleDate = new DateTime(2016,1, 17), depatureTime = new TimeSpan(5,24, 30) ,arrivalDate = new DateTime(2016,1, 17) ,arrivalTime = new TimeSpan(7,40,20), status = "onschedule", FCseats = 20, BCseats = 30, ECseats = 50, costFirst = 500.00, costBusiness = 300.00, costEconomy = 160.00, traveltype = "domestic" },
                new Schedule { scheduleId = 19,  flightId =4, source = "Kansas", sourceId = 13, dest = "Chicago", destId = 12, scheduleDate = new DateTime(2016,2, 17), depatureTime = new TimeSpan(5,24, 30) ,arrivalDate = new DateTime(2016,2, 17) ,arrivalTime = new TimeSpan(7,40,20), status = "onschedule", FCseats = 19, BCseats = 30, ECseats = 50, costFirst = 500.00, costBusiness = 300.00, costEconomy = 160.00, traveltype = "domestic" }
            };

            schedule.ForEach(s => context.Schedule.Add(s));
            context.SaveChanges();


            var payment = new List<Payment>
            {
            new Payment{ paymentId = 1, paymentMode = "Visa", bankDetails = "US Bank, Missouri", totalAmount = 600.00},
            new Payment{ paymentId = 2, paymentMode = "Visa", bankDetails = "US Bank, Missouri", totalAmount = 120.00},
            new Payment{ paymentId = 3, paymentMode = "Master", bankDetails = "Bank of America, Kansas", totalAmount = 200.00},
            new Payment{ paymentId = 4, paymentMode = "Master", bankDetails = "US Bank, Missouri", totalAmount = 500.00}

            };

            payment.ForEach(s => context.Payment.Add(s));
            context.SaveChanges();

            var ticket = new List<Ticket>
            {
            new Ticket{ticketId = 1, UserId = "sushmitha.miriam@gmail.com", flightId = 1, scheduleId = 1, paymentId = 1, dateOfJourney = new DateTime(2015,11,30), seatNo = 40, passengerName = "Sushmitha", gender = 'F', phoneNumber = "9870928198", address = "OverlandPark. KS", travelclass = "Business", emergencyContact = "Varun, Overland Park, Kansas" },
            new Ticket{ticketId = 2, UserId = "sushmitha.miriam@gmail.com", flightId = 1, scheduleId = 1, paymentId = 1, dateOfJourney = new DateTime(2015,11,30), seatNo = 41, passengerName = "Priya", gender = 'F', phoneNumber = "9870928198", address = "OverlandPark. KS", travelclass = "Business", emergencyContact = "Varun, Overland Park, Kansas" },
            new Ticket{ticketId = 3, UserId = "2", flightId = 3, scheduleId = 10, paymentId = 2, dateOfJourney = new DateTime(2016,01,30), seatNo = 60, passengerName = "Alex", gender = 'M', phoneNumber = "9834568198", address = "OverlandPark. KS", travelclass = "Economy", emergencyContact = "Varun, Overland Park, Kansas" },
            new Ticket{ticketId = 4, UserId = "3", flightId = 3, scheduleId = 14, paymentId = 3, dateOfJourney = new DateTime(2015,12,03), seatNo = 30, passengerName = "Goergia", gender = 'F', phoneNumber = "9870978654", address = "OverlandPark. KS", travelclass = "Business", emergencyContact = "Varun, Overland Park, Kansas" },
            new Ticket{ticketId = 5, UserId = "4", flightId = 4, scheduleId = 19, paymentId = 4, dateOfJourney = new DateTime(2015,11,30), seatNo = 20, passengerName = "Harry", gender = 'M', phoneNumber = "8664554786", address = "OverlandPark. KS", travelclass = "First", emergencyContact = "Varun, Overland Park, Kansas" }
            };
            ticket.ForEach(s => context.Ticket.Add(s));
            context.SaveChanges();

        }
    }
}