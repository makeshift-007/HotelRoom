using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelReservation
{
    public class HotelBookingManager
    {
        private List<Hotel> _hotels;

        private List<Hotel> Hotels
        {
            set
            {
                if (value == null || value.Count == 0)
                    throw new ArgumentException("Hotels Not Provided");
                _hotels = value;

            }
          
        }

        public HotelBookingManager(List<Hotel> hotels)
        {
            this.Hotels = hotels;
        }

        private int GetSummationOfReservationDates(Hotel hotel, List<DateTime> reservationDates, CustomerType customerType)
        {
            int currentLowestRateSummation = 0;

            foreach (var dateOfReservation in reservationDates)
                currentLowestRateSummation = currentLowestRateSummation + hotel.GetHotelRateByCustomerAndDate(customerType, dateOfReservation);

            return currentLowestRateSummation;
        }

        public string GetCheapestHotelByEnquiry(EnquiryInformation enquiry)
        {
            Hotel cheapestHotel = null;
            int lowestRateSummation = int.MaxValue;
            int currentLowestRateSummation;

            foreach (var hotel in _hotels)
            {
                currentLowestRateSummation = GetSummationOfReservationDates(hotel, enquiry.GetDatesOfReservation(), enquiry.GetCustomerType());


                if (currentLowestRateSummation <= lowestRateSummation)
                {
                    if (currentLowestRateSummation == lowestRateSummation &&
                        hotel.GetHotelRating() > cheapestHotel.GetHotelRating())
                    {
                        continue;
                    }
                    cheapestHotel = hotel;
                    lowestRateSummation = currentLowestRateSummation;

                }

            }
            return cheapestHotel.GetHotelName();
        }
    }
}
