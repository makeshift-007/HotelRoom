using System;
namespace HotelReservation
{
    public class HotelRate
    {
        private int _weekDayRate;
        private int _weekEndRate;

        public HotelRate(int weekDayRate, int weekEndRate)
        {
            this._weekDayRate = weekDayRate;
            this._weekEndRate = weekEndRate;
        }

        /// <summary>
        /// Used to get the Rate of the Hotel by Day of Week
        /// </summary>
        /// <param name="dayOfWeek"></param>
        /// <returns></returns>
        public int GetRateByDayOfWeek(DayOfWeek dayOfWeek)
        {
            switch (dayOfWeek)
            {
                case DayOfWeek.Saturday:
                case DayOfWeek.Sunday:
                    return _weekEndRate;
                default:
                    return _weekDayRate;
            }
        }


        /// <summary>
        /// Used to get the Rate of the Hotel By Date
        /// </summary>
        /// <param name="rateOnDate"></param>
        /// <returns></returns>
        public int GetRateByDate(DateTime rateOnDate)
        {
            return GetRateByDayOfWeek(rateOnDate.DayOfWeek);
        }
    }

    
}
