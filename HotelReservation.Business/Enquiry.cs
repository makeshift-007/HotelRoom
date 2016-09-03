using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelReservation
{
    public abstract class Enquiry
    {
        protected List<ReservationDate> _reservationDates;
        protected List<HotelInformation> _hotelsInformation;
        protected IHotelProvider _hotelProvider;
        public Enquiry(List<DateTime> datesOfReservation)
        {
            _reservationDates = datesOfReservation.Select(m => new ReservationDate(m)).ToList();
        }

        public virtual string GetCheapestHotel()
        {
            string hotelName = "";
            int minimumStayCost = int.MaxValue, lowestRateHotelRating = 0;

            int currentHotelCost = 0;

            foreach (var hotelInformation in _hotelsInformation)
            {
                currentHotelCost = hotelInformation.GetReservationRate(_reservationDates);

                if (minimumStayCost > currentHotelCost || (minimumStayCost == currentHotelCost && lowestRateHotelRating < hotelInformation.HotelRating))
                
                {
                    minimumStayCost = currentHotelCost;
                    hotelName = hotelInformation.HotelName;
                    lowestRateHotelRating = hotelInformation.HotelRating;
                }
            }
            return hotelName;
        }
    }

    public class RewardCustomerEnquiry : Enquiry
    {
        public RewardCustomerEnquiry(List<DateTime> datesOfReservation)
            : base(datesOfReservation)
        {
            _hotelProvider = new HotelsProvider();
            _hotelsInformation = _hotelProvider.GetRewardCustomerHotels();
        }


    }

    public class RegularCustomerEnquiry : Enquiry
    {
        public RegularCustomerEnquiry(List<DateTime> datesOfReservation)
            : base(datesOfReservation)
        {
            _hotelProvider = new HotelsProvider();
            _hotelsInformation = _hotelProvider.GetRegularCustomerHotels();

        }

    }
}
