using System;
namespace HotelReservation
{
    public class HotelRate
    {
        private int WeekDayRate { set; get; }
        private int WeekEndRate { set; get; }

        public HotelRate(int weekDayRate, int weekEndRate)
        {
            this.WeekDayRate = weekDayRate;
            this.WeekEndRate = weekEndRate;
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
                    return WeekEndRate;
                default:
                    return WeekDayRate;
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
