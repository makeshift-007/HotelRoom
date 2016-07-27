using System;

namespace HotelReservation
{
    //Model to Capture Hotel Information
    public class Hotel
    {
        private string HotelName { set; get; }

        private Customer _regularCustomer;
        private Customer _rewardsCustomer;

        private Customer RegularCustomer
        {
            set
            {
                if (value == null)
                    throw new ArgumentException("Null Value for Regular Customer");
                _regularCustomer = value;
            }
            get
            {
                return _regularCustomer;
            }
        }
        private Customer RewardsCustomer
        {
            set
            {
                if (value == null)
                    throw new ArgumentException("Null Value for Rewards Customer");
                _rewardsCustomer = value;
            }
            get
            {
                return _rewardsCustomer;
            }
        }

        private int HotelRating { set; get; }

        /// <summary>
        /// Capturing Hotel information
        /// </summary>
        /// <param name="hotelName">Hotel Name</param>
        /// /// <param name="rating">Hotel Rating</param>
        /// /// <param name="regularCustomer">Hotel's Regular Customer Information</param>
        /// <param name="rewardsCustomer">Hotel's Reward Customer Information</param>
        public Hotel(string hotelName, int rating, Customer regularCustomer, Customer rewardsCustomer)
        {
            this.HotelName = hotelName;
            this.HotelRating = rating;
            this.RegularCustomer = regularCustomer;
            this.RewardsCustomer = rewardsCustomer;
        }

        public int GetHotelRateByCustomerAndDate(CustomerType customerType, DateTime rateOfDate)
        {
            switch (customerType)
            {
                case CustomerType.Regular:
                    return RegularCustomer.GetCustomerHotelRateByDate(rateOfDate);
                default:
                    return RewardsCustomer.GetCustomerHotelRateByDate(rateOfDate);
            }
        }

        public int GetHotelRateByCustomerAndDayOfWeek(CustomerType customerType, DayOfWeek rateOfDayOfWeek)
        {
            switch (customerType)
            {
                case CustomerType.Regular:
                    return RegularCustomer.GetCustomerHotelRateByDayOfWeek(rateOfDayOfWeek);
                default:
                    return RewardsCustomer.GetCustomerHotelRateByDayOfWeek(rateOfDayOfWeek);
            }
        }

        public string GetHotelName()
        {
            return HotelName;
        }

        public int GetHotelRating()
        {
            return HotelRating;
        }

    }
}
