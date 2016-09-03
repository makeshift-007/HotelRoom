using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelReservation
{
    public class ReservationDate
    {
        private DateTime _reservationDate;

        public ReservationDate(string date)
        {

            _reservationDate = Convert.ToDateTime(date);
        }

        public ReservationDate(DateTime date)
        {
            if (date == null)
                throw new ArgumentException("Invalid Date");

            _reservationDate = date;
        }

        public bool IsWeekDay()
        {
            return _reservationDate.DayOfWeek != DayOfWeek.Saturday && _reservationDate.DayOfWeek != DayOfWeek.Sunday;
        }
    }
}
