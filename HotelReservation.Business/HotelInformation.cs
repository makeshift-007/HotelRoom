using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelReservation
{
   

    public class HotelInformation
    {

        private  int _WeekDayRate, _WeekEndRate;
        public string HotelName { set; get; }
        public int HotelRating { set; get; }

        public HotelInformation(string hotelName, int hotelRating, int weekDayRate, int weekEndRate)
        {
            _WeekDayRate = weekDayRate;
            _WeekEndRate = weekEndRate;

            HotelRating = hotelRating;
            HotelName = hotelName;
        }

        
        public int GetReservationRate(List<ReservationDate> ReservationDates)
        {
            int costForStay = 0;

            foreach (var ReservationDate in ReservationDates)
            {
                costForStay += ReservationDate.IsWeekDay() ? _WeekDayRate : _WeekEndRate;
            }
            return costForStay;
        }

    }




}
