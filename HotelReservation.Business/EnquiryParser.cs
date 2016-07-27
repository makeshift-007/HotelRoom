using System;
using System.Collections.Generic;
using System.Linq;

namespace HotelReservation
{
    public class EnquiryParser
    {
        public EnquiryInformation GetEnquiryByInput(string enquiry)
        {
            if (string.IsNullOrEmpty(enquiry))
                throw new ArgumentException("Input Cant be Null or Empty");

            ValidateInput(enquiry);
            var customerTypeAndReservationDates = GetCustomerTypeAndReservationDates(enquiry);
            return new EnquiryInformation(GetCustomerType(customerTypeAndReservationDates[0]), GetReservationDates(customerTypeAndReservationDates[1]));

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

        private CustomerType GetCustomerType(string customerType)
        {
            switch (customerType)
            {
                case "Regular":
                    return CustomerType.Regular;
                case "Rewards":
                    return CustomerType.Rewards;
                default:
                    throw new ArgumentException("Invalid Customer Type Supplied");
            }
        }
    }
}
