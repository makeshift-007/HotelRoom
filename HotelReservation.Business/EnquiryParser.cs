using System;
using System.Collections.Generic;
using System.Linq;

namespace HotelReservation
{
    public class EnquiryParser
    {
        public Enquiry GetEnquiryByInput(string enquiry)
        {
            if (string.IsNullOrEmpty(enquiry))
                throw new ArgumentException("Input Cant be Null or Empty");

            ValidateInput(enquiry);
            var customerTypeAndReservationDates = GetCustomerTypeAndReservationDates(enquiry);

            switch (customerTypeAndReservationDates[0])
            {
                case "Regular":
                    return new RegularCustomerEnquiry(GetReservationDates(customerTypeAndReservationDates[1]));
                case "Rewards":
                    return new RewardCustomerEnquiry(GetReservationDates(customerTypeAndReservationDates[1]));
                default:
                    throw new ArgumentException("Invalid Input");

            }
            
            //return new Enquiry(GetCustomerType(customerTypeAndReservationDates[0]), GetReservationDates(customerTypeAndReservationDates[1]));

        }

        private List<string> GetCustomerTypeAndReservationDates(string enquiry)
        {
            return enquiry.Split(':').ToList();
        }

        private void ValidateInput(string enquiry)
        {
            var customerTypeAndReservationDates = enquiry.Split(':');
            if (customerTypeAndReservationDates.Length != 2)
                throw new ArgumentException("Invalid Input Supplied");
        }

        private List<DateTime> GetReservationDates(string enquiryDates)
        {

            if (string.IsNullOrEmpty(enquiryDates))
                throw new ArgumentException("Reservation Dates not found");

            var reservationDates = new List<DateTime>();

            foreach (var reservationDate in enquiryDates.Split(','))
            {
                var dateOfReservation = reservationDate.Split('(');
                if (dateOfReservation.Length != 2)
                    throw new ArgumentException("Invalid Date Supplied");
                reservationDates.Add(Convert.ToDateTime(dateOfReservation[0]));
            }

            return reservationDates;
        }

     
    }
}
